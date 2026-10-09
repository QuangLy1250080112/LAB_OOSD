using System;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Windows.Forms;

namespace QLCtyDuLich
{
    public static class Database
    {
        // Chuỗi kết nối tới SQL Server (Thêm TrustServerCertificate=True để tránh lỗi SSL của Microsoft.Data.SqlClient)
        private static string connectionString = @"Data Source=.;Initial Catalog=QLCtyDuLich;Integrated Security=True;TrustServerCertificate=True";

        // Lấy SqlConnection
        public static SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }

        // 1. Thực thi câu lệnh SELECT trả về DataTable (Fill DataGridView, ComboBox...)
        public static DataTable ExecuteQuery(string query, SqlParameter[] parameters = null)
        {
            DataTable dataTable = new DataTable();
            try
            {
                using (SqlConnection conn = GetConnection())
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        if (parameters != null)
                        {
                            cmd.Parameters.AddRange(parameters);
                        }
                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            adapter.Fill(dataTable);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi truy vấn CSDL: " + ex.Message, "Lỗi Database", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return dataTable;
        }

        // 2. Thực thi câu lệnh INSERT, UPDATE, DELETE (Trả về số dòng bị ảnh hưởng)
        public static int ExecuteNonQuery(string query, SqlParameter[] parameters = null)
        {
            int rowsAffected = 0;
            try
            {
                using (SqlConnection conn = GetConnection())
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        if (parameters != null)
                        {
                            cmd.Parameters.AddRange(parameters);
                        }
                        rowsAffected = cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi thực thi CSDL: " + ex.Message, "Lỗi Database", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return rowsAffected;
        }

        // 3. Thực thi câu lệnh trả về 1 giá trị đơn lẻ (COUNT, MAX, SUM...)
        public static object ExecuteScalar(string query, SqlParameter[] parameters = null)
        {
            object result = null;
            try
            {
                using (SqlConnection conn = GetConnection())
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        if (parameters != null)
                        {
                            cmd.Parameters.AddRange(parameters);
                        }
                        result = cmd.ExecuteScalar();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi lấy dữ liệu CSDL: " + ex.Message, "Lỗi Database", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return result;
        }
    }
}