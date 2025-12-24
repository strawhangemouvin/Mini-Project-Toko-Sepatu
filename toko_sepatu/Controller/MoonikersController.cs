using MySqlConnector;
using System;
using System.Data;
using System.Windows.Forms;

namespace toko_sepatu.Controller
{
    internal class MoonikersController : Model.Connection
    {
        // ============================================================
        // PRIVATE HELPER: BACKUP LOG SYSTEM (Audit Trail)
        // ============================================================
        private void InsertLog(string action, string table, string id, string detail, MySqlConnection c, MySqlTransaction tr)
        {
            try
            {
                string q = "INSERT INTO backup_logs (action_type, table_name, data_id, old_data) " +
                           "VALUES (@a, @t, @id, @d)";

                MySqlCommand cmd = new MySqlCommand(q, c, tr);
                cmd.Parameters.AddWithValue("@a", action);
                cmd.Parameters.AddWithValue("@t", table);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@d", detail);

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Log Error: " + ex.Message);
            }
        }

        // ==========================================
        // 1. AUTHENTICATION & ACCOUNTS
        // ==========================================
        public bool CekLogin(string user, string pass)
        {
            try
            {
                using (MySqlConnection c = GetConn())
                {
                    if (c.State == ConnectionState.Closed) c.Open();
                    string q = "SELECT COUNT(*) FROM admin WHERE username=@u AND password=@p";
                    MySqlCommand cmd = new MySqlCommand(q, c);
                    cmd.Parameters.AddWithValue("@u", user);
                    cmd.Parameters.AddWithValue("@p", pass);
                    return Convert.ToInt32(cmd.ExecuteScalar()) > 0;
                }
            }
            catch (Exception ex) { MessageBox.Show("Login Error: " + ex.Message); return false; }
        }

        public string GetRole(string user)
        {
            try
            {
                using (MySqlConnection c = GetConn())
                {
                    if (c.State == ConnectionState.Closed) c.Open();
                    MySqlCommand cmd = new MySqlCommand("SELECT role FROM admin WHERE username=@u", c);
                    cmd.Parameters.AddWithValue("@u", user);
                    object result = cmd.ExecuteScalar();
                    return result != null ? result.ToString().Trim().ToLower() : "";
                }
            }
            catch { return ""; }
        }

