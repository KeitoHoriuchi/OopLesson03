using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capter05
{
    class Program
    {
        static void Main(string[] args)
        {
            //5.4
            var line = "Novelist=谷崎潤一郎;BestWork=春琴抄;Born=1886";

            Console.WriteLine("・5.4");
            var words = line.Split(';');
            foreach(var item in words)
            {
                var st = item.Split('=');
                Console.WriteLine("{0}:{1}", ToJapanese(st[0]), st[1]);
            }
        }

        static string ToJapanese(string key)
        {
            switch (key)
            {
                case "Novelist":
                    return "作家　";
                case "BestWork":
                    return "代表作";
                case "Born":
                    return "誕生年";
                default:
                    return "　　　";
            }
        }
    }
}
