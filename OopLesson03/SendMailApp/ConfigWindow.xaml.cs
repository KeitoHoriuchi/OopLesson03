using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace SendMailApp{
    /// <summary>
    /// ConfigWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class ConfigWindow : Window{
        public ConfigWindow(){
            InitializeComponent();
        }

        //初期値
        private void btDefault_Click(object sender, RoutedEventArgs e){
            Config cf = (Config.GetInstanse()).getDefaultStatus();
            tbSmtp.Text = cf.Smtp;
            tbPort.Text = cf.Port.ToString();
            tbUserName.Text = cf.MailAddress;
            tbPassWord.Password = cf.PassWord;
            cbSsl.IsChecked = cf.Ssl;
            tbSender.Text = cf.MailAddress;
        }

        //適用（更新）
        private void btApply_Click(object sender, RoutedEventArgs e){
            Config.GetInstanse().UpdateStatus(tbSmtp.Text,
                                              tbUserName.Text,
                                              tbPassWord.Password,
                                              int.Parse(tbPort.Text),
                                              cbSsl.IsChecked ?? false);//更新処理を呼び出す

        }

        //OKボタン
        private void btOK_Click(object sender, RoutedEventArgs e){
            btApply_Click(sender, e);   //更新処理を呼び出す
            this.Close();
        }

        //キャンセルボタン
        private void btCancel_Click(object sender, RoutedEventArgs e){
            this.Close();
        }

        //ロード時に一度だけ呼び出される
        private void Window_Loaded(object sender, RoutedEventArgs e){
            tbSmtp.Text = Config.GetInstanse().Smtp;
            tbPort.Text = Config.GetInstanse().Port.ToString();
            tbUserName.Text = Config.GetInstanse().MailAddress;
            tbPassWord.Password = Config.GetInstanse().PassWord;
            cbSsl.IsChecked = Config.GetInstanse().Ssl;
            tbSender.Text = Config.GetInstanse().MailAddress;

        }
    }
}
