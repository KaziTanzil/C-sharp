
namespace OOP2_Project
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.login_header = new System.Windows.Forms.Label();
            this.role_label = new System.Windows.Forms.Label();
            this.role_select_field = new System.Windows.Forms.ComboBox();
            this.signup_btn = new System.Windows.Forms.Button();
            this.signup_text_label = new System.Windows.Forms.Label();
            this.login_btn = new System.Windows.Forms.Button();
            this.uid_field = new System.Windows.Forms.TextBox();
            this.password_label = new System.Windows.Forms.Label();
            this.uname_label = new System.Windows.Forms.Label();
            this.password_field = new System.Windows.Forms.TextBox();
            this.showpass_label = new System.Windows.Forms.Label();
            this.showpass_check = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.forgot_password = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // login_header
            // 
            this.login_header.AutoSize = true;
            this.login_header.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_header.ForeColor = System.Drawing.Color.White;
            this.login_header.Location = new System.Drawing.Point(19, 19);
            this.login_header.Name = "login_header";
            this.login_header.Size = new System.Drawing.Size(169, 36);
            this.login_header.TabIndex = 32;
            this.login_header.Text = "Login Page";
            // 
            // role_label
            // 
            this.role_label.AutoSize = true;
            this.role_label.BackColor = System.Drawing.Color.SteelBlue;
            this.role_label.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.role_label.ForeColor = System.Drawing.Color.White;
            this.role_label.Location = new System.Drawing.Point(20, 240);
            this.role_label.Name = "role_label";
            this.role_label.Size = new System.Drawing.Size(50, 23);
            this.role_label.TabIndex = 31;
            this.role_label.Text = "Role";
            // 
            // role_select_field
            // 
            this.role_select_field.Cursor = System.Windows.Forms.Cursors.Hand;
            this.role_select_field.FormattingEnabled = true;
            this.role_select_field.Items.AddRange(new object[] {
            "Admin",
            "Head Supervisor",
            "Division Supervisor",
            "Voter"});
            this.role_select_field.Location = new System.Drawing.Point(24, 266);
            this.role_select_field.Name = "role_select_field";
            this.role_select_field.Size = new System.Drawing.Size(132, 21);
            this.role_select_field.TabIndex = 30;
            // 
            // signup_btn
            // 
            this.signup_btn.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.signup_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.signup_btn.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signup_btn.Location = new System.Drawing.Point(187, 336);
            this.signup_btn.Name = "signup_btn";
            this.signup_btn.Size = new System.Drawing.Size(75, 23);
            this.signup_btn.TabIndex = 29;
            this.signup_btn.Text = "Signup";
            this.signup_btn.UseVisualStyleBackColor = true;
            this.signup_btn.Click += new System.EventHandler(this.signup_btn_Click);
            // 
            // signup_text_label
            // 
            this.signup_text_label.AutoSize = true;
            this.signup_text_label.BackColor = System.Drawing.Color.SteelBlue;
            this.signup_text_label.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signup_text_label.ForeColor = System.Drawing.Color.White;
            this.signup_text_label.Location = new System.Drawing.Point(40, 340);
            this.signup_text_label.Name = "signup_text_label";
            this.signup_text_label.Size = new System.Drawing.Size(133, 15);
            this.signup_text_label.TabIndex = 28;
            this.signup_text_label.Text = "Don\'t have an account?";
            // 
            // login_btn
            // 
            this.login_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.login_btn.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_btn.Location = new System.Drawing.Point(187, 266);
            this.login_btn.Name = "login_btn";
            this.login_btn.Size = new System.Drawing.Size(75, 23);
            this.login_btn.TabIndex = 27;
            this.login_btn.Text = "Login";
            this.login_btn.UseVisualStyleBackColor = true;
            this.login_btn.Click += new System.EventHandler(this.login_btn_Click);
            // 
            // uid_field
            // 
            this.uid_field.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.uid_field.Location = new System.Drawing.Point(25, 111);
            this.uid_field.Name = "uid_field";
            this.uid_field.Size = new System.Drawing.Size(258, 20);
            this.uid_field.TabIndex = 25;
            // 
            // password_label
            // 
            this.password_label.AutoSize = true;
            this.password_label.BackColor = System.Drawing.Color.SteelBlue;
            this.password_label.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password_label.ForeColor = System.Drawing.Color.White;
            this.password_label.Location = new System.Drawing.Point(21, 151);
            this.password_label.Name = "password_label";
            this.password_label.Size = new System.Drawing.Size(90, 23);
            this.password_label.TabIndex = 24;
            this.password_label.Text = "Password";
            // 
            // uname_label
            // 
            this.uname_label.AutoSize = true;
            this.uname_label.BackColor = System.Drawing.Color.SteelBlue;
            this.uname_label.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uname_label.ForeColor = System.Drawing.Color.White;
            this.uname_label.Location = new System.Drawing.Point(51, 115);
            this.uname_label.Name = "uname_label";
            this.uname_label.Size = new System.Drawing.Size(31, 23);
            this.uname_label.TabIndex = 23;
            this.uname_label.Text = "ID";
            // 
            // password_field
            // 
            this.password_field.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.password_field.Location = new System.Drawing.Point(24, 177);
            this.password_field.Name = "password_field";
            this.password_field.PasswordChar = '*';
            this.password_field.Size = new System.Drawing.Size(260, 20);
            this.password_field.TabIndex = 26;
            // 
            // showpass_label
            // 
            this.showpass_label.AutoSize = true;
            this.showpass_label.BackColor = System.Drawing.Color.SteelBlue;
            this.showpass_label.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showpass_label.ForeColor = System.Drawing.Color.White;
            this.showpass_label.Location = new System.Drawing.Point(164, 207);
            this.showpass_label.Name = "showpass_label";
            this.showpass_label.Size = new System.Drawing.Size(98, 15);
            this.showpass_label.TabIndex = 34;
            this.showpass_label.Text = "Show password?";
            // 
            // showpass_check
            // 
            this.showpass_check.AutoSize = true;
            this.showpass_check.Cursor = System.Windows.Forms.Cursors.Hand;
            this.showpass_check.Location = new System.Drawing.Point(269, 208);
            this.showpass_check.Name = "showpass_check";
            this.showpass_check.Size = new System.Drawing.Size(15, 14);
            this.showpass_check.TabIndex = 35;
            this.showpass_check.UseVisualStyleBackColor = true;
            this.showpass_check.CheckedChanged += new System.EventHandler(this.showpass_check_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.forgot_password);
            this.panel1.Controls.Add(this.signup_btn);
            this.panel1.Controls.Add(this.signup_text_label);
            this.panel1.Controls.Add(this.role_select_field);
            this.panel1.Controls.Add(this.role_label);
            this.panel1.Controls.Add(this.login_btn);
            this.panel1.Controls.Add(this.showpass_label);
            this.panel1.Controls.Add(this.showpass_check);
            this.panel1.Controls.Add(this.login_header);
            this.panel1.Controls.Add(this.uid_field);
            this.panel1.Controls.Add(this.password_label);
            this.panel1.Controls.Add(this.password_field);
            this.panel1.Location = new System.Drawing.Point(30, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(309, 391);
            this.panel1.TabIndex = 36;
            // 
            // forgot_password
            // 
            this.forgot_password.AutoSize = true;
            this.forgot_password.BackColor = System.Drawing.Color.SteelBlue;
            this.forgot_password.Cursor = System.Windows.Forms.Cursors.Hand;
            this.forgot_password.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.forgot_password.ForeColor = System.Drawing.Color.White;
            this.forgot_password.Location = new System.Drawing.Point(22, 207);
            this.forgot_password.Name = "forgot_password";
            this.forgot_password.Size = new System.Drawing.Size(104, 15);
            this.forgot_password.TabIndex = 36;
            this.forgot_password.Text = "Forgot Password?";
            this.forgot_password.MouseClick += new System.Windows.Forms.MouseEventHandler(this.forgot_password_MouseClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, -4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(802, 455);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 37;
            this.pictureBox1.TabStop = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.uname_label);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label login_header;
        private System.Windows.Forms.Label role_label;
        private System.Windows.Forms.ComboBox role_select_field;
        private System.Windows.Forms.Button signup_btn;
        private System.Windows.Forms.Label signup_text_label;
        private System.Windows.Forms.Button login_btn;
        private System.Windows.Forms.TextBox uid_field;
        private System.Windows.Forms.Label password_label;
        private System.Windows.Forms.Label uname_label;
        private System.Windows.Forms.TextBox password_field;
        private System.Windows.Forms.Label showpass_label;
        private System.Windows.Forms.CheckBox showpass_check;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label forgot_password;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}