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
    public partial class UpdateCustomer : Form
    {
        public string idCust;
        public string namaCust;
        public string emailCust; 
        public string alamatCust;

        private MoonikersController moonController;
        private ValidationController validator;

        public UpdateCustomer()
        {
            InitializeComponent();
            moonController = new MoonikersController();
            validator = new ValidationController();
        }

        private void UpdateCustomer_Load(object sender, EventArgs e)
        {
            txt_name_update_customer.Text = namaCust;

            txt_email_add_customer.Text =emailCust;

            rich_txt_alamat.Text = alamatCust;
        }

        private void btn_save_update_customer_Click(object sender, EventArgs e)
        {
            if (!validator.ValidateCustomer(
                txt_name_update_customer.Text,
                txt_email_add_customer.Text,
                rich_txt_alamat.Text
            ))
            {
                return; 
            }

            DataTable dt = moonController.TampilkanCustomer();
            foreach (DataRow row in dt.Rows)
            {
                string dbEmail = row["email"].ToString();
                string dbId = row["id_customer"].ToString();

                if (dbEmail.ToLower() == txt_email_add_customer.Text.ToLower() && dbId != idCust)
                {
                    MessageBox.Show("This email is already in use by another customer!", "Update Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return; 
                }
            }

            // C. PROSES UPDATE KE DATABASE
            bool sukses = moonController.UpdateCustomer(
                idCust,
                txt_name_update_customer.Text,
                txt_email_add_customer.Text, 
                rich_txt_alamat.Text
            );

            if (sukses)
            {
                MessageBox.Show("Success! Customer data has been updated successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void txt_name_update_customer_KeyPress(object sender, KeyPressEventArgs e)
        {
            validator.FilterNamaCustomerStrict(e, txt_name_update_customer);
        }

        private void txt_email_add_customer_KeyPress(object sender, KeyPressEventArgs e)
        {
            validator.FilterEmailStrict(e, txt_email_add_customer);
        }
    }
}