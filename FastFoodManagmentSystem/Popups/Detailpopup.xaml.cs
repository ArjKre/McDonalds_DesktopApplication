using System;
using System.Collections.Generic;
using System.Data;
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
using System.Globalization;

namespace FastFoodManagmentSystem.Popups
{
    /// <summary>
    /// Interaction logic for Detailpopup.xaml
    /// </summary>
    public partial class Detailpopup : Window
    {
        string billingid;
       

        public Detailpopup(string BillingID)
        {
            InitializeComponent();
            billingid= BillingID;
            DataContext= this;
            
        }

        private void close_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Close();
        }

        private void minimize_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }

        private void Grid_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            fetchData();
            
        }

        public void fetchData()
        {
            DatabaseConnection.connection.Open();
            SqlDataAdapter adapter = new SqlDataAdapter($"Select First_Name,Last_Name,Phone_Number,Email,Street_Address,Apt_loc,City,State,Zip_code FROM BillingInfo_tbl WHERE Billing_id = '{billingid}'", DatabaseConnection.connection);
            DataSet dataTable = new DataSet();
            adapter.Fill(dataTable,"BillingInfo_tbl");
            DatabaseConnection.connection.Close();

            infoname.Text = dataTable.Tables[0].Rows[0][0].ToString() +" "+ dataTable.Tables[0].Rows[0][1].ToString();
            infonum.Text = dataTable.Tables[0].Rows[0][2].ToString();
            infoemail.Text = dataTable.Tables[0].Rows[0][3].ToString();
            infoadd.Text = dataTable.Tables[0].Rows[0][4].ToString();
            infoaptloc.Text = dataTable.Tables[0].Rows[0][5].ToString();
            infocity.Text = dataTable.Tables[0].Rows[0][6].ToString();
            infostate.Text = dataTable.Tables[0].Rows[0][7].ToString();
            infopin.Text = dataTable.Tables[0].Rows[0][8].ToString();

          


        }

    }
}
