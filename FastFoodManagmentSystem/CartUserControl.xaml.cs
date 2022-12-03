using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace FastFoodManagmentSystem.Fonts
{
    /// <summary>
    /// Interaction logic for CartUserControl.xaml
    /// </summary>
    public partial class CartUserControl : UserControl
    {
        private string _name;
        private string _image;
        private string _price;
        private int i = 1;
        private double price;
        public double qtnprice;
        public CartUserControl()
        {
            InitializeComponent();
        }

        
        public string _Name
        {
            get { return _name; }
            set { _name = value;
                checklb.Text = value;
            }
        }

        public string Image
        {
            get { return _image; }
            set { _image = value;
                checkimg.Source = new BitmapImage(new Uri(value, UriKind.Relative)); 
            }
        }

        
        public string Price
        {
            get { return _price; }
            set { _price = value;
                checkprc.Text = $"$ {value}";
            }

        }
        

        private void rmve_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            DatabaseConnection.connection.Open();
            SqlCommand cmd = new SqlCommand($"Delete from cart_tbl where Prod_name='{_name}' and Price = '{_price}'", DatabaseConnection.connection);
            int res = cmd.ExecuteNonQuery();
            Cart.cartInst.fetchData();
            DatabaseConnection.connection.Close();
        }
       
        
        private void inc_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
           if(i < 10)
            {
               
                i++;
                checkqty.Text = i.ToString();

                price = double.Parse(_price) * i;
                
                checkprc.Text = $"$ {price}";
                //Cart.cartInst.Refresh();
                Cart.cartInst.subTotal += price;



                

            }
            else
            {
                
            }

        }

        private void dec_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if(i > 1)
            {
                i--;
                checkqty.Text = i.ToString();
                price -= double.Parse(_price);
                Cart.cartInst.subTotal -= price;
                checkprc.Text = $"$ {price}";

            }
            else
            {
                DatabaseConnection.connection.Open();
                SqlCommand cmd = new SqlCommand($"Delete from cart_tbl where Prod_name='{_name}' and Price = '{_price}'", DatabaseConnection.connection);
                int res = cmd.ExecuteNonQuery();
                Cart.cartInst.fetchData();
                DatabaseConnection.connection.Close();
            }
        }

        private void checkprc_Loaded(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
