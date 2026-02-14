using System.Data.SqlClient;
namespace WindowsFormsApp1
{
    public static class Db
    {
        public static string ConnectionString =
            @"Data Source=.\SQLEXPRESS;Initial Catalog=ScanDentDB;Integrated Security=True;Encrypt=True;TrustServerCertificate=True;";

        public static SqlConnection GetConnection()
        {
            return new SqlConnection(ConnectionString);
        }
    }
}