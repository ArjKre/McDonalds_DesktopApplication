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
    /// Interaction logic for Menu.xaml
    /// </summary>
    public partial class Menu : Window
    {
        public Menu()
        {
            InitializeComponent();
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
            Menu menu = new Menu();
            menu.Show();
            this.Close();
        }

        private void homebtn_Click(object sender, RoutedEventArgs e)
        {
            Home home= new Home();
            home.Show();
            this.Close();
        }

        private void Cartbtn_Click(object sender, RoutedEventArgs e)
        {
            Cart cart= new Cart();
            cart.Show();
            this.Close();
        }

        private void Image_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {

        }

        private void Image_MouseLeftButtonDown_1(object sender, MouseButtonEventArgs e)
        {

        }

        private void Image_MouseLeftButtonDown_2(object sender, MouseButtonEventArgs e)
        {

        }

        private void Image_MouseLeftButtonDown_3(object sender, MouseButtonEventArgs e)
        {

        }

        private void Image_MouseLeftButtonDown_4(object sender, MouseButtonEventArgs e)
        {

        }

        private void Image_MouseLeftButtonDown_5(object sender, MouseButtonEventArgs e)
        {

        }

        private void Image_MouseLeftButtonDown_6(object sender, MouseButtonEventArgs e)
        {

        }

        private void Image_MouseLeftButtonDown_7(object sender, MouseButtonEventArgs e)
        {

        }

        private void burger_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.Show();
        }


       

        private void Sandwiches_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Sandwiches sand = new Sandwiches();
            sand.Show();
            Close();
        }

        private void Beverages_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Beverages bev = new Beverages();
            bev.Show();
            Close();
        }

        private void happyMeal_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            HappyMeal happy = new HappyMeal();
            happy.Show();
            Close();
        }

        private void Treats_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Treats treats = new Treats();
            treats.Show();
            Close();
        }
    }
}
