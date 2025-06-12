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
using System.IO;

namespace OOP2_Project
{
    public partial class User_Registration : Form
    {
        SqlConnection con = new SqlConnection("data source =DESKTOP-GDKI8TK\\SQLEXPRESS; database =OOP2_Project;" +
                                   "integrated security = SSPI");

        public User_Registration()
        {
            InitializeComponent();

        }

        private void User_Registration_Load(object sender, EventArgs e)
        {
            register_btn.Enabled = false;
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

        private void upload_img_btn_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                user_img.Image = new Bitmap(openFileDialog.FileName);
            }
        }

        private void tnc_check_CheckedChanged(object sender, EventArgs e)
        {
            if (tnc_check.Checked == true)
            {
                MessageBox.Show("By participating in the online voting system, you agree to the following terms and conditions:\n\n" +
"1. Eligibility and Authentication:\n   - Only authenticated and eligible voters are permitted to participate in the online voting process to ensure the genuineness and integrity of the voting system.\n\n" +
"2. Voting Accessibility:\n   - The online voting system is designed to provide high accessibility, allowing voters to cast their ballots securely from any location using various devices, including desktops, mobile devices, and web browsers.\n\n" +
"3. Voter Verification:\n   - Each voter will have a unique \"Voter ID\" and \"Voter Key\" and can only vote once. Additionally, a vote verification page will be provided, listing receipt numbers of all votes submitted, enabling voters to verify the submission of their votes anonymously.\n\n" +
"4. Terms of Service and Changes:\n   - By participating in the online voting system, you agree to the terms of service. While these terms are subject to change, any modifications are unlikely to occur frequently.\n\n" +
"5. Ballot Security and Integrity:\n   - The online voting system is designed to protect the integrity of votes by preventing multiple voting attempts and ensuring the secure transmission of ballots.\n\n" +
"6. Absentee and Mail-in Voting:\n   - The system supports absentee and mail-in voting, allowing eligible voters to cast their ballots without being physically present on the election day.\n\n" +
"7. Compliance with Election Laws:\n   - Participants are expected to comply with all relevant election laws and regulations governing the online voting process.\n\n" +
"By proceeding with the online voting process, you acknowledge that you have read, understood, and agreed to abide by these terms and conditions.\n\n" +
"Thank you for your cooperation, and we appreciate your commitment to ensuring a secure and accessible online voting experience.");

                register_btn.Enabled = true;
            }
        }

        private bool field_check(string name, string age, string gender, string uid, string fathers_name, string mothers_name, string uname, string password, string gmail, string role, string division, string district)
        {
            bool field_check = false;

            if(name == "")
            {
                MessageBox.Show("Enter your Name");
            }else if(age == "")
            {
                MessageBox.Show("Enter your Age");
            }
            else if (gender == "")
            {
                MessageBox.Show("Enter your Gender");
            }
            else if (uid == "")
            {
                MessageBox.Show("Enter your ID");
            }
            else if (fathers_name == "")
            {
                MessageBox.Show("Enter your Father's name");
            }
            else if (mothers_name == "")
            {
                MessageBox.Show("Enter your Mother's name");
            }
            else if (uname == "")
            {
                MessageBox.Show("Enter your Username");
            }
            else if (password == "")
            {
                MessageBox.Show("Enter your Password");
            }
            else if (gmail == "")
            {
                MessageBox.Show("Enter your Gmail");
            }
            else if (role == "")
            {
                MessageBox.Show("Enter your Role");
            }
            else if (division == "")
            {
                MessageBox.Show("Enter your Division");
            }
            else if (district == "")
            {
                MessageBox.Show("Enter your District");
            }
            else
            {
                field_check = true;
            }

            return field_check;
        }

        private bool check_uid(string uid)
        {
            bool check_uid = false;

            try
            {
                string query = "SELECT * FROM User_Info where Uid= '" + uid + "'";
                SqlDataAdapter sda = new SqlDataAdapter(query, con);

                DataTable dTable = new DataTable();
                sda.Fill(dTable);

                if (dTable.Rows.Count >= 0)
                {
                    uid = uid_field.Text;
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

        private bool gmail_check(string gmail)
        {
            try
            {
                var address = new System.Net.Mail.MailAddress(gmail);
                return address.Address == gmail;
            }
            catch
            {
                return false;
            }
        }

        private byte[] ImageToByteArray(Image user_img)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                user_img.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                return ms.ToArray();
            }
        }

        private void register_btn_Click(object sender, EventArgs e)
        {
            string name = name_field.Text;
            string age = age_field.Text;
            string gender = gender_select.Text;
            string uid = uid_field.Text;
            string fathers_name = fathers_name_field.Text;
            string mothers_name = mothers_name_field.Text;
            string uname = uname_field.Text;
            string password = password_field.Text;
            string gmail = gmail_field.Text;
            string role = role_select.Text;
            string district = district_select.Text;
            string division = division_select.Text;

            if (check_uid(uid))
            {
                if (field_check(name, age, gender, uid, fathers_name, mothers_name, uname, password, gmail, role, division, district)) {
                    if (!gmail_check(gmail))
                    {
                        MessageBox.Show("Please Enter a Valid Gmail");
                        return;
                    }

                    byte[] imgData = ImageToByteArray(user_img.Image);

                    try
                    {
                        con.Open();

                        string sql = "INSERT INTO User_Info(Name,Age,Gender,Uid,Fathers_Name,Mothers_Name,Uname,Password,Gmail,Role,Division,District,User_Img) VALUES(" +
                            "'" + name + "', " +
                            "'" + age + "', " +
                            "'" + gender + "', " +
                            "'" + uid + "', " +
                            "'" + fathers_name + "', " +
                            "'" + mothers_name + "', " +
                            "'" + uname + "', " +
                            "'" + password + "', " +
                            "'" + gmail + "', " +
                            "'" + role + "', " +
                            "'" + division + "', " +
                            "'" + district + "', " +
                            "@Image)";

                        using (SqlCommand cmd = new SqlCommand(sql, con))
                        {
                            cmd.Parameters.Add("@Image", SqlDbType.Image).Value = imgData;
                            cmd.ExecuteNonQuery();

                            MessageBox.Show("Registration Complete");

                            Login login = new Login();
                            login.Show();
                            this.Hide();
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
            else
            {
                MessageBox.Show("ID Already Registered");
                uid_field.Text = string.Empty;
            }
        }
    }
}
