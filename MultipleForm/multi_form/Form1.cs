using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace multiple_form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name=textBox1.Text;
            string country=comboBox1.Text;
            string gender = malerb.Checked ? "Male" : "Female";

            string DOB= dateTimePicker1.Value.ToString();

            string details = "Name:" + name + "\n Country: "+country + "\n Gender: " + gender + "\n Date of Birth: " + DOB;
           
            Form2 f2 = new Form2(details);
            f2.ShowDialog();
            this.Close();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
