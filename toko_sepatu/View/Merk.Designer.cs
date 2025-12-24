namespace toko_sepatu.View
{
    partial class Merk
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txt_search_merk = new Guna.UI2.WinForms.Guna2TextBox();
            this.spr_batas = new Guna.UI2.WinForms.Guna2Separator();
            this.dgv_merk = new Guna.UI2.WinForms.Guna2DataGridView();
            this.gpn_judul_merk = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.lbl_judul_customer2 = new System.Windows.Forms.Label();
            this.lbl_judul_customer = new System.Windows.Forms.Label();
            this.gpn_sidebar_customer = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.btn_delete_merk = new Guna.UI2.WinForms.Guna2Button();
            this.btn_add_merk = new Guna.UI2.WinForms.Guna2Button();
            this.btn_update_merk = new Guna.UI2.WinForms.Guna2Button();
            this.btnBack = new Guna.UI2.WinForms.Guna2Button();
            this.tbl_layout_merk = new System.Windows.Forms.TableLayoutPanel();
            this.ms_merk = new Guna.UI2.WinForms.Guna2MessageDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_merk)).BeginInit();
            this.gpn_judul_merk.SuspendLayout();
            this.gpn_sidebar_customer.SuspendLayout();
            this.tbl_layout_merk.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_search_merk
            // 
            this.txt_search_merk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_search_merk.AutoRoundedCorners = true;
            this.txt_search_merk.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.txt_search_merk.BorderRadius = 12;
            this.txt_search_merk.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_search_merk.DefaultText = "";
            this.txt_search_merk.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_search_merk.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_search_merk.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_search_merk.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_search_merk.FillColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txt_search_merk.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_search_merk.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_search_merk.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.txt_search_merk.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            //this.txt_search_merk.IconRight = global::toko_sepatu.Properties.Resources.icons8_search_50;
            this.txt_search_merk.Location = new System.Drawing.Point(484, 122);
            this.txt_search_merk.Name = "txt_search_merk";
            this.txt_search_merk.PlaceholderForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.txt_search_merk.PlaceholderText = "Search";
            this.txt_search_merk.SelectedText = "";
            this.txt_search_merk.Size = new System.Drawing.Size(256, 27);
            this.txt_search_merk.TabIndex = 18;
            this.txt_search_merk.TextChanged += new System.EventHandler(this.txt_search_merk_TextChanged);
            // 
            // spr_batas
            // 
            this.spr_batas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.spr_batas.FillColor = System.Drawing.SystemColors.ActiveCaption;
            this.spr_batas.FillThickness = 5;
            this.spr_batas.Location = new System.Drawing.Point(243, 154);
            this.spr_batas.Margin = new System.Windows.Forms.Padding(2);
            this.spr_batas.Name = "spr_batas";
            this.spr_batas.Size = new System.Drawing.Size(497, 10);
            this.spr_batas.TabIndex = 10;
            // 
            // dgv_merk
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgv_merk.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_merk.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(129)))), ((int)(((byte)(168)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(193)))), ((int)(((byte)(214)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_merk.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_merk.ColumnHeadersHeight = 40;
            this.dgv_merk.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_merk.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_merk.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_merk.Location = new System.Drawing.Point(2, 2);
            this.dgv_merk.Margin = new System.Windows.Forms.Padding(2);
            this.dgv_merk.Name = "dgv_merk";
            this.dgv_merk.RowHeadersVisible = false;
            this.dgv_merk.RowHeadersWidth = 62;
            this.dgv_merk.RowTemplate.Height = 28;
            this.dgv_merk.Size = new System.Drawing.Size(493, 272);
            this.dgv_merk.TabIndex = 15;
            this.dgv_merk.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_merk.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgv_merk.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgv_merk.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgv_merk.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgv_merk.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgv_merk.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_merk.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgv_merk.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_merk.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_merk.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgv_merk.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgv_merk.ThemeStyle.HeaderStyle.Height = 40;
            this.dgv_merk.ThemeStyle.ReadOnly = false;
            this.dgv_merk.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_merk.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_merk.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_merk.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgv_merk.ThemeStyle.RowsStyle.Height = 28;
            this.dgv_merk.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_merk.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgv_merk.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_merk_CellContentClick);
            // 
            // gpn_judul_merk
            // 
            this.gpn_judul_merk.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gpn_judul_merk.Controls.Add(this.lbl_judul_customer2);
            this.gpn_judul_merk.Controls.Add(this.lbl_judul_customer);
            this.gpn_judul_merk.FillColor2 = System.Drawing.SystemColors.ActiveCaption;
            this.gpn_judul_merk.Location = new System.Drawing.Point(-1, 0);
            this.gpn_judul_merk.Name = "gpn_judul_merk";
            this.gpn_judul_merk.Size = new System.Drawing.Size(804, 75);
            this.gpn_judul_merk.TabIndex = 36;
            // 
            // lbl_judul_customer2
            // 
            this.lbl_judul_customer2.AutoSize = true;
            this.lbl_judul_customer2.BackColor = System.Drawing.Color.Transparent;
            this.lbl_judul_customer2.Font = new System.Drawing.Font("Hobo Std", 18F, System.Drawing.FontStyle.Bold);
            this.lbl_judul_customer2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(64)))), ((int)(((byte)(103)))));
            this.lbl_judul_customer2.Location = new System.Drawing.Point(93, 38);
            this.lbl_judul_customer2.Name = "lbl_judul_customer2";
            this.lbl_judul_customer2.Size = new System.Drawing.Size(93, 34);
            this.lbl_judul_customer2.TabIndex = 37;
            this.lbl_judul_customer2.Text = "L I S T";
            // 
            // lbl_judul_customer
            // 
            this.lbl_judul_customer.AutoSize = true;
            this.lbl_judul_customer.BackColor = System.Drawing.Color.Transparent;
            this.lbl_judul_customer.Font = new System.Drawing.Font("Hobo Std", 18F, System.Drawing.FontStyle.Bold);
            this.lbl_judul_customer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(64)))), ((int)(((byte)(103)))));
            this.lbl_judul_customer.Location = new System.Drawing.Point(33, 8);
            this.lbl_judul_customer.Name = "lbl_judul_customer";
            this.lbl_judul_customer.Size = new System.Drawing.Size(108, 34);
            this.lbl_judul_customer.TabIndex = 36;
            this.lbl_judul_customer.Text = "M E R K";
            // 
            // gpn_sidebar_customer
            // 
            this.gpn_sidebar_customer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.gpn_sidebar_customer.BackColor = System.Drawing.Color.AliceBlue;
            this.gpn_sidebar_customer.Controls.Add(this.btnBack);
            this.gpn_sidebar_customer.Controls.Add(this.btn_delete_merk);
            this.gpn_sidebar_customer.Controls.Add(this.btn_add_merk);
            this.gpn_sidebar_customer.Controls.Add(this.btn_update_merk);
            this.gpn_sidebar_customer.FillColor = System.Drawing.Color.AliceBlue;
            this.gpn_sidebar_customer.FillColor2 = System.Drawing.SystemColors.ActiveCaption;
            this.gpn_sidebar_customer.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gpn_sidebar_customer.Location = new System.Drawing.Point(1, 75);
            this.gpn_sidebar_customer.Name = "gpn_sidebar_customer";
            this.gpn_sidebar_customer.Size = new System.Drawing.Size(169, 382);
            this.gpn_sidebar_customer.TabIndex = 37;
            // 
            // btn_delete_merk
            // 
            this.btn_delete_merk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_delete_merk.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_delete_merk.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.btn_delete_merk.BorderStyle = System.Drawing.Drawing2D.DashStyle.DashDot;
            this.btn_delete_merk.BorderThickness = 1;
            this.btn_delete_merk.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_delete_merk.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_delete_merk.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_delete_merk.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_delete_merk.FillColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btn_delete_merk.Font = new System.Drawing.Font("Rosewood Std Regular", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete_merk.ForeColor = System.Drawing.Color.Black;
            this.btn_delete_merk.HoverState.FillColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn_delete_merk.Location = new System.Drawing.Point(26, 247);
            this.btn_delete_merk.Margin = new System.Windows.Forms.Padding(2);
            this.btn_delete_merk.Name = "btn_delete_merk";
            this.btn_delete_merk.Size = new System.Drawing.Size(124, 42);
            this.btn_delete_merk.TabIndex = 32;
            this.btn_delete_merk.Text = "DELETE";
            this.btn_delete_merk.Click += new System.EventHandler(this.btn_delete_merk_Click);
            // 
            // btn_add_merk
            // 
            this.btn_add_merk.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_add_merk.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.btn_add_merk.BorderStyle = System.Drawing.Drawing2D.DashStyle.DashDot;
            this.btn_add_merk.BorderThickness = 1;
            this.btn_add_merk.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_add_merk.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_add_merk.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_add_merk.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_add_merk.FillColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_add_merk.Font = new System.Drawing.Font("Rosewood Std Regular", 12F, System.Drawing.FontStyle.Bold);
            this.btn_add_merk.ForeColor = System.Drawing.Color.Black;
            this.btn_add_merk.HoverState.FillColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn_add_merk.Location = new System.Drawing.Point(26, 58);
            this.btn_add_merk.Margin = new System.Windows.Forms.Padding(2);
            this.btn_add_merk.Name = "btn_add_merk";
            this.btn_add_merk.Size = new System.Drawing.Size(124, 42);
            this.btn_add_merk.TabIndex = 30;
            this.btn_add_merk.Text = "ADD";
            this.btn_add_merk.Click += new System.EventHandler(this.btn_add_merk_Click);
            // 
            // btn_update_merk
            // 
            this.btn_update_merk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_update_merk.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn_update_merk.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.btn_update_merk.BorderStyle = System.Drawing.Drawing2D.DashStyle.DashDot;
            this.btn_update_merk.BorderThickness = 1;
            this.btn_update_merk.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_update_merk.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_update_merk.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_update_merk.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_update_merk.FillColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn_update_merk.Font = new System.Drawing.Font("Rosewood Std Regular", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_update_merk.ForeColor = System.Drawing.Color.Black;
            this.btn_update_merk.HoverState.FillColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_update_merk.Location = new System.Drawing.Point(26, 155);
            this.btn_update_merk.Margin = new System.Windows.Forms.Padding(2);
            this.btn_update_merk.Name = "btn_update_merk";
            this.btn_update_merk.Size = new System.Drawing.Size(124, 42);
            this.btn_update_merk.TabIndex = 31;
            this.btn_update_merk.Text = "UPDATE";
            this.btn_update_merk.Click += new System.EventHandler(this.btn_update_merk_Click);
            // 
            // btnBack
            // 
            this.btnBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnBack.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnBack.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnBack.BorderRadius = 10;
            this.btnBack.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnBack.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnBack.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnBack.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnBack.FillColor = System.Drawing.SystemColors.Control;
            this.btnBack.Font = new System.Drawing.Font("Rosewood Std Regular", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.Black;
            this.btnBack.HoverState.FillColor = System.Drawing.SystemColors.GradientInactiveCaption;
            //this.btnBack.Image = global::toko_sepatu.Properties.Resources.icons8_back_50;
            this.btnBack.ImageSize = new System.Drawing.Size(35, 35);
            this.btnBack.Location = new System.Drawing.Point(26, 318);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(60, 45);
            this.btnBack.TabIndex = 132;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // tbl_layout_merk
            // 
            this.tbl_layout_merk.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbl_layout_merk.ColumnCount = 1;
            this.tbl_layout_merk.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbl_layout_merk.Controls.Add(this.dgv_merk, 0, 0);
            this.tbl_layout_merk.Location = new System.Drawing.Point(243, 162);
            this.tbl_layout_merk.Name = "tbl_layout_merk";
            this.tbl_layout_merk.RowCount = 1;
            this.tbl_layout_merk.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbl_layout_merk.Size = new System.Drawing.Size(497, 276);
            this.tbl_layout_merk.TabIndex = 38;
            // 
            // ms_merk
            // 
            this.ms_merk.Buttons = Guna.UI2.WinForms.MessageDialogButtons.YesNo;
            this.ms_merk.Caption = null;
            this.ms_merk.Icon = Guna.UI2.WinForms.MessageDialogIcon.None;
            this.ms_merk.Parent = this;
            this.ms_merk.Style = Guna.UI2.WinForms.MessageDialogStyle.Default;
            this.ms_merk.Text = null;
            // 
            // Merk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbl_layout_merk);
            this.Controls.Add(this.gpn_sidebar_customer);
            this.Controls.Add(this.gpn_judul_merk);
            this.Controls.Add(this.txt_search_merk);
            this.Controls.Add(this.spr_batas);
            this.MinimumSize = new System.Drawing.Size(689, 425);
            this.Name = "Merk";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Merk List";
            this.Load += new System.EventHandler(this.Merk_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_merk)).EndInit();
            this.gpn_judul_merk.ResumeLayout(false);
            this.gpn_judul_merk.PerformLayout();
            this.gpn_sidebar_customer.ResumeLayout(false);
            this.tbl_layout_merk.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox txt_search_merk;
        private Guna.UI2.WinForms.Guna2Separator spr_batas;
        private Guna.UI2.WinForms.Guna2DataGridView dgv_merk;
        private Guna.UI2.WinForms.Guna2GradientPanel gpn_judul_merk;
        private System.Windows.Forms.Label lbl_judul_customer2;
        private System.Windows.Forms.Label lbl_judul_customer;
        private Guna.UI2.WinForms.Guna2GradientPanel gpn_sidebar_customer;
        private Guna.UI2.WinForms.Guna2Button btn_delete_merk;
        private Guna.UI2.WinForms.Guna2Button btn_add_merk;
        private Guna.UI2.WinForms.Guna2Button btn_update_merk;
        private Guna.UI2.WinForms.Guna2Button btnBack;
        private System.Windows.Forms.TableLayoutPanel tbl_layout_merk;
        private Guna.UI2.WinForms.Guna2MessageDialog ms_merk;
    }
}