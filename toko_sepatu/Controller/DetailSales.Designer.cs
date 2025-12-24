namespace toko_sepatu.View
{
    partial class DetailSales
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgv_detail = new Guna.UI2.WinForms.Guna2DataGridView();
            this.dtp_date = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.txt_search_detail = new Guna.UI2.WinForms.Guna2TextBox();
            this.lbl_sales = new System.Windows.Forms.Label();
            this.sprGaris = new Guna.UI2.WinForms.Guna2Separator();
            this.picture_box_detail_sales = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.btn_back = new Guna.UI2.WinForms.Guna2Button();
            this.tbl_layout_detail_sales = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_detail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_box_detail_sales)).BeginInit();
            this.guna2GradientPanel1.SuspendLayout();
            this.tbl_layout_detail_sales.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_detail
            // 
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle7.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(193)))), ((int)(((byte)(214)))));
            this.dgv_detail.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dgv_detail.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(129)))), ((int)(((byte)(168)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(193)))), ((int)(((byte)(214)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_detail.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgv_detail.ColumnHeadersHeight = 40;
            this.dgv_detail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(193)))), ((int)(((byte)(214)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_detail.DefaultCellStyle = dataGridViewCellStyle9;
            this.dgv_detail.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_detail.Location = new System.Drawing.Point(3, 3);
            this.dgv_detail.Name = "dgv_detail";
            this.dgv_detail.RowHeadersVisible = false;
            this.dgv_detail.Size = new System.Drawing.Size(746, 204);
            this.dgv_detail.TabIndex = 0;
            this.dgv_detail.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_detail.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgv_detail.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgv_detail.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgv_detail.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgv_detail.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgv_detail.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_detail.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgv_detail.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_detail.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_detail.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgv_detail.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgv_detail.ThemeStyle.HeaderStyle.Height = 40;
            this.dgv_detail.ThemeStyle.ReadOnly = false;
            this.dgv_detail.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_detail.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_detail.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_detail.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgv_detail.ThemeStyle.RowsStyle.Height = 22;
            this.dgv_detail.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_detail.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // dtp_date
            // 
            this.dtp_date.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtp_date.AutoRoundedCorners = true;
            this.dtp_date.BackColor = System.Drawing.Color.AliceBlue;
            this.dtp_date.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.dtp_date.BorderRadius = 12;
            this.dtp_date.BorderThickness = 1;
            this.dtp_date.Checked = true;
            this.dtp_date.FillColor = System.Drawing.SystemColors.ControlLightLight;
            this.dtp_date.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtp_date.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtp_date.Location = new System.Drawing.Point(577, 94);
            this.dtp_date.Margin = new System.Windows.Forms.Padding(2);
            this.dtp_date.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtp_date.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtp_date.Name = "dtp_date";
            this.dtp_date.Size = new System.Drawing.Size(199, 27);
            this.dtp_date.TabIndex = 137;
            this.dtp_date.Value = new System.DateTime(2024, 11, 28, 9, 39, 44, 43);
            this.dtp_date.ValueChanged += new System.EventHandler(this.dtp_date_ValueChanged);
            // 
            // txt_search_detail
            // 
            this.txt_search_detail.AutoRoundedCorners = true;
            this.txt_search_detail.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.txt_search_detail.BorderRadius = 12;
            this.txt_search_detail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_search_detail.DefaultText = "";
            this.txt_search_detail.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_search_detail.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_search_detail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_search_detail.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_search_detail.FillColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txt_search_detail.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_search_detail.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_search_detail.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            //this.txt_search_detail.IconRight = global::toko_sepatu.Properties.Resources.icons8_search_50;
            this.txt_search_detail.Location = new System.Drawing.Point(24, 94);
            this.txt_search_detail.Name = "txt_search_detail";
            this.txt_search_detail.PlaceholderForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.txt_search_detail.PlaceholderText = "Search";
            this.txt_search_detail.SelectedText = "";
            this.txt_search_detail.Size = new System.Drawing.Size(199, 27);
            this.txt_search_detail.TabIndex = 136;
            this.txt_search_detail.TextChanged += new System.EventHandler(this.txt_search_detail_TextChanged);
            // 
            // lbl_sales
            // 
            this.lbl_sales.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_sales.AutoSize = true;
            this.lbl_sales.Font = new System.Drawing.Font("Hobo Std", 18F, System.Drawing.FontStyle.Bold);
            this.lbl_sales.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(64)))), ((int)(((byte)(103)))));
            this.lbl_sales.Location = new System.Drawing.Point(313, 15);
            this.lbl_sales.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_sales.Name = "lbl_sales";
            this.lbl_sales.Size = new System.Drawing.Size(186, 34);
            this.lbl_sales.TabIndex = 133;
            this.lbl_sales.Text = "DETAIL SALES";
            // 
            // sprGaris
            // 
            this.sprGaris.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sprGaris.FillColor = System.Drawing.SystemColors.ActiveCaption;
            this.sprGaris.FillThickness = 5;
            this.sprGaris.Location = new System.Drawing.Point(22, 133);
            this.sprGaris.Margin = new System.Windows.Forms.Padding(2);
            this.sprGaris.Name = "sprGaris";
            this.sprGaris.Size = new System.Drawing.Size(754, 10);
            this.sprGaris.TabIndex = 131;
            // 
            // picture_box_detail_sales
            // 
            this.picture_box_detail_sales.Anchor = System.Windows.Forms.AnchorStyles.Top;
            //this.picture_box_detail_sales.Image = global::toko_sepatu.Properties.Resources.icons8_add_product_50;
            this.picture_box_detail_sales.ImageRotate = 0F;
            this.picture_box_detail_sales.Location = new System.Drawing.Point(279, 14);
            this.picture_box_detail_sales.Name = "picture_box_detail_sales";
            this.picture_box_detail_sales.Size = new System.Drawing.Size(33, 35);
            this.picture_box_detail_sales.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picture_box_detail_sales.TabIndex = 142;
            this.picture_box_detail_sales.TabStop = false;
            // 
            // guna2GradientPanel1
            // 
            this.guna2GradientPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2GradientPanel1.Controls.Add(this.btn_back);
            this.guna2GradientPanel1.FillColor2 = System.Drawing.SystemColors.ActiveCaption;
            this.guna2GradientPanel1.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal;
            this.guna2GradientPanel1.Location = new System.Drawing.Point(-5, 373);
            this.guna2GradientPanel1.Name = "guna2GradientPanel1";
            this.guna2GradientPanel1.Size = new System.Drawing.Size(813, 82);
            this.guna2GradientPanel1.TabIndex = 143;
            // 
            // btn_back
            // 
            this.btn_back.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_back.BackColor = System.Drawing.Color.Transparent;
            this.btn_back.BorderColor = System.Drawing.Color.Transparent;
            this.btn_back.BorderRadius = 10;
            this.btn_back.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_back.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_back.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_back.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_back.FillColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btn_back.Font = new System.Drawing.Font("Rosewood Std Regular", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_back.ForeColor = System.Drawing.Color.Black;
            this.btn_back.HoverState.FillColor = System.Drawing.SystemColors.GradientActiveCaption;
            //this.btn_back.Image = global::toko_sepatu.Properties.Resources.icons8_back_50;
            this.btn_back.ImageSize = new System.Drawing.Size(35, 35);
            this.btn_back.Location = new System.Drawing.Point(19, 22);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(54, 47);
            this.btn_back.TabIndex = 130;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // tbl_layout_detail_sales
            // 
            this.tbl_layout_detail_sales.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbl_layout_detail_sales.ColumnCount = 1;
            this.tbl_layout_detail_sales.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbl_layout_detail_sales.Controls.Add(this.dgv_detail, 0, 0);
            this.tbl_layout_detail_sales.Location = new System.Drawing.Point(22, 142);
            this.tbl_layout_detail_sales.Name = "tbl_layout_detail_sales";
            this.tbl_layout_detail_sales.RowCount = 1;
            this.tbl_layout_detail_sales.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbl_layout_detail_sales.Size = new System.Drawing.Size(752, 210);
            this.tbl_layout_detail_sales.TabIndex = 144;
            // 
            // DetailSales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbl_layout_detail_sales);
            this.Controls.Add(this.guna2GradientPanel1);
            this.Controls.Add(this.picture_box_detail_sales);
            this.Controls.Add(this.dtp_date);
            this.Controls.Add(this.txt_search_detail);
            this.Controls.Add(this.lbl_sales);
            this.Controls.Add(this.sprGaris);
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "DetailSales";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Detail Sales";
            this.Load += new System.EventHandler(this.DetailSales_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_detail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_box_detail_sales)).EndInit();
            this.guna2GradientPanel1.ResumeLayout(false);
            this.tbl_layout_detail_sales.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2DataGridView dgv_detail;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtp_date;
        private Guna.UI2.WinForms.Guna2TextBox txt_search_detail;
        private System.Windows.Forms.Label lbl_sales;
        private Guna.UI2.WinForms.Guna2Separator sprGaris;
        private Guna.UI2.WinForms.Guna2PictureBox picture_box_detail_sales;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
        private Guna.UI2.WinForms.Guna2Button btn_back;
        private System.Windows.Forms.TableLayoutPanel tbl_layout_detail_sales;
    }
}