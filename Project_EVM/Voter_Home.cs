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
    public partial class Voter_Home : Form
    {
        public string userName { set; get; }

        SqlConnection con = new SqlConnection("data source =DESKTOP-GDKI8TK\\SQLEXPRESS; database =OOP2_Project;" +
                                   "integrated security = SSPI");

        public Voter_Home()
        {
            InitializeComponent();
        }

        private void Voter_Home_Load(object sender, EventArgs e)
        {
            id_label.Text = userName;
        }

        private void logout_btn_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void help_btn_Click(object sender, EventArgs e)
        {
            Contact_Us help = new Contact_Us();
            help.id = id_label.Text;
            help.Show();
            this.Hide();
        }

        private void apply_btn_Click(object sender, EventArgs e)
        {
            Apply apply = new Apply();
            apply.id = id_label.Text;
            apply.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" My fellow citizens, I stand before you today\n" +
                " pledging an unwavering commitment to serving the people.\n" +
                " If elected, I vow to fight tirelessly for economic\n" +
                " opportunity for all, a world-class education system that\n" +
                " prepares our children for the future, and a nation of\n" +
                " safety and security where justice and freedom reign supreme.\n" +
                " With integrity as my guiding light, I will work each day to\n" +
                " uplift our communities, strengthen families, and protect\n" +
                " this great country we call home. Together, we will build\n" +
                " a better, brighter, and more prosperous tomorrow.\n" +
                " You have my solemn vow.");
        }

        private void label4_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" We stand at a crossroads -- a moment to choose\n" +
                " unity over division, progress over gridlock, vision over\n" +
                " complacency. If elected as your leader, I vow to be a voice\n" +
                " for the voiceless, a champion for working families, and a\n" +
                " force for real, lasting change. Together, we will rebuild our\n" +
                " crumbling infrastructure, invest in clean energy jobs, and\n" +
                " make quality healthcare a right for all our citizens --\n " +
                " not just the privileged few. This is our chance to get our\n" +
                " nation back on track and restore faith in the democracy we\n" +
                " cherish. With hope as our catalyst, we will rise above\n" +
                " pettiness and partisanship to tackle our greatest challenges\n" +
                " head on. You have my ironclad promise to fight for you every\n" +
                " single day and build the brighter future we all deserve.");
        }

        private void label2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" My fellow citizens, I pledge to be a tireless\n" +
                " champion for the people. If elected, I vow to create economic\n" +
                " opportunity for all, build a world-class education system,\n" +
                " and ensure safety and justice across our nation. Integrity\n" +
                " will be my guiding light as we uplift communities, strengthen\n" +
                " families, and protect this great country we call home.\n" +
                " Together, we'll forge a brighter, more prosperous future.\n" +
                " You have my solemn vow to fight for you each day and never\n" +
                " quit until our vision becomes reality. United, we cannot be\n" +
                " defeated. A new dawn awaits.");
        }

        private bool check_uid(string uid)
        {
            bool check_uid = false;

            try
            {
                string query = "SELECT * FROM Vote_db where Uid_Voter= '" + uid + "'";
                SqlDataAdapter sda = new SqlDataAdapter(query, con);

                DataTable dTable = new DataTable();
                sda.Fill(dTable);

                if (dTable.Rows.Count >= 0)
                {
                    uid = id_label.Text;
                    check_uid = true;
                }
            }
            catch
            {
                MessageBox.Show("Error 404!");
            }
            finally
            {
                con.Close();
            }

            return check_uid;
        }

        private void castVote(string party_id, string uid, string name)
        {
            if (check_uid(uid))
            {
                try
                {
                    con.Open();

                    string sql = "INSERT INTO Vote_db(Party_ID,Uid_Voter,Party_Name) VALUES(" +
                        "'" + party_id + "'," +
                        "'" + uid + "'," +
                        "'" + name + "'" +
                        ")";

                    using (SqlCommand cmd = new SqlCommand(sql, con))
                    {
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Voting Complete");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
                finally
                {
                    con.Close();
                }
            }
            else
            {
                MessageBox.Show("ID Already Voted");
            }
        }

        private void p1_vote_btn_Click(object sender, EventArgs e)
        {
            string id = id_label.Text;
            string party_id = "1";
            castVote(party_id,id,"Party A");
        }

        private void p2_vote_btn_Click(object sender, EventArgs e)
        {
            string id = id_label.Text;
            string party_id = "2";
            castVote(party_id, id, "Party B");
        }

        private void p3_vote_btn_Click(object sender, EventArgs e)
        {
            string id = id_label.Text;
            string party_id = "3";
            castVote(party_id, id, "Party C");
        }
    }
}
