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
    public partial class Customer : Form
    {
        private MoonikersController moonController;

        public Customer()
        {
            InitializeComponent();
            moonController = new MoonikersController();
        }

        private void Customer_Load(object sender, EventArgs e)
        {
            TampilData();
        }

          private void TampilData()
        {
            dgv_customer.DataSource = moonController.TampilkanCustomer();

            if (dgv_customer.Columns.Count > 0)
            {
                dgv_customer.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                if (dgv_customer.Columns.Contains("id_customer"))
                    dgv_customer.Columns["id_customer"].HeaderText = "ID Customer";

                if (dgv_customer.Columns.Contains("nama_customer"))
                    dgv_customer.Columns["nama_customer"].HeaderText = "Nama Lengkap";

                if (dgv_customer.Columns.Contains("no_hp"))
                    dgv_customer.Columns["no_hp"].HeaderText = "No HP";

                if (dgv_customer.Columns.Contains("alamat"))
                    dgv_customer.Columns["alamat"].HeaderText = "Alamat";
            }
        }

        private void btn_add_customer_Click(object sender, EventArgs e)
        {
            AddCustomer formAdd = new AddCustomer();
            formAdd.ShowDialog();

            TampilData(); 
        }

        private void btn_update_customer_Click(object sender, EventArgs e)
        {
            if (dgv_customer.CurrentRow == null)
            {
                MessageBox.Show("Select the customer you want to edit!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string id = dgv_customer.CurrentRow.Cells["id_customer"].Value.ToString();
            string nama = dgv_customer.CurrentRow.Cells["nama_customer"].Value.ToString();
            string hp = dgv_customer.CurrentRow.Cells["email"].Value.ToString();
            string alamat = dgv_customer.CurrentRow.Cells["alamat"].Value.ToString();

            UpdateCustomer formUpdate = new UpdateCustomer();
            formUpdate.idCust = id;
            formUpdate.namaCust = nama;
            formUpdate.emailCust = hp;
            formUpdate.alamatCust = alamat;

            formUpdate.ShowDialog();

            TampilData();
        }

        private void btn_delete_customer_Click(object sender, EventArgs e)
        {
            // 1. Cek apakah ada baris yang dipilih
            if (dgv_customer.CurrentRow == null)
            {
                ms_customer.Text = "Select the customer you want to delete!";
                ms_customer.Caption = "Warning";
                ms_customer.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK;
                ms_customer.Icon = Guna.UI2.WinForms.MessageDialogIcon.Warning;
                ms_customer.Show();
                return;
            }

            // 2. Ambil ID dan Nama Customer
            string id = dgv_customer.CurrentRow.Cells["id_customer"].Value.ToString();
            string nama = dgv_customer.CurrentRow.Cells["nama_customer"].Value.ToString();

            // 3. Konfirmasi Hapus (Menggunakan ms_customer agar tetap Bahasa Inggris)
            ms_customer.Text = $"Sure delete Customer '{nama}'?";
            ms_customer.Caption = "Confirmation";
            ms_customer.Buttons = Guna.UI2.WinForms.MessageDialogButtons.YesNo; // Memaksa Yes/No (English)
            ms_customer.Icon = Guna.UI2.WinForms.MessageDialogIcon.Question;

            // 4. Proses Hapus jika klik 'Yes'
            if (ms_customer.Show() == DialogResult.Yes)
            {
                bool sukses = moonController.DeleteCustomer(id);
                if (sukses)
                {
                    ms_customer.Text = "Deleted successfully!";
                    ms_customer.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK;
                    ms_customer.Icon = Guna.UI2.WinForms.MessageDialogIcon.Information;
                    ms_customer.Show();

                    TampilData(); // Refresh tabel
                }
                else
                {
                    ms_customer.Text = "Failed to delete customer.";
                    ms_customer.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK;
                    ms_customer.Icon = Guna.UI2.WinForms.MessageDialogIcon.Error;
                    ms_customer.Show();
                }
            }
        }
        private void txt_search_customer_TextChanged(object sender, EventArgs e)
        {
            dgv_customer.DataSource = moonController.SearchCustomer(txtSearch.Text);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgv_customer_CellContentClick(object sender, DataGridViewCellEventArgs e) { }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            dgv_customer.DataSource = moonController.SearchCustomer(txtSearch.Text);
        }
    }
}