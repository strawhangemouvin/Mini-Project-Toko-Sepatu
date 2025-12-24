namespace toko_sepatu.View
{
    partial class Signup
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
            this.btn_signup = new Guna.UI2.WinForms.Guna2Button();
            this.lbl_login = new System.Windows.Forms.Label();
            this.lbl_question_signin = new System.Windows.Forms.Label();
            this.link_signin = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.cb_signup = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lbl_register_as = new System.Windows.Forms.Label();
            this.picture_box_merem = new Guna.UI2.WinForms.Guna2PictureBox();
            this.picture_box_melek = new Guna.UI2.WinForms.Guna2PictureBox();
            this.txt_pass_signup = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_user_signup = new Guna.UI2.WinForms.Guna2TextBox();
            this.picture_box_signup = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picture_box_merem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_box_melek)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_box_signup)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_signup
            // 
            this.btn_signup.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_signup.BorderRadius = 10;
            this.btn_signup.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_signup.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_signup.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_signup.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_signup.FillColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn_signup.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_signup.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btn_signup.HoverState.FillColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_signup.Location = new System.Drawing.Point(578, 310);
            this.btn_signup.Name = "btn_signup";
            this.btn_signup.Size = new System.Drawing.Size(80, 28);
            this.btn_signup.TabIndex = 115;
            this.btn_signup.Text = "Sign Up";
            this.btn_signup.Click += new System.EventHandler(this.btn_signup_Click);
            // 
            // lbl_login
            // 
            this.lbl_login.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_login.AutoSize = true;
            this.lbl_login.BackColor = System.Drawing.Color.AliceBlue;
            this.lbl_login.Font = new System.Drawing.Font("Jokerman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_login.Location = new System.Drawing.Point(562, 71);
            this.lbl_login.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_login.Name = "lbl_login";
            this.lbl_login.Size = new System.Drawing.Size(124, 35);
            this.lbl_login.TabIndex = 112;
            this.lbl_login.Text = "SIGN UP";
            // 
            // lbl_question_signin
            // 
            this.lbl_question_signin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_question_signin.AutoSize = true;
            this.lbl_question_signin.Font = new System.Drawing.Font("Sitka Display", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_question_signin.Location = new System.Drawing.Point(531, 360);
            this.lbl_question_signin.Name = "lbl_question_signin";
            this.lbl_question_signin.Size = new System.Drawing.Size(141, 19);
            this.lbl_question_signin.TabIndex = 116;
            this.lbl_question_signin.Text = "already have an account?";
            // 
            // link_signin
            // 
            this.link_signin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.link_signin.BackColor = System.Drawing.Color.Transparent;
            this.link_signin.Font = new System.Drawing.Font("Sitka Display", 9.749999F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.link_signin.IsSelectionEnabled = false;
            this.link_signin.Location = new System.Drawing.Point(668, 359);
            this.link_signin.Name = "link_signin";
            this.link_signin.Size = new System.Drawing.Size(39, 21);
            this.link_signin.TabIndex = 117;
            this.link_signin.Text = "Sign In";
            this.link_signin.Click += new System.EventHandler(this.link_signin_Click);
            this.link_signin.MouseEnter += new System.EventHandler(this.link_signin_MouseEnter);
            this.link_signin.MouseLeave += new System.EventHandler(this.link_signin_MouseLeave);
            // 
            // cb_signup
            // 
            this.cb_signup.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cb_signup.BackColor = System.Drawing.Color.Transparent;
            this.cb_signup.BorderRadius = 10;
            this.cb_signup.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            this.cb_signup.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cb_signup.DropDownHeight = 150;
            this.cb_signup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_signup.FocusedColor = System.Drawing.SystemColors.ActiveCaption;
            this.cb_signup.FocusedState.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.cb_signup.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cb_signup.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cb_signup.IntegralHeight = false;
            this.cb_signup.ItemHeight = 30;
            this.cb_signup.Location = new System.Drawing.Point(494, 252);
            this.cb_signup.MaxDropDownItems = 2;
            this.cb_signup.Name = "cb_signup";
            this.cb_signup.Size = new System.Drawing.Size(242, 36);
            this.cb_signup.TabIndex = 123;
            this.cb_signup.TextTransform = Guna.UI2.WinForms.Enums.TextTransform.LowerCase;
            // 
            // lbl_register_as
            // 
            this.lbl_register_as.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_register_as.AutoSize = true;
            this.lbl_register_as.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_register_as.Location = new System.Drawing.Point(496, 234);
            this.lbl_register_as.Name = "lbl_register_as";
            this.lbl_register_as.Size = new System.Drawing.Size(66, 15);
            this.lbl_register_as.TabIndex = 124;
            this.lbl_register_as.Text = "Register as";
            // 
            // picture_box_merem
            // 
            this.picture_box_merem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picture_box_merem.BackColor = System.Drawing.Color.White;
            this.picture_box_merem.ImageRotate = 0F;
            this.picture_box_merem.Location = new System.Drawing.Point(705, 190);
            this.picture_box_merem.Name = "picture_box_merem";
            this.picture_box_merem.Size = new System.Drawing.Size(28, 26);
            this.picture_box_merem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picture_box_merem.TabIndex = 122;
            this.picture_box_merem.TabStop = false;
            this.picture_box_merem.Click += new System.EventHandler(this.picture_box_merem_Click);
            // 
            // picture_box_melek
            // 
            this.picture_box_melek.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.picture_box_melek.BackColor = System.Drawing.Color.White;
            this.picture_box_melek.ImageRotate = 0F;
            this.picture_box_melek.Location = new System.Drawing.Point(708, 189);
            this.picture_box_melek.Name = "picture_box_melek";
            this.picture_box_melek.Size = new System.Drawing.Size(25, 26);
            this.picture_box_melek.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picture_box_melek.TabIndex = 121;
            this.picture_box_melek.TabStop = false;
            this.picture_box_melek.Click += new System.EventHandler(this.picture_box_melek_Click);
            // 
            // txt_pass_signup
            // 
            this.txt_pass_signup.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_pass_signup.BorderRadius = 10;
            this.txt_pass_signup.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_pass_signup.DefaultText = "";
            this.txt_pass_signup.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_pass_signup.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_pass_signup.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_pass_signup.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_pass_signup.FocusedState.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.txt_pass_signup.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_pass_signup.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_pass_signup.IconLeft = global::toko_sepatu.Properties.Resources.icons8_padlock_50;
            this.txt_pass_signup.IconLeftSize = new System.Drawing.Size(25, 25);
            this.txt_pass_signup.Location = new System.Drawing.Point(491, 185);
            this.txt_pass_signup.Name = "txt_pass_signup";
            this.txt_pass_signup.PasswordChar = '●';
            this.txt_pass_signup.PlaceholderText = "Password";
            this.txt_pass_signup.SelectedText = "";
            this.txt_pass_signup.Size = new System.Drawing.Size(247, 36);
            this.txt_pass_signup.TabIndex = 114;
            // 
            // txt_user_signup
            // 
            this.txt_user_signup.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_user_signup.BorderRadius = 10;
            this.txt_user_signup.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.txt_user_signup.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_user_signup.DefaultText = "";
            this.txt_user_signup.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_user_signup.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_user_signup.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_user_signup.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_user_signup.FocusedState.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.txt_user_signup.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_user_signup.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_user_signup.IconLeft = global::toko_sepatu.Properties.Resources.icons8_account_32;
            this.txt_user_signup.IconLeftSize = new System.Drawing.Size(25, 25);
            this.txt_user_signup.IconRightSize = new System.Drawing.Size(15, 15);
            this.txt_user_signup.Location = new System.Drawing.Point(491, 134);
            this.txt_user_signup.Name = "txt_user_signup";
            this.txt_user_signup.PlaceholderText = "Username";
            this.txt_user_signup.SelectedText = "";
            this.txt_user_signup.Size = new System.Drawing.Size(247, 36);
            this.txt_user_signup.TabIndex = 113;
            this.txt_user_signup.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_user_signup_KeyPress);
            // 
            // picture_box_signup
            // 
            this.picture_box_signup.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.picture_box_signup.Image = global::toko_sepatu.Properties.Resources.fix_slide;
            this.picture_box_signup.Location = new System.Drawing.Point(0, -16);
            this.picture_box_signup.Name = "picture_box_signup";
            this.picture_box_signup.Size = new System.Drawing.Size(418, 511);
            this.picture_box_signup.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picture_box_signup.TabIndex = 110;
            this.picture_box_signup.TabStop = false;
            // 
            // Signup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_register_as);
            this.Controls.Add(this.cb_signup);
            this.Controls.Add(this.picture_box_merem);
            this.Controls.Add(this.picture_box_melek);
            this.Controls.Add(this.link_signin);
            this.Controls.Add(this.lbl_question_signin);
            this.Controls.Add(this.btn_signup);
            this.Controls.Add(this.txt_pass_signup);
            this.Controls.Add(this.txt_user_signup);
            this.Controls.Add(this.lbl_login);
            this.Controls.Add(this.picture_box_signup);
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "Signup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sign Up";
            this.Load += new System.EventHandler(this.Signup_Load);
            this.Click += new System.EventHandler(this.Signup_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picture_box_merem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_box_melek)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_box_signup)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox picture_box_signup;
        private Guna.UI2.WinForms.Guna2Button btn_signup;
        private Guna.UI2.WinForms.Guna2TextBox txt_pass_signup;
        private Guna.UI2.WinForms.Guna2TextBox txt_user_signup;
        private System.Windows.Forms.Label lbl_login;
        private System.Windows.Forms.Label lbl_question_signin;
        private Guna.UI2.WinForms.Guna2PictureBox picture_box_merem;
        private Guna.UI2.WinForms.Guna2PictureBox picture_box_melek;
        private Guna.UI2.WinForms.Guna2HtmlLabel link_signin;
        private Guna.UI2.WinForms.Guna2ComboBox cb_signup;
        private System.Windows.Forms.Label lbl_register_as;
    }
}