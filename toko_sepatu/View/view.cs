using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using toko_sepatu.Controller;

namespace toko_sepatu.View
{
    public partial class view : Form
    {
        private SepatuController sepatuController;

        public view()
        {
            InitializeComponent();
            sepatuController = new SepatuController();
        }

        private void TampilData()
        {
            dgvData.DataSource = sepatuController.TampilkanSepatu();

            dgvData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvData.RowTemplate.Height = 100;

            // Atur Kolom Foto (Index 6)
            if (dgvData.Columns.Count > 6)
            {
                DataGridViewImageColumn imgCol = (DataGridViewImageColumn)dgvData.Columns[6];
                imgCol.ImageLayout = DataGridViewImageCellLayout.Zoom;
                imgCol.HeaderText = "Foto Produk";
                dgvData.Columns[6].Width = 150;
            }
        }

        // SAAT FORM DIBUKA
        private void view_Load(object sender, EventArgs e)
        {
            TampilData();
        }

        // tombol tambah
        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            Add formTambah = new Add();
            formTambah.ShowDialog();
            TampilData();
        }

        // tombol update
        private void btnUpdate_Click_1(object sender, EventArgs e)
        {
            if (dgvData.CurrentRow == null)
            {
                MessageBox.Show("Pilih data yang mau diedit dulu!");
                return;
            }

            Update formUpdate = new Update();
            formUpdate.idSepatu = dgvData.CurrentRow.Cells[0].Value.ToString();
            formUpdate.txtNamaUpdate.Text = dgvData.CurrentRow.Cells[1].Value.ToString();
            formUpdate.txtUkuranUpdate.Text = dgvData.CurrentRow.Cells[3].Value.ToString();
            formUpdate.txtHargaUpdate.Text = dgvData.CurrentRow.Cells[4].Value.ToString();
            formUpdate.txtStokUpdate.Text = dgvData.CurrentRow.Cells[5].Value.ToString();
            formUpdate.cbMerkUpdate.Text = dgvData.CurrentRow.Cells[2].Value.ToString();

            // Kirim Foto
            if (dgvData.CurrentRow.Cells[6].Value != DBNull.Value)
            {
                byte[] imgBytes = (byte[])dgvData.CurrentRow.Cells[6].Value;
                MemoryStream ms = new MemoryStream(imgBytes);
                formUpdate.pictureBoxUpdate.Image = Image.FromStream(ms);
            }

            formUpdate.ShowDialog();
            TampilData();
        }

        // tombol delete
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvData.CurrentRow == null)
            {
                MessageBox.Show("Pilih data yang mau dihapus!");
                return;
            }

            string id = dgvData.CurrentRow.Cells[0].Value.ToString();
            string nama = dgvData.CurrentRow.Cells[1].Value.ToString();

            DialogResult jawab = MessageBox.Show($"Yakin mau hapus sepatu '{nama}'?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (jawab == DialogResult.Yes)
            {
                sepatuController.DeleteSepatu(id);
                TampilData();
            }
        }

        //tombol search
        private void txtSearch_TextChanged_1(object sender, EventArgs e)
        {
            dgvData.DataSource = sepatuController.Search(txtSearch.Text);
        }

        private void btn_back_login_Click(object sender, EventArgs e)
        {
            DialogResult jawab = MessageBox.Show("Yakin ingin Logout?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (jawab == DialogResult.Yes)
            {
                LoginAdmin formLogin = new LoginAdmin();
                formLogin.Show();

                this.Close();
            }
        }
        //protected override void OnFormClosed(FormClosedEventArgs e)
        //{
        //    base.OnFormClosed(e);
        //    Application.Exit(); 
        //}
    }
}