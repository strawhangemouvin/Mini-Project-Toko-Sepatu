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
    public partial class UpdateMerk : Form
    {
        public string idMerk;
        public string namaMerk;

        private MoonikersController moonController;
        private ValidationController validator;

        public UpdateMerk()
        {
            InitializeComponent();
            moonController = new MoonikersController();
            validator = new ValidationController();
        }

       
        private void UpdateMerk_Load(object sender, EventArgs e)
        {
            txt_nama_merk.Text = namaMerk;
        }
    

        private void btn_save_update_merk_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_nama_merk.Text))
            {
                MessageBox.Show("Brand Name cannot be blank!");
                return;
            }

            if (moonController.UpdateMerk(idMerk, txt_nama_merk.Text))
            {
                MessageBox.Show("Data Merk Berhasil Diupdate!", "Success");
                this.DialogResult = DialogResult.OK; // Biar form depan refresh
                this.Close();
            }
        }

        private void btn_cancel_update_merk_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txt_nama_merk_KeyPress(object sender, KeyPressEventArgs e)
        {
            validator.FilterNamaStrict(e, txt_nama_merk);
        }
    }
}