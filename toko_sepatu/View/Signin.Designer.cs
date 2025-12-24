namespace toko_sepatu.View
{
    partial class Signin
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
            this.lbl_login = new System.Windows.Forms.Label();
            this.lbl_password = new System.Windows.Forms.Label();
            this.lbl_user = new System.Windows.Forms.Label();
            this.btn_signin = new Guna.UI2.WinForms.Guna2Button();
            this.link_signup = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lbl_question_signup = new System.Windows.Forms.Label();
            this.picture_box_merem = new Guna.UI2.WinForms.Guna2PictureBox();
            this.picture_box_melek = new Guna.UI2.WinForms.Guna2PictureBox();
            this.picture_box_signin = new System.Windows.Forms.PictureBox();
            this.txt_pass_signin = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_user_signin = new Guna.UI2.WinForms.Guna2TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.picture_box_merem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_box_melek)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_box_signin)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_login
            // 
            this.lbl_login.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_login.AutoSize = true;
            this.lbl_login.BackColor = System.Drawing.Color.AliceBlue;
            this.lbl_login.Font = new System.Drawing.Font("Jokerman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_login.Location = new System.Drawing.Point(563, 94);
            this.lbl_login.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_login.Name = "lbl_login";
            this.lbl_login.Size = new System.Drawing.Size(118, 35);
            this.lbl_login.TabIndex = 103;
            this.lbl_login.Text = "SIGN IN";
            // 
            // lbl_password
            // 
            this.lbl_password.AutoSize = true;
            this.lbl_password.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_password.Location = new System.Drawing.Point(181, 193);
            this.lbl_password.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_password.Name = "lbl_password";
            this.lbl_password.Size = new System.Drawing.Size(0, 19);
            this.lbl_password.TabIndex = 100;
            // 
            // lbl_user
            // 
            this.lbl_user.AutoSize = true;
            this.lbl_user.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_user.Location = new System.Drawing.Point(182, 151);
            this.lbl_user.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_user.Name = "lbl_user";
            this.lbl_user.Size = new System.Drawing.Size(0, 19);
            this.lbl_user.TabIndex = 99;
            // 
            // btn_signin
            // 
            this.btn_signin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_signin.BorderRadius = 10;
            this.btn_signin.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_signin.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_signin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_signin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_signin.FillColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn_signin.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_signin.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btn_signin.HoverState.FillColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_signin.Location = new System.Drawing.Point(580, 278);
            this.btn_signin.Name = "btn_signin";
            this.btn_signin.Size = new System.Drawing.Size(102, 30);
            this.btn_signin.TabIndex = 110;
            this.btn_signin.Text = "Sign In";
            this.btn_signin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // link_signup
            // 
            this.link_signup.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.link_signup.BackColor = System.Drawing.Color.Transparent;
            this.link_signup.Font = new System.Drawing.Font("Sitka Display", 9.749999F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.link_signup.IsSelectionEnabled = false;
            this.link_signup.Location = new System.Drawing.Point(679, 320);
            this.link_signup.Name = "link_signup";
            this.link_signup.Size = new System.Drawing.Size(43, 21);
            this.link_signup.TabIndex = 119;
            this.link_signup.Text = "Sign Up";
            this.link_signup.Click += new System.EventHandler(this.link_signup_Click);
            this.link_signup.MouseEnter += new System.EventHandler(this.link_signup_MouseEnter);
            this.link_signup.MouseLeave += new System.EventHandler(this.link_signup_MouseLeave);
            // 
            // lbl_question_signup
            // 
            this.lbl_question_signup.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_question_signup.AutoSize = true;
            this.lbl_question_signup.Font = new System.Drawing.Font("Sitka Display", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_question_signup.Location = new System.Drawing.Point(533, 321);
            this.lbl_question_signup.Name = "lbl_question_signup";
            this.lbl_question_signup.Size = new System.Drawing.Size(149, 19);
            this.lbl_question_signup.TabIndex = 118;
            this.lbl_question_signup.Text = "Don\'t have an account yet?";
            // 
            // picture_box_merem
            // 
            this.picture_box_merem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picture_box_merem.BackColor = System.Drawing.Color.White;
            //this.picture_box_merem.Image = global::toko_sepatu.Properties.Resources.icons8_eye_50__2_;
            this.picture_box_merem.ImageRotate = 0F;
            this.picture_box_merem.Location = new System.Drawing.Point(722, 220);
            this.picture_box_merem.Name = "picture_box_merem";
            this.picture_box_merem.Size = new System.Drawing.Size(27, 29);
            this.picture_box_merem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picture_box_merem.TabIndex = 121;
            this.picture_box_merem.TabStop = false;
            this.picture_box_merem.Click += new System.EventHandler(this.picture_box_merem_Click);
            // 
            // picture_box_melek
            // 
            this.picture_box_melek.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.picture_box_melek.BackColor = System.Drawing.Color.White;
            //this.picture_box_melek.Image = global::toko_sepatu.Properties.Resources.icons8_eye_50;
            this.picture_box_melek.ImageRotate = 0F;
            this.picture_box_melek.Location = new System.Drawing.Point(721, 223);
            this.picture_box_melek.Name = "picture_box_melek";
            this.picture_box_melek.Size = new System.Drawing.Size(28, 26);
            this.picture_box_melek.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picture_box_melek.TabIndex = 120;
            this.picture_box_melek.TabStop = false;
            this.picture_box_melek.Click += new System.EventHandler(this.picture_box_melek_Click);
            // 
            // picture_box_signin
            // 
            this.picture_box_signin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            //this.picture_box_signin.Image = global::toko_sepatu.Properties.Resources.fix_slide;
            this.picture_box_signin.Location = new System.Drawing.Point(0, -17);
            this.picture_box_signin.Name = "picture_box_signin";
            this.picture_box_signin.Size = new System.Drawing.Size(418, 511);
            this.picture_box_signin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picture_box_signin.TabIndex = 109;
            this.picture_box_signin.TabStop = false;
            // 
            // txt_pass_signin
            // 
            this.txt_pass_signin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_pass_signin.AutoScroll = true;
            this.txt_pass_signin.BorderRadius = 10;
            this.txt_pass_signin.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_pass_signin.DefaultText = "";
            this.txt_pass_signin.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_pass_signin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_pass_signin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_pass_signin.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_pass_signin.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_pass_signin.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_pass_signin.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            //this.txt_pass_signin.IconLeft = global::toko_sepatu.Properties.Resources.icons8_padlock_50;
            this.txt_pass_signin.IconLeftSize = new System.Drawing.Size(25, 25);
            this.txt_pass_signin.Location = new System.Drawing.Point(492, 216);
            this.txt_pass_signin.Name = "txt_pass_signin";
            this.txt_pass_signin.PlaceholderText = "Password";
            this.txt_pass_signin.SelectedText = "";
            this.txt_pass_signin.Size = new System.Drawing.Size(274, 36);
            this.txt_pass_signin.TabIndex = 108;
            this.txt_pass_signin.UseSystemPasswordChar = true;
            this.txt_pass_signin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_pass_signin_KeyPress);
            // 
            // txt_user_signin
            // 
            this.txt_user_signin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_user_signin.BorderRadius = 10;
            this.txt_user_signin.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.txt_user_signin.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_user_signin.DefaultText = "";
            this.txt_user_signin.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_user_signin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_user_signin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_user_signin.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_user_signin.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_user_signin.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_user_signin.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            //this.txt_user_signin.IconLeft = global::toko_sepatu.Properties.Resources.icons8_account_321;
            this.txt_user_signin.IconLeftSize = new System.Drawing.Size(25, 25);
            this.txt_user_signin.IconRightSize = new System.Drawing.Size(15, 15);
            this.txt_user_signin.Location = new System.Drawing.Point(492, 157);
            this.txt_user_signin.Name = "txt_user_signin";
            this.txt_user_signin.PlaceholderText = "Username";
            this.txt_user_signin.SelectedText = "";
            this.txt_user_signin.Size = new System.Drawing.Size(274, 36);
            this.txt_user_signin.TabIndex = 107;
            this.txt_user_signin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_user_signin_KeyPress);
            // 
            // Signin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(827, 450);
            this.Controls.Add(this.picture_box_merem);
            this.Controls.Add(this.picture_box_melek);
            this.Controls.Add(this.link_signup);
            this.Controls.Add(this.lbl_question_signup);
            this.Controls.Add(this.btn_signin);
            this.Controls.Add(this.picture_box_signin);
            this.Controls.Add(this.txt_pass_signin);
            this.Controls.Add(this.txt_user_signin);
            this.Controls.Add(this.lbl_login);
            this.Controls.Add(this.lbl_password);
            this.Controls.Add(this.lbl_user);
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "Signin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sign In";
            this.Load += new System.EventHandler(this.Signin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picture_box_merem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_box_melek)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_box_signin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_login;
        private System.Windows.Forms.Label lbl_password;
        private System.Windows.Forms.Label lbl_user;
        private Guna.UI2.WinForms.Guna2TextBox txt_pass_signin;
        private Guna.UI2.WinForms.Guna2TextBox txt_user_signin;
        private System.Windows.Forms.PictureBox picture_box_signin;
        private Guna.UI2.WinForms.Guna2Button btn_signin;
        private Guna.UI2.WinForms.Guna2HtmlLabel link_signup;
        private System.Windows.Forms.Label lbl_question_signup;
        private Guna.UI2.WinForms.Guna2PictureBox picture_box_melek;
        private Guna.UI2.WinForms.Guna2PictureBox picture_box_merem;
    }
}