using System;
using System.Windows.Forms;
using toko_sepatu.Controller;

namespace toko_sepatu.View
{
    public partial class LoginAdmin : Form
    {
        private AdminController adminController;

        public LoginAdmin()
        {
            InitializeComponent();
            adminController = new AdminController();
        }

        private void LoginAdmin_Load(object sender, EventArgs e)
        {
            //MessageBox.Show("Siap Bekerja Min?...");
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUser.Text == "" || txtPassword.Text == "")
            {
                MessageBox.Show("Username dan Password tidak boleh kosong!");
                return;
            }

            bool status = adminController.CekLogin(txtUser.Text, txtPassword.Text);

            if (status)
            {
                MessageBox.Show("Login Berhasil!");

                view menuUtama = new view();
                menuUtama.Show();

                this.Hide();
            }
        }
    }
}