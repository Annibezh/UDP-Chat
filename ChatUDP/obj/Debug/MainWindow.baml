   M S B A M L   `   `   `  ����B  >ChatUDP, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:ChatUDPChatUDP  5   	       ChatUDP.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:ChatUDP     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   $	��430��65   $	��650��6E    � DataContext 5	        ChatUDP.ViewModel  5
   
   6   .��5      � ���#E3F0FF � RowDefinitions 5   
   �� 5      $
��1.5* �6   6,   �� 5      $��5* �6   6*   �� 5      $��2* �6   6*   .+�5   
   �  � ColumnDefinitions 5      �� 5      $��* �6#   6/   �� 5      $��4* �6#   60   �� 5      $��2* �6#   60   .+�5      �� $��
20 20 5 20q�6   $
��Bold"�6(   $��18(�6:   ���#022B59.��6]   Name:6d   �� 5      $
��0 20q�6   $��1��6$   ��64   �� *Name+{�6J   �� *	IsEnabled+6l   ]� 5      $��2��6   $��Center=�6(   $��20 0 q�6C   .+�5      �� $	��Top=�6   $
��30 5q�6.   ���#9EB7D3���#022B59$��14(�5   C   ��5   <   �� *Join+{�6U   �� *IsEnabledBtn+.��5   Q   Join6W   �� 5      $��Bottom=�6   $
��30 5q�61   ���#9EB7D3���#022B59$��14(�5   .   ��5   ?   �� *Exit+.��5   <   Exit6B   5      5       � 5!   
   $��1��6   .+�5"      �� $��20q�6   ���#FFFEF7���#02124D$��14(�6m   ��6"   �� *
Messages+6}   5#      � 5$   
   $��2��6    5%      �� 5&      $��4* �6#   60   �� 5'      6%   .+�5)      �� $��
20 0 10 10q�6   ��6*   �� *	Message+6E   �� 5*      $��1��6   $��10 30 20 30q�6%   ���#9EB7D3���#022B59$��16(�6}   ��6:   �� *Send+.��6�   Send6�   5+      5,      5-      