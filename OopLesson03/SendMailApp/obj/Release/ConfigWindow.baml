   M S B A M L   `   `   `  ���� F  BSendMailApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:SendMailAppSendMailApp      SendMailApp.ConfigWindow   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     +localclr-namespace:SendMailApp     -     � Title$  メール送信設定��$��457.778��$	��800��.��� 
������ � ColumnDefinitions ��  � RowDefinitions �� $��4* ��� $��3* ��� $��* �.+��� $��0��
���   �$��10q�$��送信情報��.���  �� $��3* ��� $��3* ��� $��* � �� $��* ��� $��3* ��� $��* ��� $��3* �.+��� $��SMTPサーバー：��$��Center=�$��Center=��� -    ��Name$ tbSmtp��$��1��$
��5,20q��� $��1��$��ユーザー名：��$��Center=�$��Center=��� -   $ 
tbUserName��$��1��$��1��$
��5,20q��� $��2��$��ポート：��$��Center=�$��Center=��� -   $ tbPort��$��3��$
��5,20q��� $��1��$��2��$��パスワード：��$��Center=�$��Center=�G� -    G�Name$ 
tbPassWord��$��1��$��3��$
��5,20q��� -    ��Name$ cbSsl��$��2��$��3��$��	SSL有効��$��Center=�$��Center=��� $��1��
���   �$��10q�$��ユーザー情報��.���  �� $��* ��� $��* ��� $��* � �� $��* ��� $��3* ��� $��4* �.+��� $��1��$��送信元：��$��Center=�$��Center=��� -   $ tbSender��$��1��$��1��$��5q�� $��2�� �� $��* ��� $��* �.+���  �� Orientation$ 
Horizontal=�.+��� -    ��Name$ 	btDefault��$��	初期値��$��80��$��10q��� $��1��$ 
Horizontal=�$��Right=�.+��� -	   $
 btOK��$��OK��$��80��$��10q��� -
   $ btCancel��$��キャンセル��$��80��$��10q��� -   $ btApply��$��適用��$��80��$��10q