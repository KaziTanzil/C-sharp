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

namespace Demo
{
    public partial class Form1 : Form
    {
        SqlConnection conn = new SqlConnection("data source =LAPTOP-A8STJPUQ\\SQLEXPRESS; database =shahed; " +

                "integrated security = SSPI");
        public Form1()
        {
            InitializeComponent();
        }

        private void button_signup_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection();

            con.ConnectionString = "data source =LAPTOP-A8STJPUQ\\SQLEXPRESS; database =shahed; " +

                "integrated security = SSPI";

            string user = textBox_userId.Text;
            string pass = textBox_password.Text;
           

            string sql = "INSERT INTO shahed( user, pass) VALUES("
            + "'" + user + "'" + ","
            + "'" + pass + "'" + ")";

            using (SqlCommand cmd = new SqlCommand(sql, con))
            {
                //Opening the connection:
                con.Open();

                //cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();

                //Disconnect
                con.Close();


                //MessageBox.Show("Inserted ");

                

            }

        }
    }
}
