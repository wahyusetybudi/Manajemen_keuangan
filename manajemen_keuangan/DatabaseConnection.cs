using System;
using System.Data.SqlClient;

namespace manajemen_keuangan // Sama dengan namespace Form1.cs
{
    public static class DatabaseConnection
    {
        private static readonly string connectionString =
            @"Data Source=DESKTOP-CG1TVA7\WAHYU;Initial Catalog=db_keuangan;TrustServerCertificate=True;Integrated Security=True;";

        public static SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
    }
}
