using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using toko_sepatu.Controller;


namespace toko_sepatu.View
{
    public partial class AddProduct : Form
    {
        private MoonikersController moonController;
        private ValidationController validator; 
        public AddProduct()
        {
            InitializeComponent();
            moonController = new MoonikersController();
            validator = new ValidationController(); 
        }
        private void Add_Load(object sender, EventArgs e)
        {
            try
            {
                DataTable dtKat = moonController.GetMerk();
                txt_merk_add_product.DataSource = dtKat;
                txt_merk_add_product.DisplayMember = "nama_category";
                txt_merk_add_product.ValueMember = "id_category";
                txt_merk_add_product.SelectedIndex = -1;
                txt_merk_add_product.DropDownStyle = ComboBoxStyle.DropDownList;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btn_save_add_product_Click(object sender, EventArgs e)
        {
            if (!validator.ValidateProduct(
                txt_name_add_product.Text,
                txt_size_add_product.Text,
                txt_price_add_product.Text,
                txt_stock_add_product.Text,
                txt_merk_add_product,
                picture_box_add_product
            ))
            {
                return; // Jika validator memunculkan pesan error, proses berhenti di sini
            }

            try
            {
                // 2. Convert Gambar ke Byte Array secara aman
                byte[] imgBytes = null;
                if (picture_box_add_product.Image != null)
                {
                    using (MemoryStream ms = new MemoryStream())
                    {
                        // Gunakan Clone/Bitmap baru agar file asli tidak terkunci
                        using (Bitmap bmp = new Bitmap(picture_box_add_product.Image))
                        {
                            bmp.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                            imgBytes = ms.ToArray();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Please upload product photos first!");
                    return;
                }

                // 3. Eksekusi Simpan ke Database
                bool sukses = moonController.AddProduct(
                    txt_name_add_product.Text,
                    txt_merk_add_product.SelectedValue.ToString(),
                    int.Parse(txt_size_add_product.Text),
                    decimal.Parse(txt_price_add_product.Text),
                    int.Parse(txt_stock_add_product.Text),
                    imgBytes
                );

                if (sukses)
                {
                    MessageBox.Show("Shoe Data Successfully Saved!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK; 
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Failed to save to database. Check connection or SQL query.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("A technical error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_upload_add_product_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Gambar|*.jpg;*.png;*.jpeg";
            if (opf.ShowDialog() == DialogResult.OK)
            {
                picture_box_add_product.Image = Image.FromFile(opf.FileName);
                picture_box_add_product.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }
        private void btn_reset_add_product_Click(object sender, EventArgs e)
        {
            txt_name_add_product.Clear();
            txt_price_add_product.Clear();
            txt_stock_add_product.Clear();
            txt_size_add_product.Clear(); 
            txt_merk_add_product.SelectedIndex = -1;
            picture_box_add_product.Image = null;
        }

        private void btn_back_add_product_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txt_size_add_product_KeyPress(object sender, KeyPressEventArgs e)
        {
            validator.FilterSizeStrict(e, txt_size_add_product);
        }

        private void txt_stock_add_product_KeyPress(object sender, KeyPressEventArgs e)
        {
            validator.FilterAngkaOnly(e);
        }

        private void txt_price_add_product_KeyPress(object sender, KeyPressEventArgs e)
        {
            validator.FilterAngkaOnly(e);
        }

        private void txt_name_add_product_KeyPress(object sender, KeyPressEventArgs e)
        {
            validator.FilterNamaStrict(e, txt_name_add_product);
        }
    }
}