using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.ServiceModel;
using System.ServiceModel.Description;
using Shared;

namespace CalculationServer
{
    internal class Program
    {
        private static string BaseAddress = "http://localhost:8081/calc";

        public static void Main(string[] args)
        {
            var uriAddress = new Uri(BaseAddress);
            // Create the ServiceHost.
            using (ServiceHost host = new ServiceHost(typeof(CalculatingService), uriAddress))
            {
                // Enable metadata publishing.
                ServiceMetadataBehavior smb = new ServiceMetadataBehavior {HttpGetEnabled = true};
                host.Description.Behaviors.Add(smb);

                // Open the ServiceHost to start listening for messages. Since
                // no endpoints are explicitly configured, the runtime will create
                // one endpoint per base address for each service contract implemented
                // by the service.
                host.Open();

                Console.WriteLine("The service is ready at {0}", uriAddress);
                Console.WriteLine("Press <Enter> to stop the service.");
                Console.ReadLine();

                // Close the ServiceHost.
                host.Close();
            }
        }
    }

    public static class ServerSettings
    {
        static ServerSettings()
        {
            MethodsPull = new MethodsPull();

            LoadingCapacity = 100;
        }

        public static MethodsPull MethodsPull;

        public static int LoadingCapacity;
    }

    [ServiceContract]
    public interface ICalculatingService
    {
        [OperationContract]
        int CalculateLine(CalculateLineData data);
    }

    public class CalculatingService : ICalculatingService
    {
        public int CalculateLine(CalculateLineData value)
        {
            return (int)ServerSettings.MethodsPull.ExecuteMethod(new CalculateLineSimulated(value));
        }
    }
}