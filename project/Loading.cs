using Final_Project_C_;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Final_Project_C_
{
    public partial class Loading : Form
    {
        int startpos;
        public Loading()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            startpos += 5;
            progressBar1.Value = startpos;
            if (progressBar1.Value < 100)
            {
                //progressBar1.Value += 1;
                label1.Text = progressBar1.Value.ToString() + "%";

            }
            else
            {
                timer1.Stop();
                Login login = new Login();
                login.Show();
                this.Hide();
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void Loading_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
