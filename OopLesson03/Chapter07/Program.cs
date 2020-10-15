using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter07{
    class Program {
        static void Main(string[] args)
        {
            //起動時に表示
            star();
            Console.WriteLine("* 辞書登録プログラム *");
            star();

            //単語登録用のList
            var dic = new Dictionary<string, List<string>>();
            do
            {
                Console.WriteLine("1.登録　2.内容を表示　3.終了");
                int order = int.Parse(Console.ReadLine());

                if (order == 1) {
                    //1.単語登録
                    Console.Write("KEYを入力：");
                    var key = Console.ReadLine();
                    Console.Write("VALUEを入力：");
                    var value = Console.ReadLine();
                    if (dic.ContainsKey(key)) {
                        dic[key].Add(value);
                    } else {
                        dic[key] = new List<string> { value };
                    }
                    Console.WriteLine("登録しました！");
                }                
                else if (order == 2) {
                    //2.内容を表示
                    Console.WriteLine("KEY：VALUE");
                    foreach (var item in dic) {
                        foreach (var words in item.Value)
                        {
                            Console.WriteLine("{0}：{1}", item.Key, words);
                        }
                    }
                }
                else if (order == 3)
                    break;
            } while (true);
        }      
      
        private static void star()
        {
            for (int i = 0; i <= 21; i++)
                Console.Write('*');
            Console.WriteLine();
        }
    }
}
