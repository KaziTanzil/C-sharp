
namespace OOP2_Project
{
    partial class Reset_Password
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reset_Password));
            this.gmail_field = new System.Windows.Forms.TextBox();
            this.gmail_label = new System.Windows.Forms.Label();
            this.login_header = new System.Windows.Forms.Label();
            this.code_field = new System.Windows.Forms.TextBox();
            this.code_label = new System.Windows.Forms.Label();
            this.code_btn = new System.Windows.Forms.Button();
            this.p1_field = new System.Windows.Forms.TextBox();
            this.p1_label = new System.Windows.Forms.Label();
            this.p2_field = new System.Windows.Forms.TextBox();
            this.p2_label = new System.Windows.Forms.Label();
            this.back_btn = new System.Windows.Forms.Button();
            this.confirm_btn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gmail_field
            // 
            this.gmail_field.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gmail_field.Location = new System.Drawing.Point(28, 123);
            this.gmail_field.Name = "gmail_field";
            this.gmail_field.Size = new System.Drawing.Size(258, 20);
            this.gmail_field.TabIndex = 27;
            // 
            // gmail_label
            // 
            this.gmail_label.AutoSize = true;
            this.gmail_label.BackColor = System.Drawing.Color.Transparent;
            this.gmail_label.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gmail_label.ForeColor = System.Drawing.Color.White;
            this.gmail_label.Location = new System.Drawing.Point(24, 97);
            this.gmail_label.Name = "gmail_label";
            this.gmail_label.Size = new System.Drawing.Size(62, 23);
            this.gmail_label.TabIndex = 26;
            this.gmail_label.Text = "Gmail";
            // 
            // login_header
            // 
            this.login_header.AutoSize = true;
            this.login_header.BackColor = System.Drawing.Color.Transparent;
            this.login_header.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_header.ForeColor = System.Drawing.Color.White;
            this.login_header.Location = new System.Drawing.Point(22, 27);
            this.login_header.Name = "login_header";
            this.login_header.Size = new System.Drawing.Size(228, 36);
            this.login_header.TabIndex = 33;
            this.login_header.Text = "Reset Password";
            // 
            // code_field
            // 
            this.code_field.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.code_field.Location = new System.Drawing.Point(28, 184);
            this.code_field.Name = "code_field";
            this.code_field.Size = new System.Drawing.Size(154, 20);
            this.code_field.TabIndex = 35;
            // 
            // code_label
            // 
            this.code_label.AutoSize = true;
            this.code_label.BackColor = System.Drawing.Color.Transparent;
            this.code_label.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.code_label.ForeColor = System.Drawing.Color.White;
            this.code_label.Location = new System.Drawing.Point(24, 158);
            this.code_label.Name = "code_label";
            this.code_label.Size = new System.Drawing.Size(158, 23);
            this.code_label.TabIndex = 34;
            this.code_label.Text = "Verification Code";
            // 
            // code_btn
            // 
            this.code_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.code_btn.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.code_btn.Location = new System.Drawing.Point(211, 181);
            this.code_btn.Name = "code_btn";
            this.code_btn.Size = new System.Drawing.Size(75, 23);
            this.code_btn.TabIndex = 36;
            this.code_btn.Text = "Get Code";
            this.code_btn.UseVisualStyleBackColor = true;
            this.code_btn.Click += new System.EventHandler(this.code_btn_Click);
            // 
            // p1_field
            // 
            this.p1_field.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.p1_field.Location = new System.Drawing.Point(28, 248);
            this.p1_field.Name = "p1_field";
            this.p1_field.Size = new System.Drawing.Size(258, 20);
            this.p1_field.TabIndex = 38;
            // 
            // p1_label
            // 
            this.p1_label.AutoSize = true;
            this.p1_label.BackColor = System.Drawing.Color.Transparent;
            this.p1_label.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p1_label.ForeColor = System.Drawing.Color.White;
            this.p1_label.Location = new System.Drawing.Point(24, 222);
            this.p1_label.Name = "p1_label";
            this.p1_label.Size = new System.Drawing.Size(134, 23);
            this.p1_label.TabIndex = 37;
            this.p1_label.Text = "New Password";
            // 
            // p2_field
            // 
            this.p2_field.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.p2_field.Location = new System.Drawing.Point(28, 310);
            this.p2_field.Name = "p2_field";
            this.p2_field.Size = new System.Drawing.Size(258, 20);
            this.p2_field.TabIndex = 40;
            // 
            // p2_label
            // 
            this.p2_label.AutoSize = true;
            this.p2_label.BackColor = System.Drawing.Color.Transparent;
            this.p2_label.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p2_label.ForeColor = System.Drawing.Color.White;
            this.p2_label.Location = new System.Drawing.Point(24, 284);
            this.p2_label.Name = "p2_label";
            this.p2_label.Size = new System.Drawing.Size(166, 23);
            this.p2_label.TabIndex = 39;
            this.p2_label.Text = "Confirm Password";
            // 
            // back_btn
            // 
            this.back_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.back_btn.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back_btn.Location = new System.Drawing.Point(61, 368);
            this.back_btn.Name = "back_btn";
            this.back_btn.Size = new System.Drawing.Size(75, 23);
            this.back_btn.TabIndex = 41;
            this.back_btn.Text = "Back";
            this.back_btn.UseVisualStyleBackColor = true;
            this.back_btn.Click += new System.EventHandler(this.back_btn_Click);
            // 
            // confirm_btn
            // 
            this.confirm_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.confirm_btn.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirm_btn.Location = new System.Drawing.Point(175, 368);
            this.confirm_btn.Name = "confirm_btn";
            this.confirm_btn.Size = new System.Drawing.Size(75, 23);
            this.confirm_btn.TabIndex = 42;
            this.confirm_btn.Text = "Confirm";
            this.confirm_btn.UseVisualStyleBackColor = true;
            this.confirm_btn.Click += new System.EventHandler(this.confirm_btn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.confirm_btn);
            this.panel1.Controls.Add(this.login_header);
            this.panel1.Controls.Add(this.back_btn);
            this.panel1.Controls.Add(this.gmail_label);
            this.panel1.Controls.Add(this.p2_field);
            this.panel1.Controls.Add(this.gmail_field);
            this.panel1.Controls.Add(this.p2_label);
            this.panel1.Controls.Add(this.code_label);
            this.panel1.Controls.Add(this.p1_field);
            this.panel1.Controls.Add(this.code_field);
            this.panel1.Controls.Add(this.p1_label);
            this.panel1.Controls.Add(this.code_btn);
            this.panel1.Location = new System.Drawing.Point(32, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(309, 426);
            this.panel1.TabIndex = 43;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-1, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(370, 455);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 44;
            this.pictureBox1.TabStop = false;
            // 
            // Reset_Password
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(369, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Reset_Password";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reset_Password";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox gmail_field;
        private System.Windows.Forms.Label gmail_label;
        private System.Windows.Forms.Label login_header;
        private System.Windows.Forms.TextBox code_field;
        private System.Windows.Forms.Label code_label;
        private System.Windows.Forms.Button code_btn;
        private System.Windows.Forms.TextBox p1_field;
        private System.Windows.Forms.Label p1_label;
        private System.Windows.Forms.TextBox p2_field;
        private System.Windows.Forms.Label p2_label;
        private System.Windows.Forms.Button back_btn;
        private System.Windows.Forms.Button confirm_btn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}