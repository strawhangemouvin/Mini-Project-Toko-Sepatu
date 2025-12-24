using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using toko_sepatu.Controller;

namespace toko_sepatu.View
{
    public partial class AddCustomer : Form
    {
        private MoonikersController moonController;
        private ValidationController validator; 

        public AddCustomer()
        {
            InitializeComponent();
            moonController = new MoonikersController();
            validator = new ValidationController(); 
        }

        // FUNGSI GENERATE ID OTOMATIS
        private string GenerateIdCustomer()
        {
            string idBaru = "CST001";
            try
            {
                DataTable dt = moonController.TampilkanCustomer();
                if (dt.Rows.Count > 0)
                {
                    string idTerakhir = "";
                    foreach (DataRow row in dt.Rows)
                    {
                        idTerakhir = row["id_customer"].ToString();
                    }

                    if (idTerakhir.Length > 3)
                    {
                        int angka = int.Parse(idTerakhir.Substring(3)) + 1;
                        idBaru = "CST" + angka.ToString("000");
                    }
                }
            }
            catch { }
            return idBaru;
        }

        private void btn_save_add_customer_Click(object sender, EventArgs e)
        {
            if (!validator.ValidateCustomer(
                txt_name_add_customer.Text,
                txt_email_add_customer.Text,
                rich_txt_alamat.Text
            ))
            {
                return; 
            }

            DataTable dt = moonController.TampilkanCustomer();
            foreach (DataRow row in dt.Rows)
            {
                string emailDiDb = row["email"].ToString();

                if (emailDiDb.ToLower() == txt_email_add_customer.Text.ToLower())
                {
                    MessageBox.Show("This Email is ALREADY REGISTERED!\nPlease use another email.", "Failed to Register", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return; 
                }
            }

            string idBaru = GenerateIdCustomer();

            bool sukses = moonController.AddCustomer(
                idBaru,
                txt_name_add_customer.Text,
                txt_email_add_customer.Text,
                rich_txt_alamat.Text
            );

            if (sukses)
            {
                MessageBox.Show("Customer Successfully Added!\nID: " + idBaru, "Success");
                this.Close();
            }
        }

        private void btn_cansel_add_customer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_back_add_product_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddCustomer_Load(object sender, EventArgs e) { }

        //validasi saat menginputkan nama dan email
        private void txt_name_add_customer_KeyPress(object sender, KeyPressEventArgs e)
        {
            validator.FilterNamaCustomerStrict(e, txt_name_add_customer);
        }

        private void txt_email_add_customer_KeyPress(object sender, KeyPressEventArgs e)
        {
            validator.FilterEmailStrict(e, txt_email_add_customer);
        }
    }
}