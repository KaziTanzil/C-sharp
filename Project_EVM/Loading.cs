using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP2_Project
{
    public partial class Loading : Form
    {
        int startPos;
        public Loading()
        {
            InitializeComponent();
        }

        private void Loading_Load(object sender, EventArgs e)
        {
            pb_timer.Start();
        }

        private void pb_timer_Tick(object sender, EventArgs e)
        {
            startPos += 5;
            loading_pb.Value = startPos;

            try
            {
                if (loading_pb.Value < 100)
                {
                    loading_counter.Text = loading_pb.Value.ToString() + "%";
                }
                else
                {
                    pb_timer.Stop();

                    Login login = new Login();
                    login.Show();
                    this.Hide();
                }
            }
            catch
            {
                MessageBox.Show("Sytem Loading Error");
            }
        }
    }
}
