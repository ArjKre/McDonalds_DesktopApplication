   M S B A M L   `   `   `  ????R  NFastFoodManagmentSystem, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullA%clr-namespace:FastFoodManagmentSystemFastFoodManagmentSystem  5   	   "    FastFoodManagmentSystem.Menu   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   7local%clr-namespace:FastFoodManagmentSystem     5   	     ? Title$
  Menu??5   	   $	??728??6   $
??1024??6#    ? WindowStyle$
 None=?61    ? WindowStartupLocation$ CenterScreen=?6D    ? AllowsTransparency . 
??????  ? 
ResizeMode$ NoResize=?5	   "   .??5      ? -   5         ? RowDefinitions 5   
   ?? 5      $??50 ?6   ?? 5      .+?5   
   ?? $??0??6    K? ZIndex$ 1??6    ?? CornerRadius$ 	15 15 0 0??6/   ???#b9160f._?5      ? .+?5      ?? $!??/Images/logoTransparant.png??6   $??16,10,827,-63q?6=   ?? 5      -   5         ??Name$ close??5      $??/Images/close.png??6'      iconApp#??[  6B   $??0,0,15,0q?6c   6u   ?? 5      -   5        $ minimize??5      $??/Images/minimize.png??6*   #??[  6H   $??0,0,70,0q?6i   6{   ?? 5      -   5        	 ??Name$	 homebtn??5      $
??HOME??6*    
 rndbtn#??[ 69   $	??140??5      $??490,28,394,-28q?6!     SecondayYellow#??[ 69   
???????5   ,   ?? 5      -   5        $	 Menubtn??5      $
??MENU??6*   #??[ 69   $	??140??5      $??301,28,583,-28q?6!   #??[ 6:   
???????5   ,   ?? 5!      -   5        $	 Cartbtn??5!      $
??CART??6*   #??[ 69   $	??140??5"      $??683,28,201,-28q?6!   #??[ 69   
???????5#   ,   5$      5&      ?? 5)   
   $??1??6   $ 	0 0 15 15??6   ??5*      ?? 5+      
 ?? ImageSource$'
 !Images/qq_whatsinside_fries_f.jpg??6   ._?5.      ?? 
???????$??40,52,40,28q?6.    J? Effect 5/      3  -System.Windows.Media.Effects.DropShadowEffect  50         Color$ black??6'      ShadowDepth$ 5Q?66   ._?52      ? 
??????? 54      ?? 55      $??5* ?6(   ?? 56      $	??41* ?6(   .+?59      ? $??0??6    ? ColumnDefinitions 5;      ?? 5<      $	??50* ?6/   ?? 5=      $	??50* ?6/   ?? 5>      $	??50* ?6/   ?? 5?      $	??50* ?6/   ?? 5@      $	??50* ?6/   .+?5C      ?? 
???????$??5??63   $??
60,30,49,0q?6G   $??0,0,0,1q?6[   ?? 5D      -   5         ??Name$ burger??5D       $??0??6b   ???#b9160f 
 Carmen#??[ 6?   $??14(?6?   $	??Top=?6?   $??Center=?6?    ? Cursor$
 Hand??6?   $??0,30,0,0q?6?   .??6  	Burgers6  ?? 5E      $??0??6    ???#b9160f$??0,0,0,3q?6F   $??
60,51,61,0q?6`   ?? 5F      -   5        $ 
Sandwiches??5F       $??1??6i   #??[ 6y   $??14(?6?   $	??Top=?6?   $??Center=?6?   $
 Hand??6?   $??0,30,0,0q?6?   .??6  Chicken & Sandwiches6  ?? 5G      -	   5        $ 	Beverages??5G       $??2??6g   #??[ 6w   $??14(?6?   $	??Top=?6?   $??Center=?6?   $
 Hand??6?   $??0,30,0,0q?6?   .??6?   	Beverages6
  ?? 5H      -
   5        $ 	happyMeal??5H       $??3??6g   #??[ 6w   $??14(?6?   $	??Top=?6?   $??Center=?6?   $
 Hand??6?   $??0,30,0,0q?6?   .??6?   
Happy Meal6  ?? 5I      -   5        $ Treats??5I       $??4??6a   #??[ 6q   $??14(?6?   $??Bottom=?6?   $
??Left=?6?   $
 Hand??6?   $??10,0,0,6q?6?   .??6?   Deserts & Shakes6  5J      ? 5L      $??1??6    5M      ?? 5N      ?? 5O       5Q      ?? 5R      ?? 5S      ?? 5T      ?? 5U      .+?5X      ?? $??0??6!   $??0??6.   $ 5 5 5 5??6>   
