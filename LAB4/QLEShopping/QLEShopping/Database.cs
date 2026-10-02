using System;
using System.Data;
using Microsoft.Data.SqlClient; // Nếu dự án dùng .NET Framework cũ, bạn chuyển sang System.Data.SqlClient

namespace QLEShopping
{
    public static class Database
    {
        // Chuỗi kết nối đến SQL Server kết nối tới QLEShopping
        private static string connectionString = @"Data Source=localhost;Initial Catalog=QLEShopping;Integrated Security=True;TrustServerCertificate=True;";

        public static DataTable ExecuteQuery(string query, SqlParameter[]? parameters = null)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    if (parameters != null) cmd.Parameters.AddRange(parameters);
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        return dt;
                    }
                }
            }
        }

        public static int ExecuteNonQuery(string query, SqlParameter[]? parameters = null)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    if (parameters != null) cmd.Parameters.AddRange(parameters);
                    return cmd.ExecuteNonQuery();
                }
            }
        }
    }
}