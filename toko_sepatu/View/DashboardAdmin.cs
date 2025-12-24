using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using toko_sepatu.Controller; 

namespace toko_sepatu.View
{
    public partial class DashboardAdmin : Form
    {
        private MoonikersController moonController;

        public DashboardAdmin()
        {
            InitializeComponent();
            moonController = new MoonikersController(); 
        }

        private void btn_sepatu_Click(object sender, EventArgs e)
        {
            Product formProduct = new Product();
            formProduct.Show();
        }

        private void btn_merk_Click(object sender, EventArgs e)
        {
            Merk formMerk = new Merk();
            formMerk.ShowDialog();
        }

        private void btn_customer_Click(object sender, EventArgs e)
        {
            Customer formCust = new Customer();
            formCust.ShowDialog();
        }


        private void btn_logout_admin_Click(object sender, EventArgs e)
        {
            ms_admin.Text = "Are you sure you want to logout?";
            ms_admin.Caption = "Confirmation";
            ms_admin.Buttons = Guna.UI2.WinForms.MessageDialogButtons.YesNo; 
            ms_admin.Icon = Guna.UI2.WinForms.MessageDialogIcon.Question;

            if (ms_admin.Show() == DialogResult.Yes)
            {
                Signin loginForm = new Signin();
                loginForm.Show();

                this.Close();
            }
        }

        private void tbl_layout_admin_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}