using FastFoodManagmentSystem.Fonts;
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
    /// Interaction logic for Cart.xaml
    /// </summary>
    public partial class Cart : Window
    {
        public static decimal v;
        public static Cart cartInst;
        public Cart()
        {
            cartInst = this;
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

        private void Image_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Close();
        }

        private void Image_MouseEnter(object sender, MouseEventArgs e)
        {

        }

        private void Image_MouseLeftButtonDown_1(object sender, MouseButtonEventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Hide();
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            fetchData();

        }

       public void fetchData()
        {
            if(DatabaseConnection.connection.State != System.Data.ConnectionState.Open)
            {
                DatabaseConnection.connection.Open();
            }
            cart_stck.Children.Clear();
            SqlCommand cmd = new SqlCommand("select * from Cart_tbl", DatabaseConnection.connection);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                cart_stck.Children.Add(new CartUserControl
                {
                    _Name = reader["Prod_name"].ToString(),
                    Image = reader["Thumbnail"].ToString(),
                    Price = reader["Price"].ToString(),
                });
            }
            DatabaseConnection.connection.Close();
           
        }

        
        private void chckbtn_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {

        }

        

    }
}
