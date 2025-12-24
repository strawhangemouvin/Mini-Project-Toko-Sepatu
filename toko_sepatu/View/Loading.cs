using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace toko_sepatu.View
{
    public partial class Loading : Form
    {
        public Loading()
        {
            InitializeComponent();
        }

        private void timer_loading_Tick(object sender, EventArgs e)
        {
            gpb_loading_login.Increment(1);
            if (gpb_loading_login.Value == 100)
            {
                timer_loading.Stop();
                this.Hide();
                Signin loginAdmin = new Signin();
                loginAdmin.Show();
            }
        }

        private void Loading_Load(object sender, EventArgs e)
        {
            timer_loading.Start();
        }
    }
}
