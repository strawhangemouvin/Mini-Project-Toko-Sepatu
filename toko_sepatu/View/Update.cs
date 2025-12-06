using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using toko_sepatu.Controller;

namespace toko_sepatu.View
{
    public partial class Update : Form
    {
        private SepatuController sepatuController;
        private ValidationController valController;
        public string idSepatu;

        public Update()
        {
            InitializeComponent();
            sepatuController = new SepatuController();
            valController = new ValidationController();
        }

        private void Update_Load(object sender, EventArgs e)
        {
            try
            {
                string merkSaatIni = cbMerkUpdate.Text;
                DataTable dtMerk = sepatuController.GetMerk();

                cbMerkUpdate.DataSource = dtMerk;
                cbMerkUpdate.DisplayMember = "nama_merk";
                cbMerkUpdate.ValueMember = "id_merk";
                cbMerkUpdate.Text = merkSaatIni;
            }
            catch (Exception ex)
            {
                // Silent error biar ga ganggu
            }
        }

        private void btnUploadUpdate_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Pilih Gambar(*.jpg;*.png;*.jpeg)|*.jpg;*.png;*.jpeg";

            if (opf.ShowDialog() == DialogResult.OK)
            {
                pictureBoxUpdate.Image = Image.FromFile(opf.FileName);
                pictureBoxUpdate.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void btnSaveUpdate_Click(object sender, EventArgs e)
        {
            // --- VALIDASI PAKE CONTROLLER ---
            // Menggunakan nama komponen Update (txtNamaUpdate, dst)
            if (!valController.ValidateNama(txtNamaUpdate.Text)) return;
            if (!valController.ValidateAngka(txtUkuranUpdate.Text, "Ukuran")) return;
            if (!valController.ValidateAngka(txtHargaUpdate.Text, "Harga")) return;
            if (!valController.ValidateAngka(txtStokUpdate.Text, "Stok")) return;
            if (!valController.ValidateComboBox(cbMerkUpdate)) return;
            if (!valController.ValidateFoto(pictureBoxUpdate)) return;

            // --- PROSES UPDATE ---
            byte[] fotoBytes;
            using (MemoryStream ms = new MemoryStream())
            {
                pictureBoxUpdate.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                fotoBytes = ms.ToArray();
            }

            try
            {
                bool sukses = sepatuController.UpdateSepatu(
                    idSepatu,
                    txtNamaUpdate.Text,
                    Convert.ToInt32(cbMerkUpdate.SelectedValue),
                    int.Parse(txtUkuranUpdate.Text),
                    decimal.Parse(txtHargaUpdate.Text),
                    int.Parse(txtStokUpdate.Text),
                    fotoBytes
                );

                if (sukses)
                {
                    MessageBox.Show("Data Berhasil Diperbarui!");
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal Update: " + ex.Message);
            }
        }

        private void btnBackUpdate_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}