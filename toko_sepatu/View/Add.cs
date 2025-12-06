using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using toko_sepatu.Controller;

namespace toko_sepatu.View
{
    public partial class Add : Form
    {
        private SepatuController sepatuController;
        private ValidationController valController;

        public Add()
        {
            InitializeComponent();
            sepatuController = new SepatuController();
            valController = new ValidationController();
        }

        private void Add_Load(object sender, EventArgs e)
        {
            try
            {
                DataTable dtMerk = sepatuController.GetMerk();
                cbMerk.DataSource = dtMerk;
                cbMerk.DisplayMember = "nama_merk";
                cbMerk.ValueMember = "id_merk";
                cbMerk.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal memuat merk: " + ex.Message);
            }
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Pilih Gambar(*.jpg;*.png;*.jpeg)|*.jpg;*.png;*.jpeg";

            if (opf.ShowDialog() == DialogResult.OK)
            {
                pictureBox.Image = Image.FromFile(opf.FileName);
                pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // --- VALIDASI PAKE CONTROLLER ---
            // Kalau ada satu aja yang return false (gagal), langsung stop (return)
            if (!valController.ValidateNama(txtNama.Text)) return;
            if (!valController.ValidateAngka(txtUkuran.Text, "Ukuran")) return;
            if (!valController.ValidateAngka(txtHarga.Text, "Harga")) return;
            if (!valController.ValidateAngka(txtStok.Text, "Stok")) return;
            if (!valController.ValidateComboBox(cbMerk)) return;
            if (!valController.ValidateFoto(pictureBox)) return;


            byte[] fotoBytes;
            using (MemoryStream ms = new MemoryStream())
            {
                pictureBox.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                fotoBytes = ms.ToArray();
            }

            try
            {
                bool sukses = sepatuController.AddSepatu(
                    txtNama.Text,
                    Convert.ToInt32(cbMerk.SelectedValue),
                    int.Parse(txtUkuran.Text),
                    decimal.Parse(txtHarga.Text),
                    int.Parse(txtStok.Text),
                    fotoBytes
                );

                if (sukses)
                {
                    MessageBox.Show("Data Berhasil Disimpan!");
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saat simpan: " + ex.Message);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e) { }
    }
}