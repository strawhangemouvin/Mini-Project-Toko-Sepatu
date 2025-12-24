using System;
using System.Data;
using System.Windows.Forms;
using toko_sepatu.Controller;

namespace toko_sepatu.View
{
    public partial class Sales : Form
    {
        private MoonikersController moonController;

        public Sales()
        {
            InitializeComponent();
            moonController = new MoonikersController();
            dgv_sales.CellDoubleClick += dgv_sales_CellDoubleClick;
        }

        private void Sales_Load(object sender, EventArgs e)
        {
            RefreshData();
        }

        public void RefreshData()
        {
            dgv_sales.DataSource = moonController.TampilkanPenjualan();
            if (dgv_sales.Columns.Contains("total_bayar"))
            {
                dgv_sales.Columns["total_bayar"].DefaultCellStyle.Format = "N0";
            }
        }

        private void txt_search_sales_TextChanged(object sender, EventArgs e)
        {
            dgv_sales.DataSource = moonController.SearchPenjualan(txt_search_sales.Text);
        }

        private void dtp_date_ValueChanged(object sender, EventArgs e)
        {
            dgv_sales.DataSource = moonController.FilterPenjualanByDate(dtp_date.Value);
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            AddSales addForm = new AddSales();
            addForm.ShowDialog();
            RefreshData();
        }


        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        private void dgv_sales_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DetailSales formDetail = new DetailSales();
            formDetail.ShowDialog();
        }

        private void dgv_sales_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
    
}