        public bool AddAccount(string id, string user, string pass, string role, string nama)
        {
            try
            {
                using (MySqlConnection c = GetConn())
                {
                    if (c.State == ConnectionState.Closed) c.Open();
                    string q = "INSERT INTO admin (id_admin, username, password, role, nama_lengkap) VALUES (@id, @u, @p, @r, @n)";
                    MySqlCommand cmd = new MySqlCommand(q, c);
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@u", user);
                    cmd.Parameters.AddWithValue("@p", pass);
                    cmd.Parameters.AddWithValue("@r", role);
                    cmd.Parameters.AddWithValue("@n", nama);
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
            catch (Exception ex) { MessageBox.Show("Add Account Error: " + ex.Message); return false; }
        }

        // ==========================================
        // 2. PRODUCT MANAGEMENT
        // ==========================================
        public DataTable TampilkanSepatu()
        {
            DataTable dt = new DataTable();
            try { new MySqlDataAdapter("SELECT p.id_product, p.nama_product, c.nama_category, p.ukuran, p.harga, p.stock, p.gambar FROM product p JOIN category c ON p.id_category = c.id_category", GetConn()).Fill(dt); } catch { }
            return dt;
        }

        public DataTable SearchProduct(string k)
        {
            DataTable dt = new DataTable();
            try
            {
                MySqlCommand cmd = new MySqlCommand("SELECT p.id_product, p.nama_product, c.nama_category, p.ukuran, p.harga, p.stock, p.gambar FROM product p JOIN category c ON p.id_category = c.id_category WHERE p.nama_product LIKE @k", GetConn());
                cmd.Parameters.AddWithValue("@k", "%" + k + "%");
                new MySqlDataAdapter(cmd).Fill(dt);
            }
            catch { }
            return dt;
        }

        public bool AddProduct(string n, string idK, int u, decimal h, int s, byte[] i)
        {
            try
            {
                using (MySqlConnection c = GetConn())
                {
                    if (c.State == ConnectionState.Closed) c.Open();
                    string id = "PRD" + (TampilkanSepatu().Rows.Count + 1).ToString("000");
                    string q = "INSERT INTO product (id_product, nama_product, harga, stock, ukuran, gambar, id_category) VALUES (@id, @n, @h, @s, @u, @i, @idK)";
                    MySqlCommand cmd = new MySqlCommand(q, c);
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@n", n); cmd.Parameters.AddWithValue("@h", h);
                    cmd.Parameters.AddWithValue("@s", s); cmd.Parameters.AddWithValue("@u", u);
                    cmd.Parameters.AddWithValue("@i", (object)i ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@idK", idK);
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
            catch { return false; }
        }

        public bool UpdateProduct(string id, string n, string idK, int u, decimal h, int s, byte[] i)
        {
            using (MySqlConnection c = GetConn())
            {
                if (c.State == ConnectionState.Closed) c.Open();
                using (MySqlTransaction tr = c.BeginTransaction())
                {
                    try
                    {
                        InsertLog("UPDATE", "product", id, "Old: " + n, c, tr);
                        string q = "UPDATE product SET nama_product=@n, harga=@h, stock=@s, ukuran=@u, gambar=@i, id_category=@idK WHERE id_product=@id";
                        MySqlCommand cmd = new MySqlCommand(q, c, tr);
                        cmd.Parameters.AddWithValue("@id", id); cmd.Parameters.AddWithValue("@n", n);
                        cmd.Parameters.AddWithValue("@h", h); cmd.Parameters.AddWithValue("@s", s);
                        cmd.Parameters.AddWithValue("@u", u); cmd.Parameters.AddWithValue("@i", (object)i ?? DBNull.Value);
                        cmd.Parameters.AddWithValue("@idK", idK);
                        cmd.ExecuteNonQuery(); tr.Commit(); return true;
                    }
                    catch { tr.Rollback(); return false; }
                }
            }
        }

        public bool DeleteSepatu(string id)
        {
            using (MySqlConnection c = GetConn())
            {
                if (c.State == ConnectionState.Closed) c.Open();
                using (MySqlTransaction tr = c.BeginTransaction())
                {
                    try
                    {
                        InsertLog("DELETE", "product", id, "Removed", c, tr);
                        MySqlCommand cmd = new MySqlCommand("DELETE FROM product WHERE id_product=@id", c, tr);
                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.ExecuteNonQuery(); tr.Commit(); return true;
                    }
                    catch { tr.Rollback(); return false; }
                }
            }
        }

        // ==========================================
        // 3. MERK / CATEGORY (REVISI LENGKAP)
        // ==========================================
        public DataTable GetMerk()
        {
            DataTable dt = new DataTable();
            try { new MySqlDataAdapter("SELECT * FROM category", GetConn()).Fill(dt); } catch { }
            return dt;
        }

        // AGAR ERROR SearchMerk HILANG
        public DataTable SearchMerk(string k)
        {
            DataTable dt = new DataTable();
            try
            {
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM category WHERE nama_category LIKE @k", GetConn());
                cmd.Parameters.AddWithValue("@k", "%" + k + "%");
                new MySqlDataAdapter(cmd).Fill(dt);
            }
            catch { }
            return dt;
        }

        public bool AddMerk(string id, string n)
        {
            try
            {
                using (MySqlConnection c = GetConn())
                {
                    if (c.State == ConnectionState.Closed) c.Open();
                    MySqlCommand cmd = new MySqlCommand("INSERT INTO category VALUES (@id, @n)", c);
                    cmd.Parameters.AddWithValue("@id", id); cmd.Parameters.AddWithValue("@n", n);
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
            catch { return false; }
        }

        public bool UpdateMerk(string id, string n)
        {
            using (MySqlConnection c = GetConn())
            {
                if (c.State == ConnectionState.Closed) c.Open();
                using (MySqlTransaction tr = c.BeginTransaction())
                {
                    try
                    {
                        InsertLog("UPDATE", "category", id, "Old: " + n, c, tr);
                        MySqlCommand cmd = new MySqlCommand("UPDATE category SET nama_category=@n WHERE id_category=@id", c, tr);
                        cmd.Parameters.AddWithValue("@id", id); cmd.Parameters.AddWithValue("@n", n);
                        cmd.ExecuteNonQuery(); tr.Commit(); return true;
                    }
                    catch { tr.Rollback(); return false; }
                }
            }
        }

        // AGAR ERROR DeleteMerk HILANG
        public bool DeleteMerk(string id)
        {
            using (MySqlConnection c = GetConn())
            {
                if (c.State == ConnectionState.Closed) c.Open();
                using (MySqlTransaction tr = c.BeginTransaction())
                {
                    try
                    {
                        InsertLog("DELETE", "category", id, "Removed", c, tr);
                        MySqlCommand cmd = new MySqlCommand("DELETE FROM category WHERE id_category=@id", c, tr);
                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.ExecuteNonQuery(); tr.Commit(); return true;
                    }
                    catch { tr.Rollback(); return false; }
                }
            }
        }

        // ==========================================
        // 4. CUSTOMER MANAGEMENT
        // ==========================================
        public DataTable TampilkanCustomer()
        {
            DataTable dt = new DataTable();
            try { new MySqlDataAdapter("SELECT * FROM customer", GetConn()).Fill(dt); } catch { }
            return dt;
        }

        public DataTable SearchCustomer(string k)
        {
            DataTable dt = new DataTable();
            try
            {
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM customer WHERE nama_customer LIKE @k OR email LIKE @k", GetConn());
                cmd.Parameters.AddWithValue("@k", "%" + k + "%"); new MySqlDataAdapter(cmd).Fill(dt);
            }
            catch { }
            return dt;
        }

        public bool AddCustomer(string id, string n, string e, string a)
        {
            try
            {
                using (MySqlConnection c = GetConn())
                {
                    if (c.State == ConnectionState.Closed) c.Open();
                    MySqlCommand cmd = new MySqlCommand("INSERT INTO customer VALUES (@id, @n, @e, @a)", c);
                    cmd.Parameters.AddWithValue("@id", id); cmd.Parameters.AddWithValue("@n", n);
                    cmd.Parameters.AddWithValue("@e", e); cmd.Parameters.AddWithValue("@a", a);
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
            catch { return false; }
        }

        public bool UpdateCustomer(string id, string n, string e, string a)
        {
            using (MySqlConnection c = GetConn())
            {
                if (c.State == ConnectionState.Closed) c.Open();
                using (MySqlTransaction tr = c.BeginTransaction())
                {
                    try
                    {
                        InsertLog("UPDATE", "customer", id, "Old Name: " + n, c, tr);
                        MySqlCommand cmd = new MySqlCommand("UPDATE customer SET nama_customer=@n, email=@e, alamat=@a WHERE id_customer=@id", c, tr);
                        cmd.Parameters.AddWithValue("@id", id); cmd.Parameters.AddWithValue("@n", n);
                        cmd.Parameters.AddWithValue("@e", e); cmd.Parameters.AddWithValue("@a", a);
                        cmd.ExecuteNonQuery(); tr.Commit(); return true;
                    }
                    catch { tr.Rollback(); return false; }
                }
            }
        }

        public bool DeleteCustomer(string id)
        {
            using (MySqlConnection c = GetConn())
            {
                if (c.State == ConnectionState.Closed) c.Open();
                using (MySqlTransaction tr = c.BeginTransaction())
                {
                    try
                    {
                        InsertLog("DELETE", "customer", id, "Removed", c, tr);
                        MySqlCommand cmd = new MySqlCommand("DELETE FROM customer WHERE id_customer=@id", c, tr);
                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.ExecuteNonQuery(); tr.Commit(); return true;
                    }
                    catch { tr.Rollback(); return false; }
                }
            }
        }

        // ==========================================
        // 5. SALES & PENJUALAN
        // ==========================================
        public bool AddPenjualan(string idJ, string idA, string idC, DateTime t, string idP, int q, decimal tot)
        {
            using (MySqlConnection c = GetConn())
            {
                if (c.State == ConnectionState.Closed) c.Open();
                using (MySqlTransaction tr = c.BeginTransaction())
                {
                    try
                    {
                        // 1. Simpan ke tabel PENJUALAN (Header)
                        // Urutan: id_penjualan, tanggal, total_bayar, id_admin, id_customer
                        string qH = "INSERT INTO penjualan (id_penjualan, tanggal, total_bayar, id_admin, id_customer) " +
                                    "VALUES (@idJ, @t, @tot, @idA, @idC)";
                        MySqlCommand cmdH = new MySqlCommand(qH, c, tr);
                        cmdH.Parameters.AddWithValue("@idJ", idJ);
                        cmdH.Parameters.AddWithValue("@t", t.ToString("yyyy-MM-dd HH:mm:ss"));
                        cmdH.Parameters.AddWithValue("@tot", tot);
                        cmdH.Parameters.AddWithValue("@idA", idA);
                        cmdH.Parameters.AddWithValue("@idC", idC);
                        cmdH.ExecuteNonQuery();

                        // 2. Simpan ke tabel DETAIL_PENJUALAN (Rincian)
                        // Urutan: id_penjualan, id_product, jumlah, subtotal
                        string qD = "INSERT INTO detail_penjualan (id_penjualan, id_product, jumlah, subtotal) " +
                                    "VALUES (@idJ, @idP, @q, @sub)";
                        MySqlCommand cmdD = new MySqlCommand(qD, c, tr);
                        cmdD.Parameters.AddWithValue("@idJ", idJ);
                        cmdD.Parameters.AddWithValue("@idP", idP);
                        cmdD.Parameters.AddWithValue("@q", q);
                        cmdD.Parameters.AddWithValue("@sub", tot);
                        cmdD.ExecuteNonQuery();

                        tr.Commit();
                        return true;
                    }
                    catch (Exception ex)
                    {
                        tr.Rollback();
                        // Tampilkan error aslinya agar tahu kolom mana yang bermasalah
                        MessageBox.Show("Detail Error SQL: " + ex.Message);
                        return false;
                    }
                }
            }
        }

        public DataTable TampilkanPenjualan() { DataTable dt = new DataTable(); try { new MySqlDataAdapter("SELECT p.id_penjualan, p.tanggal, c.nama_customer, a.nama_lengkap AS admin, p.total_bayar FROM penjualan p JOIN customer c ON p.id_customer = c.id_customer JOIN admin a ON p.id_admin = a.id_admin ORDER BY p.tanggal DESC", GetConn()).Fill(dt); } catch { } return dt; }

        public DataTable SearchPenjualan(string k)
        {
            DataTable dt = new DataTable(); try
            {
                MySqlCommand cmd = new MySqlCommand("SELECT p.id_penjualan, p.tanggal, c.nama_customer, a.nama_lengkap AS admin, p.total_bayar FROM penjualan p JOIN customer c ON p.id_customer = c.id_customer JOIN admin a ON p.id_admin = a.id_admin WHERE p.id_penjualan LIKE @k OR c.nama_customer LIKE @k ORDER BY p.tanggal DESC", GetConn());
                cmd.Parameters.AddWithValue("@k", "%" + k + "%"); new MySqlDataAdapter(cmd).Fill(dt);
            }
            catch { }
            return dt;
        }

        public DataTable FilterPenjualanByDate(DateTime t)
        {
            DataTable dt = new DataTable(); try
            {
                MySqlCommand cmd = new MySqlCommand("SELECT p.id_penjualan, p.tanggal, c.nama_customer, a.nama_lengkap AS admin, p.total_bayar FROM penjualan p JOIN customer c ON p.id_customer = c.id_customer JOIN admin a ON p.id_admin = a.id_admin WHERE DATE(p.tanggal) = @t", GetConn());
                cmd.Parameters.AddWithValue("@t", t.ToString("yyyy-MM-dd")); new MySqlDataAdapter(cmd).Fill(dt);
            }
            catch { }
            return dt;
        }

        public bool DeletePenjualan(string id)
        {
            try
            {
                using (MySqlConnection c = GetConn())
                {
                    if (c.State == ConnectionState.Closed) c.Open();
                    MySqlCommand cmd = new MySqlCommand("DELETE FROM penjualan WHERE id_penjualan=@id", c);
                    cmd.Parameters.AddWithValue("@id", id); return cmd.ExecuteNonQuery() > 0;
                }
            }
            catch { return false; }
        }

        // ==========================================
        // 6. HELPERS & REPORT
        // ==========================================
        public DataTable GetListAdmin() { DataTable dt = new DataTable(); try { new MySqlDataAdapter("SELECT id_admin, nama_lengkap FROM admin", GetConn()).Fill(dt); } catch { } return dt; }
        public DataTable GetListCustomer() { DataTable dt = new DataTable(); try { new MySqlDataAdapter("SELECT id_customer, nama_customer FROM customer", GetConn()).Fill(dt); } catch { } return dt; }
        public DataTable GetListProductForCombo() { DataTable dt = new DataTable(); try { new MySqlDataAdapter("SELECT id_product, CONCAT(nama_product, ' (Size ', ukuran, ')') AS info_produk FROM product", GetConn()).Fill(dt); } catch { } return dt; }
        public DataTable GetProductDetail(string id) { DataTable dt = new DataTable(); try { MySqlCommand cmd = new MySqlCommand("SELECT nama_product, harga, stock, gambar FROM product WHERE id_product=@id", GetConn()); cmd.Parameters.AddWithValue("@id", id); new MySqlDataAdapter(cmd).Fill(dt); } catch { } return dt; }
    }
}