???????$??1q?6n   $??10 10 10 10q?6?   ._?5Y      ? .+?5Z   "   ?? $??20,10,20,96q?6-   .+?5[   &   ?? $1??+/Images/Menu/Quater Pounder With Cheese.jpg??6,   5\   #   ?? 5]   "   $??Smoky BLT Quater Pounder??6(   $??12(?6K   #??[ 6Y   $??30??6~   $	??Top=?6?   $??10,156,10,0q?6?   ?? 5^   "   $??$7.99??6(     
PrimaryRed#??[ 68   #??[ 6a   $??26(?6?   $??10,186,116,16q?6?   ?? 5_   "    5`   &     5a   *   $ 
WhiteSmoke??6;   $ 1Q?6N   ._?5c   &   ?? -   5        $??/Images/basket.png??5c   -   #??[  6I   $
 Hand??6j   $??44??6?   
 ?? Top$ 4??6?   $??40??6?    ?? Left$ 5??6?   $
??Left=?6?   $??139,189,0,0q?6?   5d   #   5e      5f      ?? 5h      $??0??6!   $??1??6.   $ 5 5 5 5??6>   
???????$??1q?6n   $??10,10,10,10q?6?   ._?5i      ? .+?5j   "   ?? $??20,10,20,96q?6-   ??5k   &   ?? 5l   *   $(
 "/Images/Menu/SmokyBLTDoubleQPC.jpg??65    j? Stretch$ Uniform=?6f   5n   #   ?? 5o   "   $%??Smoky BLT Double Quater
Pounder??6(   $??12(?6V   #??[ 6d   $??46??6?   $	??Top=?6?   $??10,148,10,0q?6?   ?? 5p   "   $??$6.69??6(   #??[ 68   #??[ 6a   $??26(?6?   $??10,186,116,16q?6?   ?? 5q   "    5r   &     5s   *   $ 
WhiteSmoke??6;   $ 1Q?6N   ._?5u   &   ?? -   5        $??/Images/basket.png??5u   -   #??[  6I   $
 Hand??6j   $??44??6?   $ 4??6?   $??40??6?   $ 5??6?   $
??Left=?6?   $??139,189,0,0q?6?   5v   #   5w      5x      ?? 5z      $??0??6!   $??2??6.   $ 5 5 5 5??6>   
???????$??1q?6n   $??10,10,10,10q?6?   ._?5{      ? .+?5|   "   ?? $??20,10,20,96q?6-   ??5}   &   ?? 5~   *   $
 /Images/Menu/Big Mac.jpg??65   $ Uniform=?6\   5?   #   ?? 5?   "   $??Big Mac??6(   $??12(?6:   #??[ 6H   $??46??6m   $	??Top=?6y   $??10,148,10,0q?6?   ?? 5?   "   $??$3.39??6(   #??[ 68   #??[ 6a   $??26(?6?   $??10,186,116,16q?6?   ?? 5?   "    5?   &     5?   *   $ 
WhiteSmoke??6;   $ 1Q?6N   ._?5?   &   ?? -   5        $??/Images/basket.png??5?   -   #??[  6I   $
 Hand??6j   $??44??6?   $ 4??6?   $??40??6?   $ 5??6?   $
??Left=?6?   $??139,189,0,0q?6?   5?   #   5?      5?      ?? 5?      $??0??6!   $??3??6.   $ 5 5 5 5??6>   
???????$??1q?6n   $??10,10,10,10q?6?   ._?5?      ? .+?5?   "   ?? $??20,10,20,96q?6-   ??5?   &   ?? 5?   *   $#
 /Images/Menu/Cheeseburger.jpg??65   $ Uniform=?6a   5?   #   ?? 5?   "   $??Cheeseburger??6(   $??12(?6?   #??[ 6M   $??46??6r   $	??Top=?6~   $??10,148,10,0q?6?   ?? 5?   "   $??$2.00??6(   #??[ 68   #??[ 6a   $??26(?6?   $??10,186,116,16q?6?   ?? 5?   "    5?   &     5?   *   $ 
WhiteSmoke??6;   $ 1Q?6N   ._?5?   &   ?? -   5        $??/Images/basket.png??5?   -   #??[  6I   $
 Hand??6j   $??44??6?   $ 4??6?   $??40??6?   $ 5??6?   $
??Left=?6?   $??139,189,0,0q?6?   5?   #   5?      5?      ?? 5?      $??1??6!   $??0??6.   $ 5 5 5 5??6>   
???????$??1q?6n   $??10,10,10,10q?6?   ._?5?      ? .+?5?   "   ?? $??20,10,20,96q?6-   ??5?   &   ?? 5?   *   $*
 $/Images/Menu/Double Cheeseburger.jpg??65   $ Uniform=?6h   5?   #   ?? 5?   "   $??Double Patty Cheeseburger??6(   $??12(?6L   #??[ 6Z   $??46??6   $	??Top=?6?   $??10,148,10,0q?6?   ?? 5?   "   $??$2.99??6(   #??[ 68   #??[ 6a   $??26(?6?   $??10,186,116,16q?6?   ?? 5?   "    5?   &     5?   *   $ 
WhiteSmoke??6;   $ 1Q?6N   ._?5?   &   ?? -   5        $??/Images/basket.png??5?   -   #??[  6I   $
 Hand??6j   $??44??6?   $ 4??6?   $??40??6?   $ 5??6?   $
??Left=?6?   $??139,189,0,0q?6?   5?   #   5?      5?      ?? 5?      $??1??6!   $??1??6.   $ 5 5 5 5??6>   
???????$??1q?6n   $??10,10,10,10q?6?   ._?5?      ? .+?5?   "   ?? $??20,10,20,96q?6-   ??5?   &   ?? 5?   *   $1
 +/Images/Menu/Triple Double Cheeseburger.jpg??65   $ UniformToFill=?6o   5?   #   ?? 5?   "   $??Triple Patty Cheeseburger??6(   $??12(?6L   #??[ 6Z   $??46??6   $	??Top=?6?   $??10,148,10,0q?6?   ?? 5?   "   $??$4.49??6(   #??[ 68   #??[ 6a   $??26(?6?   $??10,186,116,16q?6?   ?? 5?   "    5?   &     5?   *   $ 
WhiteSmoke??6;   $ 1Q?6N   ._?5?   &   ?? -   5        $??/Images/basket.png??5?   -   #??[  6I   $
 Hand??6j   $??44??6?   $ 4??6?   $??40??6?   $ 5??6?   $
??Left=?6?   $??139,189,0,0q?6?   5?   #   5?      5?      ?? 5?      $??1??6!   $??2??6.   $ 5 5 5 5??6>   
???????$??1q?6n   $??10,10,10,10q?6?   ._?5?      ? .+?5?   "   ?? $??20,10,20,96q?6-   ??5?   &   ?? 5?   *   $'
 !/Images/Menu/Bacon bbq burger.jpg??65   $ UniformToFill=?6e   5?   #   ?? 5?   "   $??Bacon BBQ Burger??6(   $??12(?6C   #??[ 6Q   $??46??6v   $	??Top=?6?   $??10,148,10,0q?6?   ?? 5?   "   $??$4.49??6(   #??[ 68   #??[ 6a   $??26(?6?   $??10,186,116,16q?6?   ?? 5?   "    5?   &     5?   *   $ 
WhiteSmoke??6;   $ 1Q?6N   ._?5?   &   ?? -   5        $??/Images/basket.png??5?   -   #??[  6I   $
 Hand??6j   $??44??6?   $ 4??6?   $??40??6?   $ 5??6?   $
??Left=?6?   $??139,189,0,0q?6?   5?   #   5?      5?      ?? 5?      $??1??6!   $??3??6.   $ 5 5 5 5??6>   
???????$??1q?6n   $??10,10,10,10q?6?   ._?5?      ? .+?5?   "   ?? $??20,10,20,96q?6-   ??5?   &   ?? 5?   *   $
 /Images/Menu/Mcplant.jpg??65   $ UniformToFill=?6\   5?   #   ?? 5?   "   $??McPlant??6(   $??12(?6:   #??[ 6H   $??46??6m   $	??Top=?6y   $??10,148,10,0q?6?   ?? 5?   "   $??$3.39??6(   #??[ 68   #??[ 6a   $??26(?6?   $??10,186,116,16q?6?   ?? 5?   "    5?   &     5?   *   $ 
WhiteSmoke??6;   $ 1Q?6N   ._?5?   &   ?? -   5        $??/Images/basket.png??5?   -   #??[  6I   $
 Hand??6j   $??44??6?   $ 4??6?   $??40??6?   $ 5??6?   $
??Left=?6?   $??139,189,0,0q?6?   5?   #   5?      5?      5?      5?      5?      5?      5?      5?      