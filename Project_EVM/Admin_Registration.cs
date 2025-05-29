using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.Sql;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace OOP2_Project
{
    public partial class Admin_Registration : Form
    {
        SqlConnection con = new SqlConnection("data source =DESKTOP-GDKI8TK\\SQLEXPRESS; database =OOP2_Project;" +
                                   "integrated security = SSPI");

        public Admin_Registration()
        {
            InitializeComponent();
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void showpass_check_CheckedChanged(object sender, EventArgs e)
        {
            if (showpass_check.Checked)
            {
                password_field.PasswordChar = '\0';
                showpass_label.Text = "Hide Password?";
            }
            else
            {
                password_field.PasswordChar = '*';
                showpass_label.Text = "Show Password?";
            }
        }

        private void register_btn_Click(object sender, EventArgs e)
        {
            string aid = aid_field.Text;
            string password = password_field.Text;
            string s_question = s_question_field.Text;

            try
            {
                string query = "SELECT * FROM Admin_Info WHERE Aid = '" + aid + "' AND Admin_Password = '" + password + "'";
                SqlDataAdapter sda = new SqlDataAdapter(query, con);

                DataTable dtable = new DataTable();
                sda.Fill(dtable);

                if (dtable.Rows.Count > 0)
                {
                    aid = aid_field.Text;
                    password = password_field.Text;

                    MessageBox.Show("User Already Registered");

                    this.Close();
                }
                else
                {
                    if (s_question == "Tofayet_Sultan")
                    {
                        string sql = "INSERT INTO Admin_Info(Aid,Admin_Password,S_Question) VALUES("
                        + "'" + aid + "'" + ","
                        + "'" + password + "'" + ","
                        + "'" + s_question + "'" +
                        ")";

                        using (SqlCommand cmd = new SqlCommand(sql, con))
                        {
                            con.Open();

                            cmd.ExecuteNonQuery();

                            con.Close();
                        }

                        MessageBox.Show("Registration Complete");

                        Login login = new Login();
                        login.Show();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Not Today Hacker!\nWarning! App Shutting Down");
                        this.Close();
                    }
                }
            }
            catch
            {
                MessageBox.Show("Error 404! User Not Found");
            }
        }
    }
}
