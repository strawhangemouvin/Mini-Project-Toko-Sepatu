using System;
using System.Windows.Forms;
using toko_sepatu.Controller;

namespace toko_sepatu.View
{
    public partial class Signup : Form
    {
        private MoonikersController adminController;
        private ValidationController validator;

        public Signup()
        {
            InitializeComponent();
            adminController = new MoonikersController();
            validator = new ValidationController();
        }

        private void Signup_Load(object sender, EventArgs e)
        {
            txt_pass_signup.UseSystemPasswordChar = true;

            picture_box_melek.Visible = false;
            picture_box_merem.Visible = true;

            cb_signup.DropDownStyle = ComboBoxStyle.DropDownList;

          
            if (cb_signup.Items.Count == 0)
            {
                cb_signup.Items.Add("Admin");
                cb_signup.Items.Add("Kasir");
            }
        }

        private void btn_signup_Click(object sender, EventArgs e)
        {
            if (!validator.ValidateUsername(txt_user_signup.Text)) return;

            if (!validator.ValidateSignupData(txt_pass_signup.Text, cb_signup)) return;

            Random rnd = new Random();
            string idBaru = "ADM" + rnd.Next(1000, 9999).ToString();

            string selectedRole = cb_signup.SelectedItem.ToString();

            bool sukses = adminController.AddAccount(idBaru, txt_user_signup.Text, txt_pass_signup.Text, selectedRole, "New Staff");

            if (sukses)
            {
                MessageBox.Show("Successful Registration as " + selectedRole + "!\nPlease Login.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Signin formLogin = new Signin();
                formLogin.Show();
                this.Hide();
            }
        }
        private void link_signin_Click(object sender, EventArgs e)
        {
            Signin formLogin = new Signin();
            formLogin.Show();
            this.Hide();
        }

        private void picture_box_merem_Click(object sender, EventArgs e)
        {
            txt_pass_signup.UseSystemPasswordChar = false;

            txt_pass_signup.PasswordChar = '\0';

            picture_box_merem.Visible = false;
            picture_box_melek.Visible = true;
        }

        private void picture_box_melek_Click(object sender, EventArgs e)
        {
            txt_pass_signup.UseSystemPasswordChar = true;

            picture_box_melek.Visible = false;
            picture_box_merem.Visible = true;
        }

        private void link_signin_MouseEnter(object sender, EventArgs e)
        {
            link_signin.Cursor = Cursors.Hand;
        }

        private void link_signin_MouseLeave(object sender, EventArgs e)
        {
            link_signin.Cursor = Cursors.Default;
        }

        private void txt_user_signup_KeyPress(object sender, KeyPressEventArgs e)
        {
            validator.FilterUsernameInput(e);
        }
    }
}