using Microsoft.Owin.Hosting;
using System;
using System.Net.Http;

namespace SelfHostWebDoorAccessControl
{
    public class Program
    {
        const string HostIP = "192.168.1.138";
        const string HostPort = "80";

        static void Main()
        {
            string baseAddress = $"http://{HostIP}:{HostPort}/";

            // Start OWIN host 
            using (WebApp.Start<Startup>(url: baseAddress))
            {
                // Create HttpCient
                HttpClient client = new HttpClient();
                string reqUri = baseAddress + "api/DoorAccess";
                var response = client.GetAsync(reqUri).Result;

                //Console.WriteLine(response);
                Console.WriteLine($"\r\nListening at {reqUri}\r\n");
                Console.WriteLine(response.Content.ReadAsStringAsync().Result);
                Console.ReadLine();
            }
        }
    }
}