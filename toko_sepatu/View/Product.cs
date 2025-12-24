using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using toko_sepatu.Controller;

namespace toko_sepatu.View
{
    public partial class Product : Form
    {
        private MoonikersController moonController;

        public Product()
        {
            InitializeComponent();
            moonController = new MoonikersController();
        }

        private void TampilData()
        {
            dgvData.DataSource = moonController.TampilkanSepatu();
            dgvData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvData.RowTemplate.Height = 80;

            if (dgvData.Columns.Contains("harga"))
                dgvData.Columns["harga"].DefaultCellStyle.Format = "N0";

            //  (Kolom Index ke-6 sesuai database)
            if (dgvData.Columns.Count > 6)
            {
                DataGridViewImageColumn imgCol = (DataGridViewImageColumn)dgvData.Columns[6];
                imgCol.ImageLayout = DataGridViewImageCellLayout.Zoom;
                imgCol.HeaderText = "Foto Produk";
            }
        }

        private void view_Load(object sender, EventArgs e)
        {
            TampilData();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvData.CurrentRow == null) return;

            string id = dgvData.CurrentRow.Cells["id_product"].Value.ToString();
            string nama = dgvData.CurrentRow.Cells["nama_product"].Value.ToString();

            ms_product.Text = $"Are you sure you want to delete {nama} ({id})?";
            ms_product.Caption = "Confirmation";
            ms_product.Buttons = Guna.UI2.WinForms.MessageDialogButtons.YesNo; 
            ms_product.Icon = Guna.UI2.WinForms.MessageDialogIcon.Warning;

            if (ms_product.Show() == DialogResult.Yes)
            {
                if (moonController.DeleteSepatu(id))
                {
                    ms_product.Text = "Data successfully deleted!";
                    ms_product.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK;
                    ms_product.Icon = Guna.UI2.WinForms.MessageDialogIcon.Information;
                    ms_product.Show();

                    TampilData(); 
                }
                else
                {
                    ms_product.Text = "Failed to delete data from database.";
                    ms_product.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK;
                    ms_product.Icon = Guna.UI2.WinForms.MessageDialogIcon.Error;
                    ms_product.Show();
                }
            }
        }

        private void btnUpdate_Click_1(object sender, EventArgs e)
        {
            if (dgvData.CurrentRow == null) return;

            UpdateProduct formUpdate = new UpdateProduct();

            // Gunakan nama kolom asli database agar akurat
            formUpdate.idSepatu = dgvData.CurrentRow.Cells["id_product"].Value.ToString();
            formUpdate.txt_name_update_product.Text = dgvData.CurrentRow.Cells["nama_product"].Value.ToString();
            formUpdate.cb_merk_update_product.Text = dgvData.CurrentRow.Cells["nama_category"].Value.ToString();
            formUpdate.txt_size_update_product.Text = dgvData.CurrentRow.Cells["ukuran"].Value.ToString();

            // Bersihkan harga dari koma-koma liar
            string harga = dgvData.CurrentRow.Cells["harga"].Value.ToString();
            formUpdate.txt_price_update_product.Text = harga.Replace(",00", "").Replace(".", "").Replace(",", "");

            formUpdate.txt_stock_update_product.Text = dgvData.CurrentRow.Cells["stock"].Value.ToString();

            if (dgvData.CurrentRow.Cells["gambar"].Value != DBNull.Value)
            {
                byte[] imgBytes = (byte[])dgvData.CurrentRow.Cells["gambar"].Value;
                using (MemoryStream ms = new MemoryStream(imgBytes))
                {
                    formUpdate.picture_box_update_product.Image = Image.FromStream(ms);
                }
            }

            if (formUpdate.ShowDialog() == DialogResult.OK) TampilData();
        }


        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            dgvData.DataSource = moonController.SearchProduct(txt_search.Text);
        }

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            AddProduct formAdd = new AddProduct();
            formAdd.ShowDialog();
            TampilData();
        }

        private void btn_back_product_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}