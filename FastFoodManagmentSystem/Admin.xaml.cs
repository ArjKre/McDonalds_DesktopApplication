using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace FastFoodManagmentSystem
{
    /// <summary>
    /// Interaction logic for Admin.xaml
    /// </summary>
    public partial class Admin : Window
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void close_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void minimize_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }

        private void Grid_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }

        private void logout_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            MainWindow window= new MainWindow(); 
            window.Show();
            this.Close();   
        }

        private void ordbtn_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            AdminOrders orders= new AdminOrders();
            orders.Show();
            this.Close();
        }

        private void revbtn_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {

        }
    }
}
