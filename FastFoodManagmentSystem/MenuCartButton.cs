//using System;
//using System.Collections.Generic;
//using System.Drawing;
//using System.Drawing.Text;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Windows.Controls;
//using System.Windows.Media.Imaging;
//using System.Windows.Media.Media3D;
//using System.Windows.Threading;

//namespace FastFoodManagmentSystem
//{
//    public static class MenuCartButton
//    {
//       public static void CartGreen()
//        {
//            DispatcherTimer Timer = new DispatcherTimer();
//            Timer.Tick += new EventHandler(Timer_Tick);
//            Timer.Interval = new TimeSpan(0, 0, 2);

//            void Timer_Tick(object sender, EventArgs e)
//            {
//             Menu.MenuInst.projbtn.Source = new BitmapImage(new Uri(@"Images\Cart-Green.png", UriKind.Relative));
//             Timer.Start();
              
//            }
//        }
//    }
//}
