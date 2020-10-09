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
            //問題6.1
            var numbers = new int[] { 5, 10, 17, 9, 3, 21, 10, 40, 21, 3, 35 };

            //6.1.1 最大値を求める
            Exercise1_1(numbers);
            
            //6.1.2 最後から要素を2つ取り出す
            Exercise1_2(numbers);
            
            //6.1.3 数値型→文字列型
            Exercise1_3(numbers);
            Console.WriteLine();

            //6.1.4 昇順から要素を3つ取り出す
            Exercise1_4(numbers);
            Console.WriteLine();

            //6.1.5 重複なく10より大きい値をカウント
            Exercise1_5(numbers);

            //問題6.2
            //6.2.1
            
        }

        private static void Exercise1_1(int[] numbers){
            Console.WriteLine("・6.1.1");
            Console.WriteLine(numbers.Max());
        }

        private static void Exercise1_2(int[] numbers){
            Console.WriteLine("・6.1.2");
            int pos = numbers.Length - 2;
            foreach (var number in numbers.Skip(pos)){
                Console.WriteLine(number + " ");
            }
        }

        private static void Exercise1_3(int[] numbers){
            Console.WriteLine("・6.1.3");
            foreach (int n in numbers)
            {
                Console.Write(n.ToString() + " ");
            }
        }

        private static void Exercise1_4(int[] numbers){
            Console.WriteLine("・6.1.4");
            foreach (var number in numbers.OrderBy(n => n).Take(3)){
                Console.Write(number + " ");
            }
        }

        private static void Exercise1_5(int[] numbers){
            Console.WriteLine("・6.1.5");
            Console.WriteLine(numbers.Distinct().Count(n => n > 10));
        }
    }
}
