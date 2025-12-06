using MySqlConnector;
using System;
using System.Data;
using System.Windows.Forms;

namespace toko_sepatu.Controller
{
    internal class AdminController : Model.Connection
    {
        public bool CekLogin(string username, string password)
        {
            try
            {
                string query = "SELECT * FROM admin WHERE username=@user AND password=@pass";

                cmd = new MySqlCommand(query, GetConn());
                cmd.Parameters.Add("@user", MySqlDbType.VarChar).Value = username;
                cmd.Parameters.Add("@pass", MySqlDbType.VarChar).Value = password;

                da = new MySqlDataAdapter(cmd);
                DataTable table = new DataTable();
                da.Fill(table);

                if (table.Rows.Count > 0)
                {
                    return true;
                }
                else
                {
                    MessageBox.Show("Username atau Password salah!");
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Login Error: " + ex.Message);
                return false;
            }
        }
    }
}