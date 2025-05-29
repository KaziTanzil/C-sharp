
namespace OOP2_Project
{
    partial class Admin_Registration
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin_Registration));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.s_question_field = new System.Windows.Forms.TextBox();
            this.s_question_label = new System.Windows.Forms.Label();
            this.password_field = new System.Windows.Forms.TextBox();
            this.aid_field = new System.Windows.Forms.TextBox();
            this.password_label = new System.Windows.Forms.Label();
            this.aid_label = new System.Windows.Forms.Label();
            this.back_btn = new System.Windows.Forms.Button();
            this.register_btn = new System.Windows.Forms.Button();
            this.registration_header = new System.Windows.Forms.Label();
            this.showpass_check = new System.Windows.Forms.CheckBox();
            this.showpass_label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(374, 455);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 84;
            this.pictureBox1.TabStop = false;
            // 
            // s_question_field
            // 
            this.s_question_field.Location = new System.Drawing.Point(561, 280);
            this.s_question_field.Name = "s_question_field";
            this.s_question_field.PasswordChar = '*';
            this.s_question_field.Size = new System.Drawing.Size(156, 20);
            this.s_question_field.TabIndex = 83;
            // 
            // s_question_label
            // 
            this.s_question_label.AutoSize = true;
            this.s_question_label.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.s_question_label.ForeColor = System.Drawing.Color.White;
            this.s_question_label.Location = new System.Drawing.Point(390, 276);
            this.s_question_label.Name = "s_question_label";
            this.s_question_label.Size = new System.Drawing.Size(165, 23);
            this.s_question_label.TabIndex = 82;
            this.s_question_label.Text = "Security Question:";
            // 
            // password_field
            // 
            this.password_field.Location = new System.Drawing.Point(561, 210);
            this.password_field.Name = "password_field";
            this.password_field.PasswordChar = '*';
            this.password_field.Size = new System.Drawing.Size(156, 20);
            this.password_field.TabIndex = 81;
            // 
            // aid_field
            // 
            this.aid_field.Location = new System.Drawing.Point(563, 161);
            this.aid_field.Name = "aid_field";
            this.aid_field.Size = new System.Drawing.Size(155, 20);
            this.aid_field.TabIndex = 80;
            // 
            // password_label
            // 
            this.password_label.AutoSize = true;
            this.password_label.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password_label.ForeColor = System.Drawing.Color.White;
            this.password_label.Location = new System.Drawing.Point(459, 210);
            this.password_label.Name = "password_label";
            this.password_label.Size = new System.Drawing.Size(96, 23);
            this.password_label.TabIndex = 79;
            this.password_label.Text = "Password:";
            // 
            // aid_label
            // 
            this.aid_label.AutoSize = true;
            this.aid_label.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aid_label.ForeColor = System.Drawing.Color.White;
            this.aid_label.Location = new System.Drawing.Point(518, 161);
            this.aid_label.Name = "aid_label";
            this.aid_label.Size = new System.Drawing.Size(37, 23);
            this.aid_label.TabIndex = 78;
            this.aid_label.Text = "ID:";
            // 
            // back_btn
            // 
            this.back_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.back_btn.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back_btn.Location = new System.Drawing.Point(508, 354);
            this.back_btn.Name = "back_btn";
            this.back_btn.Size = new System.Drawing.Size(75, 23);
            this.back_btn.TabIndex = 77;
            this.back_btn.Text = "Back";
            this.back_btn.UseVisualStyleBackColor = true;
            this.back_btn.Click += new System.EventHandler(this.back_btn_Click);
            // 
            // register_btn
            // 
            this.register_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.register_btn.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.register_btn.Location = new System.Drawing.Point(606, 355);
            this.register_btn.Name = "register_btn";
            this.register_btn.Size = new System.Drawing.Size(75, 23);
            this.register_btn.TabIndex = 76;
            this.register_btn.Text = "Register";
            this.register_btn.UseVisualStyleBackColor = true;
            this.register_btn.Click += new System.EventHandler(this.register_btn_Click);
            // 
            // registration_header
            // 
            this.registration_header.AutoSize = true;
            this.registration_header.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registration_header.ForeColor = System.Drawing.Color.White;
            this.registration_header.Location = new System.Drawing.Point(406, 65);
            this.registration_header.Name = "registration_header";
            this.registration_header.Size = new System.Drawing.Size(361, 36);
            this.registration_header.TabIndex = 75;
            this.registration_header.Text = "Admin Registration Page";
            // 
            // showpass_check
            // 
            this.showpass_check.AutoSize = true;
            this.showpass_check.Cursor = System.Windows.Forms.Cursors.Hand;
            this.showpass_check.Location = new System.Drawing.Point(697, 243);
            this.showpass_check.Name = "showpass_check";
            this.showpass_check.Size = new System.Drawing.Size(15, 14);
            this.showpass_check.TabIndex = 86;
            this.showpass_check.UseVisualStyleBackColor = true;
            this.showpass_check.CheckedChanged += new System.EventHandler(this.showpass_check_CheckedChanged);
            // 
            // showpass_label
            // 
            this.showpass_label.AutoSize = true;
            this.showpass_label.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showpass_label.ForeColor = System.Drawing.Color.White;
            this.showpass_label.Location = new System.Drawing.Point(592, 241);
            this.showpass_label.Name = "showpass_label";
            this.showpass_label.Size = new System.Drawing.Size(98, 15);
            this.showpass_label.TabIndex = 85;
            this.showpass_label.Text = "Show password?";
            // 
            // Admin_Registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.showpass_check);
            this.Controls.Add(this.showpass_label);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.s_question_field);
            this.Controls.Add(this.s_question_label);
            this.Controls.Add(this.password_field);
            this.Controls.Add(this.aid_field);
            this.Controls.Add(this.password_label);
            this.Controls.Add(this.aid_label);
            this.Controls.Add(this.back_btn);
            this.Controls.Add(this.register_btn);
            this.Controls.Add(this.registration_header);
            this.Name = "Admin_Registration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin_Registration";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox s_question_field;
        private System.Windows.Forms.Label s_question_label;
        private System.Windows.Forms.TextBox password_field;
        private System.Windows.Forms.TextBox aid_field;
        private System.Windows.Forms.Label password_label;
        private System.Windows.Forms.Label aid_label;
        private System.Windows.Forms.Button back_btn;
        private System.Windows.Forms.Button register_btn;
        private System.Windows.Forms.Label registration_header;
        private System.Windows.Forms.CheckBox showpass_check;
        private System.Windows.Forms.Label showpass_label;
    }
}