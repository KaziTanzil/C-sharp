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

namespace WindowsFormsApp2
{
    public partial class Form2 : Form
    {
       
        public Form2(string name, string id,string dateofbirth, string country)
        {
            InitializeComponent();
            richTextBox1.AppendText("Name: " + name + "\n");
            richTextBox1.AppendText("ID: " + id + "\n");
            richTextBox1.AppendText("Date of Birth: " + dateofbirth + "\n");
            richTextBox1.AppendText("Country: " + country + "\n");
            //richTextBox1.AppendText("Gender: " + gender + "\n");
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
