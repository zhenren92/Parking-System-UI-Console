using System;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;

namespace Parking_System_UI.Helper
{
    public class Helper
    {
        public class Configuration
        {
            public string GetServerAPI()
            {
                return "http://localhost:5000/api/";
            }
        }

        public class ParkirAPI
        {
            public WebClient Initial()
            {
                var client = new WebClient();
                client.BaseAddress = new Configuration().GetServerAPI() + "Parkir/";
                client.Headers.Add("Content-Type:application/json");  
                client.Headers.Add("Accept:application/json"); 
                return client;
            }
        }
    }
}