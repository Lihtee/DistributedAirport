using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Web;
using System.Web.Services;

namespace MainBalancer
{
    /// <summary>
    /// Summary description for BalancerService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class BalancerService : System.Web.Services.WebService
    {
        public MainServerReference.MainServerServiceSoapClient mainServer = new MainServerReference.MainServerServiceSoapClient();

        public static List<string> servers = new List<string>();
        public static List<string> clients = new List<string>();

        [WebMethod]
        public Request MakeRequest(Request request)
        {
            string clientAddress = request.SenderIP;
            if (!clients.Contains(clientAddress))
                clients.Add(clientAddress);

            string address = getFreeServer();

            return request;
        }

        [WebMethod]
        public Request NewRequest()
        {
            Request request = new Request();

            string address = getFreeServer();

            return request;
        }

        [WebMethod]
        public MainServerReference.Plane NewPlane()
        {
            MainServerReference.Plane plane = mainServer.NewPlane();

            return plane;
        }

        [WebMethod]
        public void StoreServer(string address)
        {
            if (!servers.Contains(address))
                servers.Add(address);
        }

        [WebMethod]
        public string ShowStoredServers()
        {
            return servers.FirstOrDefault();
        }

        private string getFreeServer()
        {
            if (!servers.Contains(getURLAddress()))
            {
                servers.Add(getURLAddress());
            }

            int min = 101;
            string res = "";

            foreach (string str in servers)
            {
                try
                {
                    WebRequest request = WebRequest.Create("http://" + str + "/getLoad");
                    request.Method = "POST";
                    request.ContentLength = 0;
                    WebResponse response = request.GetResponse();

                    var encoding = Encoding.UTF8;
                    string responseText;
                    using (var reader = new System.IO.StreamReader(response.GetResponseStream(), encoding))
                    {
                        responseText = reader.ReadToEnd();
                    }
                    responseText = responseText.Remove(0, 40); //"<int xmlns=\"http://tempuri.org/\">0</int>"
                    int indexStart = responseText.IndexOf('>');
                    int indexFinish = responseText.Remove(0, 2).IndexOf('<');

                    responseText = responseText.Substring(indexStart + 1, indexFinish - indexStart + 1);
                    int responseInt = Int32.Parse(responseText);

                    if (responseInt < min)
                    {
                        min = responseInt;
                        res = str;
                    }
                }
                catch (Exception)
                {

                }                
            }

            return res;
        }

        private string getURLAddress()
        {
            string res = "";

            res = mainServer.Endpoint.ListenUri.Authority + "/" + mainServer.Endpoint.ListenUri.Segments[1];

            return res;
        }
    }

    public class Request
    {
        private string senderIP;
        private int requestType;
        private MainServerReference.Plane plane;
        private int requestDifficulty;
        private int requestTime;

        public Request()
        {
            senderIP = "";
            requestType = 1;
            plane = new MainServerReference.Plane();
            requestDifficulty = 25;
            requestTime = 1000;
        }

        // IP отправителя запроса
        public string SenderIP { get { return senderIP; } set { senderIP = value; } }

        // Тип запроса. 1 = взлёт, 2 = посадка
        public int RequestType { get { return requestType; } set { requestType = value; } }

        // Самолёт
        public MainServerReference.Plane Plane { get { return plane; } set { plane = value; } }

        // Сложность запроса (от 0 до 100%)
        public int RequestDifficulty { get { return requestDifficulty; } set { requestDifficulty = value; } }

        // Время выполнения запроса (в мс)
        public int RequestTime { get { return requestTime; } set { requestTime = value; } }

        public Request getRequest()
        {
            return this;
        }        
    }
}
