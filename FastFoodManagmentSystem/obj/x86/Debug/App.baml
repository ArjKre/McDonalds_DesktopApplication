   M S B A M L   `   `   `  ????R  NFastFoodManagmentSystem, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullA%clr-namespace:FastFoodManagmentSystemFastFoodManagmentSystem  5      !    FastFoodManagmentSystem.App   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      7local%clr-namespace:FastFoodManagmentSystem     5        ?? 	Resources  5         Insaniburger  InsaniburgerwithCheese  
Montserrat  primaryYellow ?? Color  SecondayYellow  
PrimaryRed  SecondaryRed ?? 
TargetType 
 rndbtn ?? Property ?? Value ?? Triggers P? Property P? Value3  -System.Windows.Media.Effects.DropShadowEffect ?? 	Resources  TextBox.Static.Border 	 TextBox.MouseOver.Border 
 TextBox.Focus.Border  CW-Inline-TextBox-  'System.Windows.Input.KeyboardNavigation	 ?? 
TargetType
 ? 	Resources  Key ?? TargetProperty ?? 
TargetName9  3System.Windows.Media.Animation.EasingDoubleKeyFrame O? KeyTime O? Value   EasingFunction0  *System.Windows.Media.Animation.QuinticEase7  1System.Windows.Media.Animation.EasingFunctionBase   
EasingMode8  2System.Windows.Media.Animation.EasingColorKeyFrame ?? KeyTime ?? Value R? KeyTime R? Value ??Name J? SnapsToDevicePixels ??Name ??Name
 ? Tag J? RenderTransformOrigin ?? Triggers ?? 
TargetName N? EnterActions  CW-Inline-input-example ]? 
Conditions ?? Property  ?? Value??%?  &	        &	 5     &	 ?     &	 ?     &	 ?     &	     &	 "    &	 C    &	 ?    &		     &	
 >    &	 _    7  7 	 7 
 7  *?5   
   /Fonts/#Insaniburger .ttf)?5
      *?5   
   73FontFamily = "\Fonts\#Insainburger With Cheese.ttf")?5      *?5   
   #/Fonts/#Montserrat SemiBold.ttf)?5      ?? 5   
   $ #FFF10A??60   ?? 5   
   $ #FEC208??61   ?? 5   
   $ #CF240A??6-   ?? 5   
   $ #FF2D08??6/   ?? 5   
   " ??6   .?5      ??  ? ??$ 24(?6)   ?? 5       ? ??# ?   67    5      P? 5        ?@J?IsMouseOver . . ?5!      ??  ? ?? ?#CF240A63   ?? 5"       ? ??
 ?????63   ?? 5#       ?@J?Effect 5$        5%      5'      5(       5*      ???? 5+      '??       " ??6   .?5,      ??  ?@??CornerRadius$ 10??65   5-      5.      5/      ?? 52   
   $ 	Gainsboro??68   ?? 53   
   $ #CF240A??6;   ?? 54   
   $ #9E1A1A??67   ?? 58   
   " ??6*   .?5:      ??  ? ??$ 0,55,0,0q?6'   ?? 5;       ? ??# ? ??6+   ?? 5<       ? ??8   6,   ?? 5=       ? ??# ? ??6+   ?? 5>       ? ??$ 1q?60   ?? 5?       ?@ TabNavigation$
 None=?6A   ?? 5@       ? ??$
 Left=?6;   ?? 5A       ?@?FocusVisualStyle 61   Z? ?? 5B       ?@J?	AllowDrop . 6*   ?? 5C       ?@??PanningMode$ VerticalFirst=?69   ?? 5D       ?@??IsFlicksEnabled .  67   ?? 5E       ? ?? 5F      ?? 5G      "	 ??6&   
 5H      ???? 5I      CW-Inline-input-example .??5J   "   U? $U O(UIElement.RenderTransform).(TransformGroup.Children)[3].(TranslateTransform.X)?6@   $ 	textBlock??6?   .\?5K   &     $ 0:0:0.6??6;   $ -6.667Q?6M    5L   *     5M   .   $ 	EaseInOut=?6:   5O   '   5P   #   U? 5Q   "   $U O(UIElement.RenderTransform).(TransformGroup.Children)[3].(TranslateTransform.Y)?6@   $ 	textBlock??6?   .\?5R   &     $ 0:0:0.6??6;   $ -45.733Q?6M    5S   *     5T   .   $ 	EaseInOut=?6:   5V   '   5W   #   ?? 5X   "   $6 0(TextElement.Foreground).(SolidColorBrush.Color)?6?   $ 	textBlock??6?   .g?5Y   &     $ 0:0:0.6??6:   $ #ff8b3d??6L   5Z   #   T? 5[   "   $ (TextElement.FontWeight)?6@   $ 	textBlock??6u   ..?5\   &   i? $ 0:0:0.3??6=    5]   *   #?5^   .   Bold"?6?   5`   '   5a   #   5b      5c      .R?5e      ? .+?5g      ?? $ border??6%   $??1??65   #??z??5h      #??z??6I   #??z??5i       . ._?5j   "   ?? $ PART_ContentHost??6/   |?.  $??Hidden=?5k   '   $??Hidden=?6N   5l      ?? 5n      $ 	textBlock??6(   #??z 6;   $??Center=?5o   $   $	??8,0q?6?   
???????$ 0.5,0.5&?5p   6   z?5r   "   V? 5s   &   .~?5t   *   ?? ?? 5u   *   ?? 5v   *   T? 5w   *   5x   '   5z      5|       5~      P? 5       ? {? .  . ?5?   "   ?? $ border??6<    ?@J?Opacity$
 0.56Q?6P   5?      P? 5?       ?@J?IsMouseOver . . ?5?   "   ?? $ border??6@   8   ? ??6T   5?      P? 5?       ?@J?IsKeyboardFocused . . ?5?   "   ?? $ border??6@   8   ? ??6T    5?   "   ?? 5?   &   8?? 66   5?      5?      5?       5?      ]? 5?       5?      ?? 5?      + ?@??#IsInactiveSelectionHighlightEnabled  . 6S   ?? 5?       ?@??IsSelectionActive  .  6A   ./?5?      ??  ?@??SelectionBrush# ? /?67   5?      5?      5?      5?      