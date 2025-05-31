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
    public partial class Division_Supervisor_Home : Form
    {
        public string userName { set; get; }

        SqlConnection con = new SqlConnection("data source =DESKTOP-GDKI8TK\\SQLEXPRESS; database =OOP2_Project;" +
                                   "integrated security = SSPI");

        public Division_Supervisor_Home()
        {
            InitializeComponent();
        }

        private void Division_Supervisor_Home_Load(object sender, EventArgs e)
        {
            id_label.Text = userName;
            load_btn.Enabled = false;
        }

        private void logout_btn_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void divisionSelect(string divName)
        {
            if (divName == "Dhaka" && s_question_field.Text == "Traffic_Jam")
            {
                string query = "SELECT * FROM User_Info WHERE Division=@Division";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@Division", divName);

                    try
                    {
                        SqlDataAdapter sda = new SqlDataAdapter(cmd);
                        DataSet dSet = new DataSet();

                        con.Open();

                        sda.Fill(dSet);

                        con.Close();

                        division_gridview.DataSource = dSet.Tables[0];
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erroe: " + ex.Message);
                    }
                }
            }
            else if (divName == "Chattogram" && s_question_field.Text == "My_Chicago")
            {
                string query = "SELECT * FROM User_Info WHERE Division=@Division";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@Division", divName);

                    try
                    {
                        SqlDataAdapter sda = new SqlDataAdapter(cmd);
                        DataSet dSet = new DataSet();

                        con.Open();

                        sda.Fill(dSet);

                        con.Close();

                        division_gridview.DataSource = dSet.Tables[0];
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erroe: " + ex.Message);
                    }
                }
            }
            else if (divName == "Rajshahi" && s_question_field.Text == "Him_shagor")
            {
                string query = "SELECT * FROM User_Info WHERE Division=@Division";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@Division", divName);

                    try
                    {
                        SqlDataAdapter sda = new SqlDataAdapter(cmd);
                        DataSet dSet = new DataSet();

                        con.Open();

                        sda.Fill(dSet);

                        con.Close();

                        division_gridview.DataSource = dSet.Tables[0];
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erroe: " + ex.Message);
                    }
                }
            }
            else if (divName == "Khulna" && s_question_field.Text == "Royal_Bengal")
            {
                string query = "SELECT * FROM User_Info WHERE Division=@Division";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@Division", divName);

                    try
                    {
                        SqlDataAdapter sda = new SqlDataAdapter(cmd);
                        DataSet dSet = new DataSet();

                        con.Open();

                        sda.Fill(dSet);

                        con.Close();

                        division_gridview.DataSource = dSet.Tables[0];
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erroe: " + ex.Message);
                    }
                }
            }
            else if (divName == "Sylhet" && s_question_field.Text == "Tea_Garden")
            {
                string query = "SELECT * FROM User_Info WHERE Division=@Division";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@Division", divName);

                    try
                    {
                        SqlDataAdapter sda = new SqlDataAdapter(cmd);
                        DataSet dSet = new DataSet();

                        con.Open();

                        sda.Fill(dSet);

                        con.Close();

                        division_gridview.DataSource = dSet.Tables[0];
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erroe: " + ex.Message);
                    }
                }
            }
            else if (divName == "Barisal" && s_question_field.Text == "Padma_Bridge")
            {
                string query = "SELECT * FROM User_Info WHERE Division=@Division";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@Division", divName);

                    try
                    {
                        SqlDataAdapter sda = new SqlDataAdapter(cmd);
                        DataSet dSet = new DataSet();

                        con.Open();

                        sda.Fill(dSet);

                        con.Close();

                        division_gridview.DataSource = dSet.Tables[0];
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erroe: " + ex.Message);
                    }
                }
            }
            else if (divName == "Rangpur" && s_question_field.Text == "Color_Ful")
            {
                string query = "SELECT * FROM User_Info WHERE Division=@Division";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@Division", divName);

                    try
                    {
                        SqlDataAdapter sda = new SqlDataAdapter(cmd);
                        DataSet dSet = new DataSet();

                        con.Open();

                        sda.Fill(dSet);

                        con.Close();

                        division_gridview.DataSource = dSet.Tables[0];
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erroe: " + ex.Message);
                    }
                }
            }
            else if (divName == "Mymensingh" && s_question_field.Text == "B_A_U")
            {
                string query = "SELECT * FROM User_Info WHERE Division=@Division";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@Division", divName);

                    try
                    {
                        SqlDataAdapter sda = new SqlDataAdapter(cmd);
                        DataSet dSet = new DataSet();

                        con.Open();

                        sda.Fill(dSet);

                        con.Close();

                        division_gridview.DataSource = dSet.Tables[0];
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erroe: " + ex.Message);
                    }
                }
            }
        }

        private void s_question_field_TextChanged(object sender, EventArgs e)
        {
            load_btn.Enabled = true;
        }

        private void load_btn_Click(object sender, EventArgs e)
        {
            if (division_select.Text == null || division_select.Text == "")
            {
                MessageBox.Show("Specify your division.");
            }
            else
            {
                string division = division_select.Text;
                divisionSelect(division);
            }
        }

        
    }
}