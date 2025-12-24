using System;
using System.Windows.Forms;
using toko_sepatu.Controller;

namespace toko_sepatu.View
{
    public partial class DashboardKasir : Form
    {
        private MoonikersController moonController;

        public DashboardKasir()
        {
            InitializeComponent();
            moonController = new MoonikersController();
        }

        private void DashboardKasir_Load(object sender, EventArgs e)
        {
        }

        private void btn_customer_Click(object sender, EventArgs e)
        {
            Customer formCust = new Customer();

            this.Hide();             
            formCust.ShowDialog();  
            this.Show();            
        }

        private void btn_purchase_Click(object sender, EventArgs e)
        {
            Sales formSales = new Sales();

            this.Hide();             
            formSales.ShowDialog();  
            this.Show();             
        }

        private void btn_detail_Click(object sender, EventArgs e)
        {

            DetailSales formDetail = new DetailSales();
            formDetail.ShowDialog();
        }

        private void btn_logout_cashier_Click(object sender, EventArgs e)
        {
            ms_kasir.Text = "Are you sure you want to logout?";
            ms_kasir.Caption = "Confirmation";
            ms_kasir.Buttons = Guna.UI2.WinForms.MessageDialogButtons.YesNo; 
            ms_kasir.Icon = Guna.UI2.WinForms.MessageDialogIcon.Question;

            if (ms_kasir.Show() == DialogResult.Yes)
            {
                Signin login = new Signin();
                login.Show();
                this.Hide();
            }
        }
    }
}