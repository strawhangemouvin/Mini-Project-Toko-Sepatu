namespace toko_sepatu.View
{
    partial class UpdateMerk
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
            this.lbl_judul = new System.Windows.Forms.Label();
            this.txt_nama_merk = new System.Windows.Forms.TextBox();
            this.lbl_nama = new System.Windows.Forms.Label();
            this.gpn_update_merk = new Guna.UI2.WinForms.Guna2Panel();
            this.btn_save_update_merk = new Guna.UI2.WinForms.Guna2Button();
            this.btn_cansel_update_merk = new Guna.UI2.WinForms.Guna2Button();
            this.gpn_name = new Guna.UI2.WinForms.Guna2Panel();
            this.picture_box_update_merk = new Guna.UI2.WinForms.Guna2PictureBox();
            this.gpn_update_merk.SuspendLayout();
            this.gpn_name.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture_box_update_merk)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_judul
            // 
            this.lbl_judul.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_judul.AutoSize = true;
            this.lbl_judul.BackColor = System.Drawing.Color.AliceBlue;
            this.lbl_judul.Font = new System.Drawing.Font("Hobo Std", 18F, System.Drawing.FontStyle.Bold);
            this.lbl_judul.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(64)))), ((int)(((byte)(103)))));
            this.lbl_judul.Location = new System.Drawing.Point(136, 52);
            this.lbl_judul.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_judul.Name = "lbl_judul";
            this.lbl_judul.Size = new System.Drawing.Size(190, 34);
            this.lbl_judul.TabIndex = 123;
            this.lbl_judul.Text = "UPDATE MERK";
            // 
            // txt_nama_merk
            // 
            this.txt_nama_merk.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_nama_merk.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nama_merk.Location = new System.Drawing.Point(39, 37);
            this.txt_nama_merk.Margin = new System.Windows.Forms.Padding(2);
            this.txt_nama_merk.Multiline = true;
            this.txt_nama_merk.Name = "txt_nama_merk";
            this.txt_nama_merk.Size = new System.Drawing.Size(296, 26);
            this.txt_nama_merk.TabIndex = 121;
            this.txt_nama_merk.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_nama_merk_KeyPress);
            // 
            // lbl_nama
            // 
            this.lbl_nama.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_nama.AutoSize = true;
            this.lbl_nama.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lbl_nama.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nama.Location = new System.Drawing.Point(40, 16);
            this.lbl_nama.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_nama.Name = "lbl_nama";
            this.lbl_nama.Size = new System.Drawing.Size(67, 19);
            this.lbl_nama.TabIndex = 119;
            this.lbl_nama.Text = "NAME :";
            // 
            // gpn_update_merk
            // 
            this.gpn_update_merk.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gpn_update_merk.BackColor = System.Drawing.SystemColors.Menu;
            this.gpn_update_merk.Controls.Add(this.btn_save_update_merk);
            this.gpn_update_merk.Controls.Add(this.btn_cansel_update_merk);
            this.gpn_update_merk.Location = new System.Drawing.Point(0, 307);
            this.gpn_update_merk.Margin = new System.Windows.Forms.Padding(2);
            this.gpn_update_merk.Name = "gpn_update_merk";
            this.gpn_update_merk.Size = new System.Drawing.Size(450, 65);
            this.gpn_update_merk.TabIndex = 147;
            // 
            // btn_save_update_merk
            // 
            this.btn_save_update_merk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_save_update_merk.BorderRadius = 15;
            this.btn_save_update_merk.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_save_update_merk.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_save_update_merk.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_save_update_merk.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_save_update_merk.FillColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn_save_update_merk.Font = new System.Drawing.Font("Rosewood Std Regular", 12F, System.Drawing.FontStyle.Bold);
            this.btn_save_update_merk.ForeColor = System.Drawing.Color.Black;
            this.btn_save_update_merk.Location = new System.Drawing.Point(253, 17);
            this.btn_save_update_merk.Margin = new System.Windows.Forms.Padding(2);
            this.btn_save_update_merk.Name = "btn_save_update_merk";
            this.btn_save_update_merk.Size = new System.Drawing.Size(117, 31);
            this.btn_save_update_merk.TabIndex = 29;
            this.btn_save_update_merk.Text = "Save";
            this.btn_save_update_merk.Click += new System.EventHandler(this.btn_save_update_merk_Click);
            // 
            // btn_cansel_update_merk
            // 
            this.btn_cansel_update_merk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_cansel_update_merk.BorderRadius = 15;
            this.btn_cansel_update_merk.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_cansel_update_merk.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_cansel_update_merk.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_cansel_update_merk.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_cansel_update_merk.FillColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn_cansel_update_merk.Font = new System.Drawing.Font("Rosewood Std Regular", 12F, System.Drawing.FontStyle.Bold);
            this.btn_cansel_update_merk.ForeColor = System.Drawing.Color.Black;
            this.btn_cansel_update_merk.Location = new System.Drawing.Point(71, 17);
            this.btn_cansel_update_merk.Margin = new System.Windows.Forms.Padding(2);
            this.btn_cansel_update_merk.Name = "btn_cansel_update_merk";
            this.btn_cansel_update_merk.Size = new System.Drawing.Size(117, 31);
            this.btn_cansel_update_merk.TabIndex = 28;
            this.btn_cansel_update_merk.Text = "Cansel";
            this.btn_cansel_update_merk.Click += new System.EventHandler(this.btn_cancel_update_merk_Click);
            // 
            // gpn_name
            // 
            this.gpn_name.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.gpn_name.BackColor = System.Drawing.SystemColors.Menu;
            this.gpn_name.BorderRadius = 10;
            this.gpn_name.Controls.Add(this.txt_nama_merk);
            this.gpn_name.Controls.Add(this.lbl_nama);
            this.gpn_name.FillColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.gpn_name.Location = new System.Drawing.Point(33, 129);
            this.gpn_name.Margin = new System.Windows.Forms.Padding(2);
            this.gpn_name.Name = "gpn_name";
            this.gpn_name.Size = new System.Drawing.Size(383, 86);
            this.gpn_name.TabIndex = 148;
            // 
            // picture_box_update_merk
            // 
            this.picture_box_update_merk.Anchor = System.Windows.Forms.AnchorStyles.Top;
            //this.picture_box_update_merk.Image = global::toko_sepatu.Properties.Resources.icons8_category_50;
            this.picture_box_update_merk.ImageRotate = 0F;
            this.picture_box_update_merk.Location = new System.Drawing.Point(109, 55);
            this.picture_box_update_merk.Name = "picture_box_update_merk";
            this.picture_box_update_merk.Size = new System.Drawing.Size(27, 25);
            this.picture_box_update_merk.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picture_box_update_merk.TabIndex = 149;
            this.picture_box_update_merk.TabStop = false;
            // 
            // UpdateMerk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(450, 372);
            this.Controls.Add(this.picture_box_update_merk);
            this.Controls.Add(this.gpn_name);
            this.Controls.Add(this.gpn_update_merk);
            this.Controls.Add(this.lbl_judul);
            this.MinimumSize = new System.Drawing.Size(466, 411);
            this.Name = "UpdateMerk";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Update Merk";
            this.Load += new System.EventHandler(this.UpdateMerk_Load);
            this.gpn_update_merk.ResumeLayout(false);
            this.gpn_name.ResumeLayout(false);
            this.gpn_name.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture_box_update_merk)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_judul;
        public System.Windows.Forms.TextBox txt_nama_merk;
        private System.Windows.Forms.Label lbl_nama;
        private Guna.UI2.WinForms.Guna2Panel gpn_update_merk;
        private Guna.UI2.WinForms.Guna2Button btn_save_update_merk;
        private Guna.UI2.WinForms.Guna2Button btn_cansel_update_merk;
        private Guna.UI2.WinForms.Guna2Panel gpn_name;
        private Guna.UI2.WinForms.Guna2PictureBox picture_box_update_merk;
    }
}