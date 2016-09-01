using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

namespace SelfHosting
{
    public class CoordinatesController : ApiController
    {
        private static List<Coordinate> list;
        public void SetCoordinates(List<Coordinate> coordinates)
        {
            list = new List<Coordinate>();
            foreach (Coordinate c in coordinates)
            {
                list.Add(c);
            }
        }
        public List<Coordinate> GetCoordinates()
        {
            return list;
        }
    }
    public class Coordinate
    {
        public double lng { get; set; }
        public double lat { get; set; }
    }
}

