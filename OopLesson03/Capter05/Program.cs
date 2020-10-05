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
            Console.Write("文字列1：");
            var st1 = Console.ReadLine();
            Console.Write("文字列2：");
            var st2 = Console.ReadLine();

            if (string.Compare(st1, st2, ignoreCase: true) == 0) {
                Console.WriteLine("等しい");
            }else {
                Console.WriteLine("等しくない");
            }

            //5.2
            Console.WriteLine("数値文字列：");
            var line = Console.ReadLine();
            int num;    //返還後の数値格納用
            if(int.TryParse(line, out num)) {
                Console.WriteLine(num.ToString("#,#"));
            }

	    //5.3
	    var st = "Jackdaws love my big sphinx of quartz";

            //5.3.1
            Console.WriteLine("・5.3.1");
            int spaces = st.Count(c => c == ' ');
            Console.WriteLine("空白数：[0]", spaces);

            //5.3.2
            Console.WriteLine("・5.3.2");
            var replaced = st.Replace("big", "small");
            Console.WriteLine(replaced);

            //5.3.3
            Console.WriteLine("・5.3.3");
            int count = st.Split(' ').Count();
            Console.WriteLine("単語数[0]", count);

            //5.3.4
            Console.WriteLine("・5.3.4");
            //var words = st.Split(' ').Where(s => s.Length <= 4);
            //foreach(var word in words)
            //{
            //    Console.WriteLine(word);
            //}

            st.Split(' ').Where(s => s.Length <= 4).ToList().ForEach(Console.WriteLine);

            //5.3.5
            Console.WriteLine("・5.3.5");
            var array = st.Split(' ').ToArray();
            if (array.Length > 0)
            {
                var sb = new StringBuilder(array[0]);
                foreach (var word in array.Skip(1))
                {
                    sb.Append(' ');
                    sb.Append(word);
                }
                Console.WriteLine();
            }
        }
    }
}
