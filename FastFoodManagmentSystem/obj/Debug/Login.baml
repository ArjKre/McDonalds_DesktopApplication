   M S B A M L   `   `   `  ����R  NFastFoodManagmentSystem, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullA%clr-namespace:FastFoodManagmentSystemFastFoodManagmentSystem  5   	   #    FastFoodManagmentSystem.Login   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   7local%clr-namespace:FastFoodManagmentSystem     5   	     � Title$  Login��5   	   $	��728��6   $
��1024��6$    � WindowStyle$
 None=�61    � WindowStartupLocation$ CenterScreen=�6D    � AllowsTransparency . 
������  � 
ResizeMode$ NoResize=�5	   "   .��5      �� -   5         �� CornerRadius$ 25 25 25 25��5      ��5   
   �� 5       �� ImageSource$$ /Images/MCDbackgroundImage.jpg��6    j� Stretch$ UniformToFill=�6F    j� TileMode$ FlipX=�6^   ._�5   
   �� $��22,200,494,123q�6   	 J� Effect	 5      3  -System.Windows.Media.Effects.DropShadowEffect  5      
   Color$

 Gray��6#      ShadowDepth$ 5Q�60   ._�5      �� 
�������.+�5      �� $��44��6    K� ZIndex$ 0��6%   $	��506��66   ���	#FFB9160F.+�5      �� -   5         ��Name$ close��5         iconApp#��[  6+   $��/Images/close.png��6L   $��44��6g   $	��506��6s   $��Right=�6   $��Center=�6�    � Cursor$
 Hand��6�   $��	-5,-1,0,0q�6�   �� 5      -   5        $
 back��5      #��[  6*   $��/Images/back.png��6K   $��44��6g   $	��467��6s   $
 Hand��6   $��
-12,-1,0,0q�6�   �� 5      $��95��6   $	��178��6)    �� Left$	 164��65   $��Center=�6G   $��Center=�6d   ��5      �� 5      $ /Images/logo.jpg��6)   $ Uniform=�6H   5      5       �� 5"      $	��304��6   $��0,57,0,0q�6*   $	��503��6<   .+�5#      �� .+�5$      �� $��Log In��6    $��42(�61   $��Center=�6?     
Montserrat#���  5%       5&      �� 5'      $	��151��6!   $	��438��6.   .+�5(      �� -   5         ��Name$ usertxt��5(   "   
 � Tag$ Username��63   $��35��6B   $	��270��6N   $��25(�6Z     CW-Inline-TextBox#���  5)   "   #���  5*   #   $��Center=�6M   $��Bottom=�6j   $��0,35,0,0q�6�   �� 5,      -   5        $ passtxt��5,   "   $ Password��63   $��35��6B   $	��270��6N   $��25(�6Z   #���  5-   "     Password#���  5.   #   $��0,40,0,0q�6K   .��6]    J� InputBindings 5/      �� 51   "    �� Command$% ApplicationCommands.NotACommand��6-   
 �� Key$ C��52   %    �� 	Modifiers$ Controlf�53   %   �� 55   "   $% ApplicationCommands.NotACommand��6-   $ X��56   %   $ Controlf�57   %   .��58   5    � ContextMenu 59      �� 5;   "   $y�	Collapsed=�6.   .��5<   3   5=      5?      �� 5A      -   5        $��Log in��5A       
 rndbtn#��[ 6.     
PrimaryRed#���  6N   
�������$	��214��6�   $��58��6�   $��Center=�6�   $��0,20,0,0q�6�   6�   5C      5E      5F      5H      5J      