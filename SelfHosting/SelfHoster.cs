using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Web.Http;
using System.Web.Http.SelfHost;

namespace SelfHosting
{
    public class SelfHoster
    {
        public void Run(List<Coordinate> coordinates)
        {
            CoordinatesController ct = new CoordinatesController();
            ct.SetCoordinates(coordinates);

            var config = new HttpSelfHostConfiguration("http://localhost:52707");
            config.MessageHandlers.Add(new CustomHeaderHandler());

            config.Routes.MapHttpRoute(
                name: "API",
                routeTemplate: "{controller}/{action}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );

            using (HttpSelfHostServer server = new HttpSelfHostServer(config))
            {
                server.OpenAsync().Wait();
                Console.WriteLine("Web API is started now.");
                System.Diagnostics.Process.Start("C:/Users/klaus/Documents/Visual Studio 2015/Projects/SelfHosting/Maps2/index.html");
                TimeOut();
            }
        }
        private static void TimeOut()
        {
            bool x = true;
            Stopwatch sw = new Stopwatch();
            sw.Start();
            while (x == true)
            {
                if (sw.ElapsedMilliseconds == 5000)
                {
                    x = false;
                }
            }
        }
    }
}
