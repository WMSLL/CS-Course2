using System;
using Microsoft.Data.SqlClient;
namespace ConnectionString
{
    class Program
    {

        private const string ConnectionStrong=
        "Server=tcp:shadow-art.database.windows.net,1433;" +
        "Initial Catalog=reminder; " +
        "Persist Security Info=False;" +
        "User ID=v_kizlik@shadow-art;" +
        "Password=Y6t8mO03d5cksKGQPoP8;" +
        "Encrypt=True;";
        static void Main(string[] args)
        {
            using var connect = new SqlConnection(ConnectionStrong);
            
        }
    }
}
