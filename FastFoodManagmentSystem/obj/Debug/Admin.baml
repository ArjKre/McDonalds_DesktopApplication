   M S B A M L   `   `   `  ����R  NFastFoodManagmentSystem, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullA%clr-namespace:FastFoodManagmentSystemFastFoodManagmentSystem  5   	   #    FastFoodManagmentSystem.Admin   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   7local%clr-namespace:FastFoodManagmentSystem     5   	     � Title$  Admin��5   	   $	��728��6   $
��1024��6$    � WindowStyle$
 None=�61    � WindowStartupLocation$ CenterScreen=�6D    � AllowsTransparency . 
������  � 
ResizeMode$ NoResize=�5	   "   .��5      �  � RowDefinitions 5   
   �� 5      $��50 �6   �� 5      .+�5   
   �� -   5        $��0��5       K� ZIndex$ 1��6    �� CornerRadius$ 5 5 0 0��6/   ���#cc0001$��0q�6v   ._�5      � .+�5      �� $!��/Images/logoTransparant.png��6   $��422,10,422,-63q�6=   �� 5      -   5         ��Name$ close��5      $��/Images/close.png��6'      iconApp#��[  6B   $��0,0,15,0q�6c   6u   �� 5      -   5        $ minimize��5      $��/Images/minimize.png��6*   #��[  6H   $��0,0,70,0q�6i   6{   5      5      �� 5   
   $��1��6   
�������$  0 0 5 5��61   ._�5      �� $ 0,0,5,5��6   ��5      �� 5      	 �� ImageSource$*	 $/Images/Admin/AdminBackground(2).jpg��6!   
 j� Stretch$
 UniformToFill=�6U    �� Opacity$
 0.96Q�6m   ._�5      � .+�5       �� $	��252��6   $ 
0,35,35,35��6*   $	��320��6E   $
��Left=�6Q   $��Center=�6l   $��	215,0,0,0q�6�   ��5!      �� 5"      $4	 ./Images/Admin/Screenshot 2022-12-09 191435.jpg��6)   $
 UniformToFill=�6f   $
 0.75Q�6~    J� Effect 5$      3  -System.Windows.Media.Effects.DropShadowEffect  5%         Color$
 Gray��6/      ShadowDepth$ 5Q�6<   ._�5'      � .+�5(      �� -   5          
Montserrat#��[ 5(   (   $ 0��6�    � Cursor$
 Hand��6�   $��Bottom=�6�   $��55(�6�   
������� �� Left$ 10��6�   
 �� Top$	 172��6�   $��
10,0,80,10q�6  Orders6   �� 5)      -   5         ��Name$ ordbtn��5)   %   $ 1��66   $��0q�6G   $	��294��6[   $��67.0466666666667��6g   $��Bottom=�6�   $ 10��6�   $	 172��6�   $��
10,0,16,10q�6�   ��6�   Z� 5*      5+      �� 5;      $	��252��6   $	��320��6*   $ 
35,0,35,35��66   $
��Left=�6P   $��560,213,0,213q�6k   ��5<      �� 5=      $4	 ./Images/Admin/Screenshot 2022-12-09 191523.jpg��6)   $
 0.85Q�6f   $
 UniformToFill=�6u    5?        5@      $
 Gray��6/   $ 5Q�6<   ._�5B      �� #��[ 6$   $��Bottom=�6N   $��55(�6i   
�������$ 10��6�   $	 172��6�   $��
10,0,16,10q�6�   �� 5C      -   5        $ logout��5C   $   $��/Images/Logout.png��64   $
 Hand��6P   $��65��6^   $��	0,0,0,-12q�6j   6}   	 Logout5E      5F      5G      5H      5K      5L      5M      