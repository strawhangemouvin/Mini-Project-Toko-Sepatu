namespace toko_sepatu.View
{
    partial class AddCustomer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_judul_add_product = new System.Windows.Forms.Label();
            this.txt_email_add_customer = new System.Windows.Forms.TextBox();
            this.txt_name_add_customer = new System.Windows.Forms.TextBox();
            this.lbl_email = new System.Windows.Forms.Label();
            this.lbl_nama = new System.Windows.Forms.Label();
            this.rich_txt_alamat = new System.Windows.Forms.RichTextBox();
            this.lbl_alamat = new System.Windows.Forms.Label();
            this.gpn_add_customer = new Guna.UI2.WinForms.Guna2Panel();
            this.btn_save_add_customer = new Guna.UI2.WinForms.Guna2Button();
            this.btn_cansel_add_customer = new Guna.UI2.WinForms.Guna2Button();
            this.gpn_customer = new Guna.UI2.WinForms.Guna2Panel();
            this.picture_box_customer = new Guna.UI2.WinForms.Guna2PictureBox();
            this.gpn_add_customer.SuspendLayout();
            this.gpn_customer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture_box_customer)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_judul_add_product
            // 
            this.lbl_judul_add_product.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_judul_add_product.AutoSize = true;
            this.lbl_judul_add_product.BackColor = System.Drawing.Color.AliceBlue;
            this.lbl_judul_add_product.Font = new System.Drawing.Font("Hobo Std", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_judul_add_product.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(64)))), ((int)(((byte)(103)))));
            this.lbl_judul_add_product.Location = new System.Drawing.Point(196, 33);
            this.lbl_judul_add_product.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_judul_add_product.Name = "lbl_judul_add_product";
            this.lbl_judul_add_product.Size = new System.Drawing.Size(210, 34);
            this.lbl_judul_add_product.TabIndex = 103;
            this.lbl_judul_add_product.Text = "ADD CUSTOMER";
            // 
            // txt_email_add_customer
            // 
            this.txt_email_add_customer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_email_add_customer.BackColor = System.Drawing.SystemColors.Menu;
            this.txt_email_add_customer.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_email_add_customer.Location = new System.Drawing.Point(89, 53);
            this.txt_email_add_customer.Margin = new System.Windows.Forms.Padding(2);
            this.txt_email_add_customer.Multiline = true;
            this.txt_email_add_customer.Name = "txt_email_add_customer";
            this.txt_email_add_customer.Size = new System.Drawing.Size(319, 25);
            this.txt_email_add_customer.TabIndex = 102;
            this.txt_email_add_customer.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_email_add_customer_KeyPress);
            // 
            // txt_name_add_customer
            // 
            this.txt_name_add_customer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_name_add_customer.BackColor = System.Drawing.SystemColors.Menu;
            this.txt_name_add_customer.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_name_add_customer.Location = new System.Drawing.Point(89, 11);
            this.txt_name_add_customer.Margin = new System.Windows.Forms.Padding(2);
            this.txt_name_add_customer.Multiline = true;
            this.txt_name_add_customer.Name = "txt_name_add_customer";
            this.txt_name_add_customer.Size = new System.Drawing.Size(319, 26);
            this.txt_name_add_customer.TabIndex = 101;
            this.txt_name_add_customer.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_name_add_customer_KeyPress);
            // 
            // lbl_email
            // 
            this.lbl_email.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_email.AutoSize = true;
            this.lbl_email.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lbl_email.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_email.Location = new System.Drawing.Point(11, 53);
            this.lbl_email.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(62, 19);
            this.lbl_email.TabIndex = 100;
            this.lbl_email.Text = "EMAIL";
            // 
            // lbl_nama
            // 
            this.lbl_nama.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_nama.AutoSize = true;
            this.lbl_nama.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lbl_nama.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nama.Location = new System.Drawing.Point(11, 13);
            this.lbl_nama.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_nama.Name = "lbl_nama";
            this.lbl_nama.Size = new System.Drawing.Size(58, 19);
            this.lbl_nama.TabIndex = 99;
            this.lbl_nama.Text = "NAME";
            // 
            // rich_txt_alamat
            // 
            this.rich_txt_alamat.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rich_txt_alamat.BackColor = System.Drawing.SystemColors.Menu;
            this.rich_txt_alamat.Location = new System.Drawing.Point(89, 97);
            this.rich_txt_alamat.Name = "rich_txt_alamat";
            this.rich_txt_alamat.Size = new System.Drawing.Size(319, 65);
            this.rich_txt_alamat.TabIndex = 134;
            this.rich_txt_alamat.Text = "";
            // 
            // lbl_alamat
            // 
            this.lbl_alamat.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_alamat.AutoSize = true;
            this.lbl_alamat.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lbl_alamat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_alamat.Location = new System.Drawing.Point(9, 97);
            this.lbl_alamat.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_alamat.Name = "lbl_alamat";
            this.lbl_alamat.Size = new System.Drawing.Size(75, 19);
            this.lbl_alamat.TabIndex = 135;
            this.lbl_alamat.Text = "ADDRES";
            // 
            // gpn_add_customer
            // 
            this.gpn_add_customer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gpn_add_customer.BackColor = System.Drawing.SystemColors.Menu;
            this.gpn_add_customer.Controls.Add(this.btn_save_add_customer);
            this.gpn_add_customer.Controls.Add(this.btn_cansel_add_customer);
            this.gpn_add_customer.Location = new System.Drawing.Point(-1, 330);
            this.gpn_add_customer.Margin = new System.Windows.Forms.Padding(2);
            this.gpn_add_customer.Name = "gpn_add_customer";
            this.gpn_add_customer.Size = new System.Drawing.Size(578, 65);
            this.gpn_add_customer.TabIndex = 136;
            // 
            // btn_save_add_customer
            // 
            this.btn_save_add_customer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_save_add_customer.BorderColor = System.Drawing.Color.DimGray;
            this.btn_save_add_customer.BorderRadius = 15;
            this.btn_save_add_customer.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.btn_save_add_customer.BorderThickness = 1;
            this.btn_save_add_customer.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_save_add_customer.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_save_add_customer.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_save_add_customer.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_save_add_customer.FillColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn_save_add_customer.Font = new System.Drawing.Font("Rosewood Std Regular", 12F, System.Drawing.FontStyle.Bold);
            this.btn_save_add_customer.ForeColor = System.Drawing.Color.Black;
            this.btn_save_add_customer.Location = new System.Drawing.Point(324, 17);
            this.btn_save_add_customer.Margin = new System.Windows.Forms.Padding(2);
            this.btn_save_add_customer.Name = "btn_save_add_customer";
            this.btn_save_add_customer.Size = new System.Drawing.Size(117, 31);
            this.btn_save_add_customer.TabIndex = 29;
            this.btn_save_add_customer.Text = "Save";
            this.btn_save_add_customer.Click += new System.EventHandler(this.btn_save_add_customer_Click);
            // 
            // btn_cansel_add_customer
            // 
            this.btn_cansel_add_customer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_cansel_add_customer.BorderColor = System.Drawing.Color.DimGray;
            this.btn_cansel_add_customer.BorderRadius = 15;
            this.btn_cansel_add_customer.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.btn_cansel_add_customer.BorderThickness = 1;
            this.btn_cansel_add_customer.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_cansel_add_customer.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_cansel_add_customer.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_cansel_add_customer.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_cansel_add_customer.FillColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn_cansel_add_customer.Font = new System.Drawing.Font("Rosewood Std Regular", 12F, System.Drawing.FontStyle.Bold);
            this.btn_cansel_add_customer.ForeColor = System.Drawing.Color.Black;
            this.btn_cansel_add_customer.Location = new System.Drawing.Point(111, 17);
            this.btn_cansel_add_customer.Margin = new System.Windows.Forms.Padding(2);
            this.btn_cansel_add_customer.Name = "btn_cansel_add_customer";
            this.btn_cansel_add_customer.Size = new System.Drawing.Size(117, 31);
            this.btn_cansel_add_customer.TabIndex = 28;
            this.btn_cansel_add_customer.Text = "Cansel";
            this.btn_cansel_add_customer.Click += new System.EventHandler(this.btn_cansel_add_customer_Click);
            // 
            // gpn_customer
            // 
            this.gpn_customer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.gpn_customer.BackColor = System.Drawing.SystemColors.Menu;
            this.gpn_customer.BorderRadius = 8;
            this.gpn_customer.Controls.Add(this.txt_name_add_customer);
            this.gpn_customer.Controls.Add(this.lbl_nama);
            this.gpn_customer.Controls.Add(this.lbl_alamat);
            this.gpn_customer.Controls.Add(this.lbl_email);
            this.gpn_customer.Controls.Add(this.rich_txt_alamat);
            this.gpn_customer.Controls.Add(this.txt_email_add_customer);
            this.gpn_customer.FillColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.gpn_customer.Location = new System.Drawing.Point(69, 85);
            this.gpn_customer.Margin = new System.Windows.Forms.Padding(2);
            this.gpn_customer.Name = "gpn_customer";
            this.gpn_customer.Size = new System.Drawing.Size(436, 180);
            this.gpn_customer.TabIndex = 137;
            // 
            // picture_box_customer
            // 
            this.picture_box_customer.Anchor = System.Windows.Forms.AnchorStyles.Top;
            //this.picture_box_customer.Image = global::toko_sepatu.Properties.Resources.icons8_account_32;
            this.picture_box_customer.ImageRotate = 0F;
            this.picture_box_customer.Location = new System.Drawing.Point(159, 34);
            this.picture_box_customer.Name = "picture_box_customer";
            this.picture_box_customer.Size = new System.Drawing.Size(42, 31);
            this.picture_box_customer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picture_box_customer.TabIndex = 138;
            this.picture_box_customer.TabStop = false;
            // 
            // AddCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(575, 393);
            this.Controls.Add(this.picture_box_customer);
            this.Controls.Add(this.gpn_customer);
            this.Controls.Add(this.gpn_add_customer);
            this.Controls.Add(this.lbl_judul_add_product);
            this.MinimumSize = new System.Drawing.Size(570, 425);
            this.Name = "AddCustomer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Customer";
            this.gpn_add_customer.ResumeLayout(false);
            this.gpn_customer.ResumeLayout(false);
            this.gpn_customer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture_box_customer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_judul_add_product;
        public System.Windows.Forms.TextBox txt_email_add_customer;
        public System.Windows.Forms.TextBox txt_name_add_customer;
        private System.Windows.Forms.Label lbl_email;
        private System.Windows.Forms.Label lbl_nama;
        private System.Windows.Forms.RichTextBox rich_txt_alamat;
        private System.Windows.Forms.Label lbl_alamat;
        private Guna.UI2.WinForms.Guna2Panel gpn_add_customer;
        private Guna.UI2.WinForms.Guna2Button btn_save_add_customer;
        private Guna.UI2.WinForms.Guna2Button btn_cansel_add_customer;
        private Guna.UI2.WinForms.Guna2Panel gpn_customer;
        private Guna.UI2.WinForms.Guna2PictureBox picture_box_customer;
    }
}