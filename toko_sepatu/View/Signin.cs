using System;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using toko_sepatu.Controller;

namespace toko_sepatu.View
{
    public partial class Signin : Form
    {
        private MoonikersController adminController;
        private ValidationController validator; 

        public Signin()
        {
            InitializeComponent();
            adminController = new MoonikersController();
            validator = new ValidationController(); 
        }

        private void Signin_Load(object sender, EventArgs e)
        {
            txt_pass_signin.UseSystemPasswordChar = true;

            if (picture_box_merem != null) picture_box_merem.Visible = true;
            if (picture_box_melek != null) picture_box_melek.Visible = false;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (!validator.ValidateUsername(txt_user_signin.Text)) return;
            if (!validator.ValidatePasswordLogin(txt_pass_signin.Text)) return;

            bool status = adminController.CekLogin(txt_user_signin.Text, txt_pass_signin.Text);

            if (status)
            {
                // Ambil role dan langsung bersihkan (Trim hapus spasi, ToLower jadi huruf kecil)
                string role = adminController.GetRole(txt_user_signin.Text).Trim().ToLower();

                if (role == "admin")
                {
                    MessageBox.Show("Login Successfully as Warehouse admin!", "Success");
                    DashboardAdmin dashAdmin = new DashboardAdmin();
                    dashAdmin.Show();
                    this.Hide();
                }
                else if (role == "kasir")
                {
                    MessageBox.Show("Login Successfully as Cashier!", "Success");
                    DashboardKasir dashKasir = new DashboardKasir();
                    dashKasir.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Role not recognized! Role content in DB is: '" + role + "'",
                                    "Error Role", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Wrong Username or Password!!", "Login Failed",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void link_signup_Click(object sender, EventArgs e)
        {
            Signup formDaftar = new Signup();
            formDaftar.Show();
            this.Hide();
        }

        private void link_signup_MouseEnter(object sender, EventArgs e)
        {
            link_signup.Cursor = Cursors.Hand;
        }

        private void link_signup_MouseLeave(object sender, EventArgs e)
        {
            link_signup.Cursor = Cursors.Default;
        }

        private void picture_box_merem_Click(object sender, EventArgs e)
        {
            txt_pass_signin.UseSystemPasswordChar = false; 
            picture_box_merem.Visible = false;
            picture_box_melek.Visible = true;
        }

        private void picture_box_melek_Click(object sender, EventArgs e)
        {
            txt_pass_signin.UseSystemPasswordChar = true; 
            picture_box_melek.Visible = false;
            picture_box_merem.Visible = true;
        }

        private void txt_user_signin_KeyPress(object sender, KeyPressEventArgs e)
        {
            validator.FilterUsernameInput(e);
        }

        private void txt_pass_signin_KeyPress(object sender, KeyPressEventArgs e)
        {
            validator.FilterPasswordStrict(e, txt_pass_signin);
        }
    }
}