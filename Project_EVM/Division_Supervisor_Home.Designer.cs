
namespace OOP2_Project
{
    partial class Division_Supervisor_Home
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
            this.id_label = new System.Windows.Forms.Label();
            this.userName_label = new System.Windows.Forms.Label();
            this.logout_btn = new System.Windows.Forms.Button();
            this.load_btn = new System.Windows.Forms.Button();
            this.division_select_label = new System.Windows.Forms.Label();
            this.s_question_field = new System.Windows.Forms.TextBox();
            this.s_question_label = new System.Windows.Forms.Label();
            this.division_gridview = new System.Windows.Forms.DataGridView();
            this.division_select = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.division_gridview)).BeginInit();
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
            this.id_label.Text = "000";
            // 
            // userName_label
            // 
            this.userName_label.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userName_label.ForeColor = System.Drawing.Color.White;
            this.userName_label.Location = new System.Drawing.Point(638, 24);
            this.userName_label.Name = "userName_label";
            this.userName_label.Size = new System.Drawing.Size(71, 19);
            this.userName_label.TabIndex = 73;
            this.userName_label.Text = "D.S ID:";
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
            // load_btn
            // 
            this.load_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.load_btn.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.load_btn.Location = new System.Drawing.Point(356, 108);
            this.load_btn.Name = "load_btn";
            this.load_btn.Size = new System.Drawing.Size(75, 23);
            this.load_btn.TabIndex = 75;
            this.load_btn.Text = "Load";
            this.load_btn.UseVisualStyleBackColor = true;
            this.load_btn.Click += new System.EventHandler(this.load_btn_Click);
            // 
            // division_select_label
            // 
            this.division_select_label.AutoSize = true;
            this.division_select_label.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.division_select_label.ForeColor = System.Drawing.Color.White;
            this.division_select_label.Location = new System.Drawing.Point(46, 68);
            this.division_select_label.Name = "division_select_label";
            this.division_select_label.Size = new System.Drawing.Size(143, 23);
            this.division_select_label.TabIndex = 81;
            this.division_select_label.Text = "Select Division:";
            // 
            // s_question_field
            // 
            this.s_question_field.Location = new System.Drawing.Point(195, 110);
            this.s_question_field.Name = "s_question_field";
            this.s_question_field.PasswordChar = '*';
            this.s_question_field.Size = new System.Drawing.Size(155, 20);
            this.s_question_field.TabIndex = 84;
            this.s_question_field.TextChanged += new System.EventHandler(this.s_question_field_TextChanged);
            // 
            // s_question_label
            // 
            this.s_question_label.AutoSize = true;
            this.s_question_label.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.s_question_label.ForeColor = System.Drawing.Color.White;
            this.s_question_label.Location = new System.Drawing.Point(24, 107);
            this.s_question_label.Name = "s_question_label";
            this.s_question_label.Size = new System.Drawing.Size(165, 23);
            this.s_question_label.TabIndex = 83;
            this.s_question_label.Text = "Security Question:";
            // 
            // division_gridview
            // 
            this.division_gridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.division_gridview.Location = new System.Drawing.Point(28, 154);
            this.division_gridview.Name = "division_gridview";
            this.division_gridview.Size = new System.Drawing.Size(747, 219);
            this.division_gridview.TabIndex = 85;
            // 
            // division_select
            // 
            this.division_select.FormattingEnabled = true;
            this.division_select.Items.AddRange(new object[] {
            "Dhaka",
            "Chattogram",
            "Rajshahi",
            "Khulna",
            "Sylhet",
            "Barishal",
            "Rangpur",
            "Mymensingh"});
            this.division_select.Location = new System.Drawing.Point(195, 69);
            this.division_select.Name = "division_select";
            this.division_select.Size = new System.Drawing.Size(155, 21);
            this.division_select.TabIndex = 86;
            // 
            // Division_Supervisor_Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.division_select);
            this.Controls.Add(this.division_gridview);
            this.Controls.Add(this.s_question_field);
            this.Controls.Add(this.s_question_label);
            this.Controls.Add(this.division_select_label);
            this.Controls.Add(this.load_btn);
            this.Controls.Add(this.id_label);
            this.Controls.Add(this.userName_label);
            this.Controls.Add(this.logout_btn);
            this.Name = "Division_Supervisor_Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Division_Supervisor_Home";
            this.Load += new System.EventHandler(this.Division_Supervisor_Home_Load);
            ((System.ComponentModel.ISupportInitialize)(this.division_gridview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label id_label;
        private System.Windows.Forms.Label userName_label;
        private System.Windows.Forms.Button logout_btn;
        private System.Windows.Forms.Button load_btn;
        private System.Windows.Forms.Label division_select_label;
        private System.Windows.Forms.TextBox s_question_field;
        private System.Windows.Forms.Label s_question_label;
        private System.Windows.Forms.DataGridView division_gridview;
        private System.Windows.Forms.ComboBox division_select;
    }
}