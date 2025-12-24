using MySqlConnector;
using System;
using System.Data;
using System.Windows.Forms;

namespace toko_sepatu.Controller
{
    internal class DetailController : Model.Connection
    {
        // ============================================================
        // 1. FUNGSI UTAMA: AMBIL SEMUA DETAIL (LAPORAN SALES)
        // ============================================================
        public DataTable AmbilSemuaDetailRinci()
        {
            DataTable dt = new DataTable();
            try
            {
                // Query lengkap untuk menggabungkan Penjualan, Detail, Produk, dan Customer
                string query = "SELECT " +
                               "p.id_penjualan AS 'Invoice', " +
                               "p.tanggal AS 'Date', " +
                               "c.nama_customer AS 'Customer', " +
                               "pr.nama_product AS 'Product', " +
                               "pr.ukuran AS 'Size', " +
                               "dp.jumlah AS 'Qty', " +
                               "pr.harga AS 'Price', " +
                               "dp.subtotal AS 'Subtotal' " +
                               "FROM detail_penjualan dp " +
                               "JOIN penjualan p ON dp.id_penjualan = p.id_penjualan " +
                               "JOIN product pr ON dp.id_product = pr.id_product " +
                               "JOIN customer c ON p.id_customer = c.id_customer " +
                               "ORDER BY p.tanggal DESC";

                using (MySqlConnection conn = GetConn())
                {
                    MySqlDataAdapter da = new MySqlDataAdapter(query, conn);
                    da.Fill(dt);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading detailed sales: " + ex.Message);
            }
            return dt;
        }

        // ============================================================
        // 2. FUNGSI SEARCH: CARI DATA (Invoice / Customer / Product)
        // ============================================================
        public DataTable CariDetailLengkap(string k)
        {
            DataTable dt = new DataTable();
            try
            {
                string query = "SELECT " +
                               "p.id_penjualan AS 'Invoice', " +
                               "p.tanggal AS 'Date', " +
                               "c.nama_customer AS 'Customer', " +
                               "pr.nama_product AS 'Product', " +
                               "dp.jumlah AS 'Qty', " +
                               "dp.subtotal AS 'Subtotal' " +
                               "FROM detail_penjualan dp " +
                               "JOIN penjualan p ON dp.id_penjualan = p.id_penjualan " +
                               "JOIN product pr ON dp.id_product = pr.id_product " +
                               "JOIN customer c ON p.id_customer = c.id_customer " +
                               "WHERE p.id_penjualan LIKE @k " +
                               "OR c.nama_customer LIKE @k " +
                               "OR pr.nama_product LIKE @k " +
                               "ORDER BY p.tanggal DESC";

                using (MySqlConnection conn = GetConn())
                {
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@k", "%" + k + "%");
                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                    da.Fill(dt);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Search Error: " + ex.Message);
            }
            return dt;
        }

        // ============================================================
        // 3. FUNGSI FILTER: BERDASARKAN TANGGAL
        // ============================================================
        public DataTable FilterDetailByDate(DateTime t)
        {
            DataTable dt = new DataTable();
            try
            {
                string query = "SELECT " +
                               "p.id_penjualan AS 'Invoice', " +
                               "p.tanggal AS 'Date', " +
                               "c.nama_customer AS 'Customer', " +
                               "pr.nama_product AS 'Product', " +
                               "dp.subtotal AS 'Subtotal' " +
                               "FROM detail_penjualan dp " +
                               "JOIN penjualan p ON dp.id_penjualan = p.id_penjualan " +
                               "JOIN product pr ON dp.id_product = pr.id_product " +
                               "JOIN customer c ON p.id_customer = c.id_customer " +
                               "WHERE DATE(p.tanggal) = @t";

                using (MySqlConnection conn = GetConn())
                {
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@t", t.ToString("yyyy-MM-dd"));
                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                    da.Fill(dt);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Filter Error: " + ex.Message);
            }
            return dt;
        }
    }
}