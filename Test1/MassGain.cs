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

namespace Test1
{
    public partial class MassGain : Form
    {
        public MassGain()
        {
            InitializeComponent();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_select_Click(object sender, EventArgs e)
        {

            // Check if both ComboBox and TextBox have values
            if (cmb_massGain.SelectedItem != null && !string.IsNullOrWhiteSpace(txt_uname.Text))
            {
                // Get the selected item from the ComboBox and the value from the TextBox
                string selectedItem = cmb_massGain.SelectedItem.ToString();
                string textBoxValue = txt_uname.Text;

                if (IsUsernameExists(textBoxValue))
                {
                    MessageBox.Show("Username already exists. Please choose a different username.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return; // Abort the insertion process
                }

                // Insert the values into the database
                try
                {
                    using (SqlConnection connection = new SqlConnection("Data Source=DESKTOP-NK2RF8T;Initial Catalog=PowerFit;Integrated Security=True"))
                    {
                        connection.Open();

                        // Prepare the SQL query with parameterized query to prevent SQL injection
                        string query = "INSERT INTO SelectSchedule(PlanName,Usname) VALUES (@SelectedItem, @TextBoxValue)";
                        SqlCommand command = new SqlCommand(query, connection);

                        // Add parameters to the query
                        command.Parameters.AddWithValue("@SelectedItem", selectedItem);
                        command.Parameters.AddWithValue("@TextBoxValue", textBoxValue);

                        // Execute the query
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Values saved to the database successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Values not saved to the database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (SqlException)
                {
                    MessageBox.Show("Sql Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please select an item from the ComboBox and enter a value in the TextBox.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
        private bool IsUsernameExists(string username)
        {
            using (SqlConnection connection = new SqlConnection("Data Source=DESKTOP-NK2RF8T;Initial Catalog=PowerFit;Integrated Security=True"))
            {
                try
                {
                    connection.Open();

                    // Prepare the SQL query with parameterized query to prevent SQL injection
                    string query = "SELECT COUNT(*) FROM SelectSchedule WHERE Usname = @Username";
                    SqlCommand command = new SqlCommand(query, connection);

                    // Add parameter to the query
                    command.Parameters.AddWithValue("@Username", username);

                    // Execute the query and check if any rows are returned
                    int count = (int)command.ExecuteScalar();
                    return count > 0;
                }
                catch (SqlException)
                {
                    MessageBox.Show("Sql Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return true; // To be safe, consider returning true in case of a database error.
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return true; // To be safe, consider returning true in case of any other error.
                }
            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            // Check if both ComboBox and TextBox have values
            if (cmb_massGain.SelectedItem != null && !string.IsNullOrWhiteSpace(txt_uname.Text))
            {
                // Get the selected item from the ComboBox and the value from the TextBox
                string selectedItem = cmb_massGain.SelectedItem.ToString();
                string textBoxValue = txt_uname.Text;

                // Update the TrainerName in the database
                try
                {
                    using (SqlConnection connection = new SqlConnection("Data Source=DESKTOP-NK2RF8T;Initial Catalog=PowerFit;Integrated Security=True"))
                    {
                        connection.Open();

                        // Prepare the SQL query with parameterized query to prevent SQL injection
                        string query = "UPDATE SelectSchedule SET PlanName = @SelectedItem WHERE Usname = @TextBoxValue";
                        SqlCommand command = new SqlCommand(query, connection);

                        // Add parameters to the query
                        command.Parameters.AddWithValue("@SelectedItem", selectedItem);
                        command.Parameters.AddWithValue("@TextBoxValue", textBoxValue);

                        // Execute the query
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Schedule Name updated in the database successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("You Have not Selected a Schedule earlier.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (SqlException)
                {
                    MessageBox.Show("Sql Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please select an item from the ComboBox and enter a value in the TextBox.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
