using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using toko_sepatu.Controller;

namespace toko_sepatu.View
{
    public partial class UpdateProduct : Form
    {
        private MoonikersController sepatuController;
        private ValidationController validator;

        public string idSepatu;

        // Variabel untuk fitur RESET
        private string namaAsli, merkAsli, hargaAsli, stokAsli, ukuranAsli;
        private Image gambarAsli;

        public UpdateProduct()
        {
            InitializeComponent();
            sepatuController = new MoonikersController();
            validator = new ValidationController();
        }

        private void UpdateProduct_Load(object sender, EventArgs e)
        {
            try
            {
                DataTable dtMerk = sepatuController.GetMerk();
                cb_merk_update_product.DataSource = dtMerk;
                cb_merk_update_product.DisplayMember = "nama_category";
                cb_merk_update_product.ValueMember = "id_category";
                cb_merk_update_product.DropDownStyle = ComboBoxStyle.DropDownList;

                namaAsli = txt_name_update_product.Text;
                hargaAsli = txt_price_update_product.Text.Replace(",00", "").Replace(".", "").Replace(",", "");
                stokAsli = txt_stock_update_product.Text;
                ukuranAsli = txt_size_update_product.Text;
                merkAsli = cb_merk_update_product.Text;
                gambarAsli = picture_box_update_product.Image;

                txt_price_update_product.Text = hargaAsli;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load data: " + ex.Message);
            }
        }

        private void btn_upload_update_product_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Gambar (*.jpg;*.png;*.jpeg)|*.jpg;*.png;*.jpeg";
            if (opf.ShowDialog() == DialogResult.OK)
            {
                picture_box_update_product.Image = Image.FromFile(opf.FileName);
                picture_box_update_product.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void txt_name_update_product_KeyPress(object sender, KeyPressEventArgs e)
        {
            validator.FilterNamaStrict(e, txt_name_update_product);
        }

        private void txt_size_update_product_KeyPress(object sender, KeyPressEventArgs e)
        {
            validator.FilterSizeStrict(e, txt_size_update_product);
        }

        private void txt_price_update_product_KeyPress(object sender, KeyPressEventArgs e)
        {
            validator.FilterAngkaOnly(e);
        }

        private void txt_stock_update_product_KeyPress(object sender, KeyPressEventArgs e)
        {
            validator.FilterAngkaOnly(e);
        }

        private void btn_reset_update_product_Click(object sender, EventArgs e)
        {
            txt_name_update_product.Text = namaAsli;
            txt_price_update_product.Text = hargaAsli;
            txt_stock_update_product.Text = stokAsli;
            txt_size_update_product.Text = ukuranAsli;
            cb_merk_update_product.Text = merkAsli;
            picture_box_update_product.Image = gambarAsli;
        }

        private void btn_save_update_product_Click(object sender, EventArgs e)
        {
            string hargaMurni = txt_price_update_product.Text.Replace(",00", "").Replace(".", "").Replace(",", "");
            txt_price_update_product.Text = hargaMurni;

            if (!validator.ValidateProduct(txt_name_update_product.Text, txt_size_update_product.Text,
                hargaMurni, txt_stock_update_product.Text, cb_merk_update_product, picture_box_update_product)) return;

            // 2. Konversi Gambar (Gunakan Try-Catch agar tidak 'macet')
            byte[] imgBytes = null;
            try
            {
                if (picture_box_update_product.Image != null)
                {
                    using (MemoryStream ms = new MemoryStream())
                    {
                        using (Bitmap bmp = new Bitmap(picture_box_update_product.Image))
                        {
                            bmp.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                            imgBytes = ms.ToArray();
                        }
                    }
                }

                bool sukses = sepatuController.UpdateProduct(idSepatu, txt_name_update_product.Text,
                    cb_merk_update_product.SelectedValue.ToString(), int.Parse(txt_size_update_product.Text),
                    decimal.Parse(hargaMurni), int.Parse(txt_stock_update_product.Text), imgBytes);

                if (sukses)
                {
                    MessageBox.Show("Successful update!", "Success");
                    this.DialogResult = DialogResult.OK; // Penting agar form depan refresh!
                    this.Close();
                }
            }
            catch (Exception ex) { MessageBox.Show("Failed: " + ex.Message); }
        }
        private void btn_back_update_product_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}