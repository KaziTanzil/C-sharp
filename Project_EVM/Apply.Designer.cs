
namespace OOP2_Project
{
    partial class Apply
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
            this.back_btn = new System.Windows.Forms.Button();
            this.id_label = new System.Windows.Forms.Label();
            this.userName_label = new System.Windows.Forms.Label();
            this.logout_btn = new System.Windows.Forms.Button();
            this.division_select = new System.Windows.Forms.ComboBox();
            this.district_select = new System.Windows.Forms.ComboBox();
            this.division_label = new System.Windows.Forms.Label();
            this.district_label = new System.Windows.Forms.Label();
            this.name_field = new System.Windows.Forms.TextBox();
            this.name_label = new System.Windows.Forms.Label();
            this.party_label = new System.Windows.Forms.Label();
            this.party_field = new System.Windows.Forms.TextBox();
            this.uid_field = new System.Windows.Forms.TextBox();
            this.uid_label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.reason_field = new System.Windows.Forms.RichTextBox();
            this.apply_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // back_btn
            // 
            this.back_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.back_btn.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back_btn.Location = new System.Drawing.Point(187, 37);
            this.back_btn.Name = "back_btn";
            this.back_btn.Size = new System.Drawing.Size(75, 23);
            this.back_btn.TabIndex = 79;
            this.back_btn.Text = "Back";
            this.back_btn.UseVisualStyleBackColor = true;
            this.back_btn.Click += new System.EventHandler(this.back_btn_Click);
            // 
            // id_label
            // 
            this.id_label.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id_label.ForeColor = System.Drawing.Color.White;
            this.id_label.Location = new System.Drawing.Point(415, 39);
            this.id_label.Name = "id_label";
            this.id_label.Size = new System.Drawing.Size(71, 19);
            this.id_label.TabIndex = 78;
            // 
            // userName_label
            // 
            this.userName_label.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userName_label.ForeColor = System.Drawing.Color.White;
            this.userName_label.Location = new System.Drawing.Point(349, 38);
            this.userName_label.Name = "userName_label";
            this.userName_label.Size = new System.Drawing.Size(71, 19);
            this.userName_label.TabIndex = 77;
            this.userName_label.Text = "User ID:";
            // 
            // logout_btn
            // 
            this.logout_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logout_btn.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logout_btn.Location = new System.Drawing.Point(268, 37);
            this.logout_btn.Name = "logout_btn";
            this.logout_btn.Size = new System.Drawing.Size(75, 23);
            this.logout_btn.TabIndex = 76;
            this.logout_btn.Text = "Logout";
            this.logout_btn.UseVisualStyleBackColor = true;
            this.logout_btn.Click += new System.EventHandler(this.logout_btn_Click);
            // 
            // division_select
            // 
            this.division_select.Cursor = System.Windows.Forms.Cursors.Hand;
            this.division_select.FormattingEnabled = true;
            this.division_select.Items.AddRange(new object[] {
            "Dhaka",
            "Rangpur",
            "Rajshahi",
            "Chattogram",
            "Barishal",
            "Khulna",
            "Sylhet",
            "Mymensingh"});
            this.division_select.Location = new System.Drawing.Point(56, 280);
            this.division_select.Name = "division_select";
            this.division_select.Size = new System.Drawing.Size(121, 21);
            this.division_select.TabIndex = 85;
            // 
            // district_select
            // 
            this.district_select.Cursor = System.Windows.Forms.Cursors.Hand;
            this.district_select.FormattingEnabled = true;
            this.district_select.Location = new System.Drawing.Point(56, 334);
            this.district_select.Name = "district_select";
            this.district_select.Size = new System.Drawing.Size(121, 21);
            this.district_select.TabIndex = 84;
            this.district_select.MouseClick += new System.Windows.Forms.MouseEventHandler(this.district_select_MouseClick);
            // 
            // division_label
            // 
            this.division_label.AutoSize = true;
            this.division_label.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.division_label.ForeColor = System.Drawing.Color.White;
            this.division_label.Location = new System.Drawing.Point(52, 256);
            this.division_label.Name = "division_label";
            this.division_label.Size = new System.Drawing.Size(71, 21);
            this.division_label.TabIndex = 83;
            this.division_label.Text = "Division";
            // 
            // district_label
            // 
            this.district_label.AutoSize = true;
            this.district_label.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.district_label.ForeColor = System.Drawing.Color.White;
            this.district_label.Location = new System.Drawing.Point(52, 310);
            this.district_label.Name = "district_label";
            this.district_label.Size = new System.Drawing.Size(64, 21);
            this.district_label.TabIndex = 82;
            this.district_label.Text = "District";
            // 
            // name_field
            // 
            this.name_field.Location = new System.Drawing.Point(56, 173);
            this.name_field.Name = "name_field";
            this.name_field.Size = new System.Drawing.Size(121, 20);
            this.name_field.TabIndex = 81;
            // 
            // name_label
            // 
            this.name_label.AutoSize = true;
            this.name_label.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name_label.ForeColor = System.Drawing.Color.White;
            this.name_label.Location = new System.Drawing.Point(52, 148);
            this.name_label.Name = "name_label";
            this.name_label.Size = new System.Drawing.Size(53, 21);
            this.name_label.TabIndex = 80;
            this.name_label.Text = "Name";
            // 
            // party_label
            // 
            this.party_label.AutoSize = true;
            this.party_label.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.party_label.ForeColor = System.Drawing.Color.White;
            this.party_label.Location = new System.Drawing.Point(218, 148);
            this.party_label.Name = "party_label";
            this.party_label.Size = new System.Drawing.Size(49, 21);
            this.party_label.TabIndex = 86;
            this.party_label.Text = "Party";
            // 
            // party_field
            // 
            this.party_field.Location = new System.Drawing.Point(222, 172);
            this.party_field.Name = "party_field";
            this.party_field.Size = new System.Drawing.Size(121, 20);
            this.party_field.TabIndex = 87;
            // 
            // uid_field
            // 
            this.uid_field.Location = new System.Drawing.Point(56, 227);
            this.uid_field.Name = "uid_field";
            this.uid_field.Size = new System.Drawing.Size(121, 20);
            this.uid_field.TabIndex = 89;
            // 
            // uid_label
            // 
            this.uid_label.AutoSize = true;
            this.uid_label.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uid_label.ForeColor = System.Drawing.Color.White;
            this.uid_label.Location = new System.Drawing.Point(52, 202);
            this.uid_label.Name = "uid_label";
            this.uid_label.Size = new System.Drawing.Size(29, 21);
            this.uid_label.TabIndex = 88;
            this.uid_label.Text = "ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(218, 207);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 21);
            this.label1.TabIndex = 90;
            this.label1.Text = "Why do you want to apply?";
            // 
            // reason_field
            // 
            this.reason_field.Location = new System.Drawing.Point(222, 235);
            this.reason_field.Name = "reason_field";
            this.reason_field.Size = new System.Drawing.Size(214, 120);
            this.reason_field.TabIndex = 91;
            this.reason_field.Text = "";
            // 
            // apply_btn
            // 
            this.apply_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.apply_btn.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.apply_btn.Location = new System.Drawing.Point(361, 375);
            this.apply_btn.Name = "apply_btn";
            this.apply_btn.Size = new System.Drawing.Size(75, 23);
            this.apply_btn.TabIndex = 92;
            this.apply_btn.Text = "Apply";
            this.apply_btn.UseVisualStyleBackColor = true;
            this.apply_btn.Click += new System.EventHandler(this.apply_btn_Click);
            // 
            // Apply
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(495, 450);
            this.Controls.Add(this.apply_btn);
            this.Controls.Add(this.reason_field);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.uid_field);
            this.Controls.Add(this.uid_label);
            this.Controls.Add(this.party_field);
            this.Controls.Add(this.party_label);
            this.Controls.Add(this.division_select);
            this.Controls.Add(this.district_select);
            this.Controls.Add(this.division_label);
            this.Controls.Add(this.district_label);
            this.Controls.Add(this.name_field);
            this.Controls.Add(this.name_label);
            this.Controls.Add(this.back_btn);
            this.Controls.Add(this.id_label);
            this.Controls.Add(this.userName_label);
            this.Controls.Add(this.logout_btn);
            this.Name = "Apply";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Apply for Candidacy";
            this.Load += new System.EventHandler(this.Apply_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button back_btn;
        private System.Windows.Forms.Label id_label;
        private System.Windows.Forms.Label userName_label;
        private System.Windows.Forms.Button logout_btn;
        private System.Windows.Forms.ComboBox division_select;
        private System.Windows.Forms.ComboBox district_select;
        private System.Windows.Forms.Label division_label;
        private System.Windows.Forms.Label district_label;
        private System.Windows.Forms.TextBox name_field;
        private System.Windows.Forms.Label name_label;
        private System.Windows.Forms.Label party_label;
        private System.Windows.Forms.TextBox party_field;
        private System.Windows.Forms.TextBox uid_field;
        private System.Windows.Forms.Label uid_label;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox reason_field;
        private System.Windows.Forms.Button apply_btn;
    }
}