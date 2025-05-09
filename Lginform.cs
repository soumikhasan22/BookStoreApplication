using BookStoreApplication.UserUC;
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

namespace BookStoreApplication
{
    public partial class Lginform : Form
    {
        function fn = new function();
        string query;
        DataSet ds;
        public Lginform()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtusername.Text) || string.IsNullOrWhiteSpace(txtpassword.Text))
            {
                MessageBox.Show("Please enter both username and password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                query = "select * from users";
                ds = fn.getData(query);

                if (ds.Tables[0].Rows.Count == 0)
                {
                    if (txtusername.Text == "root" && txtpassword.Text == "root")
                    {
                        AdminPanel ad = new AdminPanel();
                        ad.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Login failed. Invalid Username or Password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    query = "select * from users where username='" + txtusername.Text + "' and pass='" + txtpassword.Text + "'";
                    ds = fn.getData(query);

                    if (ds.Tables[0].Rows.Count != 0)
                    {
                        String storedPassword = ds.Tables[0].Rows[0]["pass"].ToString();

                        if (storedPassword == txtpassword.Text)
                        {
                            String role = ds.Tables[0].Rows[0][0].ToString();

                            if (role == "Admin User")
                            {
                                MessageBox.Show("Login Successful", "Success", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                AdminPanel admin = new AdminPanel();
                                admin.Show();
                                this.Hide();
                            }
                            else if (role == "Employee User")
                            {
                                MessageBox.Show("Login Successful", "Success", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                EmployeePanel emp = new EmployeePanel();
                                emp.Show();
                                this.Hide();
                            }
                            else if (role == "Normal User")
                            {
                                string user = txtusername.Text;
                                MessageBox.Show("Login Successful", "Success", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                UC_New us = new UC_New(user);
                                us.Show();
                                this.Hide();
                            }
                        }
                       
                    }
                    else
                    {
                        MessageBox.Show("Login failed. Invalid Username or Password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }





        private void label2_Click(object sender, EventArgs e)
        {
            txtusername.Clear();
            txtpassword.Clear();
            txtusername.Focus();
            
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();;
        }

        private void txtusername_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
           this.Hide();
            new registrationform().Show();
           
            

        }

        private void chkshowpassword_CheckedChanged(object sender, EventArgs e)
        {
            if(chkshowpassword.Checked)
            {
                txtpassword.UseSystemPasswordChar = true;
            }

            else
            {
                txtpassword.UseSystemPasswordChar =false;
            }
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void exitbtn_Click(object sender, EventArgs e)
        {
            DialogResult check = MessageBox.Show("Are you sure you want to exit?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (check == DialogResult.Yes)
            {
                Application.Exit();

                this.Hide();
            }
           
        }
    }
}
