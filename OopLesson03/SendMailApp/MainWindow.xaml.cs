using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Forms;


namespace SendMailApp
{
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    
    public partial class MainWindow : Window
    {
        SmtpClient sc = new SmtpClient();
        

        public MainWindow()
        {
            InitializeComponent();
            sc.SendCompleted += Sc_SendCompleted;
        }

        //送信完了イベント
        private void Sc_SendCompleted(object sender, System.ComponentModel.AsyncCompletedEventArgs e){
            if(e.Cancelled) {
                System.Windows.MessageBox.Show("送信はキャンセルされました。");
            } else {
                System.Windows.MessageBox.Show(e.Error?.Message ?? "送信完了。");
            }
        }

        //メール送信処理
        private void btOk_Click(object sender, RoutedEventArgs e){
            try {
                MailMessage msg = new MailMessage("ojsinfosys01@gmail.com", tbTo.Text);

                msg.Subject = tbTitle.Text; //件名
                msg.Body = tbText.Text;     //本文
                if(tbfile.Text != "")
                msg.Attachments.Add(new Attachment(tbfile.Text)); //添付ファイル

                if(tbCc.Text != "")
                msg.CC.Add(tbCc.Text);      //CC

                if(tbBcc.Text != "")
                msg.Bcc.Add(tbBcc.Text);    //BCC

                sc.Host = "smtp.gmail.com"; //SMTPサーバーの設定
                sc.Port = 587;
                sc.EnableSsl = true;
                sc.Credentials = new NetworkCredential("ojsinfosys01@gmail.com", "ojsInfosys2020");

                //sc.Send(msg);   //送信
                sc.SendMailAsync(msg);
            }
            catch (Exception ex){
                System.Windows.MessageBox.Show(ex.Message);
            }
        }

        //キャンセル処理
        private void btCancel_Click(object sender, RoutedEventArgs e)
        {
            sc.SendAsyncCancel();
        }

        //設定ボタンイベントハンドラ
        private void btConfig_Click(object sender, RoutedEventArgs e){
            ConfigWindow configWindow = new ConfigWindow();
            configWindow.Show();    //設定画面表示
        }

        //設定画面表示
        private void ConfigWindowShow(){
            ConfigWindow configWindow = new ConfigWindow();//設定画面のインスタンスを生成
            configWindow.Show();
        }

        //ウィンドウのロード時
        private void Window_Loaded(object sender, RoutedEventArgs e){

            if (sc.Host == null ||
               sc.Port == 0 ||
               sc.Credentials == new NetworkCredential())
                ConfigWindowShow();
            

            try
            {
                Config.GetInstanse().DeSerialise(); //逆シリアル化 XML→オブジェクト
            }
            catch (Exception ex)
            {
                System.Windows.MessageBox.Show(ex.Message);
            }
        }

        //ウィンドウを閉じる時
        private void Window_Closed(object sender, EventArgs e){
            try{
                Config.GetInstanse().Serialise();   //シリアル化　オブジェクト→XML
            }
            catch (Exception ex){
                System.Windows.MessageBox.Show(ex.Message);
            }
        }
        
        //添付ファイルの追加
        private void btAdd_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "ファイルを開く";
            ofd.InitialDirectory = @"C:\";

            if(ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                tbfile.Text = ofd.FileName;
            }
           
        }

        //添付ファイルの削除
        private void btdelete_Click(object sender, RoutedEventArgs e)
        {
            tbfile.Text = "";
        }
    }
}
