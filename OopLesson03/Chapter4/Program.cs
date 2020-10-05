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
        //演習問題4.2
        static void Main(string[] args)
        {
            //4.2.1
            var ymCollection = new YearMonth[]{
                new YearMonth(1980,1),
                new YearMonth(1990,4),
                new YearMonth(2000,7),
                new YearMonth(2010,9),
                new YearMonth(2020,2)
            };

            //4.2.2
            Console.WriteLine("・4.2.2");
            foreach(var ym in ymCollection){
                Console.WriteLine(ym);
            }
            Console.WriteLine("────────────────────────");
        }
        ////4.2.3
        //static YearMonth FindFirst21C(YearMonth[] ym)
        //{   }


        ////4.2.4
        //private static void Exercise2_4(YearMonth[] ymCollection)
        //{
        //    var yearmonth = FindFirst21C(ymCollection);
        //    false
        //        var s = yearmonth == new YearMonth
        //}

    }

}