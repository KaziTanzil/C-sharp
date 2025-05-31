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
    public partial class Apply : Form
    {
        public string id { get; set; }

        SqlConnection con = new SqlConnection("data source =DESKTOP-GDKI8TK\\SQLEXPRESS; database =OOP2_Project;" +
                                   "integrated security = SSPI");

        public Apply()
        {
            InitializeComponent();
        }

        private void Apply_Load(object sender, EventArgs e)
        {
            id_label.Text = id;
        }

        private void logout_btn_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            Voter_Home voter_Home = new Voter_Home();
            voter_Home.userName = id_label.Text;
            voter_Home.Show();
            this.Hide();
        }

        private void district_select_MouseClick(object sender, MouseEventArgs e)
        {
            district_select.Items.Clear();


            if (string.IsNullOrWhiteSpace(division_select.Text))
            {
                district_select.Items.Add("Select Division");
            }
            else
            {
                if (division_select.Text == "Dhaka")
                {
                    string[] Dhaka_Districts =
                    {
                        "Dhaka", "Faridpur", "Gazipur", "Gopalganj", "Kishoreganj","Madaripur", "Manikganj","Munshiganj", "Narayanganj", "Narsingdi","Rajbari", "Shariatpur", "Tangail"
                    };

                    district_select.Items.AddRange(Dhaka_Districts);
                }
                else if (division_select.Text == "Chattogram")
                {
                    string[] Chattogram_Districts =
                    {
                        "Brahmanbaria","Comilla","Chandpur","Lakshmipur","Noakhali","Feni","Khagrachhari","Rangamati","Bandarban","Chittagong","Cox's Bazar"
                    };

                    district_select.Items.AddRange(Chattogram_Districts);
                }
                else if (division_select.Text == "Barishal")
                {
                    string[] Barishal_Districts =
                    {
                        "Barishal", "Patuakhali", "Bhola", "Pirojpur", "Barguna", "Jhalokati"
                    };

                    district_select.Items.AddRange(Barishal_Districts);
                }
                else if (division_select.Text == "Khulna")
                {
                    string[] Khulna_Districts =
                    {
                        "Khulna", "Bagherhat", "Sathkhira", "Jessore", "Magura", "Jhenaidah", "Narail", "Kushtia", "Chuadanga", "Meherpur"
                    };

                    district_select.Items.AddRange(Khulna_Districts);
                }
                else if (division_select.Text == "Rajshahi")
                {
                    string[] Rajshahi_Districts =
                    {
                        "Rajshahi", "Chapainawabganj", "Natore", "Naogaon", "Pabna", "Sirajganj", "Bogra", "Joypurhat"
                    };

                    district_select.Items.AddRange(Rajshahi_Districts);
                }
                else if (division_select.Text == "Rangpur")
                {
                    string[] Rangpur_Districts =
                    {
                        "Rangpur", "Gaibandha", "Nilphamari", "Kurigram", "Lalmonirhat", "Dinajpur", "Thakurgaon", "Panchagarh"
                    };

                    district_select.Items.AddRange(Rangpur_Districts);
                }
                else if (division_select.Text == "Mymensingh")
                {
                    string[] Mymensingh_Districts =
                    {
                        "Mymensingh", "Jamalpur", "Netrokona", "Sherpur"
                    };

                    district_select.Items.AddRange(Mymensingh_Districts);
                }
                else if (division_select.Text == "Sylhet")
                {
                    string[] Sylhet_Districts =
                    {
                        "Habiganj", "Moulvibazar", "Sunamganj", "Sylhet"
                    };

                    district_select.Items.AddRange(Sylhet_Districts);
                }
                else
                {
                    division_select.Items.Add("Select Division");
                }

            }
        }

        public bool field_check(string name, string uid, string division, string district, string partyName, string reason)
        {
            bool field_check = false;

            if (name == "")
            {
                MessageBox.Show("Enter your Name");
            }
            else if (uid == "")
            {
                MessageBox.Show("Enter your ID");
            }
            else if (division == "")
            {
                MessageBox.Show("Enter your Division");
            }
            else if (district == "")
            {
                MessageBox.Show("Enter your District");
            }
            else if (partyName == "")
            {
                MessageBox.Show("Enter your Party's Name");
            }
            else if (reason == "")
            {
                MessageBox.Show("Enter your Reason");
            }
            else
            {
                field_check = true;
            }

            return field_check;
        }

        private void apply_btn_Click(object sender, EventArgs e)
        {
            string name = name_field.Text;
            string uid = uid_field.Text;
            string division = division_select.Text;
            string district = district_select.Text;
            string partyName = party_field.Text;
            string reason = reason_field.Text;

            if (field_check(name, uid, division, district, partyName, reason))
            {
                if (uid != id_label.Text)
                {
                    MessageBox.Show("Enter Your ID");
                }
                else
                {
                    try
                    {
                        con.Open();

                        string sql = "INSERT INTO Candidacy_db(Name,Uid_Candidate,Division,District,Party_Name,Reason) VALUES(" +
                            "'" + name + "', " +
                            "'" + uid + "', " +
                            "'" + division + "', " +
                            "'" + district + "', " +
                            "'" + partyName + "', " +
                            "'" + reason + "'" +
                            ")";

                        using (SqlCommand cmd = new SqlCommand(sql, con))
                        {
                            cmd.ExecuteNonQuery();

                            MessageBox.Show("Application Sent");
                            name_field.Text = "";
                            uid_field.Text = "";
                            division_select.Text = "";
                            district_select.Text = "";
                            party_field.Text = "";
                            reason_field.Text = "";
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
            }
        }
    }
}
