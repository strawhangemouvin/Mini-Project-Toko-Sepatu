using System.Windows.Forms;

namespace toko_sepatu.View
{
    partial class AddMerk
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
            this.label7 = new System.Windows.Forms.Label();
            this.txt_nama_add_merk = new System.Windows.Forms.TextBox();
            this.lbl_nama = new System.Windows.Forms.Label();
            this.gpn_add_merk = new Guna.UI2.WinForms.Guna2Panel();
            this.btn_save_add_merk = new Guna.UI2.WinForms.Guna2Button();
            this.btn_cansel_add_merk = new Guna.UI2.WinForms.Guna2Button();
            this.gpn_name = new Guna.UI2.WinForms.Guna2Panel();
            this.picture_box_merk = new Guna.UI2.WinForms.Guna2PictureBox();
            this.gpn_add_merk.SuspendLayout();
            this.gpn_name.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture_box_merk)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.AliceBlue;
            this.label7.Font = new System.Drawing.Font("Hobo Std", 18F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(64)))), ((int)(((byte)(103)))));
            this.label7.Location = new System.Drawing.Point(170, 51);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(143, 34);
            this.label7.TabIndex = 114;
            this.label7.Text = "ADD MERK";
            // 
            // txt_nama_add_merk
            // 
            this.txt_nama_add_merk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_nama_add_merk.BackColor = System.Drawing.SystemColors.Menu;
            this.txt_nama_add_merk.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nama_add_merk.Location = new System.Drawing.Point(48, 39);
            this.txt_nama_add_merk.Margin = new System.Windows.Forms.Padding(2);
            this.txt_nama_add_merk.Multiline = true;
            this.txt_nama_add_merk.Name = "txt_nama_add_merk";
            this.txt_nama_add_merk.Size = new System.Drawing.Size(296, 26);
            this.txt_nama_add_merk.TabIndex = 109;
            //this.txt_nama_add_merk.TextChanged += new System.EventHandler(this.txtNama_TextChanged);
            this.txt_nama_add_merk.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_nama_add_merk_KeyPress);
            // 
            // lbl_nama
            // 
            this.lbl_nama.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_nama.AutoSize = true;
            this.lbl_nama.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lbl_nama.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nama.Location = new System.Drawing.Point(44, 18);
            this.lbl_nama.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_nama.Name = "lbl_nama";
            this.lbl_nama.Size = new System.Drawing.Size(67, 19);
            this.lbl_nama.TabIndex = 106;
            this.lbl_nama.Text = "NAME :";
            // 
            // gpn_add_merk
            // 
            this.gpn_add_merk.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gpn_add_merk.BackColor = System.Drawing.SystemColors.Menu;
            this.gpn_add_merk.Controls.Add(this.btn_save_add_merk);
            this.gpn_add_merk.Controls.Add(this.btn_cansel_add_merk);
            this.gpn_add_merk.Location = new System.Drawing.Point(-4, 307);
            this.gpn_add_merk.Margin = new System.Windows.Forms.Padding(2);
            this.gpn_add_merk.Name = "gpn_add_merk";
            this.gpn_add_merk.Size = new System.Drawing.Size(457, 65);
            this.gpn_add_merk.TabIndex = 137;
            // 
            // btn_save_add_merk
            // 
            this.btn_save_add_merk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_save_add_merk.BorderRadius = 15;
            this.btn_save_add_merk.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_save_add_merk.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_save_add_merk.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_save_add_merk.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_save_add_merk.FillColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn_save_add_merk.Font = new System.Drawing.Font("Rosewood Std Regular", 12F, System.Drawing.FontStyle.Bold);
            this.btn_save_add_merk.ForeColor = System.Drawing.Color.Black;
            this.btn_save_add_merk.Location = new System.Drawing.Point(251, 17);
            this.btn_save_add_merk.Margin = new System.Windows.Forms.Padding(2);
            this.btn_save_add_merk.Name = "btn_save_add_merk";
            this.btn_save_add_merk.Size = new System.Drawing.Size(117, 31);
            this.btn_save_add_merk.TabIndex = 29;
            this.btn_save_add_merk.Text = "Save";
            this.btn_save_add_merk.Click += new System.EventHandler(this.btn_save_add_merk_Click);
            // 
            // btn_cansel_add_merk
            // 
            this.btn_cansel_add_merk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_cansel_add_merk.BorderRadius = 15;
            this.btn_cansel_add_merk.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_cansel_add_merk.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_cansel_add_merk.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_cansel_add_merk.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_cansel_add_merk.FillColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn_cansel_add_merk.Font = new System.Drawing.Font("Rosewood Std Regular", 12F, System.Drawing.FontStyle.Bold);
            this.btn_cansel_add_merk.ForeColor = System.Drawing.Color.Black;
            this.btn_cansel_add_merk.Location = new System.Drawing.Point(89, 17);
            this.btn_cansel_add_merk.Margin = new System.Windows.Forms.Padding(2);
            this.btn_cansel_add_merk.Name = "btn_cansel_add_merk";
            this.btn_cansel_add_merk.Size = new System.Drawing.Size(117, 31);
            this.btn_cansel_add_merk.TabIndex = 28;
            this.btn_cansel_add_merk.Text = "Cansel";
            this.btn_cansel_add_merk.Click += new System.EventHandler(this.btn_cansel_add_merk_Click);
            // 
            // gpn_name
            // 
            this.gpn_name.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.gpn_name.BackColor = System.Drawing.SystemColors.Menu;
            this.gpn_name.BorderRadius = 10;
            this.gpn_name.Controls.Add(this.lbl_nama);
            this.gpn_name.Controls.Add(this.txt_nama_add_merk);
            this.gpn_name.FillColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.gpn_name.Location = new System.Drawing.Point(34, 129);
            this.gpn_name.Margin = new System.Windows.Forms.Padding(2);
            this.gpn_name.Name = "gpn_name";
            this.gpn_name.Size = new System.Drawing.Size(383, 86);
            this.gpn_name.TabIndex = 138;
            // 
            // picture_box_merk
            // 
            this.picture_box_merk.Anchor = System.Windows.Forms.AnchorStyles.Top;
            //this.picture_box_merk.Image = global::toko_sepatu.Properties.Resources.icons8_category_50;
            this.picture_box_merk.ImageRotate = 0F;
            this.picture_box_merk.Location = new System.Drawing.Point(143, 56);
            this.picture_box_merk.Name = "picture_box_merk";
            this.picture_box_merk.Size = new System.Drawing.Size(27, 25);
            this.picture_box_merk.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picture_box_merk.TabIndex = 139;
            this.picture_box_merk.TabStop = false;
            // 
            // AddMerk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(450, 372);
            this.Controls.Add(this.picture_box_merk);
            this.Controls.Add(this.gpn_name);
            this.Controls.Add(this.gpn_add_merk);
            this.Controls.Add(this.label7);
            this.MinimumSize = new System.Drawing.Size(423, 411);
            this.Name = "AddMerk";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Merk";
            this.Load += new System.EventHandler(this.AddMerk_Load);
            this.gpn_add_merk.ResumeLayout(false);
            this.gpn_name.ResumeLayout(false);
            this.gpn_name.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture_box_merk)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label7;
        private TextBox txt_nama_add_merk;
        public System.Windows.Forms.TextBox txt_name_merk;
        private System.Windows.Forms.Label lbl_nama;
        private Guna.UI2.WinForms.Guna2Panel gpn_add_merk;
        private Guna.UI2.WinForms.Guna2Button btn_save_add_merk;
        private Guna.UI2.WinForms.Guna2Button btn_cansel_add_merk;
        private Guna.UI2.WinForms.Guna2Panel gpn_name;
        private Guna.UI2.WinForms.Guna2PictureBox picture_box_merk;
    }
}