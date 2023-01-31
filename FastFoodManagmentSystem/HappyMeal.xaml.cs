using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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
    /// Interaction logic for HappyMeal.xaml
    /// </summary>
    public partial class HappyMeal : Window
    {
        public HappyMeal()
        {
            InitializeComponent();
        }

        private void Grid_MouseDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }

        private void close_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void minimize_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }

        private void homebtn_Click(object sender, RoutedEventArgs e)
        {
            Home home = new Home();
            home.Show();
            Close();
        }

        private void Menubtn_Click(object sender, RoutedEventArgs e)
        {
            Menu menu= new Menu();
            menu.Show();
            Close();
        }

        private void Cartbtn_Click(object sender, RoutedEventArgs e)
        {
            Cart cart=new Cart();
            cart.Show();
            Close();
        }

        private void burger_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Menu menu=new Menu();
            menu.Show();
            Close();
        }

        private void Beverages_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Beverages label=new Beverages();
            label.Show();
            Close();
        }

       

        private void Treats_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Treats label = new Treats();
            label.Show();
            Close();
        }

        private void Sand_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Sandwiches sandwiches=new Sandwiches();
            sandwiches.Show();
            Close();
        }

        private void Image_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            h1.Source = new BitmapImage(new Uri(@"Images\Cart-Green.png", UriKind.Relative));
            DatabaseConnection.connection.Open();
            DatabaseConnection.command = new SqlCommand("INSERT INTO Cart_tbl(Prod_id,Cat_id,Price,Prod_name,Thumbnail) SELECT Prod_id, Cat_id,Price,Prod_name,Thumbnail FROM Products_tbl WHERE Prod_id = 23", DatabaseConnection.connection);
            DatabaseConnection.command.ExecuteNonQuery();
            DatabaseConnection.connection.Close();
        }

        private void Image_MouseLeftButtonDown_1(object sender, MouseButtonEventArgs e)
        {
            h2.Source = new BitmapImage(new Uri(@"Images\Cart-Green.png", UriKind.Relative));
            DatabaseConnection.connection.Open();
            DatabaseConnection.command = new SqlCommand("INSERT INTO Cart_tbl(Prod_id,Cat_id,Price,Prod_name,Thumbnail) SELECT Prod_id, Cat_id,Price,Prod_name,Thumbnail FROM Products_tbl WHERE Prod_id = 24", DatabaseConnection.connection);
            DatabaseConnection.command.ExecuteNonQuery();
            DatabaseConnection.connection.Close();
        }

        private void Image_MouseLeftButtonDown_2(object sender, MouseButtonEventArgs e)
        {
            h3.Source = new BitmapImage(new Uri(@"Images\Cart-Green.png", UriKind.Relative));
            DatabaseConnection.connection.Open();
            DatabaseConnection.command = new SqlCommand("INSERT INTO Cart_tbl(Prod_id,Cat_id,Price,Prod_name,Thumbnail) SELECT Prod_id, Cat_id,Price,Prod_name,Thumbnail FROM Products_tbl WHERE Prod_id = 25", DatabaseConnection.connection);
            DatabaseConnection.command.ExecuteNonQuery();
            DatabaseConnection.connection.Close();

        }

        private void happyMeal_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            HappyMeal happyMeal = new HappyMeal();
            happyMeal.Show();
            Close();
        }
    }
}
