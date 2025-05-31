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
    public partial class Contact_Us : Form
    {
        public string id { set; get; }

        SqlConnection con = new SqlConnection("data source =DESKTOP-GDKI8TK\\SQLEXPRESS; database =OOP2_Project;" +
                                   "integrated security = SSPI");

        public Contact_Us()
        {
            InitializeComponent();
        }

        private void Help_Load(object sender, EventArgs e)
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
            Voter_Home voter_home = new Voter_Home();
            voter_home.userName = id_label.Text;
            voter_home.Show();
            this.Hide();
        }

        private void upload_img_btn_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                report_img.Image = new Bitmap(openFileDialog.FileName);
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

        private void submit_btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (uid_field.Text == null || uid_field.Text == "")
                {
                    MessageBox.Show("Enter your ID.");
                }
                else if (report_field.Text == null || report_field.Text == "")
                {
                    MessageBox.Show("Enter your issue.");
                }
                else
                {
                    con.Open();

                    string uid = uid_field.Text;
                    string gmail = gmail_field.Text;
                    string report = report_field.Text;

                    byte[] imgData = ImageToByteArray(report_img.Image);

                    string sql = "INSERT INTO Contact_Us(Uid_Contact,Gmail,Report,Report_Img) VALUES(" +
                                "'" + uid + "', " +
                                "'" + gmail + "', " +
                                "'" + report + "', " +
                                "@Image)";

                    using (SqlCommand cmd = new SqlCommand(sql, con))
                    {
                        cmd.Parameters.Add("@Image", SqlDbType.Image).Value = imgData;
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Authorities have been notified.");

                        uid_field.Text = "";
                        gmail_field.Text = "";
                        report_field.Text = "";
                        report_img.Image = null;
                    }
                }
            }
            catch(Exception ex)
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
