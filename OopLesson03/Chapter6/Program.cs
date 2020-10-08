using Chapter06;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter6
{
    class Program
    {
        static void Main(string[] args)
        {
            //整数の例
            var numbers = new List<int> { 19, 17, 15, 24, 12, 225, 14, 20, 12, 28, 19, 30, 24 };

            //var strings = numbers.Select(n => n.ToString("0000")).ToArray();
            //foreach(var st in strings) {
            //    Console.WriteLine(st + " ");
            //}

            numbers.Select(n => n.ToString("0000")).Distinct().ToList().ForEach(s => Console.Write(s + " "));
            Console.WriteLine();

            //並べ替え
            var soteN = numbers.OrderBy(n => n);
            foreach (var nums in soteN)
            {
                Console.WriteLine(nums + " ");
            }

            //文字列の例
            var words = new List<string> { "Microsoft", "Apple", "Google", "Oracle", "Facebook" };

            var lower = words.Select(name => name.ToLower()).ToArray();

            //オブジェクトの例
            var books = Books.GetBooks();
            //タイトルのみのリスト
            var titles = books.Select(name => name.Title);
            foreach (var title in titles)
            {
                Console.WriteLine(title + " ");
            }

            Console.WriteLine();

            //ページ、又は金額の多い順に並べ替え
            var soteB = books.OrderByDescending(book => book.Pages).Take(3);
            foreach (var book in soteB)
            {
                Console.WriteLine(book.Title +" "+ book.Pages);

            }
        }
    }
}
