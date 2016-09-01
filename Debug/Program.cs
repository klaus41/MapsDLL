using SelfHosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Debug
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Coordinate> list = new List<Coordinate>();

            Coordinate c1 = new Coordinate { lng = 8.692384, lat = 55.575616 };
            Coordinate c2 = new Coordinate { lng = 8.682384, lat = 55.475616 };
            Coordinate c3 = new Coordinate { lng = 8.652384, lat = 55.775616 };
            Coordinate c4 = new Coordinate { lng = 8.632384, lat = 55.975616 };
            Coordinate c5 = new Coordinate { lng = 8.72384, lat = 55.15616 };
            list.Add(c1);
            list.Add(c2);
            list.Add(c3);
            list.Add(c4);
            list.Add(c5);

            SelfHoster sh = new SelfHoster();
            sh.Run(list);
        }
    }
}
