using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Test1
{
    public partial class LogIN : Form
    {
        public LogIN()
        {
            InitializeComponent();
        }
        private const string connectionString = "Data Source=DESKTOP-NK2RF8T;Initial Catalog=PowerFit;Integrated Security=True";

        private void btn_close_Click(object sender, EventArgs e)
        {
            Hide();
            Home obj = new Home();
            obj.ShowDialog();
        }

        private void btn_logIn_Click(object sender, EventArgs e)
        {
            string enteredUsername = txt_uname.Text;
            string enteredPassword = txt_password.Text;

            if (IsCredentialsValid(enteredUsername, enteredPassword))
            {
                MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // Perform any actions you want after successful login

                Hide();
                Home obj=new Home();
                obj.ShowDialog();
            }
            else
            {
                MessageBox.Show("Invalid credentials. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // Clear the password field for re-entry
                txt_password.Clear();
            }

        }
        private bool IsCredentialsValid(string username, string password)
        {
            // Create a connection to the database
            using (SqlConnection connection = new SqlConnection("Data Source=DESKTOP-NK2RF8T;Initial Catalog=PowerFit;Integrated Security=True"))
            {
                try
                {
                    // Open the connection
                    connection.Open();

                    // Create a SQL command to retrieve the password for the entered username
                    string query = "SELECT Password FROM UserDetails WHERE UserName = @Username";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Add the username parameter to the SQL command
                        command.Parameters.AddWithValue("@Username", username);

                        // Execute the SQL command and retrieve the password from the database
                        string storedPassword = (string)command.ExecuteScalar();

                        // Compare the entered password with the stored password
                        return password == storedPassword;
                    }
                }
                catch (SqlException)
                {
                    MessageBox.Show("Sql Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                catch (Exception ex)
                {
                    // Handle any potential exceptions (e.g., database connection error)
                    MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
        }

        private void txt_password_TextChanged(object sender, EventArgs e)
        {
            this.txt_password.PasswordChar = '*';
        }
    }
}
