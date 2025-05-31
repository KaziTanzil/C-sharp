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
    public partial class Head_Supervisor_Home : Form
    {
        public string userName { set; get; }

        SqlConnection con = new SqlConnection("data source =DESKTOP-GDKI8TK\\SQLEXPRESS; database =OOP2_Project;" +
                                   "integrated security = SSPI");

        public Head_Supervisor_Home()
        {
            InitializeComponent();
        }

        private void Head_Supervisor_Home_Load(object sender, EventArgs e)
        {
            id_label.Text = userName;
        }

        private void logout_btn_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void party_a_btn_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM Vote_db WHERE Party_Name = 'Party A'";
            fill_a_Info(query);

            gridView_label.Text = "Showing Voter for Party A";
            search_a_btn.BringToFront();
        }

        private void fill_a_Info(string query)
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

        private void party_b_btn_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM Vote_db WHERE Party_Name = 'Party B'";
            fill_b_Info(query);

            gridView_label.Text = "Showing Voter for Party B";
            search_b_btn.BringToFront();
        }

        private void fill_b_Info(string query)
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

        private void party_c_btn_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM Vote_db WHERE Party_Name = 'Party C'";
            fill_c_Info(query);

            gridView_label.Text = "Showing Voter for Party C";
            search_c_btn.BringToFront();
        }

        private void fill_c_Info(string query)
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
    }
}
