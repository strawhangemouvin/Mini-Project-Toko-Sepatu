using System;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;
using toko_sepatu.Controller;

namespace toko_sepatu.View
{
    public partial class AddSales : Form
    {
        private MoonikersController moonController;

        public AddSales()
        {
            InitializeComponent();
            moonController = new MoonikersController();
        }

        private void AddSales_Load(object sender, EventArgs e)
        {
            cmb_cashier.DataSource = moonController.GetListAdmin();
            cmb_cashier.DisplayMember = "nama_lengkap";
            cmb_cashier.ValueMember = "id_admin";

            cmb_customer.DataSource = moonController.GetListCustomer();
            cmb_customer.DisplayMember = "nama_customer";
            cmb_customer.ValueMember = "id_customer";

            cmb_product.DataSource = moonController.GetListProductForCombo();
            cmb_product.DisplayMember = "info_produk";
            cmb_product.ValueMember = "id_product";
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txt_qty_product.Text))
                {
                    MessageBox.Show("Qty must be filled in!");
                    return;
                }

                string idJ = "INV-" + DateTime.Now.ToString("yyyyMMdd-HHmmss");
                string idA = cmb_cashier.SelectedValue.ToString();
                string idC = cmb_customer.SelectedValue.ToString();
                string idP = cmb_product.SelectedValue.ToString();
                int qty = int.Parse(txt_qty_product.Text);

                DataTable dtProd = moonController.GetProductDetail(idP);
                decimal harga = Convert.ToDecimal(dtProd.Rows[0]["harga"]);
                decimal total = harga * qty;

                if (moonController.AddPenjualan(idJ, idA, idC, dtp_date.Value, idP, qty, total))
                {
                    MessageBox.Show("Transaction Successful!");

                    // MUNCIULKAN STRUK DISINI
                    ShowReceiptPreview(idJ, total);

                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        // FUNGSI UNTUK MEMUNCULKAN STRUK POP-UP
        private void ShowReceiptPreview(string idInvoice, decimal totalBayar)
        {
            PrintDocument pd = new PrintDocument();
            pd.DefaultPageSettings.PaperSize = new PaperSize("Receipt", 300, 500);

            pd.PrintPage += (s, ev) => {
                Graphics g = ev.Graphics;
                Font f8 = new Font("Arial", 8);
                Font f10b = new Font("Arial", 10, FontStyle.Bold);
                int y = 20;

                g.DrawString("MOONIKERS SHOES STORE", f10b, Brushes.Black, 60, y); y += 30;
                g.DrawString("Invoice : " + idInvoice, f8, Brushes.Black, 10, y); y += 15;
                g.DrawString("Cashier : " + cmb_cashier.Text, f8, Brushes.Black, 10, y); y += 15;
                g.DrawString("Customer: " + cmb_customer.Text, f8, Brushes.Black, 10, y); y += 20;
                g.DrawString("------------------------------------------", f8, Brushes.Black, 10, y); y += 15;

                g.DrawString(cmb_product.Text, f8, Brushes.Black, 10, y); y += 15;
                g.DrawString(txt_qty_product.Text + " unit x " + (totalBayar / int.Parse(txt_qty_product.Text)).ToString("N0"), f8, Brushes.Black, 20, y);
                g.DrawString(totalBayar.ToString("N0"), f8, Brushes.Black, 200, y); y += 30;

                g.DrawString("TOTAL   : IDR " + totalBayar.ToString("N0"), f10b, Brushes.Black, 80, y); y += 40;
                g.DrawString("Thank you for visiting!", f8, Brushes.Black, 60, y);
            };

            PrintPreviewDialog ppd = new PrintPreviewDialog { Document = pd };
            ppd.ShowDialog();
        }

        private void btn_close_Click(object sender, EventArgs e) { this.Close(); }
    }
}