using Chapter06;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter6
{
    class Book
    {
        public string Title { get; set; }
        public int Price { get; set; }
        public int Pages { get; set; }
    }
    static class Books
    {
        public static List<Book> GetBooks()
        {
            var books = new List<Book> {
               new Book { Title = "こころ", Price = 400, Pages = 378 },
               new Book { Title = "人間失格", Price = 281, Pages = 212 },
               new Book { Title = "伊豆の踊子", Price = 389, Pages = 201 },
               new Book { Title = "若草物語", Price = 637, Pages = 464 },
               new Book { Title = "銀河鉄道の夜", Price = 411, Pages = 276 },
               new Book { Title = "二都物語", Price = 961, Pages = 666 },
               new Book { Title = "遠野物語", Price = 514, Pages = 268 },
            };
            return books;
        }

        class Program
        {
            static void Main(string[] args)
            {

            }
        }

        private static void Exercise2_1(List<Book> books) {
            Console.WriteLine("・6.2.1");
            var book = books.FirstOrDefault(b => b.Title == "ワンダフル・C#ライフ");
            if (book != null) {
                Console.WriteLine($"{book.Price} {book.Pages}");
            }
        }

        private static void Exercise2_2(List<Book> books) {
            Console.WriteLine("・6.2.2");
            int count = books.Count(b => b.Title.Contains("C#"));
            Console.WriteLine(count);
        }

        private static void Exercise2_3(List<Book> books) { 
            Console.WriteLine("・6.2.3");
            var average = books.Where(b => b.Title.Contains("C#")).Average(b => b.Pages);
            Console.WriteLine(average);
        }
        private static void Exercise2_4(List<Book> books) {
            Console.WriteLine("・6.2.4");
            var book = books.FirstOrDefault(b => b.Price < 4000);
            if(book != null)
                Console.WriteLine(book);
        }
        private static void Exercise2_5(List<Book> books) {
            Console.WriteLine("・6.2.5");
            var pages = books.Where(b => b.Price < 4000).Max(b => b.Price);
            Console.WriteLine(pages);
        }
        private static void Exercise2_6(List<Book> books) {
            var selected = books.Where(b => b.Pages >= 400).OrderByDescending(b => b.Price);
            foreach(var book in selected){
                Console.WriteLine("{0} {1}", book.Title, book.Price);
            }
        }
        private static void Exercise2_7(List<Book> books){
            var selected = books.Where(b => b.Title.Contains("C#") && b.Pages <= 500);
            foreach(var book in books) {
                Console.WriteLine(book.Title);
            }
        }
    }
}