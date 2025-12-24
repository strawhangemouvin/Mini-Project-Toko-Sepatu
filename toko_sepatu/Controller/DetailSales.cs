using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;
using toko_sepatu.Controller;

namespace toko_sepatu.View
{
    public partial class DetailSales : Form
    {
        private MoonikersController moonController;

        public DetailSales()
        {
            InitializeComponent();
            moonController = new MoonikersController();
        }

        private void DetailSales_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        public void LoadData()
        {
            DataTable dt = moonController.TampilkanPenjualan();
            dgv_detail.DataSource = dt;
            AturTampilanTabel();
        }

        private void txt_search_detail_TextChanged(object sender, EventArgs e)
        {
            if (dgv_detail.DataSource is DataTable dt)
            {
                dt.DefaultView.RowFilter = string.Format("nama_customer LIKE '%{0}%' OR id_penjualan LIKE '%{0}%'", txt_search_detail.Text);
            }
        }

        private void dtp_date_ValueChanged(object sender, EventArgs e)
        {
            string filterDate = dtp_date.Value.ToString("yyyy-MM-dd");
            if (dgv_detail.DataSource is DataTable dt)
            {
                dt.DefaultView.RowFilter = string.Format("tanggal >= #{0} 00:00:00# AND tanggal <= #{0} 23:59:59#", filterDate);
            }
        }

        private void AturTampilanTabel()
        {
            if (dgv_detail.Columns.Count > 0)
            {
                dgv_detail.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                if (dgv_detail.Columns.Contains("total_bayar"))
                {
                    dgv_detail.Columns["total_bayar"].HeaderText = "Total Bayar";
                    dgv_detail.Columns["total_bayar"].DefaultCellStyle.Format = "N0";
                }

                if (dgv_detail.Columns.Contains("tanggal"))
                {
                    dgv_detail.Columns["tanggal"].HeaderText = "Tanggal Transaksi";
                }
            }
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}