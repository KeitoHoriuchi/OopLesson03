using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Chapter3
{
    class Program
    {
        //デリゲートの宣言（int型の変数を受け取ってbool1値を返すメソッド
        public delegate bool Judgement(int value);

        static void Main(string[] args)
        {
            var names = new List<string>
            {
                "Tokyo","New Delhi","Bangkok","London","Paris","Berlin","Canberra","Hong Kong",
            };

            var query = names.Where(s => s.Length <= 5).ToList();
            foreach(var item in query)
            {
                Console.WriteLine(item);
            }

            names[0] = "Osaka";
            foreach(var item in query)
            {
                Console.WriteLine(item);
            }
        }
    }
}
