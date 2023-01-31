using CSharpVitamins;
using FastFoodManagmentSystem.Fonts;
using FastFoodManagmentSystem.Popups;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Remoting;
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
        public double subTotal;
        public static Cart cartInst;
        public double tax;
        public double finalamount;
        public double dev;
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
                    _Image = reader["Thumbnail"].ToString(),
                    _Price = reader["Price"].ToString(),
                });
                subTotal += double.Parse(reader["Price"].ToString());

            }
            DatabaseConnection.connection.Close();

            subtl.Content = $"${subTotal.ToString()}";
            tax = subTotal * 0.25;
            taxtl.Content = $"${tax.ToString("0.00")}";
            finalamount = subTotal + tax + dev + 5.00;
            total.Content= $"${finalamount.ToString("0.00")}";

        }

        public static string Truncate(string source, int length)
        {
            if (source.Length > length)
            {
                source = source.Substring(0, length);
            }
            return source;
        }
        private string UuidGeneration()
        {
            //Guid guid = Guid.NewGuid();
            //ShortGuid sguid = new ShortGuid;
            //return sguid;
            var shortUid = Convert.ToBase64String(Guid.NewGuid().ToByteArray()).Trim('=').Trim('+').Trim('/');
            return shortUid;
        }

        
        private void chckbtn_Click(object sender, RoutedEventArgs e)
        {
            string billing = UuidGeneration();

            if (fnametxt.Text != string.Empty || numtxt.Text != string.Empty || emailtxt.Text != string.Empty || addtxt.Text != string.Empty || citytxt.Text != string.Empty || statetxt.Text != "" || ziptxt.Text != "")
            {
                if (optxt.Text == string.Empty)
                {
                    optxt.Text = "NULL";
                }
                
            DatabaseConnection.connection.Open();
            //Billing Info
            DatabaseConnection.command = new SqlCommand($"INSERT INTO BillingInfo_tbl(Billing_id,First_Name,Last_Name, Phone_Number, Email, Street_Address,Apt_loc,City,State,Zip_code) " +
            $"Values('{billing}','{fnametxt.Text}','{lnametxt.Text}','{numtxt.Text}','{emailtxt.Text}','{addtxt.Text}','{optxt.Text}','{citytxt.Text}','{statetxt.Text}','{ziptxt.Text}')", DatabaseConnection.connection);
            DatabaseConnection.command.ExecuteNonQuery();
            //Order Info
            //DatabaseConnection.command = new SqlCommand($"INSERT INTO Order_tbl(Billing_id,Prod_id,Prod_name,Price) SELECT '{billing}',Prod_id,Prod_name,Price FROM Cart_tbl ", DatabaseConnection.connection);
            //DatabaseConnection.command.ExecuteNonQuery();
            ////Final Bill Info
            //DatabaseConnection.command = new SqlCommand($"INSERT INTO Bill_tbl(Billing_id,SubTotal,Delivery_Fee,Tax,Total)Values('{billing}','{subtl.Content}','{Dev.Content}','{taxtl.Content}','{total.Content}')", DatabaseConnection.connection);
            //DatabaseConnection.command.ExecuteNonQuery();

            DatabaseConnection.connection.Close();
                //Thankyou popup message
            CheckoutPopup1 popup1 = new CheckoutPopup1();
            popup1.Show();

            DatabaseConnection.connection.Open();
            DatabaseConnection.command = new SqlCommand($"Truncate Table Cart_tbl", DatabaseConnection.connection);
            DatabaseConnection.command.ExecuteNonQuery();
            DatabaseConnection.connection.Close();
            fnametxt.Text= null;
            lnametxt.Text= null;
            numtxt.Text= null;
            emailtxt.Text= null;
            addtxt.Text= null;  
            citytxt.Text= null;
            statetxt.Text= null;
            ziptxt.Text= null;
            optxt.Text= null;

                
            }
            else
            {
                //Error Message
                CheckoutPopup2 popup2 = new CheckoutPopup2();
                popup2.Show();
            }


        }


    }
}
