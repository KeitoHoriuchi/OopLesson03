﻿using Chapter06;
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
        class Program
        {
            static void Main(string[] args)
            {
                var books = new List<Book> {
                 new Book { Title = "C#プログラミングの新常識", Price = 3800, Pages = 378 },
                 new Book { Title = "ラムダ式とLINQの極意", Price = 2500, Pages = 312 },
                 new Book { Title = "ワンダフル・C#ライフ", Price = 2900, Pages = 385 },
                 new Book { Title = "一人で学ぶ並列処理プログラミング", Price = 4800, Pages = 464 },
                 new Book { Title = "フレーズで覚えるC#入門", Price = 5300, Pages = 604 },
                 new Book { Title = "私でも分かったASP.NET MVC", Price = 3200, Pages = 453 },
                 new Book { Title = "楽しいC#プログラミング教室", Price = 2540, Pages = 348 },
                };

                //C#の文字をカウント
                int count = 0;
                foreach(var book in books.Where(b => b.Title.Contains("C#"))){
                    for (int i = 0; i < book.Title.Length; i++) {
                        if ((book.Title[i] == 'C') && (book.Title[i + 1] == '#'))
                            count++;
                    }
                }
                Console.WriteLine(count);

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