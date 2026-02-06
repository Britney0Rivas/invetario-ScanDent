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
@"Server=192.168.0.07\SQLEXPRESS;Database=ScanDentDB;User Id=dev_dani;Password=daniperrona123;TrustServerCertificate=True;";

        public static SqlConnection GetConnection()
        {
            return new SqlConnection(ConnectionString);
        }
    }
}
