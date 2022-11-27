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
    /// Interaction logic for Sandwiches.xaml
    /// </summary>
    public partial class Sandwiches : Window
    {
        public Sandwiches()
        {
            InitializeComponent();
        }
        private void homebtn_Click(object sender, RoutedEventArgs e)
        {
            Home home = new Home();
            home.Show();
            Close();
        }

        private void Menubtn_Click(object sender, RoutedEventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            Close();
        }

        private void Cartbtn_Click(object sender, RoutedEventArgs e)
        {
            Cart cart = new Cart();
            cart.Show();
            Close();
        }
        private void burger_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            Close();
        }

        private void Sand_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.Show();
        }

        private void happyMeal_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            HappyMeal meal = new HappyMeal();
            meal.Show();
            Close();
        }
        private void Beverages_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Beverages meal = new Beverages();
            meal.Show();
            Close();
        }

        private void Treats_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Treats tr = new Treats();
            tr.Show();
            Close();
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
    }
}
