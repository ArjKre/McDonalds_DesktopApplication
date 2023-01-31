using System;
using System.Data.SqlClient;
using System.Windows;
using System.Windows.Input;


namespace FastFoodManagmentSystem
{
    /// <summary>
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : Window
    {
        
        
        SqlDataReader reader;
        public Login()
        {
            InitializeComponent();
        }

        private void close_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void Border_MouseDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }

        private void back_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            MainWindow main = new MainWindow();
            main.Show();
            Close();

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            DatabaseConnection.connection.Open();
            DatabaseConnection.command = new SqlCommand("Select ID from admin_tbl where Username='" + usertxt.Text + "'and Password='" + passtxt.Text + "'", DatabaseConnection.connection);
            DatabaseConnection.command.ExecuteNonQuery();
            reader = DatabaseConnection.command.ExecuteReader();

            if (reader.Read())
            {
                if (Convert.ToBoolean(reader["ID"])== true)
                {
                    Admin admin = new Admin();
                    admin.Show();
                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show("Username or Password incorrect!","Error",MessageBoxButton.OK,MessageBoxImage.Error);
            }

            DatabaseConnection.connection.Close();
        }
    }
}
