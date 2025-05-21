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

namespace LogIn_database
{
    public partial class signup : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=LAPTOP-A8STJPUQ\\SQLEXPRESS;Initial Catalog=signup;Integrated Security=True");
        public signup()
        {
            InitializeComponent();
        }

        private void button_register_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("insert into [Tanzil]  (Name,User, Mobile, Password) " +
                       "values('" + textBox_name.Text + "','" + textBox_user.Text + "','" + textBox_mobile.Text + "','" + textBox_pass.Text + "')", conn);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Registered Succesfully");

        }
    }
}
