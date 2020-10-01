using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Dynamic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Chapter4
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }
        private static object GetProduct()
        {
            Sale sale = new Sale
            {
                ShopName = "pet store",
                Amount = 100000,
                Product = "food"
            };
            sale = null;
            return sale?.Product;
        }

        class Sale
        {
            //店舗名
            public string ShopName { get; set; }
            //売上高   
            public int Amount { get; set; }
            public string Product { get; set; }
        }
    }
}
