using System;
using System.Data;
using MySqlConnector;
using System.Windows.Forms;

namespace toko_sepatu.Model 
{
    public class Connection 
    {
        public MySqlCommand cmd;
        public DataSet ds;
        public MySqlDataAdapter da;

        public MySqlConnection GetConn()
        {
            MySqlConnection conn = new MySqlConnection();
            conn.ConnectionString = "server=localhost;user=root;database=moonikers_system;;password=";

            try
            {
                conn.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal Koneksi: " + ex.Message);
            }

            return conn;
        }
    }
}