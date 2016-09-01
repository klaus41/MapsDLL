using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

namespace SelfHosting
{
    public class ProductsController : ApiController
    {
        public Product GetProduct()
        {
            return new Product
            {
                ProductID = 1,
                Name = "Red Bull",
                Price = 15
            };
        }
    }
    public class Product
    {
        public int ProductID { get; set; }
        public String Name { get; set; }
        public int Price { get; set; }
    }
}
