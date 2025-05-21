namespace Demo
{
    partial class Form1
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
            this.button_signup = new System.Windows.Forms.Button();
            this.textBox_userId = new System.Windows.Forms.TextBox();
            this.textBox_password = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button_signup
            // 
            this.button_signup.Location = new System.Drawing.Point(425, 291);
            this.button_signup.Name = "button_signup";
            this.button_signup.Size = new System.Drawing.Size(75, 23);
            this.button_signup.TabIndex = 25;
            this.button_signup.Text = "insert";
            this.button_signup.UseVisualStyleBackColor = true;
            this.button_signup.Click += new System.EventHandler(this.button_signup_Click);
            // 
            // textBox_userId
            // 
            this.textBox_userId.Location = new System.Drawing.Point(409, 106);
            this.textBox_userId.Name = "textBox_userId";
            this.textBox_userId.Size = new System.Drawing.Size(100, 22);
            this.textBox_userId.TabIndex = 23;
            // 
            // textBox_password
            // 
            this.textBox_password.Location = new System.Drawing.Point(409, 146);
            this.textBox_password.Name = "textBox_password";
            this.textBox_password.Size = new System.Drawing.Size(100, 22);
            this.textBox_password.TabIndex = 22;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_signup);
            this.Controls.Add(this.textBox_userId);
            this.Controls.Add(this.textBox_password);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button_signup;
        private System.Windows.Forms.TextBox textBox_userId;
        private System.Windows.Forms.TextBox textBox_password;
    }
}

