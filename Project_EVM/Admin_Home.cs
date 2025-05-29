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
    public partial class Admin_Home : Form
    {
        public string adminName { get; set; }

        SqlConnection con = new SqlConnection("data source =DESKTOP-GDKI8TK\\SQLEXPRESS; database =OOP2_Project;" +
                                   "integrated security = SSPI");

        public Admin_Home()
        {
            InitializeComponent();
        }

        private void Admin_Home_Load(object sender, EventArgs e)
        {
            id_label.Text = adminName;
        }

        private void logout_btn_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void user_info_btn_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM User_Info";
            fill_User_Info(query);

            gridView_label.Text = "Showing User Info";
            search_user_btn.BringToFront();
            delete_user_btn.BringToFront();
        }

        private void fill_User_Info(string query)
        {
            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                con.Open();

                SqlDataReader reader = cmd.ExecuteReader();

                DataTable dTable = new DataTable();
                dTable.Load(reader);

                db_gridview.DataSource = dTable;

                con.Close();
            }
        }

        private void search_user_btn_Click(object sender, EventArgs e)
        {
            string search = search_field.Text;

            if (!string.IsNullOrWhiteSpace(search))
            {
                string query = $"SELECT * FROM User_Info WHERE Name LIKE '%{search}%' OR Uid LIKE '%{search}%' OR Uname LIKE '%{search}%'";
                fill_User_Info(query);
            }
        }

        private void delete_user_btn_Click(object sender, EventArgs e)
        {
            string delete = delete_search.Text;

            if (delete_search.Text == null || delete_search.Text == "")
            {
                MessageBox.Show("Enter ID To Delete User");
            }
            else
            {
                string query = $"DELETE FROM User_Info WHERE Uid = {delete}";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    try
                    {
                        con.Open();

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Deleted");
                        }
                        else
                        {
                            MessageBox.Show("No Record Found");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex);
                    }
                    finally
                    {
                        con.Close();
                    }
                }
            }
        }

        private void admin_info_btn_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM Admin_Info";
            fill_Admin_Info(query);

            gridView_label.Text = "Showing Admin Info";
            search_admin_btn.BringToFront();
            delete_admin_btn.BringToFront();
        }

        private void fill_Admin_Info(string query)
        {
            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                con.Open();

                SqlDataReader reader = cmd.ExecuteReader();

                DataTable dTable = new DataTable();
                dTable.Load(reader);

                db_gridview.DataSource = dTable;

                con.Close();
            }
        }

        private void search_admin_btn_Click(object sender, EventArgs e)
        {
            string search = search_field.Text;

            if (!string.IsNullOrWhiteSpace(search))
            {
                string query = $"SELECT * FROM Admin_Info WHERE Aid LIKE '%{search}%'";
                fill_Admin_Info(query);
            }
        }

        private void delete_admin_btn_Click(object sender, EventArgs e)
        {
            string delete = delete_search.Text;

            if (delete_search.Text == null || delete_search.Text == "")
            {
                MessageBox.Show("Enter ID To Delete User");
            }
            else
            {
                string query = $"DELETE FROM Admin_Info WHERE Uname = {delete}";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    try
                    {
                        con.Open();

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Deleted");
                        }
                        else
                        {
                            MessageBox.Show("No Record Found");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex);
                    }
                    finally
                    {
                        con.Close();
                    }
                }
            }
        }

        private void reports_btn_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM Contact_Us";
            fill_reports(query);

            gridView_label.Text = "Showing Reports Issued";
            delete_report_btn.BringToFront();
        }

        private void fill_reports(string query)
        {
            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                con.Open();

                SqlDataReader reader = cmd.ExecuteReader();

                DataTable dTable = new DataTable();
                dTable.Load(reader);

                db_gridview.DataSource = dTable;

                con.Close();
            }
        }

        private void delete_report_btn_Click(object sender, EventArgs e)
        {
            string delete = delete_search.Text;

            if (delete_search.Text == null || delete_search.Text == "")
            {
                MessageBox.Show("Enter ID To Delete User");
            }
            else
            {
                string query = $"DELETE FROM Contact_Us WHERE Uid_Contact = {delete}";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    try
                    {
                        con.Open();

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Deleted");
                        }
                        else
                        {
                            MessageBox.Show("No Record Found");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex);
                    }
                    finally
                    {
                        con.Close();
                    }
                }
            }
        }

        private void applications_btn_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM Candidacy_db";
            fill_candidacy(query);

            gridView_label.Text = "Showing Candidate List";
            delete_application_btn.BringToFront();
        }

        private void fill_candidacy(string query)
        {
            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                con.Open();

                SqlDataReader reader = cmd.ExecuteReader();

                DataTable dTable = new DataTable();
                dTable.Load(reader);

                db_gridview.DataSource = dTable;

                con.Close();
            }
        }

        private void delete_application_btn_Click(object sender, EventArgs e)
        {
            string delete = delete_search.Text;

            if (delete_search.Text == null || delete_search.Text == "")
            {
                MessageBox.Show("Enter ID To Delete User");
            }
            else
            {
                string query = $"DELETE FROM Candidacy_db WHERE Uid_Candidate = {delete}";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    try
                    {
                        con.Open();

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Deleted");
                        }
                        else
                        {
                            MessageBox.Show("No Record Found");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex);
                    }
                    finally
                    {
                        con.Close();
                    }
                }
            }
        }

        private void update_btn_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in db_gridview.Rows)
            {
                if (!row.IsNewRow && row.Selected)
                {
                    int userID = Convert.ToInt32(row.Cells["Uid"].Value);

                    SqlCommand cmd = new SqlCommand("UPDATE User_Info SET Name=@Name, Age=@Age, Uname=@Uname, Password=@Password, Gmail=@Gmail WHERE Uid=@UserID", con);

                    cmd.Parameters.AddWithValue("@Name", row.Cells["Name"].Value);
                    cmd.Parameters.AddWithValue("@Age", row.Cells["Age"].Value);
                    cmd.Parameters.AddWithValue("@Uname", row.Cells["Uname"].Value);
                    cmd.Parameters.AddWithValue("@Password", row.Cells["Password"].Value);
                    cmd.Parameters.AddWithValue("@Gmail", row.Cells["Gmail"].Value);
                    cmd.Parameters.AddWithValue("@UserID", userID);

                    try
                    {
                        con.Open();
                        cmd.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error updating user info: " + ex.Message);
                    }
                    finally
                    {
                        con.Close();
                    }
                }
            }

            MessageBox.Show("User Info Updated");
        }
    }
}