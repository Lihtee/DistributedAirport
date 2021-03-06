﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace MainServer
{
    /// <summary>
    /// Summary description for MainServerService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class MainServerService : System.Web.Services.WebService
    {
        public List<BalancerReference.Request> currentTasks = new List<BalancerReference.Request>();
        public BalancerReference.BalancerServiceSoapClient balancerService = new BalancerReference.BalancerServiceSoapClient();
        public static bool alreadySendAddress = false;

        [WebMethod]
        public Plane NewPlane()
        {
            sendAddress();
            return new Plane();
        }

        [WebMethod]
        public Plane ChangeState(Plane plane, int newState)
        {
            sendAddress();
            return plane.changeState(newState);
        }

        [WebMethod]
        public Plane ChangeName(Plane plane, string newName)
        {
            sendAddress();
            return plane.changeName(newName);
        }

        [WebMethod]
        public Plane ChangeType(Plane plane, int newType)
        {
            sendAddress();
            return plane.changeType(newType);
        }

        [WebMethod]
        public int getLoad()
        {
            sendAddress();
            int result = 0;
            foreach (BalancerReference.Request req in currentTasks)
            {
                result += req.RequestDifficulty;
            }
            return result;
        }

        private string getURLAddress()
        {
            string res = "";

            res = HttpContext.Current.Request.Url.Authority + "/" + HttpContext.Current.Request.Url.Segments[1];

            return res;
        }

        private void sendAddress()
        {
            if (!alreadySendAddress)
            {
                balancerService.StoreServer(getURLAddress());
                alreadySendAddress = true;
            }
        }
    }

    public class Plane
    {
        private int state;
        private string name;
        private int planeType;

        public Plane()
        {
            state = 0;
            name = "DefaultName";
            planeType = 1;
        }

        // Состояние самолёта. -1 = в воздухе, 0 = в ангаре, 1 и больше = на полосе
        public int State { get { return state; } set { state = value; } }

        // Название самолёта
        public string Name { get { return name; } set { name = value; } }

        // Тип самолёта. 1 = большой, 2 = маленький
        public int PlaneType { get { return planeType; } set { planeType = value; } }

        public Plane getPlane()
        {
            return this;
        }

        public Plane changeState(int newState)
        {
            State = newState;

            return this;
        }

        public Plane changeName(string newName)
        {
            Name = newName;

            return this;
        }

        public Plane changeType(int newType)
        {
            PlaneType = newType;

            return this;
        }
    }
}
