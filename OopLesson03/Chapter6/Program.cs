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
            var numbers = new List<int> { 9, 7, -5, 4, 2, 5, 4, 2, -4, -1, 6, 4, };
            Console.WriteLine($"平均値：{numbers.Average()}");
            Console.WriteLine($"合計値：{numbers.Sum()}");
            Console.WriteLine($"最小値：{numbers.Min()}");
            Console.WriteLine($"最大値：{numbers.Max()}");

            Console.WriteLine($"0より大きい値：{numbers.Where(n => n > 0).Min()}");

            bool exists = numbers.Any(n => n % 7 == 0);

            var books = Books.GetBooks();
            Console.WriteLine($"本の平均価格：{ books.Average(b => b.Price)}");
            Console.WriteLine($"本の合計価格：{ books.Sum(b => b.Price) }");
            Console.WriteLine($"本のページが最大：{ books.Max(b => b.Pages) }");
            Console.WriteLine($"高価な本：{ books.Max(b => b.Price) }");
            Console.WriteLine($"タイトルに「物語」がある冊数：{ books.Count(b => b.Title.Contains("物語"))}");

            //600ページを超える書籍があるか？（Anyメソッド）
            Console.Write($"600ページを超える書籍はあるか：");
            Console.WriteLine( books.Any(p => p.Pages >= 600) ? "ある" : "ない");

            //すべてが200ページ以上の書籍か？（Allメソッド）
            Console.WriteLine($"{books.All(p => p.Pages >= 200)}");

            //本の値段が400円以上のものを3冊出力
            var book = books.Where(x => x.Price >= 400).Take(3);
            foreach(var item in book)
            {
                Console.WriteLine(item.Title + " ");
            }

        }
    }
}
