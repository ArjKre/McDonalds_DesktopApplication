   M S B A M L   `   `   `  ????R  NFastFoodManagmentSystem, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullA%clr-namespace:FastFoodManagmentSystemFastFoodManagmentSystem  5      !    FastFoodManagmentSystem.App   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      7local%clr-namespace:FastFoodManagmentSystem     5        ?? 	Resources  5         Insaniburger  InsaniburgerwithCheese  
Montserrat  Password 
 Carmen  Protofo  primaryYellow ?? Color  SecondayYellow  
PrimaryRed 	 SecondaryRed 
 iconApp ?? 
TargetType ?? Property ?? Value ?? Triggers P? Property P? Value ?? ScaleX	 ?? ScaleY  shadow-effect3  -System.Windows.Media.Effects.DropShadowEffect
   Color 
 rdnbtn 
 rndbtn ?? 	Resources  TextBox.Static.Border  TextBox.MouseOver.Border  TextBox.Focus.Border  CW-Inline-TextBox-  'System.Windows.Input.KeyboardNavigation ?? 
TargetType ? 	Resources  Key ?? TargetProperty ?? 
TargetName9  3System.Windows.Media.Animation.EasingDoubleKeyFrame O? KeyTime O? Value   EasingFunction0  *System.Windows.Media.Animation.QuinticEase7  1System.Windows.Media.Animation.EasingFunctionBase   
EasingMode8  2System.Windows.Media.Animation.EasingColorKeyFrame ?? KeyTime ?? Value R? KeyTime R? Value ??Name J? SnapsToDevicePixels ??Name ??Name
 ? Tag J? RenderTransformOrigin ?? Triggers ?? 
TargetName  N? EnterActions  CW-Inline-input-example! ]? 
Conditions" ?? Property# ?? Value  cnct-lb  ScrollThumbs$ ?Name% ?? CornerRadius& ]?Name' ]? Thumb( n?Name) ]? IncreaseRepeatButton* ??Name+ J? Opacity, ]? DecreaseRepeatButton- P? 
SourceName. ?? Angle??%Z  &	        &	 5     &	 ?     &	 ?     &	 ?     &	 b    &	 ?    &	 ?    &	     &		 1    &	
 R    &	 \    &	     7  &	 ?    &	 ?    &	 ?    &	 ?    &	     7  7  7  7  &	 ?    &	 ?    '?? ?    *?5   
   /Fonts/#Insaniburger .ttf)?5
      *?5   
   73FontFamily = "\Fonts\#Insainburger With Cheese.ttf")?5      *?5   
   #/Fonts/#Montserrat SemiBold.ttf)?5      *?5   
   /Fonts/#Password .tff)?5      *?5   
   ZVC:\Users\ArjunKre\Desktop\FFMS\FastFoodManagmentSystem\Fonts\#Carmen Sans SemiBold.ttf)?5      *?5   
   TPC:\Users\ArjunKre\Desktop\FFMS\FastFoodManagmentSystem\Fonts\#Protofo Medium.ttf)?5      ?? 5    
   $ #FFF10A??60   ?? 5!   
   $ #FEC208??61   ?? 5"   
   $ #CF240A??6-   ?? 5#   
   $ #FF2D08??6/   ?? 5%   
   " ??6    .?5&      ??  ? ??$	 Top=?62   ?? 5'       ? ??$ Right=?64    5(      P? 5)       ?@J?IsMouseOver . . ?5*      ??  ? z? 5+      ?? 5,      $	 1.2Q?6-   $		 1.2Q?6:   5.      5/      51      ?? 53   
   " ??6&    54      P? 55       ?@J?IsMouseOver . . ?56      ??  ?@J?Effect 57        58      $
 
WhiteSmoke??6/   5:      5<      5>      ?? 5@   
   " 	?6   .?5A      ??  ?@?LayoutTransform 5B      ?? 5C      $
 2.25Q?6%   $
	 2.25Q?63   5E       5F      P? 5G       ? {? . . ?5H      ??  ? ??8   63   5I      5K      ?? 5N   
   " ??6   .?5O      ??  ? ??$ 24(?6)   ?? 5P       ? ??# ?   67   ?? 5Q       ? ?? ?#CF240A6+   ?? 5R       ? ??
 ?????6+    5S      P? 5T       ?@J?IsMouseOver . . ?5U      ??  ?@J?Effect 5V        5W      5Y      5Z       5\      ???? 5]      '??       " ??6   .?5^      ??  ?@??CornerRadius$ 10??65   5_      5`      5a      ?? 5c   
   $ 	Gainsboro??68   ?? 5d   
   $ #CF240A??6;   ?? 5e   
   $ #9E1A1A??67   ?? 5g   
   " ??6*   .?5h      ??  ? ??# ? ??6+   ?? 5i       ? ??8   6,   ?? 5j       ? ??# ? ??6+   ?? 5k       ? ??$ 1q?60   ?? 5l       ?@ TabNavigation$
 None=?6A   ?? 5m       ? ??$
 Left=?6;   ?? 5n       ?@?FocusVisualStyle 61   Z? ?? 5o       ?@J?	AllowDrop . 6*   ?? 5p       ?@??PanningMode$ VerticalFirst=?69   ?? 5q       ?@??IsFlicksEnabled .  67   ?? 5r       ? ?? 5s      ?? 5t      " ??6&    5u      ???? 5v      CW-Inline-input-example .??5w   "   U? $U O(UIElement.RenderTransform).(TransformGroup.Children)[3].(TranslateTransform.X)?6@   $ 	textBlock??6?   .\?5x   &     $ 0:0:0.6??6;   $ -6.667Q?6M    5y   *     5z   .   $ 	EaseInOut=?6:   5|   '   5}   #   U? 5~   "   $U O(UIElement.RenderTransform).(TransformGroup.Children)[3].(TranslateTransform.Y)?6@   $ 	textBlock??6?   .\?5   &     $ 0:0:0.6??6;   $	 -30Q?6M    5?   *     5?   .   $ 	EaseInOut=?6:   5?   '   5?   #   ?? 5?   "   $6 0(TextElement.Foreground).(SolidColorBrush.Color)?6?   $ 	textBlock??6?   .g?5?   &     $ 0:0:0.6??6:   $ #ff8b3d??6L   5?   #   T? 5?   "   $ (TextElement.FontWeight)?6@   $ 	textBlock??6u   ..?5?   &   i? $ 0:0:0.3??6=    5?   *   #?5?   .   Bold"?6?   5?   '   5?   #   5?      5?      .R?5?      ? .+?5?      ?? $ border??6%   $??1??65   #??z??5?      #??z??6I   #??z??5?       . ._?5?   "   ?? $ PART_ContentHost??6/   |?.  $??Hidden=?5?   '   $??Hidden=?6N   5?      ?? 5?      $ 	textBlock??6(   #??z 6;   $??Center=?5?   $   $	??8,0q?6?   
???????$ 0.5,0.5&?5?   6   z?5?   "   V? 5?   &   .~?5?   *   ?? ?? 5?   *   ?? 5?   *   T? 5?   *   5?   '   5?      5?       5?      P? 5?       ? {? .  . ?5?   "   ?? $ border??6<    ?@J?Opacity$
 0.56Q?6P   5?      P? 5?       ?@J?IsMouseOver . . ?5?   "   ?? $ border??6@   8   ? ??6T   5?      P? 5?       ?@J?IsKeyboardFocused . . ?5?   "   ?? $ border??6@   8   ? ??6T     5?   "   ?? 5?   &   8?? 66   5?      5?      5?       5?      ]? 5?      ! 5?      ?? 5?      +" ?@??#IsInactiveSelectionHighlightEnabled# . 6S   ?? 5?      " ?@??IsSelectionActive# .  6A   ./?5?      ??  ?@??SelectionBrush# ? /?67   5?      5?      ?? 5?   
   " ??6    .?5?      ??  ? ??$ 16(?6)   ?? 5?       ? ??# ?  6+   ?? 5?       ?@J?Opacity$
 0.75Q?6(   ?? 5?       ? ??$ 30??6'   ?? 5?       ? ??$	 150??6&   5?      ?? 5?   
   " n?6%   .?5?      ??  ? ?? 5?      ?? 5?      .R?5?      ? $
$ Grid??6   .+?5?      ?? $??Stretch=?6(   $??Stretch=?6F   $
??Auto??6b   $
??Auto??5?   ,   
?????? 6:   ?? 5?      $ 
Rectangle1??6%   $% 	10 0 0 10??69   $??Stretch=?6R   $??Stretch=?5?   )   $
??Auto??6E   $
??Auto??6R   #??z??5?   )   5?       5?      P? 5?       ?@?Tag$ 
Horizontal??65   . ?5?   "   ?? $ 
Rectangle1??6)    ? ??$
 Auto??6R   ?? 5?   "   $ 
Rectangle1??6)    ? ??$ 7??6S   5?      5?      5?      5?      ?? 5?   
   " ??6+   .?5?      ??  ?@??IsFlicksEnabled .  67   ?? 5?       ? ?? ?	#AAA8341A6+   ?? 5?       ? ??
 ?????6+   ?? 5?       ? ??$ 10??6&   ?? 5?       ? ?? 5?      ?? 5?      " ??6&   .R?5?      ? $$ GridRoot??6   $??12??61   ??6<   Z? .+?5?      ]? $& 
PART_Track??6$   $??0??68   ??. |?.  ' 5?   "   n? 5?   &   $( Thumb??6,   #??z??6;   #???  5?   0   ) 5?   "   ?? 5?   &   $* PageUp??63   $??ScrollBar.PageDownCommand??6C   $+ 0Q?6g   |?.  6s   , 5?   "   ?? 5?   &   $* PageDown??63   $??ScrollBar.PageUpCommand??6E   $+ 0Q?6g   |?.  6s   5?      5       5     P? 5     $- Thumb??6&    ?@J?IsMouseOver . . ?5  "   ?? $ Thumb??5  -    ? ??
 ?   ?6@   5     P? 5     $- Thumb??6&    ?@n?
IsDragging . . ?5  "   ?? $ Thumb??67    ? ??
 ?   ?6J   5	     P? 5      ? {? .  . ?5  "   ?? $ Thumb??6)    ? y?$ 	Collapsed=?6R   5     P? 5      ?@??Orientation$ 
Horizontal=?6=   . ?5  "   ?? $ GridRoot??6)    ?@?LayoutTransform 5  &   ?? 5  *   $	. -90Q?6:   5  #   ?? 5  "   $ 
PART_Track??6)    ?@?LayoutTransform 5  &   ?? 5  *   $	. -90Q?6:   5  #   ?? 5  "    ? ??$
 Auto??6:   ?? 5  "    ? ??$ 12??6;   ?? 5  "   $ Thumb??6)    ?@?Tag$ 
Horizontal??6K   ?? 5  "   $ PageDown??6)    ? ??$ ScrollBar.PageLeftCommand??6R   ?? 5  "   $ PageUp??6)    ? ??$  ScrollBar.PageRightCommand??6P   5     5      5"     5#     5&     5'     