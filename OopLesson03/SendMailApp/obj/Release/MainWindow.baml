   M S B A M L   `   `   `  ���� F  BSendMailApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:SendMailAppSendMailApp      SendMailApp.MainWindow   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     +localclr-namespace:SendMailApp     -     � Title$  メール送信アプリ��$��446.083��$��936.682��.��� 
������ � RowDefinitions �� $
��Auto ��� $
��Auto ��� $
��Auto ��� $
��Auto ��� $��206.5 ��� $
��Auto � � ColumnDefinitions �� $	��100 ��� $	��171 ��� $	��371 ��� $��* ��� $��* ��� $��* �.+��� $��18(�$��Center=�$
��23,8q�$
��Wrap=�$��	件名：��$��Center=�$��24��$��54���� -    ��Name$ tbTitle��$��1��$��Center=�$��24��$��	26,8,16,8q� �� TextWrapping$
 Wrap=�$�� ��$��Center=�$	��500��$��2���� $��1��$��18(�$��Center=�$��
32,10,23,6q�$
��Wrap=�$��To：��$��Center=�$��24��$��45���� -   $
 tbTo��$��1��$��1��$��Center=�$��24��$��	26,8,16,8q�$
 Wrap=�$�� ��$��Center=�$	��500��$��2���� $��2��$��18(�$��Center=�$��	32,8,23,8q�$
��Wrap=�$��Cc：��$��Center=� J� RenderTransformOrigin$ 0.885,-0.332&�$��24��$��45���� -   $
 tbCc��$��2��$��1��$��Center=�$��24��$��	26,8,16,8q�$
 Wrap=�$�� ��$��Center=�$	��500��$��2���� $��3��$��18(�$��Center=�$��	26,8,30,7q�$
��Wrap=�$��Bcc：��$��Center=�$ 0.78,-0.071&�$��24��$��44���� -   $ tbBcc��$��3��$��1��$��Center=�$��24��$��	26,7,16,8q�$
 Wrap=�$�� ��$��Center=�$	��500��$��2���� $��4��$��16(�$��Center=�$��23,93,23,90q�$
��Wrap=�$��	本文：��$��Center=�$��24��$��54���� -   $ tbText��$��4��$��1��$��Center=�$	��180��$��26,14,16,13q�$
 Wrap=�$�� ��$��Center=�$	��500��$��2���� $��5��$��2��$��Right=�$��49��$	��Top=�$	��195�� �� Orientation$ 
Horizontal=�.+��� -    ��Name$ btCancel��$��14(�$��キャンセル��$��75��$��10q��� -   $
 btOk��$��14(�$��送信��$��75��$��10q�� $��5��.+��� -	   $ btConfig��$��設定��$��14(�$��10q�� $��3��$��3��$��5��.+��� -
   $ tbfile��$��3��$��5��$��	0,8,10,10q�� $��5��$��3��.+��� $��添付ファイル：��$��15(�$��Center=�$��Center=�� $��5��$��4��.+��� -   $ btAdd��$��追加��$��14(�$��Center=�$��Center=�$��76��$��29��� $��5��$��5��.+��� -   $ btdelete��$��削除��$��14(�$��Center=�$��Center=�$��75��$��29��