using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LogIn_database
{
    public partial class Form1 : Form
    {
        private const string conn = "Data Source=LAPTOP-A8STJPUQ\\SQLEXPRESS;Initial Catalog=signup;Integrated Security=True";
        public Form1()
        {
            InitializeComponent();
        }

        private void button_login_Click(object sender, EventArgs e)
        {
            string userID = textBox_user.Text;
            string password = textBox_password.Text;

            if (CheckIfUserIDExists(userID))
            {
                if (IsBuyer(userID, password))
                {
                    OpenBuyerPanel(userID, password);
                }
                else if (IsSeller(userID, password))
                {
                    OpenSellerPanel(userID, password);
                }
                else if (IsAdmin(userID, password))
                {
                    OpenAdminPanel(userID, password);
                }
                else
                {
                    MessageBox.Show("User not found.");
                }
            }
            else
            {
                MessageBox.Show("Invalid. Please try again.");
            }
        }

        private void textBox_user_TextChanged(object sender, EventArgs e)
        {
            
        }

        private bool CheckIfUserIDExists(string userID)
        {
            bool userIDExists = false;

            try
            {
                using (SqlConnection connection = new SqlConnection(conn))
                {
                    connection.Open();

                    

                    // Query for  Admin
                    string adminQuery = "SELECT * FROM [Admin] WHERE UPPER(User_Id) = UPPER(@UserID)";
                    SqlDataAdapter adminAdapter = new SqlDataAdapter(adminQuery, connection);
                    adminAdapter.SelectCommand.Parameters.AddWithValue("@UserID", userID);

                    DataTable adminTable = new DataTable();
                    adminAdapter.Fill(buyerTable);

                    // Check if either seller or buyer or admin exists
                    userIDExists = ((adminTable.Rows.Count > 0);

                    // If neither seller nor buyer found, display error message
                    if (!userIDExists)
                    {
                        MessageBox.Show("Invalid user ID. Please reenter ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle the exception, log it, or throw it further up the call stack.
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return userIDExists;
        }
    }
}
