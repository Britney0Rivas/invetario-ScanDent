using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace WindowsFormsApp1
{
    public static class Db
    {
        public static string ConnectionString =
"Data Source=DESKTOP-G6EGNGU\\SQLEXPRESS;Initial Catalog=ScanDentDB;Integrated Security=True;TrustServerCertificate=True";


        public static SqlConnection GetConnection()
        {
            return new SqlConnection(ConnectionString);
        }
    }
}
