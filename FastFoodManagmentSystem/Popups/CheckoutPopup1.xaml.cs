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

namespace FastFoodManagmentSystem.Popups
{
    /// <summary>
    /// Interaction logic for CheckoutPopup1.xaml
    /// </summary>
    public partial class CheckoutPopup1 : Window
    {
        public CheckoutPopup1()
        {
            InitializeComponent();
        }

        

        private void close_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.Close();
        }
    }
}
