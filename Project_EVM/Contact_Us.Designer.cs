
namespace OOP2_Project
{
    partial class Contact_Us
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Contact_Us));
            this.id_label = new System.Windows.Forms.Label();
            this.userName_label = new System.Windows.Forms.Label();
            this.logout_btn = new System.Windows.Forms.Button();
            this.back_btn = new System.Windows.Forms.Button();
            this.login_header = new System.Windows.Forms.Label();
            this.uid_field = new System.Windows.Forms.TextBox();
            this.uname_label = new System.Windows.Forms.Label();
            this.report_label = new System.Windows.Forms.Label();
            this.report_field = new System.Windows.Forms.RichTextBox();
            this.report_img = new System.Windows.Forms.PictureBox();
            this.upload_img_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.submit_btn = new System.Windows.Forms.Button();
            this.gmail_field = new System.Windows.Forms.TextBox();
            this.gmail_label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.report_img)).BeginInit();
            this.SuspendLayout();
            // 
            // id_label
            // 
            this.id_label.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id_label.ForeColor = System.Drawing.Color.White;
            this.id_label.Location = new System.Drawing.Point(704, 25);
            this.id_label.Name = "id_label";
            this.id_label.Size = new System.Drawing.Size(71, 19);
            this.id_label.TabIndex = 74;
            // 
            // userName_label
            // 
            this.userName_label.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userName_label.ForeColor = System.Drawing.Color.White;
            this.userName_label.Location = new System.Drawing.Point(638, 24);
            this.userName_label.Name = "userName_label";
            this.userName_label.Size = new System.Drawing.Size(71, 19);
            this.userName_label.TabIndex = 73;
            this.userName_label.Text = "User ID:";
            // 
            // logout_btn
            // 
            this.logout_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logout_btn.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logout_btn.Location = new System.Drawing.Point(557, 23);
            this.logout_btn.Name = "logout_btn";
            this.logout_btn.Size = new System.Drawing.Size(75, 23);
            this.logout_btn.TabIndex = 72;
            this.logout_btn.Text = "Logout";
            this.logout_btn.UseVisualStyleBackColor = true;
            this.logout_btn.Click += new System.EventHandler(this.logout_btn_Click);
            // 
            // back_btn
            // 
            this.back_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.back_btn.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back_btn.Location = new System.Drawing.Point(476, 23);
            this.back_btn.Name = "back_btn";
            this.back_btn.Size = new System.Drawing.Size(75, 23);
            this.back_btn.TabIndex = 75;
            this.back_btn.Text = "Back";
            this.back_btn.UseVisualStyleBackColor = true;
            this.back_btn.Click += new System.EventHandler(this.back_btn_Click);
            // 
            // login_header
            // 
            this.login_header.AutoSize = true;
            this.login_header.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_header.ForeColor = System.Drawing.Color.White;
            this.login_header.Location = new System.Drawing.Point(76, 72);
            this.login_header.Name = "login_header";
            this.login_header.Size = new System.Drawing.Size(421, 26);
            this.login_header.TabIndex = 78;
            this.login_header.Text = "Use the form below to report your issue.";
            // 
            // uid_field
            // 
            this.uid_field.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.uid_field.Location = new System.Drawing.Point(80, 173);
            this.uid_field.Name = "uid_field";
            this.uid_field.Size = new System.Drawing.Size(258, 20);
            this.uid_field.TabIndex = 77;
            // 
            // uname_label
            // 
            this.uname_label.AutoSize = true;
            this.uname_label.BackColor = System.Drawing.Color.SteelBlue;
            this.uname_label.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uname_label.ForeColor = System.Drawing.Color.White;
            this.uname_label.Location = new System.Drawing.Point(76, 147);
            this.uname_label.Name = "uname_label";
            this.uname_label.Size = new System.Drawing.Size(31, 23);
            this.uname_label.TabIndex = 76;
            this.uname_label.Text = "ID";
            // 
            // report_label
            // 
            this.report_label.AutoSize = true;
            this.report_label.BackColor = System.Drawing.Color.SteelBlue;
            this.report_label.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.report_label.ForeColor = System.Drawing.Color.White;
            this.report_label.Location = new System.Drawing.Point(76, 213);
            this.report_label.Name = "report_label";
            this.report_label.Size = new System.Drawing.Size(69, 23);
            this.report_label.TabIndex = 79;
            this.report_label.Text = "Details";
            // 
            // report_field
            // 
            this.report_field.Location = new System.Drawing.Point(80, 240);
            this.report_field.Name = "report_field";
            this.report_field.Size = new System.Drawing.Size(258, 142);
            this.report_field.TabIndex = 80;
            this.report_field.Text = "";
            // 
            // report_img
            // 
            this.report_img.Image = ((System.Drawing.Image)(resources.GetObject("report_img.Image")));
            this.report_img.Location = new System.Drawing.Point(417, 240);
            this.report_img.Name = "report_img";
            this.report_img.Size = new System.Drawing.Size(173, 142);
            this.report_img.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.report_img.TabIndex = 81;
            this.report_img.TabStop = false;
            // 
            // upload_img_btn
            // 
            this.upload_img_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.upload_img_btn.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.upload_img_btn.Location = new System.Drawing.Point(417, 399);
            this.upload_img_btn.Name = "upload_img_btn";
            this.upload_img_btn.Size = new System.Drawing.Size(173, 23);
            this.upload_img_btn.TabIndex = 82;
            this.upload_img_btn.Text = "Upload";
            this.upload_img_btn.UseVisualStyleBackColor = true;
            this.upload_img_btn.Click += new System.EventHandler(this.upload_img_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(76, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(372, 21);
            this.label1.TabIndex = 83;
            this.label1.Text = "Please also provide a screenshot of the problem.";
            // 
            // submit_btn
            // 
            this.submit_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.submit_btn.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submit_btn.Location = new System.Drawing.Point(263, 388);
            this.submit_btn.Name = "submit_btn";
            this.submit_btn.Size = new System.Drawing.Size(75, 23);
            this.submit_btn.TabIndex = 84;
            this.submit_btn.Text = "Submit";
            this.submit_btn.UseVisualStyleBackColor = true;
            this.submit_btn.Click += new System.EventHandler(this.submit_btn_Click);
            // 
            // gmail_field
            // 
            this.gmail_field.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gmail_field.Location = new System.Drawing.Point(374, 173);
            this.gmail_field.Name = "gmail_field";
            this.gmail_field.Size = new System.Drawing.Size(258, 20);
            this.gmail_field.TabIndex = 86;
            // 
            // gmail_label
            // 
            this.gmail_label.AutoSize = true;
            this.gmail_label.BackColor = System.Drawing.Color.SteelBlue;
            this.gmail_label.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gmail_label.ForeColor = System.Drawing.Color.White;
            this.gmail_label.Location = new System.Drawing.Point(370, 147);
            this.gmail_label.Name = "gmail_label";
            this.gmail_label.Size = new System.Drawing.Size(62, 23);
            this.gmail_label.TabIndex = 85;
            this.gmail_label.Text = "Gmail";
            // 
            // Contact_Us
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gmail_field);
            this.Controls.Add(this.gmail_label);
            this.Controls.Add(this.submit_btn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.upload_img_btn);
            this.Controls.Add(this.report_img);
            this.Controls.Add(this.report_field);
            this.Controls.Add(this.report_label);
            this.Controls.Add(this.login_header);
            this.Controls.Add(this.uid_field);
            this.Controls.Add(this.uname_label);
            this.Controls.Add(this.back_btn);
            this.Controls.Add(this.id_label);
            this.Controls.Add(this.userName_label);
            this.Controls.Add(this.logout_btn);
            this.Name = "Contact_Us";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Contact_Us";
            this.Load += new System.EventHandler(this.Help_Load);
            ((System.ComponentModel.ISupportInitialize)(this.report_img)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label id_label;
        private System.Windows.Forms.Label userName_label;
        private System.Windows.Forms.Button logout_btn;
        private System.Windows.Forms.Button back_btn;
        private System.Windows.Forms.Label login_header;
        private System.Windows.Forms.TextBox uid_field;
        private System.Windows.Forms.Label uname_label;
        private System.Windows.Forms.Label report_label;
        private System.Windows.Forms.RichTextBox report_field;
        private System.Windows.Forms.PictureBox report_img;
        private System.Windows.Forms.Button upload_img_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button submit_btn;
        private System.Windows.Forms.TextBox gmail_field;
        private System.Windows.Forms.Label gmail_label;
    }
}