using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Today_Task
{
    public partial class Form1 : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=LAPTOP-A8STJPUQ\\SQLEXPRESS;Initial Catalog=Donor;Integrated Security=True");
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {


            SqlConnection con = new SqlConnection();

            con.ConnectionString = "data source =LAPTOP-A8STJPUQ\\SQLEXPRESS; database =Donor; " +

                "integrated security = SSPI";

            string donorNo = textBox_donorNo.Text;
            string bloodGroup = comboBox_bloodGroup.Text;
            string age = textBox_age.Text;
            string sex = comboBox_sex.Text;
            string name = textBox_name.Text;
            string address = richTextBox_address.Text;

            string mobile = textBox_mobile.Text;
            string email = textBox_email.Text;

            string sql = "INSERT INTO Details(Donor_no,Blood_group, Age, Sex, Name,Address,Mobile,Gmail) VALUES("
            //+ 1 + ","
            + "'" + name + "'" + ","
            + "'" + bloodGroup + "'" + ","
            + "'" + age + "'" + ","
            + "'" + sex + "'" + ","
            + "'" + name + "'" + ","
            + "'" + address + "'" + ","
            + "'" + mobile + "'" + ","
            + "'" + email + "'" + ")";

            using (SqlCommand cmd = new SqlCommand(sql, con))
            {
                //Opening the connection:
                con.Open();

                //cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();

                //Disconnect
                con.Close();


                //MessageBox.Show("Inserted ");

                Table T= new Table();
                T.Show();

            }
        }

        private void comboBox_bloodGroup_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
