using System;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;

namespace BookStoreApplication.AdministratorUC
{
    public partial class UC_Adduser : UserControl
    {
        function fn = new function();
        string query;
        public UC_Adduser()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {

            if (userRole.Text == "" || txtName.Text == "" || txtDob.Text == "" || txtMobileNumber.Text == "" || txtEmailAddress.Text == "" || txtUserName.Text == "" || txtPassword.Text == "")
            {
                MessageBox.Show("Please fill all the blanks.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            else
            {

                try
                {
                    string role = userRole.Text;
                    string name = txtName.Text;
                    string dob = txtDob.Text;
                    Int64 mobile = Int64.Parse(txtMobileNumber.Text);
                    string email = txtEmailAddress.Text;
                    string username = txtUserName.Text;
                    string pass = txtPassword.Text;

                    query = "insert into users(userRole,name,dob,mobile,email,username,pass) values('" + role + "','" + name + "','" + dob + "'," + mobile + ",'" + email + "','" + username + "','" + pass + "')";
                    fn.setData(query, "Added successfully.");

                }
                catch (Exception)
                {
                    MessageBox.Show("Invalid input of something.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                /*string connectionString = "Data Source=LAPTOP-5J0IRN8J\\SQLEXPRESS03;Initial Catalog=book_store;Integrated Security=True";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Check if the username already exists
                    SqlCommand checkCmd = new SqlCommand("SELECT COUNT(*) FROM user_table WHERE username = @username", connection);
                    checkCmd.Parameters.AddWithValue("@username", txtUserName.Text);

                    int userCount = (int)checkCmd.ExecuteScalar();

                    if (userCount > 0)
                    {
                        // Username already exists, handle accordingly (e.g., show a message)
                        MessageBox.Show("Username already exists. Please choose a different username.");
                    }
                    else
                    {
                        // Username does not exist, proceed to add the user
                        SqlCommand insertCmd = new SqlCommand("INSERT INTO user_table (username, name, password, mobileNumber, email) " +
                                                              "VALUES (@username, @name, @password, @mobileNumber, @email)", connection);

                        // Assuming you have TextBox controls named txtname, txtpassword, txtmobile, and txtemail for the user's name, password, mobile number, and email respectively
                        insertCmd.Parameters.AddWithValue("@username", txtUserName.Text);
                        insertCmd.Parameters.AddWithValue("@name", name.Text);
                        insertCmd.Parameters.AddWithValue("@password", txtPassword.Text);
                        insertCmd.Parameters.AddWithValue("@mobileNumber", txtMobileNumber.Text);
                        insertCmd.Parameters.AddWithValue("@email", txtEmailAddress.Text);

                        int rowsAffected = insertCmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            // User added successfully, you can show a success message or perform any additional actions
                            MessageBox.Show("User added successfully.");
                        }
                        else
                        {
                            // Error occurred while adding the user
                            MessageBox.Show("Error adding user. Please try again.");
                        }
                      */

            }
        }

        private void gunaButton2_Click(object sender, EventArgs e)
        {
            clearAll();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void UC_Adduser_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void addBtn_Click(object sender, EventArgs e)
        {

        }
        public void clearAll()
        {
            txtName.Clear();
            txtDob.ResetText();
            txtMobileNumber.Clear();
            txtEmailAddress.Clear();
            txtUserName.Clear();
            txtPassword.Clear();

        }

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {
            query = "select * from users where username='" + txtUserName.Text + "'";
            DataSet ds = fn.getData(query);
            if (ds.Tables[0].Rows.Count == 0)
            {
                pictureBox1.ImageLocation = @"C:\\Users\\risha\\OneDrive\\Pictures\\C# project pictures\\Pharmacy Management System in C#\\yes.png";
            }
            else
            {

                pictureBox1.ImageLocation = @"C:\\Users\\risha\\OneDrive\\Pictures\\C# project pictures\\Pharmacy Management System in C#\\no.png";

            }
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }
    }
}
