using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Security.AccessControl;
using System.ServiceModel;
using System.ServiceModel.Description;
using System.Threading;
using CalculationServer.ServiceReference1;
using Shared;

namespace CalculationServer
{
    internal class Program
    {
        public static string BaseAddress;

        public static void Main(string[] args)
        {
            Console.WindowHeight /= 2;
            Console.WindowWidth /= 2;

            var ip = Methods.GetLocalIPAddress();
            var port = Methods.GetFreeTcpPort();

            string address = $"http://{ip}:{port}/calc";
            var uriAddress = new Uri(address);

            ServerSettings.ServerList.Add(address);
            BaseAddress = address;

            // Create the ServiceHost.
            using (ServiceHost host = new ServiceHost(typeof(CalculatingService), uriAddress))
            {
                // Enable metadata publishing.
                ServiceMetadataBehavior smb = new ServiceMetadataBehavior { HttpGetEnabled = true };
                host.Description.Behaviors.Add(smb);

                // Open the ServiceHost to start listening for messages. Since
                // no endpoints are explicitly configured, the runtime will create
                // one endpoint per base address for each service contract implemented
                // by the service.
                host.Open();

                Console.WriteLine("The service is ready at {0}", uriAddress);
                Console.WriteLine("Type \" connect <address>\" to attach this server to existing ones.");

                // Запуск постоянного обмена.
                var t = new Thread(ExchangeAddress) { IsBackground = true };
                t.Start();

                while (true)
                {
                    var input = Console.ReadLine().Split(' ');
                    if (input[0] == "connect")
                    {
                        // Тут запросим коннект у сервера. Надо его добавить. 
                        var client = new CalculatingServiceClient(
                            new BasicHttpBinding(),
                            new EndpointAddress(input[1]));
                        var result = client.Connect(ServerSettings.ServerList.ToArray());
                        Console.WriteLine("Connected");
                    }
                }
            }
        }

        /// <summary>
        /// Методя лоя постоянного обмена ардесами раз в 2 секунды.
        /// </summary>
        public static void ExchangeAddress()
        {
            while (true)
            {
                foreach (var server in ServerSettings.ServerList)
                {
                    if (server == BaseAddress)
                        continue;
                    try
                    {
                        var client = new CalculatingServiceClient(
                                        new BasicHttpBinding(),
                                        new EndpointAddress(server));
                        var result = client.Connect(ServerSettings.ServerList.ToArray());
                    }
                    catch (Exception)
                    {
                        // Пока что ничего.
                    }
                }

                Thread.Sleep(2000);
            }
        }
    }

    public static class ServerSettings
    {
        static ServerSettings()
        {
            MethodsPull = new MethodsPull();

            LoadingCapacity = 100;

            ServerList = new List<string>();
        }

        public static List<string> ServerList;

        public static MethodsPull MethodsPull;

        public static int LoadingCapacity;
    }

    [ServiceContract]
    public interface ICalculatingService : IConnect
    {
        [OperationContract]
        int CalculateLine(CalculateLineData data);

        [OperationContract]
        int GetLoading();
    }

    [ServiceContract]
    public interface IConnect
    {
        [OperationContract]
        List<string> Connect(List<string> data);
    }


    public class CalculatingService : ICalculatingService
    {
        public int CalculateLine(CalculateLineData value)
        {

            return (int)ServerSettings.MethodsPull.ExecuteMethod(new CalculateLineSimulated(value));
        }

        public List<string> Connect(List<string> data)
        {
            return (List<string>)ServerSettings.MethodsPull.ExecuteMethod(new ConnectSimulated(data));
        }

        public int GetLoading()
        {
            return ServerSettings.MethodsPull.GetLoading();
        }
    }

    public class ConnectSimulated : BaseSimulatedMethod
    {
        public List<string> Param;

        public ConnectSimulated(List<string> param)
        {
            Param = param;

            Loading = 1;
            Time = 1;
        }

        public override object Process()
        {
            ServerSettings.ServerList = ServerSettings.ServerList.Union(Param).ToList();
            string log = "Completed Connect: new list is ";
            foreach (var server in ServerSettings.ServerList)
            {
                log += $"{Environment.NewLine}{server}";
            }

            Console.WriteLine(log);
            return ServerSettings.ServerList;
        }


    }

    public class CalculateLineSimulated : BaseSimulatedMethod
    {
        public CalculateLineData Param;

        public CalculateLineSimulated(CalculateLineData param)
        {
            Param = param;

            Loading = 10;
            Time = 10;
        }

        private object InnerProcess()
        {
            // Какие-то вычисления сдесь.
            return 0;
        }

        public override object Process()
        {
            // Если не инициируем, то вычисляем.
            if (!Param.Initial)
            {
                return InnerProcess();
            }

            // Сначала опросим сервера на нагрузку (заодно обозначим недоступные).
            var serverLoading = new Dictionary<string, int>();

            foreach (var server in ServerSettings.ServerList)
            {
                if (server == Program.BaseAddress)
                {
                    serverLoading.Add(server, ServerSettings.MethodsPull.GetLoading());
                }

                try
                {
                    var client = new CalculatingServiceClient(
                        new BasicHttpBinding(),
                        new EndpointAddress(server));
                    var result = client.GetLoading();
                    serverLoading.Add(server, result);
                }
                catch (Exception )
                {
                    serverLoading.Add(server, -1);
                }
            }

            // Выберем наименее нагруженные серверы.
            var livingServers = serverLoading.Where(x => x.Value >= 0);
            IEnumerable<KeyValuePair<string, int>> serversToCalculate;

            if (livingServers.Count() > 4)
            {
                serversToCalculate = livingServers
                    .OrderBy(x => x.Value)
                    .Take(4);
            }
            else
            {
                serversToCalculate = livingServers;
            }

            // Дадим им посчитать.
            var serverResults = new Dictionary<string, int>();
            foreach (var server in serversToCalculate)
            {
                // Если данный сервер подходит, то тоже считает.
                if (server.Key == Program.BaseAddress)
                {
                    serverResults.Add(server.Key, (int)InnerProcess());
                }

                try
                {
                    var client = new CalculatingServiceClient(
                        new BasicHttpBinding(),
                        new EndpointAddress(server.Key));
                    var result = client.CalculateLine(Param);
                    serverResults.Add(server.Key, result);
                }
                catch (Exception )
                {
                    serverResults.Add(server.Key, -1);
                }
            }

            // Выбрать самое популярное решение.
            var livingResults = serverResults.Where((x, y) => y >= 0);
            var res = livingResults
                .GroupBy(x => x.Value)
                .OrderByDescending(g => g.Count())
                .Select(x => x.Key)
                .FirstOrDefault();

            return res;
        }
    }
}