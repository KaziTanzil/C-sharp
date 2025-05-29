
namespace OOP2_Project
{
    partial class Admin_Home
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
            this.user_info_btn = new System.Windows.Forms.Button();
            this.adminName_label = new System.Windows.Forms.Label();
            this.logout_btn = new System.Windows.Forms.Button();
            this.db_gridview = new System.Windows.Forms.DataGridView();
            this.gridView_label = new System.Windows.Forms.Label();
            this.admin_info_btn = new System.Windows.Forms.Button();
            this.search_field = new System.Windows.Forms.TextBox();
            this.search_user_btn = new System.Windows.Forms.Button();
            this.search_admin_btn = new System.Windows.Forms.Button();
            this.delete_search = new System.Windows.Forms.TextBox();
            this.delete_admin_btn = new System.Windows.Forms.Button();
            this.delete_user_btn = new System.Windows.Forms.Button();
            this.id_label = new System.Windows.Forms.Label();
            this.update_btn = new System.Windows.Forms.Button();
            this.reports_btn = new System.Windows.Forms.Button();
            this.applications_btn = new System.Windows.Forms.Button();
            this.delete_report_btn = new System.Windows.Forms.Button();
            this.delete_application_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.db_gridview)).BeginInit();
            this.SuspendLayout();
            // 
            // user_info_btn
            // 
            this.user_info_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.user_info_btn.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user_info_btn.Location = new System.Drawing.Point(58, 40);
            this.user_info_btn.Name = "user_info_btn";
            this.user_info_btn.Size = new System.Drawing.Size(97, 23);
            this.user_info_btn.TabIndex = 69;
            this.user_info_btn.Text = "User Info";
            this.user_info_btn.UseVisualStyleBackColor = true;
            this.user_info_btn.Click += new System.EventHandler(this.user_info_btn_Click);
            // 
            // adminName_label
            // 
            this.adminName_label.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminName_label.ForeColor = System.Drawing.Color.White;
            this.adminName_label.Location = new System.Drawing.Point(637, 25);
            this.adminName_label.Name = "adminName_label";
            this.adminName_label.Size = new System.Drawing.Size(59, 19);
            this.adminName_label.TabIndex = 68;
            this.adminName_label.Text = "Admin:";
            // 
            // logout_btn
            // 
            this.logout_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logout_btn.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logout_btn.Location = new System.Drawing.Point(556, 24);
            this.logout_btn.Name = "logout_btn";
            this.logout_btn.Size = new System.Drawing.Size(75, 23);
            this.logout_btn.TabIndex = 67;
            this.logout_btn.Text = "Logout";
            this.logout_btn.UseVisualStyleBackColor = true;
            this.logout_btn.Click += new System.EventHandler(this.logout_btn_Click);
            // 
            // db_gridview
            // 
            this.db_gridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.db_gridview.Location = new System.Drawing.Point(58, 137);
            this.db_gridview.Name = "db_gridview";
            this.db_gridview.Size = new System.Drawing.Size(697, 234);
            this.db_gridview.TabIndex = 70;
            // 
            // gridView_label
            // 
            this.gridView_label.AutoSize = true;
            this.gridView_label.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView_label.ForeColor = System.Drawing.Color.White;
            this.gridView_label.Location = new System.Drawing.Point(53, 107);
            this.gridView_label.Name = "gridView_label";
            this.gridView_label.Size = new System.Drawing.Size(113, 27);
            this.gridView_label.TabIndex = 76;
            this.gridView_label.Text = "Data View";
            // 
            // admin_info_btn
            // 
            this.admin_info_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.admin_info_btn.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admin_info_btn.Location = new System.Drawing.Point(58, 69);
            this.admin_info_btn.Name = "admin_info_btn";
            this.admin_info_btn.Size = new System.Drawing.Size(97, 23);
            this.admin_info_btn.TabIndex = 77;
            this.admin_info_btn.Text = "Admin Info";
            this.admin_info_btn.UseVisualStyleBackColor = true;
            this.admin_info_btn.Click += new System.EventHandler(this.admin_info_btn_Click);
            // 
            // search_field
            // 
            this.search_field.Location = new System.Drawing.Point(477, 107);
            this.search_field.Name = "search_field";
            this.search_field.Size = new System.Drawing.Size(154, 20);
            this.search_field.TabIndex = 78;
            // 
            // search_user_btn
            // 
            this.search_user_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.search_user_btn.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_user_btn.Location = new System.Drawing.Point(641, 105);
            this.search_user_btn.Name = "search_user_btn";
            this.search_user_btn.Size = new System.Drawing.Size(114, 23);
            this.search_user_btn.TabIndex = 82;
            this.search_user_btn.Text = "Search";
            this.search_user_btn.UseVisualStyleBackColor = true;
            this.search_user_btn.Click += new System.EventHandler(this.search_user_btn_Click);
            // 
            // search_admin_btn
            // 
            this.search_admin_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.search_admin_btn.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_admin_btn.Location = new System.Drawing.Point(658, 104);
            this.search_admin_btn.Name = "search_admin_btn";
            this.search_admin_btn.Size = new System.Drawing.Size(97, 23);
            this.search_admin_btn.TabIndex = 83;
            this.search_admin_btn.Text = "Search";
            this.search_admin_btn.UseVisualStyleBackColor = true;
            this.search_admin_btn.Click += new System.EventHandler(this.search_admin_btn_Click);
            // 
            // delete_search
            // 
            this.delete_search.Location = new System.Drawing.Point(477, 381);
            this.delete_search.Name = "delete_search";
            this.delete_search.Size = new System.Drawing.Size(154, 20);
            this.delete_search.TabIndex = 84;
            // 
            // delete_admin_btn
            // 
            this.delete_admin_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.delete_admin_btn.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete_admin_btn.Location = new System.Drawing.Point(641, 380);
            this.delete_admin_btn.Name = "delete_admin_btn";
            this.delete_admin_btn.Size = new System.Drawing.Size(114, 23);
            this.delete_admin_btn.TabIndex = 85;
            this.delete_admin_btn.Text = "Delete Admin";
            this.delete_admin_btn.UseVisualStyleBackColor = true;
            this.delete_admin_btn.Click += new System.EventHandler(this.delete_admin_btn_Click);
            // 
            // delete_user_btn
            // 
            this.delete_user_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.delete_user_btn.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete_user_btn.Location = new System.Drawing.Point(641, 379);
            this.delete_user_btn.Name = "delete_user_btn";
            this.delete_user_btn.Size = new System.Drawing.Size(114, 23);
            this.delete_user_btn.TabIndex = 86;
            this.delete_user_btn.Text = "Delete User";
            this.delete_user_btn.UseVisualStyleBackColor = true;
            this.delete_user_btn.Click += new System.EventHandler(this.delete_user_btn_Click);
            // 
            // id_label
            // 
            this.id_label.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id_label.ForeColor = System.Drawing.Color.White;
            this.id_label.Location = new System.Drawing.Point(691, 26);
            this.id_label.Name = "id_label";
            this.id_label.Size = new System.Drawing.Size(71, 19);
            this.id_label.TabIndex = 87;
            // 
            // update_btn
            // 
            this.update_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.update_btn.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update_btn.Location = new System.Drawing.Point(58, 383);
            this.update_btn.Name = "update_btn";
            this.update_btn.Size = new System.Drawing.Size(97, 23);
            this.update_btn.TabIndex = 88;
            this.update_btn.Text = "Update";
            this.update_btn.UseVisualStyleBackColor = true;
            this.update_btn.Click += new System.EventHandler(this.update_btn_Click);
            // 
            // reports_btn
            // 
            this.reports_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.reports_btn.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reports_btn.Location = new System.Drawing.Point(263, 40);
            this.reports_btn.Name = "reports_btn";
            this.reports_btn.Size = new System.Drawing.Size(97, 23);
            this.reports_btn.TabIndex = 89;
            this.reports_btn.Text = "Reports";
            this.reports_btn.UseVisualStyleBackColor = true;
            this.reports_btn.Click += new System.EventHandler(this.reports_btn_Click);
            // 
            // applications_btn
            // 
            this.applications_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.applications_btn.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.applications_btn.Location = new System.Drawing.Point(263, 69);
            this.applications_btn.Name = "applications_btn";
            this.applications_btn.Size = new System.Drawing.Size(97, 23);
            this.applications_btn.TabIndex = 90;
            this.applications_btn.Text = "Applications";
            this.applications_btn.UseVisualStyleBackColor = true;
            this.applications_btn.Click += new System.EventHandler(this.applications_btn_Click);
            // 
            // delete_report_btn
            // 
            this.delete_report_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.delete_report_btn.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete_report_btn.Location = new System.Drawing.Point(641, 380);
            this.delete_report_btn.Name = "delete_report_btn";
            this.delete_report_btn.Size = new System.Drawing.Size(114, 23);
            this.delete_report_btn.TabIndex = 91;
            this.delete_report_btn.Text = "Delete Report";
            this.delete_report_btn.UseVisualStyleBackColor = true;
            this.delete_report_btn.Click += new System.EventHandler(this.delete_report_btn_Click);
            // 
            // delete_application_btn
            // 
            this.delete_application_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.delete_application_btn.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete_application_btn.Location = new System.Drawing.Point(641, 380);
            this.delete_application_btn.Name = "delete_application_btn";
            this.delete_application_btn.Size = new System.Drawing.Size(114, 23);
            this.delete_application_btn.TabIndex = 92;
            this.delete_application_btn.Text = "Delete Applicant";
            this.delete_application_btn.UseVisualStyleBackColor = true;
            this.delete_application_btn.Click += new System.EventHandler(this.delete_application_btn_Click);
            // 
            // Admin_Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.applications_btn);
            this.Controls.Add(this.reports_btn);
            this.Controls.Add(this.update_btn);
            this.Controls.Add(this.id_label);
            this.Controls.Add(this.delete_search);
            this.Controls.Add(this.search_field);
            this.Controls.Add(this.admin_info_btn);
            this.Controls.Add(this.gridView_label);
            this.Controls.Add(this.user_info_btn);
            this.Controls.Add(this.adminName_label);
            this.Controls.Add(this.logout_btn);
            this.Controls.Add(this.search_user_btn);
            this.Controls.Add(this.search_admin_btn);
            this.Controls.Add(this.delete_application_btn);
            this.Controls.Add(this.db_gridview);
            this.Controls.Add(this.delete_user_btn);
            this.Controls.Add(this.delete_admin_btn);
            this.Controls.Add(this.delete_report_btn);
            this.Name = "Admin_Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin_Home";
            this.Load += new System.EventHandler(this.Admin_Home_Load);
            ((System.ComponentModel.ISupportInitialize)(this.db_gridview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button user_info_btn;
        private System.Windows.Forms.Label adminName_label;
        private System.Windows.Forms.Button logout_btn;
        private System.Windows.Forms.DataGridView db_gridview;
        private System.Windows.Forms.Label gridView_label;
        private System.Windows.Forms.Button admin_info_btn;
        private System.Windows.Forms.TextBox search_field;
        private System.Windows.Forms.Button search_user_btn;
        private System.Windows.Forms.Button search_admin_btn;
        private System.Windows.Forms.TextBox delete_search;
        private System.Windows.Forms.Button delete_admin_btn;
        private System.Windows.Forms.Button delete_user_btn;
        private System.Windows.Forms.Label id_label;
        private System.Windows.Forms.Button update_btn;
        private System.Windows.Forms.Button reports_btn;
        private System.Windows.Forms.Button applications_btn;
        private System.Windows.Forms.Button delete_report_btn;
        private System.Windows.Forms.Button delete_application_btn;
    }
}