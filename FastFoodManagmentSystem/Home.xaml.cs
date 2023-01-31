using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using System.Web.UI;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Windows.Threading;


namespace FastFoodManagmentSystem
{
    /// <summary>
    /// Interaction logic for Home.xaml
    /// </summary>
    /// 

    public partial class Home : Window
    {
        DispatcherTimer Timer = new DispatcherTimer();
        public Home()
        {
            InitializeComponent();

        Timer.Tick += new EventHandler(Timer_Tick);
        Timer.Interval = new TimeSpan(0, 0, 2);

        }
        
        private void Grid_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }

        private void close_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void minimize_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }

        private void Menubtn_Click(object sender, RoutedEventArgs e)
        {
            Menu menu= new Menu();
            menu.Show();
            this.Close();
        }

        int i = 1;
        private void Timer_Tick(object sender, EventArgs e)
        { 
            LoadNextImage();
        }


        private void LoadPreviousImage()
        {
            Timer.Start();

            i--;
            if (i < 1)
            {
                i = 4;
            }
            Imgholder.Source = new BitmapImage(new Uri(@"Images/poster" + i + ".jpg", UriKind.Relative));
            LoadChecked();
        }

        private void LoadNextImage()
        {
            Timer.Start();

            i++;
            if (i > 4)
            {
                i = 1;
            }
            Imgholder.Source = new BitmapImage(new Uri(@"Images/Slideshow/poster" + i + ".jpg", UriKind.Relative));
            LoadChecked();
        }
        private void LoadChecked()
        {
            Timer.Start();
            if (i == 1) { rdnbtn1.IsChecked = true; }
            if (i == 2) { rdnbtn2.IsChecked = true; }
            if (i == 3) { rdnbtn3.IsChecked = true; }
            if (i == 4) { rdnbtn4.IsChecked = true; }
        }

        private void ChangedCheck()
        {
            Timer.Start();
            if (rdnbtn1.IsChecked == true) { i = 1; }
            if (rdnbtn2.IsChecked == true) { i = 2; }
            if (rdnbtn3.IsChecked == true) { i = 3; }
            if (rdnbtn4.IsChecked == true) { i = 4; }
            Imgholder.Source = new BitmapImage(new Uri(@"Images/Slideshow/poster" + i + ".jpg", UriKind.Relative));
        }
       
        private void prvbtn_Click(object sender, RoutedEventArgs e)
        {
            Timer.Stop();
            LoadPreviousImage();
        }

        private void nxtbtn_Click(object sender, RoutedEventArgs e)
        {
            Timer.Stop();
            LoadNextImage();
        }

        private void Cartbtn_Click(object sender, RoutedEventArgs e)
        {
            Cart cart = new Cart();
            cart.Show();
            this.Close();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Timer.Start();
            rdnbtn1.IsChecked = true;
        }

        private void rdnbtn_Checked(object sender, RoutedEventArgs e)
        {
            Timer.Stop();
            ChangedCheck();
        }

        private void Image_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Hide();
        }
    }
}
