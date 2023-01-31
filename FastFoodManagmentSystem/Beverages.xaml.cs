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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace FastFoodManagmentSystem
{
    /// <summary>
    /// Interaction logic for Beverages.xaml
    /// </summary>
    public partial class Beverages : Window
    {
        public Beverages()
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
            Home home= new Home();  
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
            Cart cart =new Cart();  
            cart.Show();
            Close();
        }

        private void Image_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Bev1.Source = new BitmapImage(new Uri(@"Images\Cart-Green.png", UriKind.Relative));
            DatabaseConnection.connection.Open();
            DatabaseConnection.command = new SqlCommand("INSERT INTO Cart_tbl(Prod_id,Cat_id,Price,Prod_name,Thumbnail) SELECT Prod_id, Cat_id,Price,Prod_name,Thumbnail FROM Products_tbl WHERE Prod_id = 15", DatabaseConnection.connection);
            DatabaseConnection.command.ExecuteNonQuery();
            DatabaseConnection.connection.Close();
        }

        private void Image_MouseLeftButtonDown_1(object sender, MouseButtonEventArgs e)
        {
            Bev2.Source = new BitmapImage(new Uri(@"Images\Cart-Green.png", UriKind.Relative));
            DatabaseConnection.connection.Open();
            DatabaseConnection.command = new SqlCommand("INSERT INTO Cart_tbl(Prod_id,Cat_id,Price,Prod_name,Thumbnail) SELECT Prod_id, Cat_id,Price,Prod_name,Thumbnail FROM Products_tbl WHERE Prod_id = 16", DatabaseConnection.connection);
            DatabaseConnection.command.ExecuteNonQuery();
            DatabaseConnection.connection.Close();
        }

        private void Image_MouseLeftButtonDown_2(object sender, MouseButtonEventArgs e)
        {
            Bev3.Source = new BitmapImage(new Uri(@"Images\Cart-Green.png", UriKind.Relative));
            DatabaseConnection.connection.Open();
            DatabaseConnection.command = new SqlCommand("INSERT INTO Cart_tbl(Prod_id,Cat_id,Price,Prod_name,Thumbnail) SELECT Prod_id, Cat_id,Price,Prod_name,Thumbnail FROM Products_tbl WHERE Prod_id = 17", DatabaseConnection.connection);
            DatabaseConnection.command.ExecuteNonQuery();
            DatabaseConnection.connection.Close();
        }

        private void Image_MouseLeftButtonDown_3(object sender, MouseButtonEventArgs e)
        {
            Bev4.Source = new BitmapImage(new Uri(@"Images\Cart-Green.png", UriKind.Relative));
            DatabaseConnection.connection.Open();
            DatabaseConnection.command = new SqlCommand("INSERT INTO Cart_tbl(Prod_id,Cat_id,Price,Prod_name,Thumbnail) SELECT Prod_id, Cat_id,Price,Prod_name,Thumbnail FROM Products_tbl WHERE Prod_id = 18", DatabaseConnection.connection);
            DatabaseConnection.command.ExecuteNonQuery();
            DatabaseConnection.connection.Close();
        }

        private void Image_MouseLeftButtonDown_4(object sender, MouseButtonEventArgs e)
        {
            Bev5.Source = new BitmapImage(new Uri(@"Images\Cart-Green.png", UriKind.Relative));
            DatabaseConnection.connection.Open();
            DatabaseConnection.command = new SqlCommand("INSERT INTO Cart_tbl(Prod_id,Cat_id,Price,Prod_name,Thumbnail) SELECT Prod_id, Cat_id,Price,Prod_name,Thumbnail FROM Products_tbl WHERE Prod_id = 19", DatabaseConnection.connection);
            DatabaseConnection.command.ExecuteNonQuery();
            DatabaseConnection.connection.Close();
        }

        private void Image_MouseLeftButtonDown_5(object sender, MouseButtonEventArgs e)
        {
            Bev6.Source = new BitmapImage(new Uri(@"Images\Cart-Green.png", UriKind.Relative));
            DatabaseConnection.connection.Open();
            DatabaseConnection.command = new SqlCommand("INSERT INTO Cart_tbl(Prod_id,Cat_id,Price,Prod_name,Thumbnail) SELECT Prod_id, Cat_id,Price,Prod_name,Thumbnail FROM Products_tbl WHERE Prod_id = 20", DatabaseConnection.connection);
            DatabaseConnection.command.ExecuteNonQuery();
            DatabaseConnection.connection.Close();
        }

        private void Image_MouseLeftButtonDown_6(object sender, MouseButtonEventArgs e)
        {
            Bev7.Source = new BitmapImage(new Uri(@"Images\Cart-Green.png", UriKind.Relative));
            DatabaseConnection.connection.Open();
            DatabaseConnection.command = new SqlCommand("INSERT INTO Cart_tbl(Prod_id,Cat_id,Price,Prod_name,Thumbnail) SELECT Prod_id, Cat_id,Price,Prod_name,Thumbnail FROM Products_tbl WHERE Prod_id = 21", DatabaseConnection.connection);
            DatabaseConnection.command.ExecuteNonQuery();
            DatabaseConnection.connection.Close();
        }

        private void Image_MouseLeftButtonDown_7(object sender, MouseButtonEventArgs e)
        {
            Bev8.Source = new BitmapImage(new Uri(@"Images\Cart-Green.png", UriKind.Relative));
            DatabaseConnection.connection.Open();
            DatabaseConnection.command = new SqlCommand("INSERT INTO Cart_tbl(Prod_id,Cat_id,Price,Prod_name,Thumbnail) SELECT Prod_id, Cat_id,Price,Prod_name,Thumbnail FROM Products_tbl WHERE Prod_id = 22", DatabaseConnection.connection);
            DatabaseConnection.command.ExecuteNonQuery();
            DatabaseConnection.connection.Close();
        }

        private void burger_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Menu menu= new Menu();
            menu.Show();
            Close();
        }

        private void Sand_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Sandwiches wiches= new Sandwiches();
            wiches.Show();
            Close();
        }

        private void Treats_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Treats des = new Treats();
            des.Show();
            Close();
        }

        private void Nuggets_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            HappyMeal meal = new HappyMeal();
            meal.Show();
            Close();
        }

        private void Beverages_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.Show();
        }
    }
}
