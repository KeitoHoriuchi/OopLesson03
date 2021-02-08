using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;


namespace SendMailApp
{
    public class Config
    {
        //単一のインスタンス
        static Config instanse;

        //インスタンスの取得
        public static Config GetInstanse()
        {
            if (instanse == null)
            {
                instanse = new Config();
            }
            return instanse;
        }

        public string Smtp { get; set; }        //SMTPサーバー
        public string MailAddress { get; set; } //自メールアドレス(送信元)
        public string PassWord { get; set; }    //パスワード
        public int Port { get; set; }           //ポート番号
        public bool Ssl { get; set; }           //SSL設定

        //コンストラクタ(外部からnewできないようにする)
        private Config() { }

        //初期設定用
        public void DefaultSet()
        {
            Smtp = "smtp.gmail.com";
            MailAddress = "ojsinfosys01@gmail.com";
            PassWord = "ojsInfosys2020";
            Port = 587;
            Ssl = true;
        }

        //初期値取得用
        public Config getDefaultStatus()
        {
            Config obj = new Config
            {
                Smtp = "smtp.gmail.com",
                MailAddress = "ojsinfosys01@gmail.com",
                PassWord = "ojsInfosys2020",
                Port = 587,
                Ssl = true
            };
            return obj;
        }

        //設定データ更新
        public bool UpdateStatus(string smtp, string mailAddress, string passWord,
                                    int port, bool ssl)
        {
            Smtp = smtp;
            MailAddress = mailAddress;
            PassWord = passWord;
            Port = port;
            Ssl = ssl;
            return true;
        }

        public void Serialise() //シリアル化
        {
            try
            {
                using (var wirter = XmlWriter.Create("config.xml"))
                {
                    var serialiser = new XmlSerializer(instanse.GetType());
                    serialiser.Serialize(wirter, instanse);
                }
            }
            catch (Exception)
            {

            }
        }

        public void DeSerialise()//逆シリアル化
        {
            try
            {
                using (var reader = XmlReader.Create("config.xml"))
                {
                    var serialiser = new XmlSerializer(typeof(Config));
                    instanse = serialiser.Deserialize(reader) as Config;
                }
            }
            catch (Exception)
            {

            }
        }
    }
}
