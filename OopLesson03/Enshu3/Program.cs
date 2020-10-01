using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//新規
namespace Enshu3
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new List<int> { 12, 87, 94, 14, 53, 20, 40, 35, 76, 91, 31, 17, 48 };

            //問題3.1.1
            var exists = numbers.Exists(n => 0 == numbers[n] % 8 || 0 == numbers[n] % 9);
            if (exists)
                Console.WriteLine("存在しています。");
            else
                Console.WriteLine("存在していません。");

            Console.WriteLine();//改行

            Console.WriteLine("・問題3.1.2");
            numbers.ForEach(n => Console.WriteLine(n / 2.0));

            Console.WriteLine();

            Console.WriteLine("・問題3.1.3");
            IEnumerable<int> query = numbers.Where(n => n >= 50);
            foreach (var item in query)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();

            Console.WriteLine("・問題3.1.4");
            List<int> lists = numbers.Select(x => x * 2).ToList();
            foreach (var item in lists)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();

            var names = new List<string> { "Tokyo", "New Delhi", "Bangkok", "London",
                                          "Paris", "Berlin", "Canberra", "Hong Kong" };

            Console.WriteLine("・問題3.2.1");
            Console.Write("都市名を入力してください。空欄で終了します");
            do
            {
                var line = Console.ReadLine();
                if (string.IsNullOrEmpty(line))
                {
                    break;
                }
                var index = names.FindIndex(s => s == line);
                Console.WriteLine(index);
            } while (true);

            Console.WriteLine();

            Console.WriteLine("・問題3.2.2");
            var count = names.Count(s => s.Contains('o'));
            Console.WriteLine(count);

            Console.WriteLine();

            Console.WriteLine("・問題3.2.3");
            var selected = names.Where(s => s.Contains('o')).ToList();
            foreach (var name in selected)
            {
                Console.WriteLine(name);
            }

            Console.WriteLine();

            Console.WriteLine("・問題3.2.4");
            var nameCounts = names.Where(s => s.StartsWith("B")).Select(s => s.Length);
            foreach (var length in nameCounts)
            {
                Console.WriteLine(length);
            }
        }
    }
}
