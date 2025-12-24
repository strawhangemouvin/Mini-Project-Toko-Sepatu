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
    public partial class AddMerk : Form
    {
        private MoonikersController moonController;
        private ValidationController validator;


        public AddMerk()
        {
            InitializeComponent();
            moonController = new MoonikersController();
            validator = new ValidationController();
        }

        private void AddMerk_Load(object sender, EventArgs e)
        {
            txt_nama_add_merk.Focus();

        }

        private void btn_cansel_add_merk_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_save_add_merk_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_nama_add_merk.Text))
            {
                MessageBox.Show("Brand Name is required!");
                return;
            }

            string idBaru = "CAT" + (moonController.GetMerk().Rows.Count + 1).ToString("00");

            if (moonController.AddMerk(idBaru, txt_nama_add_merk.Text))
            {
                MessageBox.Show("Brand Added Successfully!");
                this.DialogResult = DialogResult.OK; 
                this.Close();
            }
        }

        private void txt_nama_add_merk_KeyPress(object sender, KeyPressEventArgs e)
        {
            validator.FilterNamaStrict(e, txt_nama_add_merk);
        }
    }
}