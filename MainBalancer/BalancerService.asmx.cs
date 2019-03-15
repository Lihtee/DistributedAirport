using System;
using System.Collections.Generic;
using System.Linq;
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

        public List<string> servers;
        public List<string> clients;

        [WebMethod]
        public Request MakeRequest(Request request)
        {
            string clientAddress = request.SenderIP;
            if (!clients.Contains(clientAddress))
                clients.Add(clientAddress);

            MainServerReference.Plane response = mainServer.ChangeName(request.Plane, "124");

            request.Plane = response;

            return request;
        }

        [WebMethod]
        public Request NewRequest()
        {
            Request request = new Request();

            MainServerReference.Plane response = mainServer.ChangeName(request.Plane, "124");

            request.Plane = response;

            return request;
        }

        [WebMethod]
        public MainServerReference.Plane NewPlane()
        {
            MainServerReference.Plane plane = mainServer.NewPlane();

            return plane;
        }

        private string getFreeServer()
        {
            return "";
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
