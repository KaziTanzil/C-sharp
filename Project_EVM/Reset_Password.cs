using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;
using System.Net.Mail;
using System.Diagnostics;

namespace OOP2_Project
{
    public partial class Reset_Password : Form
    {
        private string verificationCode;

        SqlConnection con = new SqlConnection("data source =DESKTOP-GDKI8TK\\SQLEXPRESS; database =OOP2_Project;" +
                                       "integrated security = SSPI");

        public Reset_Password()
        {
            InitializeComponent();
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private bool emailExists(string gmail)
        {
            try
            {
                con.Open();

                string query = "SELECT COUNT(*) FROM User_Info WHERE Gmail = @gmail";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@gmail", gmail);

                    int count = (int)cmd.ExecuteScalar();
                    return count > 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                return false;
            }
            finally
            {
                con.Close();
            }
        }

        private string generateVerificationCode()
        {
            Random random = new Random();
            return random.Next(100000, 999999).ToString();
        }

        private void sendVerificationCodeByEmail(string gmail, string code)
        {
            try
            {
                MailMessage mail = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");

                mail.From = new MailAddress("kazitanjilkazitanjil@gmail.com");
                mail.To.Add(gmail);
                mail.Subject = "Verification Code";
                mail.Body = "Your verification code is: " + code;

                SmtpServer.Port = 587;
                SmtpServer.Credentials = new System.Net.NetworkCredential("kazitanjilkazitanjil@gmail.com", "qlzeiwkjdeokdzas");
                SmtpServer.EnableSsl = true;

                SmtpServer.Send(mail);
                Debug.WriteLine("Email sent successfully.");
                MessageBox.Show("Verification code sent to your email.");
            }
            catch (SmtpException ex)
            {
                Debug.WriteLine("Failed to send email: " + ex.StatusCode + " - " + ex.Message);
                MessageBox.Show("Failed to send email: " + ex.StatusCode + " - " + ex.Message);
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Error sending email: " + ex.Message);
                MessageBox.Show("Error sending email: " + ex.Message);
            }
        }

        private void code_btn_Click(object sender, EventArgs e)
        {
            string gmail = gmail_field.Text;

            if (!emailExists(gmail))
            {
                MessageBox.Show("Error 404!\nEmail not Found.");
                return;
            }

            verificationCode = generateVerificationCode();

            sendVerificationCodeByEmail(gmail, verificationCode);
        }

        private void confirm_btn_Click(object sender, EventArgs e)
        {
            string enteredCode = code_field.Text;
            string newPassword = p1_field.Text;
            string confirmPassword = p2_field.Text;

            if(enteredCode != verificationCode)
            {
                MessageBox.Show("Invalid verification code.");
                return;
            }
            if (string.IsNullOrEmpty(newPassword))
            {
                MessageBox.Show("New password cannot be empty.");
                return;
            }
            if (newPassword != confirmPassword)
            {
                MessageBox.Show("Passwords do not match.");
                return;
            }

            try
            {
                con.Open();

                string sql = "UPDATE User_Info SET Password = @newPassword WHERE Gmail = @gmail";
                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@newPassword", newPassword);
                    cmd.Parameters.AddWithValue("@gmail", gmail_field.Text);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Password updated successfully.");

                        Login login = new Login();
                        login.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Failed to update password.");
                    }
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
