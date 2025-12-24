namespace toko_sepatu.View
{
    partial class AddSales
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
            this.dtp_date = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.gpn_add_sales = new Guna.UI2.WinForms.Guna2Panel();
            this.btn_save = new Guna.UI2.WinForms.Guna2Button();
            this.btn_close = new Guna.UI2.WinForms.Guna2Button();
            this.lblDateSales = new System.Windows.Forms.Label();
            this.lbQtyPruduct = new System.Windows.Forms.Label();
            this.lblIdProduct = new System.Windows.Forms.Label();
            this.lblIdCustomer = new System.Windows.Forms.Label();
            this.lblIDSales = new System.Windows.Forms.Label();
            this.lbl_judul_add_sales = new System.Windows.Forms.Label();
            this.cmb_cashier = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txt_qty_product = new Guna.UI2.WinForms.Guna2TextBox();
            this.cmb_customer = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cmb_product = new Guna.UI2.WinForms.Guna2ComboBox();
            this.picture_box_sales = new Guna.UI2.WinForms.Guna2PictureBox();
            this.picture_box_uang_numpuk = new Guna.UI2.WinForms.Guna2PictureBox();
            this.picture_box_dolar = new Guna.UI2.WinForms.Guna2PictureBox();
            this.gpn_add_sales.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture_box_sales)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_box_uang_numpuk)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_box_dolar)).BeginInit();
            this.SuspendLayout();
            // 
            // dtp_date
            // 
            this.dtp_date.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtp_date.AutoRoundedCorners = true;
            this.dtp_date.BorderRadius = 11;
            this.dtp_date.Checked = true;
            this.dtp_date.FillColor = System.Drawing.SystemColors.Control;
            this.dtp_date.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtp_date.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtp_date.Location = new System.Drawing.Point(300, 287);
            this.dtp_date.Margin = new System.Windows.Forms.Padding(2);
            this.dtp_date.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtp_date.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtp_date.Name = "dtp_date";
            this.dtp_date.Size = new System.Drawing.Size(199, 25);
            this.dtp_date.TabIndex = 71;
            this.dtp_date.Value = new System.DateTime(2024, 11, 28, 1, 35, 25, 501);
            // 
            // gpn_add_sales
            // 
            this.gpn_add_sales.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gpn_add_sales.BackColor = System.Drawing.SystemColors.Menu;
            this.gpn_add_sales.Controls.Add(this.btn_save);
            this.gpn_add_sales.Controls.Add(this.btn_close);
            this.gpn_add_sales.Location = new System.Drawing.Point(-8, 383);
            this.gpn_add_sales.Margin = new System.Windows.Forms.Padding(2);
            this.gpn_add_sales.Name = "gpn_add_sales";
            this.gpn_add_sales.Size = new System.Drawing.Size(809, 88);
            this.gpn_add_sales.TabIndex = 69;
            // 
            // btn_save
            // 
            this.btn_save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_save.BorderRadius = 15;
            this.btn_save.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_save.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_save.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_save.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_save.FillColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn_save.Font = new System.Drawing.Font("Rosewood Std Regular", 12F, System.Drawing.FontStyle.Bold);
            this.btn_save.ForeColor = System.Drawing.Color.Black;
            this.btn_save.Location = new System.Drawing.Point(463, 30);
            this.btn_save.Margin = new System.Windows.Forms.Padding(2);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(117, 31);
            this.btn_save.TabIndex = 29;
            this.btn_save.Text = "Saved";
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_close
            // 
            this.btn_close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_close.BorderRadius = 15;
            this.btn_close.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_close.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_close.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_close.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_close.FillColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn_close.Font = new System.Drawing.Font("Rosewood Std Regular", 12F, System.Drawing.FontStyle.Bold);
            this.btn_close.ForeColor = System.Drawing.Color.Black;
            this.btn_close.Location = new System.Drawing.Point(235, 30);
            this.btn_close.Margin = new System.Windows.Forms.Padding(2);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(117, 31);
            this.btn_close.TabIndex = 28;
            this.btn_close.Text = "Close";
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // lblDateSales
            // 
            this.lblDateSales.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDateSales.AutoSize = true;
            this.lblDateSales.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.lblDateSales.Location = new System.Drawing.Point(304, 255);
            this.lblDateSales.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDateSales.Name = "lblDateSales";
            this.lblDateSales.Size = new System.Drawing.Size(82, 19);
            this.lblDateSales.TabIndex = 68;
            this.lblDateSales.Text = "Sales Date";
            // 
            // lbQtyPruduct
            // 
            this.lbQtyPruduct.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbQtyPruduct.AutoSize = true;
            this.lbQtyPruduct.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.lbQtyPruduct.Location = new System.Drawing.Point(578, 255);
            this.lbQtyPruduct.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbQtyPruduct.Name = "lbQtyPruduct";
            this.lbQtyPruduct.Size = new System.Drawing.Size(89, 19);
            this.lbQtyPruduct.TabIndex = 66;
            this.lbQtyPruduct.Text = "Qty Pruduct";
            // 
            // lblIdProduct
            // 
            this.lblIdProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblIdProduct.AutoSize = true;
            this.lblIdProduct.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.lblIdProduct.Location = new System.Drawing.Point(59, 255);
            this.lblIdProduct.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblIdProduct.Name = "lblIdProduct";
            this.lblIdProduct.Size = new System.Drawing.Size(82, 19);
            this.lblIdProduct.TabIndex = 64;
            this.lblIdProduct.Text = "ID Product";
            // 
            // lblIdCustomer
            // 
            this.lblIdCustomer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblIdCustomer.AutoSize = true;
            this.lblIdCustomer.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.lblIdCustomer.Location = new System.Drawing.Point(579, 123);
            this.lblIdCustomer.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblIdCustomer.Name = "lblIdCustomer";
            this.lblIdCustomer.Size = new System.Drawing.Size(96, 19);
            this.lblIdCustomer.TabIndex = 62;
            this.lblIdCustomer.Text = "ID Customer";
            // 
            // lblIDSales
            // 
            this.lblIDSales.AutoSize = true;
            this.lblIDSales.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIDSales.Location = new System.Drawing.Point(59, 124);
            this.lblIDSales.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblIDSales.Name = "lblIDSales";
            this.lblIDSales.Size = new System.Drawing.Size(83, 19);
            this.lblIDSales.TabIndex = 60;
            this.lblIDSales.Text = "ID Cahsier";
            // 
            // lbl_judul_add_sales
            // 
            this.lbl_judul_add_sales.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_judul_add_sales.AutoSize = true;
            this.lbl_judul_add_sales.BackColor = System.Drawing.Color.AliceBlue;
            this.lbl_judul_add_sales.Font = new System.Drawing.Font("Hobo Std", 18F, System.Drawing.FontStyle.Bold);
            this.lbl_judul_add_sales.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(64)))), ((int)(((byte)(103)))));
            this.lbl_judul_add_sales.Location = new System.Drawing.Point(308, 30);
            this.lbl_judul_add_sales.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_judul_add_sales.Name = "lbl_judul_add_sales";
            this.lbl_judul_add_sales.Size = new System.Drawing.Size(225, 34);
            this.lbl_judul_add_sales.TabIndex = 99;
            this.lbl_judul_add_sales.Text = "ADD DATA SALES";
            // 
            // cmb_cashier
            // 
            this.cmb_cashier.BackColor = System.Drawing.Color.Transparent;
            this.cmb_cashier.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.cmb_cashier.BorderRadius = 10;
            this.cmb_cashier.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmb_cashier.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_cashier.FillColor = System.Drawing.SystemColors.Control;
            this.cmb_cashier.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmb_cashier.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmb_cashier.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmb_cashier.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmb_cashier.ItemHeight = 20;
            this.cmb_cashier.Location = new System.Drawing.Point(53, 156);
            this.cmb_cashier.Name = "cmb_cashier";
            this.cmb_cashier.Size = new System.Drawing.Size(176, 26);
            this.cmb_cashier.TabIndex = 101;
            // 
            // txt_qty_product
            // 
            this.txt_qty_product.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_qty_product.AutoRoundedCorners = true;
            this.txt_qty_product.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.txt_qty_product.BorderRadius = 11;
            this.txt_qty_product.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_qty_product.DefaultText = "";
            this.txt_qty_product.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_qty_product.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_qty_product.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_qty_product.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_qty_product.FillColor = System.Drawing.SystemColors.Control;
            this.txt_qty_product.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_qty_product.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_qty_product.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_qty_product.Location = new System.Drawing.Point(572, 287);
            this.txt_qty_product.Name = "txt_qty_product";
            this.txt_qty_product.PlaceholderText = "";
            this.txt_qty_product.SelectedText = "";
            this.txt_qty_product.Size = new System.Drawing.Size(176, 25);
            this.txt_qty_product.TabIndex = 67;
            // 
            // cmb_customer
            // 
            this.cmb_customer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmb_customer.BackColor = System.Drawing.Color.Transparent;
            this.cmb_customer.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.cmb_customer.BorderRadius = 10;
            this.cmb_customer.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmb_customer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_customer.FillColor = System.Drawing.SystemColors.Control;
            this.cmb_customer.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmb_customer.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmb_customer.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmb_customer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmb_customer.ItemHeight = 20;
            this.cmb_customer.Location = new System.Drawing.Point(572, 156);
            this.cmb_customer.Name = "cmb_customer";
            this.cmb_customer.Size = new System.Drawing.Size(176, 26);
            this.cmb_customer.TabIndex = 102;
            // 
            // cmb_product
            // 
            this.cmb_product.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cmb_product.BackColor = System.Drawing.Color.Transparent;
            this.cmb_product.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.cmb_product.BorderRadius = 10;
            this.cmb_product.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmb_product.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_product.FillColor = System.Drawing.SystemColors.Control;
            this.cmb_product.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmb_product.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmb_product.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmb_product.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmb_product.ItemHeight = 20;
            this.cmb_product.Location = new System.Drawing.Point(53, 287);
            this.cmb_product.Name = "cmb_product";
            this.cmb_product.Size = new System.Drawing.Size(176, 26);
            this.cmb_product.TabIndex = 103;
            // 
            // picture_box_sales
            // 
            this.picture_box_sales.Anchor = System.Windows.Forms.AnchorStyles.Top;
            //this.picture_box_sales.Image = global::toko_sepatu.Properties.Resources.icons8_add_product_50;
            this.picture_box_sales.ImageRotate = 0F;
            this.picture_box_sales.Location = new System.Drawing.Point(270, 30);
            this.picture_box_sales.Name = "picture_box_sales";
            this.picture_box_sales.Size = new System.Drawing.Size(33, 35);
            this.picture_box_sales.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picture_box_sales.TabIndex = 141;
            this.picture_box_sales.TabStop = false;
            // 
            // picture_box_uang_numpuk
            // 
            this.picture_box_uang_numpuk.Anchor = System.Windows.Forms.AnchorStyles.None;
            //this.picture_box_uang_numpuk.Image = global::toko_sepatu.Properties.Resources.icons8_sales_50__1_;
            this.picture_box_uang_numpuk.ImageRotate = 0F;
            this.picture_box_uang_numpuk.Location = new System.Drawing.Point(407, 170);
            this.picture_box_uang_numpuk.Margin = new System.Windows.Forms.Padding(2);
            this.picture_box_uang_numpuk.Name = "picture_box_uang_numpuk";
            this.picture_box_uang_numpuk.Size = new System.Drawing.Size(54, 58);
            this.picture_box_uang_numpuk.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picture_box_uang_numpuk.TabIndex = 100;
            this.picture_box_uang_numpuk.TabStop = false;
            // 
            // picture_box_dolar
            // 
            this.picture_box_dolar.Anchor = System.Windows.Forms.AnchorStyles.None;
            //this.picture_box_dolar.Image = global::toko_sepatu.Properties.Resources.icons8_sales_50;
            this.picture_box_dolar.ImageRotate = 0F;
            this.picture_box_dolar.Location = new System.Drawing.Point(318, 156);
            this.picture_box_dolar.Margin = new System.Windows.Forms.Padding(2);
            this.picture_box_dolar.Name = "picture_box_dolar";
            this.picture_box_dolar.Size = new System.Drawing.Size(69, 72);
            this.picture_box_dolar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picture_box_dolar.TabIndex = 70;
            this.picture_box_dolar.TabStop = false;
            // 
            // AddSales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(800, 469);
            this.Controls.Add(this.picture_box_sales);
            this.Controls.Add(this.cmb_product);
            this.Controls.Add(this.cmb_customer);
            this.Controls.Add(this.cmb_cashier);
            this.Controls.Add(this.picture_box_uang_numpuk);
            this.Controls.Add(this.lbl_judul_add_sales);
            this.Controls.Add(this.dtp_date);
            this.Controls.Add(this.picture_box_dolar);
            this.Controls.Add(this.gpn_add_sales);
            this.Controls.Add(this.lblDateSales);
            this.Controls.Add(this.txt_qty_product);
            this.Controls.Add(this.lbQtyPruduct);
            this.Controls.Add(this.lblIdProduct);
            this.Controls.Add(this.lblIdCustomer);
            this.Controls.Add(this.lblIDSales);
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "AddSales";
            this.Text = "Add Sales";
            this.Load += new System.EventHandler(this.AddSales_Load);
            this.gpn_add_sales.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picture_box_sales)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_box_uang_numpuk)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_box_dolar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2DateTimePicker dtp_date;
        private Guna.UI2.WinForms.Guna2PictureBox picture_box_dolar;
        private Guna.UI2.WinForms.Guna2Panel gpn_add_sales;
        private Guna.UI2.WinForms.Guna2Button btn_save;
        private Guna.UI2.WinForms.Guna2Button btn_close;
        private System.Windows.Forms.Label lblDateSales;
        private System.Windows.Forms.Label lbQtyPruduct;
        private System.Windows.Forms.Label lblIdProduct;
        private System.Windows.Forms.Label lblIdCustomer;
        private System.Windows.Forms.Label lblIDSales;
        private System.Windows.Forms.Label lbl_judul_add_sales;
        private Guna.UI2.WinForms.Guna2PictureBox picture_box_uang_numpuk;
        private Guna.UI2.WinForms.Guna2ComboBox cmb_product;
        private Guna.UI2.WinForms.Guna2ComboBox cmb_customer;
        private Guna.UI2.WinForms.Guna2ComboBox cmb_cashier;
        private Guna.UI2.WinForms.Guna2TextBox txt_qty_product;
        private Guna.UI2.WinForms.Guna2PictureBox picture_box_sales;
    }
}