using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastFoodManagmentSystem
{
    internal class DatabaseConnection
    {
        public static SqlConnection connection = new SqlConnection(@"Data Source=LAPTOP-9NS1BJAQ\SQLEXPRESS;Initial Catalog=dtbs_FFMS;Integrated Security=True");
        public static SqlCommand command;

    }
}
