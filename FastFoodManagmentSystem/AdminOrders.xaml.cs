using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Windows.Controls.Primitives;
using FastFoodManagmentSystem.Popups;
using System.Globalization;

namespace FastFoodManagmentSystem
{
    /// <summary>
    /// Interaction logic for AdminOrders.xaml
    /// </summary>
    public partial class AdminOrders : Window
    {
        string billingId;
        
        
        public AdminOrders()
        {
            InitializeComponent();
        }

        private void Border_MouseDown(object sender, MouseButtonEventArgs e)
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
            Admin admin = new Admin();
            admin.Show();
            this.Close();
        }

        
        private void Window_Loaded(object sender, RoutedEventArgs e)
        { 
                //Billing Table
                DatabaseConnection.connection.Open();
                SqlCommand command = new SqlCommand("SELECT * FROM Bill_tbl", DatabaseConnection.connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable data = new DataTable();
                adapter.Fill(data);
                DataGrid.ItemsSource = data.DefaultView;
                DatabaseConnection.connection.Close();

                
        }
       
        

        private void DataGridCell_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        { 
            if(e.ChangedButton == MouseButton.Left)
            {

            FetchData();
            InfoTable();
            }
        }

        public void FetchData()
        {
            DatabaseConnection.connection.Open();

            DataGridRow row = (DataGridRow)DataGrid.ItemContainerGenerator.ContainerFromIndex(DataGrid.SelectedIndex);
            System.Windows.Controls.DataGridCell RowColumn = DataGrid.Columns[0].GetCellContent(row).Parent as System.Windows.Controls.DataGridCell;
            billingId = ((TextBlock)RowColumn.Content).Text;



            string query = $"Select prod.Prod_ID,prod.Prod_name,Thumbnail FROM Order_tbl ord, Products_tbl prod WHERE prod.Prod_Id = ord.Prod_id AND ord.Billing_Id = '{billingId}'";

            //Order Table
            SqlCommand command = new SqlCommand(query, DatabaseConnection.connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable datatable = new DataTable();
            adapter.Fill(datatable);
            DataColumn col = datatable.Columns.Add("SlNo", typeof(int));
            col.SetOrdinal(0);

            for(int i = 0; i< datatable.Rows.Count; i++)
            {
                datatable.Rows[i]["SlNo"] = (i + 1);
            }
            datatable.Columns["SlNo"].ReadOnly = true;
            DataGrid2.ItemsSource = datatable.DefaultView;

            DatabaseConnection.connection.Close();
        }

        public void InfoTable()
        {
            
            Detailpopup detailpopup = new Detailpopup(billingId);
            detailpopup.Show();
        }

        

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            DataGridRow row = (DataGridRow)DataGrid.ItemContainerGenerator.ContainerFromIndex(DataGrid.SelectedIndex);
            System.Windows.Controls.DataGridCell RowColumn = DataGrid.Columns[0].GetCellContent(row).Parent as System.Windows.Controls.DataGridCell;
            string billingIdFromLeftClick = ((TextBlock)RowColumn.Content).Text;
            DatabaseConnection.connection.Open();
            DatabaseConnection.command = new SqlCommand($"Delete From BillingInfo_tbl WHERE billing_id = '{billingIdFromLeftClick}'",DatabaseConnection.connection);
            DatabaseConnection.command.ExecuteNonQuery();
            DatabaseConnection.command = new SqlCommand($"Delete From Bill_tbl WHERE billing_id = '{billingIdFromLeftClick}'", DatabaseConnection.connection);
            DatabaseConnection.command.ExecuteNonQuery();
            DatabaseConnection.command = new SqlCommand($"Delete From Order_tbl WHERE billing_id = '{billingIdFromLeftClick}'", DatabaseConnection.connection);
            DatabaseConnection.command.ExecuteNonQuery();
            DatabaseConnection.connection.Close();
            System.Windows.MessageBox.Show("Successful Deleted");
            DataGrid.UpdateLayout();
        }

        private void DataGridCell_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
                      
        }
    }
}
