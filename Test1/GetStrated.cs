using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;



namespace Test1
{
    public partial class GetStrated : Form
    {
        string random_number;
        int i;
        
        public GetStrated()
        {
            InitializeComponent();
        }
        
        Database db = new Database();
        

        private void btn_close_Click(object sender, EventArgs e)
        {
            Hide();
            Home obj = new Home();
            obj.ShowDialog();
        }

        private void btn_sendOtp_Click(object sender, EventArgs e)
        {
            string result;
            string apiKey = "d0Ddt1kIVgnAu0zmO7ck";
            string user_id = "25262";
            string numbers = txt_teleNo.Text; // in a comma-separated list

            string sender_id = "NotifyDEMO";
            string name = txt_name.Text;
            Random rand = new Random();
            random_number = rand.Next(100000, 999999).ToString();
            string message = $"Hey {name}! Your OTP code is {random_number}";

            string url = $"https://app.notify.lk/api/v1/send?user_id={user_id}&api_key={apiKey}&sender_id={sender_id}&to={numbers}&message={message}";

            HttpWebRequest objRequest = (HttpWebRequest)WebRequest.Create(url);
            objRequest.Method = "POST";

            try
            {
                HttpWebResponse objResponse = (HttpWebResponse)objRequest.GetResponse();
                using (StreamReader sr = new StreamReader(objResponse.GetResponseStream()))
                {
                    result = sr.ReadToEnd();
                    // Close and clean up the StreamReader
                    sr.Close();
                }
                MessageBox.Show("OTP Sent Successfully To You!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error sending OTP: " + ex.Message);
            }
        }

        private void btn_verify_Click(object sender, EventArgs e)
        {
            if (txt_otp.Text == random_number)
            {
                i = 1;
                MessageBox.Show("Verification Successfull.Now Click Save button", "info",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Wrong OTP code", "error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            
                try
                {
                    string query = "Insert into UserDetails values ('" + txt_name.Text + "', '" + txt_address.Text + "', '" + txt_email.Text + "','" + txt_password.Text + "','" + txt_age.Text + "','" + txt_teleNo.Text + "')";
                    i = db.save_update_delete(query);
                    if (i == 1)
                        MessageBox.Show("Data save Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("Data Cannot Save", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            catch (SqlException)
                {
                    MessageBox.Show("Sql Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            catch (Exception)
                {
                    MessageBox.Show("Please check again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
        }


        private void btn_check_Click(object sender, EventArgs e)
        {
        
        if (string.IsNullOrEmpty(txt_name.Text))
        {
            error_msg.Text = "User Name cannot be blank";
            txt_name.Focus();
        }
         else if (txt_name.Text.Any(char.IsDigit))
        {
            error_msg.Text = "User Name cannot have numbers";
            txt_name.Focus();
        }
         else if (string.IsNullOrEmpty(txt_address.Text))
        {
            error_msg.Text = "Address cannot be blank";
            txt_name.Focus();
        }
         else if (txt_email.Text.Length == 0)
        {
            error_msg.Text = "Please Enter Email Address";
            txt_email.Focus();
        }
         else if (!Regex.IsMatch(txt_email.Text, @"^[a-zA-Z][\w\.-]*[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$"))
        {
            error_msg.Text = "Enter a valid email. Ex:name@gmail.com";
            txt_email.Focus();
        }
         else if (txt_password.Text.Length == 0)
        {
            error_msg.Text = "Please Enter your Password";
            txt_password.Focus();
        }
         else if (txt_checkpasword.Text.Length == 0)
        {
            error_msg.Text = "Please Enter your Confirm Password";
            txt_checkpasword.Focus();
        }
         else if (txt_password.Text != txt_checkpasword.Text)
        {
            error_msg.Text = "Confirm Password must same as the Password";
            txt_checkpasword.Focus();
        }
         else if (string.IsNullOrEmpty(txt_age.Text))
        {
            error_msg.Text = "Age cannot be blank";
            txt_age.Focus();
        }
        else if (!int.TryParse(txt_age.Text, out int age) || age < 14 || age > 70)
        {
             error_msg.Text = "Age must be a number between 14 and 70";
             txt_age.Focus();
        }

            else if (!Regex.IsMatch(txt_teleNo.Text, @"^(?:\+94|94)\d{9}$"))
         {
            error_msg.Text = "TP must have 10 numbers";
            txt_teleNo.Focus();
         }

        else
        {
            error_msg.Text = "";
            MessageBox.Show("Now Click Send OTP butoon", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        }

        private void GetStrated_Load(object sender, EventArgs e)
        {

        }

        private void txt_password_TextChanged(object sender, EventArgs e)
        {
            this.txt_password.PasswordChar = '*';
        }

        private void txt_checkpasword_TextChanged(object sender, EventArgs e)
        {
           this.txt_checkpasword.PasswordChar = '*';
        }

        private void btn_continue_Click(object sender, EventArgs e)
        {
            Hide();
            Home obj= new Home();
            obj.ShowDialog();
        }
    }
    
}
