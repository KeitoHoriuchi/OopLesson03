using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter07{
    class Program {
        static void Main(string[] args) {
            //演習問題7.1
            var text = "Cozy lummox gives smart squid who asks for job pen";
            Exercise1_1(text);  //7.1.1
        }        

        static void Exercise1_1(string text) {
            var dict = new Dictionary<char, int>();
            foreach(var ch in text){
                char uch = char.ToUpper(ch);    //大文字への変換

                //dictのAからZの範囲にuchが登録されているかどうか
                if('A' <= uch && uch <= 'Z'){
                    if (dict.ContainsKey(uch)){
                        dict[uch]++;    //登録済みだった場合はカウント
                    } else {
                        dict[uch] = 1;  //未登録だった場合は新しくキーを登録
                    }
                }
            }
            foreach (var word in dict){
                Console.WriteLine("{0}：{1}",word.Key,word.Value);
            }
        }
    }
}
