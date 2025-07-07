using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace manajemen_keuangan.Models
{
    public class Transaksi
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string JenisTransaksi { get; set; }
        public DateTime Tanggal { get; set; }
        public decimal Nominal { get; set; }
    }

    public class TransaksiModel
    {
        public static List<Transaksi> GetAll()
        {
            List<Transaksi> list = new List<Transaksi>();
            using (SqlConnection conn = DatabaseConnection.GetConnection())
            {
                conn.Open();
                string query = "SELECT * FROM transaksi ORDER BY tanggal DESC";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new Transaksi
                        {
                            Id = Convert.ToInt32(reader["id"]),
                            Username = reader["username"].ToString(),
                            JenisTransaksi = reader["jenis_transaksi"].ToString(),
                            Tanggal = Convert.ToDateTime(reader["tanggal"]),
                            Nominal = Convert.ToDecimal(reader["nominal"])
                        });
                    }
                }
            }
            return list;
        }

        public static bool Insert(Transaksi t)
        {
            using (SqlConnection conn = DatabaseConnection.GetConnection())
            {
                conn.Open();
                string query = "INSERT INTO transaksi (username, jenis_transaksi, tanggal, nominal) VALUES (@username, @jenis, @tanggal, @nominal)";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@username", t.Username);
                    cmd.Parameters.AddWithValue("@jenis", t.JenisTransaksi);
                    cmd.Parameters.AddWithValue("@tanggal", t.Tanggal);
                    cmd.Parameters.AddWithValue("@nominal", t.Nominal);
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        public static bool Update(Transaksi t)
        {
            using (SqlConnection conn = DatabaseConnection.GetConnection())
            {
                conn.Open();
                string query = "UPDATE transaksi SET username = @username, jenis_transaksi = @jenis, tanggal = @tanggal, nominal = @nominal WHERE id = @id";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@username", t.Username);
                    cmd.Parameters.AddWithValue("@jenis", t.JenisTransaksi);
                    cmd.Parameters.AddWithValue("@tanggal", t.Tanggal);
                    cmd.Parameters.AddWithValue("@nominal", t.Nominal);
                    cmd.Parameters.AddWithValue("@id", t.Id);
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        public static bool Delete(int id)
        {
            using (SqlConnection conn = DatabaseConnection.GetConnection())
            {
                conn.Open();
                string query = "DELETE FROM transaksi WHERE id = @id";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }
    }
}
