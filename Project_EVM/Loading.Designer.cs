
namespace OOP2_Project
{
    partial class Loading
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Loading));
            this.loading_pb = new System.Windows.Forms.ProgressBar();
            this.loading_counter = new System.Windows.Forms.Label();
            this.pb_timer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // loading_pb
            // 
            this.loading_pb.Location = new System.Drawing.Point(12, 412);
            this.loading_pb.Name = "loading_pb";
            this.loading_pb.Size = new System.Drawing.Size(776, 32);
            this.loading_pb.TabIndex = 1;
            // 
            // loading_counter
            // 
            this.loading_counter.AutoSize = true;
            this.loading_counter.BackColor = System.Drawing.Color.Transparent;
            this.loading_counter.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loading_counter.ForeColor = System.Drawing.Color.White;
            this.loading_counter.Location = new System.Drawing.Point(385, 388);
            this.loading_counter.Name = "loading_counter";
            this.loading_counter.Size = new System.Drawing.Size(86, 21);
            this.loading_counter.TabIndex = 2;
            this.loading_counter.Text = "Loading...";
            // 
            // pb_timer
            // 
            this.pb_timer.Tick += new System.EventHandler(this.pb_timer_Tick);
            // 
            // Loading
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.loading_counter);
            this.Controls.Add(this.loading_pb);
            this.Name = "Loading";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Loading System";
            this.Load += new System.EventHandler(this.Loading_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ProgressBar loading_pb;
        private System.Windows.Forms.Label loading_counter;
        private System.Windows.Forms.Timer pb_timer;
    }
}

