   M S B A M L   `   `   `  ����@  <Type2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:Type2Type2  5          Type2.RedditBox   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      %localclr-namespace:Type2     5      .��5      �   � RowDefinitions  5	   
   �� 5
      $��* �6   .+�5   
   �  � Orientation$ Vertical=�6   $��Stretch=�6+   .+�5      � $ 
Horizontal=�6   
�������.+�5      ]� $��Stretch=�6   .+�5      �� $��/Resources/Red1.png��6   $��30��69   $��30��6D   $��5q�6P   $	��Top=�6[   �� 5      $��2��6    $��Stretch=�6*   
�������
�������$��0,0,0,7q�6j   5      � 5      -   5        $��wrapBox��5      $ Vertical=�6+   $��Stretch=�6C   $	��400��6_   $
��Left=�6n   .+�5      � -   5        $��header��5   W   $ 
Horizontal=�6    $��Stretch=�69   .+�5      �� -   5        $��	txtNombre��5   2   $��nombre ��6#   $��Center=�6C    �� AutoWordSelection$
 True��6�   ��6^   Z� ��6u   Z� 6�   �� 5      -   5        $��	Separador��5   ,   $��·��6    6?   �� 5      -   5        $��txtTime��5   ,   $��X��6#   $��Center=�6;   $��2,0,0,0q�6V   ��6g   Z� ��6}   Z� 6�   �� 5      -   5        $��txtHours��5   0   $��hours��6#   $��Center=�6@   $��2,0,0,0q�6[   ��6l   Z� ��6�   Z� 6�   �� 5      $	��ago��6    61   �� 5      -   5         ��Name$ btnEliminar��5   !   $��Right=�66   $��20��6R   $��X��6]   $��	230,0,0,0q�6i   6�   5      �� 5      -   5         ��Name$ 
txtContent��5   9   $
��Left=�6   4  .System.Windows.Automation.AutomationProperties   HelpText$ Introducir el Texto��6M    �� AcceptsReturn$
 True��6�    �� 
AcceptsTab$
 True��6�   $	��350��6�    �� TextWrapping$
 Wrap=�6�   ��6�   Z� .��6�   5!      � 5"      -	   5        $��footer��5"       .+�5#      �� -
   5        $ btnReply��5#   !   $y�Visible=�63   $��Center=�6�   $��Center=�6�   ��6H   Z� ��6_   Z� ��6u   Z� .��5$      �� 	 �� Orientation$	 
Horizontal=�6)   $��Center=�6B   $��Center=�6_   .+�5%   "   �� $/��)/Resources/iconfinder_replies_4295561.png��6(   $��10��6\   $��10��6g   $��Center=�6s   $��Center=�6�   $��0,0,0,0q�6�   $y�Visible=�6�   �� 5&   "   $��Reply��6(   $��Center=�68   5'      5(      �� 5)      $��
Give Award��6    $��Center=�65   6S   �� 5*      $��Share��6    $��Center=�61   6O   �� 5+      $��Report��6    $��Center=�61   6O   �� 5,      $
��Save��6    $��Center=�60   6N   5-      � 5.      -   5        $��wrapResponse��5.       $ Vertical=�64   $��10,0,0,0q�6K   5/      50      53      54      55      56      