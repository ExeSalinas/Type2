   M S B A M L   `   `   `  ����@  <Type2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:Type2Type2  5   	       Type2.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   %localclr-namespace:Type2     5   	     � Title$  
MainWindow��5   	   $	��600��6   $	��850��6,   $	��900��6;   .��5	      �  � ColumnDefinitions 5   
   �� 5      $
��0.7* �6   �� 5      $
��0.3* �6   .+�5   
   �� -   5         ��Name$ scrollViewer��5      $��0,0,20,0q�6-   $��Stretch=�6?   $��Stretch=�6]   $
��Auto=�6y   .��5      �� -   5         ��Name$ 	mainPanel��5      $��20,20,20,20q�6,   $��0��6A    �� Orientation$ Vertical=�6R   .+�5         Type2.RedditBox  5      5      � 5   
   -   5        $��wrapOptions��5   ?   $��1��6   $��Center=�6$   .+�5      �� -   5         ��Name$ txtVelocidad��5      $��25(�6.   $��Velocidad: ��6<   $��Stretch=�6O   �� 5      -   5         ��Name$ SliderVelocidad��5      $	��120��6/    � Maximum$	 100Q�6g    � Minimum$ 10Q�6u   $��Center=�6�   �� 5      -   5        	 ��Name$	 AddButon��5      $��30,20,30,20q�6'   
 � Cursor$

 Hand��6<   .��5      �� $ 
Horizontal=�6   .+�5      �� $��Agregar Comentario��6   $��15(�69   6J   �� 5      $,��&/Resources/iconfinder_plus_1814113.png��6   $��35��6L   $��35��6W   5      5!      �� 5"      -   5        $��btnPlay��5"      $

 Hand��6$   $��Center=�6H   $��	70,0,70,3q�6f   ��5#      � 5$      .+�5%      �� -   5         ��Name$ lblPlay��5%       $
��Play��61   $��20(�6B   �� 5&      $,��&/Resources/iconfinder_play_1814112.png��6    $��35��6P   $��35��6\   5'      5)      5*      5+      5,      