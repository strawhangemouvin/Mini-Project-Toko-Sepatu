using System;
using System.Data;
using MySqlConnector;
using System.Windows.Forms;
using toko_sepatu.Model; 

namespace toko_sepatu.Controller
{
    public class SepatuController : Connection
    {
        public DataTable TampilkanSepatu()
        {
            DataTable data = new DataTable();
            try
            {
                string show = "SELECT s.id_sepatu, s.nama_sepatu, m.nama_merk, s.ukuran, s.harga, s.stok, s.foto " +
                              "FROM sepatu s " +
                              "JOIN merk m ON s.id_merk = m.id_merk " +
                              "ORDER BY s.id_sepatu ASC"; // Urutkan biar rapi

                da = new MySqlDataAdapter(show, GetConn());
                da.Fill(data);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal menampilkan data: " + ex.Message);
            }
            return data;
        }

        // TAMBAH DATA (CREATE)
        public bool AddSepatu(string namaSepatu, int idMerk, int ukuran, decimal harga, int stok, byte[] foto)
        {
            string add = "INSERT INTO sepatu (nama_sepatu, id_merk, ukuran, harga, stok, foto) " +
                         "VALUES (@nama, @idMerk, @ukuran, @harga, @stok, @foto)";
            try
            {
                cmd = new MySqlCommand(add, GetConn());
                cmd.Parameters.Add("@nama", MySqlDbType.VarChar).Value = namaSepatu;
                cmd.Parameters.Add("@idMerk", MySqlDbType.Int32).Value = idMerk;
                cmd.Parameters.Add("@ukuran", MySqlDbType.Int32).Value = ukuran;
                cmd.Parameters.Add("@harga", MySqlDbType.Decimal).Value = harga;
                cmd.Parameters.Add("@stok", MySqlDbType.Int32).Value = stok;
                cmd.Parameters.Add("@foto", MySqlDbType.LongBlob).Value = foto;

                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Tambah Sepatu gagal: " + ex.Message);
                return false;
            }
        }

        // EDIT DATA (UPDATE)
        public bool UpdateSepatu(string idSepatu, string namaSepatu, int idMerk, int ukuran, decimal harga, int stok, byte[] foto)
        {
            string update = "UPDATE sepatu SET nama_sepatu=@nama, id_merk=@idMerk, ukuran=@ukuran, " +
                            "harga=@harga, stok=@stok, foto=@foto WHERE id_sepatu=@id";
            try
            {
                cmd = new MySqlCommand(update, GetConn());
                cmd.Parameters.Add("@id", MySqlDbType.VarChar).Value = idSepatu;
                cmd.Parameters.Add("@nama", MySqlDbType.VarChar).Value = namaSepatu;
                cmd.Parameters.Add("@idMerk", MySqlDbType.Int32).Value = idMerk;
                cmd.Parameters.Add("@ukuran", MySqlDbType.Int32).Value = ukuran;
                cmd.Parameters.Add("@harga", MySqlDbType.Decimal).Value = harga;
                cmd.Parameters.Add("@stok", MySqlDbType.Int32).Value = stok;
                cmd.Parameters.Add("@foto", MySqlDbType.LongBlob).Value = foto;

                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Update Sepatu gagal: " + ex.Message);
                return false;
            }
        }

        // HAPUS DATA (DELETE)
        public bool DeleteSepatu(string idSepatu)
        {
            string delete = "DELETE FROM sepatu WHERE id_sepatu=@id";
            try
            {
                cmd = new MySqlCommand(delete, GetConn());
                cmd.Parameters.Add("@id", MySqlDbType.VarChar).Value = idSepatu;

                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hapus Sepatu gagal: " + ex.Message);
                return false;
            }
        }

        public DataTable Search(string search)
        {
            DataTable data = new DataTable();

            // Perhatikan query ini: Menggabungkan ID, Nama Sepatu, Merk, Ukuran, Harga, Stok jadi satu kalimat panjang
            string query = "SELECT s.id_sepatu, s.nama_sepatu, m.nama_merk, s.ukuran, s.harga, s.stok, s.foto " +
                           "FROM sepatu s " +
                           "JOIN merk m ON s.id_merk = m.id_merk " +
                           "WHERE CONCAT(s.id_sepatu, ' ', s.nama_sepatu, ' ', m.nama_merk, ' ', s.ukuran, ' ', s.harga, ' ', s.stok) LIKE @search";

            try
            {
                cmd = new MySqlCommand(query, GetConn());
                cmd.Parameters.AddWithValue("@search", "%" + search + "%");

                da = new MySqlDataAdapter(cmd);
                da.Fill(data);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan search: " + ex.Message);
            }
            return data;
        }

        // AMBIL DATA MERK (KHUSUS UNTUK COMBOBOX)
        public DataTable GetMerk()
        {
            DataTable data = new DataTable();
            try
            {
                string query = "SELECT id_merk, nama_merk FROM merk";
                da = new MySqlDataAdapter(query, GetConn());
                da.Fill(data);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal ambil Merk: " + ex.Message);
            }
            return data;
        }
    }
}