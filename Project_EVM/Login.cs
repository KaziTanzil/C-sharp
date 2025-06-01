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
    public partial class Login : Form
    {
        SqlConnection con = new SqlConnection("data source =DESKTOP-GDKI8TK\\SQLEXPRESS; database =OOP2_Project;" +
                                   "integrated security = SSPI");

        public Login()
        {
            InitializeComponent();
        }

        private void signup_btn_Click(object sender, EventArgs e)
        {
            string role;

            role = role_select_field.Text;

            try
            {
                string query = "SELECT * FROM User_Info WHERE Role = '" + role + "'";
                SqlDataAdapter sda = new SqlDataAdapter(query, con);

                DataTable dTable = new DataTable();
                sda.Fill(dTable);

                if (dTable.Rows.Count >= 0)
                {
                    role = role_select_field.Text;

                    if (role == null || role == "")
                    {
                        MessageBox.Show("Error! Please Select a Role");
                    }
                    else if (role == "Admin")
                    {
                        Admin_Registration admin_registration = new Admin_Registration();
                        admin_registration.Show();
                        this.Hide();
                    }
                    else
                    {
                        User_Registration user_registration = new User_Registration();
                        user_registration.Show();
                        this.Hide();
                    }
                }
                else
                {
                    MessageBox.Show("Error! Invalid Credentials");
                }
            }
            catch
            {
                MessageBox.Show("Error 404! User Not Found");
            }
        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            string uid, password, role;

            uid = uid_field.Text;
            password = password_field.Text;
            role = role_select_field.Text;

            try
            {
                if (role == "Admin")
                {
                    string query = "SELECT * FROM Admin_Info WHERE Aid = '" + uid + "' AND Admin_Password = '" + password + "'";
                    SqlDataAdapter sda = new SqlDataAdapter(query, con);

                    DataTable dTable = new DataTable();
                    sda.Fill(dTable);

                    if (dTable.Rows.Count > 0)
                    {
                        uid = uid_field.Text;
                        password = password_field.Text;

                        Admin_Home admin_home = new Admin_Home();
                        admin_home.adminName = uid_field.Text;
                        admin_home.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Error! Invalid Credentials.\nCheck Username, Password or Role");
                    }
                }
                else if (role == "Voter")
                {
                    string query = "SELECT * FROM User_Info WHERE Uid = '" + uid + "' AND Password = '" + password + "' AND Role = '" + role + "'";
                    SqlDataAdapter sda = new SqlDataAdapter(query, con);

                    DataTable dTable = new DataTable();
                    sda.Fill(dTable);

                    if (dTable.Rows.Count > 0)
                    {
                        uid = uid_field.Text;
                        password = password_field.Text;
                        role = role_select_field.Text;

                        Voter_Home voter_home = new Voter_Home();
                        voter_home.userName = uid_field.Text;
                        voter_home.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Error! Invalid Credentials\nCheck Username and Password and Role");
                    }
                }
                else if (role == "Head Supervisor")
                {
                    string query = "SELECT * FROM User_Info WHERE Uid = '" + uid + "' AND Password = '" + password + "' AND Role = '" + role + "'";
                    SqlDataAdapter sda = new SqlDataAdapter(query, con);

                    DataTable dTable = new DataTable();
                    sda.Fill(dTable);

                    if (dTable.Rows.Count > 0)
                    {
                        uid = uid_field.Text;
                        password = password_field.Text;
                        role = role_select_field.Text;

                        Head_Supervisor_Home head_supervisor_home = new Head_Supervisor_Home();
                        head_supervisor_home.userName = uid_field.Text;
                        head_supervisor_home.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Error! Invalid Credentials\nCheck Username and Password and Role");
                    }
                }
                else if (role == "Division Supervisor")
                {
                    string query = "SELECT * FROM User_Info WHERE Uid = '" + uid + "' AND Password = '" + password + "' AND Role = '" + role + "'";
                    SqlDataAdapter sda = new SqlDataAdapter(query, con);

                    DataTable dTable = new DataTable();
                    sda.Fill(dTable);

                    if (dTable.Rows.Count > 0)
                    {
                        uid = uid_field.Text;
                        password = password_field.Text;
                        role = role_select_field.Text;

                        Division_Supervisor_Home division_supervisor_home = new Division_Supervisor_Home();
                        division_supervisor_home.userName = uid_field.Text;
                        division_supervisor_home.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Error! Invalid Credentials\nCheck Username and Password and Role");
                    }
                }
            }
            catch
            {
                MessageBox.Show("Error 404! User Not Found");
            }
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

        private void forgot_password_MouseClick(object sender, MouseEventArgs e)
        {
            Reset_Password forgot_password = new Reset_Password();
            forgot_password.Show();
            this.Hide();
        }
    }
}
