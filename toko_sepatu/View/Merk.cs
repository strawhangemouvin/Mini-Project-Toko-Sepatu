using System;
using System.Windows.Forms;
using toko_sepatu.Controller;

namespace toko_sepatu.View
{
    public partial class Merk : Form
    {
        private MoonikersController moonController;

        public Merk()
        {
            InitializeComponent();
            moonController = new MoonikersController();
        }

        private void Merk_Load(object sender, EventArgs e)
        {
            TampilData();
        }

        private void TampilData()
        {
            dgv_merk.DataSource = moonController.GetMerk();

            if (dgv_merk.Columns.Count > 0)
            {
                dgv_merk.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                if (dgv_merk.Columns.Contains("id_category"))
                    dgv_merk.Columns["id_category"].HeaderText = "ID Merk";

                if (dgv_merk.Columns.Contains("nama_category"))
                    dgv_merk.Columns["nama_category"].HeaderText = "Nama Merk";
            }
        }

        private void btn_add_merk_Click(object sender, EventArgs e)
        {
            AddMerk formAdd = new AddMerk();
            formAdd.ShowDialog(); 

            TampilData(); 
        }

        private void btn_update_merk_Click(object sender, EventArgs e)
        {
            if (dgv_merk.CurrentRow == null)
            {
                MessageBox.Show("Select the brand you want to edit!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            UpdateMerk formUpdate = new UpdateMerk();

            // Mengirim data ke variabel public di UpdateMerk.cs
            formUpdate.idMerk = dgv_merk.CurrentRow.Cells["id_category"].Value.ToString();
            formUpdate.namaMerk = dgv_merk.CurrentRow.Cells["nama_category"].Value.ToString();

            if (formUpdate.ShowDialog() == DialogResult.OK)
            {
                TampilData();
            }
        }

        private void btn_delete_merk_Click(object sender, EventArgs e)
        {
            if (dgv_merk.CurrentRow == null) return;

            string id = dgv_merk.CurrentRow.Cells["id_category"].Value.ToString();
            string nama = dgv_merk.CurrentRow.Cells["nama_category"].Value.ToString();

            ms_merk.Text = $"Are you sure you want to remove brand {nama}?";
            ms_merk.Caption = "Confirmation";
            ms_merk.Buttons = Guna.UI2.WinForms.MessageDialogButtons.YesNo; 
            ms_merk.Icon = Guna.UI2.WinForms.MessageDialogIcon.Question;

            if (ms_merk.Show() == DialogResult.Yes)
            {
                if (moonController.DeleteMerk(id))
                {
                    ms_merk.Text = "Erased successfully!!";
                    ms_merk.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK;
                    ms_merk.Icon = Guna.UI2.WinForms.MessageDialogIcon.Information;
                    ms_merk.Show();

                    TampilData(); 
                }
                else
                {
                    ms_merk.Text = "Failed to erase data.";
                    ms_merk.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK;
                    ms_merk.Icon = Guna.UI2.WinForms.MessageDialogIcon.Error;
                    ms_merk.Show();
                }
            }
        }        

        private void txt_search_merk_TextChanged(object sender, EventArgs e)
        {
            dgv_merk.DataSource = moonController.SearchMerk(txt_search_merk.Text);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgv_merk_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
    }
}