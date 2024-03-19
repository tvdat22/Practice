using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Practice
{
    class Connection
    {
        private static string connectionString = "Data Source=TVDat;Initial Catalog=QlyLopHoc;Integrated Security=True";
        public static SqlConnection GetSqlConnection() 
        { 
            return new SqlConnection(connectionString);
        }
    }
}
