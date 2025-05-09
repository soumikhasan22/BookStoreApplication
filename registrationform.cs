using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BookStoreApplication
{
    public partial class registrationform : Form
    {
        public registrationform()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Lginform().Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = "Data Source = LAPTOP-M46LEEKM\\SQLEXPRESS;Initial Catalog=BookUser;Integrated Security= True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = connection;
            string userrole = "Normal User";

            if (string.IsNullOrWhiteSpace(regname.Text) || string.IsNullOrWhiteSpace(regusername.Text) ||
                string.IsNullOrWhiteSpace(regpassword.Text) || string.IsNullOrWhiteSpace(regconpassword.Text) ||
                string.IsNullOrWhiteSpace(regmobile.Text) || string.IsNullOrWhiteSpace(regemail.Text) ||
                string.IsNullOrWhiteSpace(regdob.Text))
            {
                MessageBox.Show("Please fill in all the registration fields.", "Registration Failed!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (regpassword.Text == regconpassword.Text)
            {
                connection.Open();

                string register = "INSERT INTO users VALUES ('" + userrole + "','" + regname.Text + "','" + regdob.Text + "','" + regmobile.Text + "','" + regemail.Text + "','" + regusername.Text + "','" + regpassword.Text + "')";
                cmd = new SqlCommand(register, connection);
                cmd.ExecuteNonQuery();
                connection.Close();

                MessageBox.Show("Your account has been successfully created!", "Registration Success!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                regname.Clear();
                regusername.Clear();
                regpassword.Clear();
                regconpassword.Clear();
                regmobile.Clear();
                regemail.Clear();

            }
            else if (regusername.Text == "")
            {
                MessageBox.Show("Username field is empty", "Registration Failed!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Password do not match, please try again", "Registration failed");
                regpassword.Clear();
                regconpassword.Clear();
            }
        }


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void registrationform_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}