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
using System.IO;

namespace BookStoreApplication.UserUC
{
    public partial class UC_New : Form
    {
        SqlConnection cn;
        SqlCommand cm;
        SqlDataReader dr;

        private PictureBox pic = new PictureBox();
        private Label price;
        private Label bookTitle;
        private string user;

        public UC_New(string user)
        {
            InitializeComponent();
            this.user = user;
            usernameshow.Text = user;
            cn = new SqlConnection();
            cn.ConnectionString = "Data Source = LAPTOP-M46LEEKM\\SQLEXPRESS;Initial Catalog=BookUser;Integrated Security= True";
            //cn.ConnectionString = "Data Source = DESKTOP-QJP3HM2\\SQLEXPRESS;Initial Catalog=BookUser;Integrated Security= True";

            // Associate event handler
            booksearch.TextChanged += booksearch_TextChanged;
        }


        public UC_New()
        {

        }

        private void UC_New_Load(object sender, EventArgs e)
        {
            GetData();

            // Get the total number of items in the user's cart
            int totalCartNumber = GetTotalCartNumber();
            totalbookcart.Text = totalCartNumber.ToString();
        }

        private int GetTotalCartNumber()
        {
            try
            {
                cn.Open();

                // Check if the userCart table exists
                string tableName = $"{user}Cart";
                if (TableExists(tableName))
                {
                    string query = $"SELECT COUNT(*) AS row_count FROM [{tableName}]";
                    cm = new SqlCommand(query, cn);
                    int totalCartNumber = Convert.ToInt32(cm.ExecuteScalar());
                    return totalCartNumber;
                }
                else
                {
                    
                    return 0; // Return 0 when the table does not exist
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0; // Return 0 in case of an error
            }
            finally
            {
                cn.Close();
            }
        }

        private bool TableExists(string tableName)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand($"SELECT 1 FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = @TableName", cn))
                {
                    cmd.Parameters.AddWithValue("@TableName", tableName);
                    object result = cmd.ExecuteScalar();
                    return result != null && result != DBNull.Value;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error checking table existence: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }


        private void GetData()
        {
            try
            {
                // Clear existing controls in the flowLayoutPanel
                flowLayoutPanel1.Controls.Clear();

                cn.Open();

                string query;
                if (string.IsNullOrEmpty(booksearch.Text))
                {
                    // Booksearch is empty, show all books
                    query = "SELECT bookimage, bookTitle, price FROM allbooks";
                }
                else
                {
                    // Booksearch is not empty, filter books by search text
                    query = "SELECT bookimage, bookTitle, price FROM allbooks WHERE bookTitle LIKE @SearchText";
                }

                using (cm = new SqlCommand(query, cn))
                {
                    // Add parameter if booksearch is not empty
                    if (!string.IsNullOrEmpty(booksearch.Text))
                    {
                        cm.Parameters.AddWithValue("@SearchText", "%" + booksearch.Text + "%");
                    }

                    using (dr = cm.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            long len = dr.GetBytes(0, 0, null, 0, 0);
                            byte[] array = new byte[System.Convert.ToInt32(len) + 1];
                            dr.GetBytes(0, 0, array, 0, System.Convert.ToInt32(len));

                            pic = new PictureBox();
                            pic.Width = 150;
                            pic.Height = 150;
                            pic.BackgroundImageLayout = ImageLayout.Stretch;
                            pic.BorderStyle = BorderStyle.FixedSingle;

                            price = new Label();
                            price.Name = "price"; // Set the name of the label
                            price.Text = dr["price"].ToString();
                            price.Width = 50;
                            price.BackColor = Color.FromArgb(255, 121, 121);
                            price.TextAlign = ContentAlignment.MiddleCenter;

                            bookTitle = new Label();
                            bookTitle.Name = "bookTitle"; // Set the name of the label
                            bookTitle.Text = dr["bookTitle"].ToString();
                            bookTitle.BackColor = Color.FromArgb(46, 134, 222);
                            bookTitle.TextAlign = ContentAlignment.MiddleCenter;
                            bookTitle.Dock = DockStyle.Bottom;

                            MemoryStream ms = new MemoryStream(array);
                            Bitmap bitmap = new System.Drawing.Bitmap(ms);
                            pic.BackgroundImage = bitmap;
                            pic.Controls.Add(bookTitle);
                            pic.Controls.Add(price);

                            // Add the event handler to open bookviewdetails
                            pic.Click += Pic_Click;

                            flowLayoutPanel1.Controls.Add(pic);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                cn.Close();
            }
        }



        private void Pic_Click(object sender, EventArgs e)
        {
            // Retrieve information from the clicked PictureBox
            PictureBox clickedPictureBox = (PictureBox)sender;
            string clickedPrice = ((Label)clickedPictureBox.Controls["price"]).Text;
            string clickedBookTitle = ((Label)clickedPictureBox.Controls["bookTitle"]).Text;

            // Open bookviewdetails and pass information as parameters
            bookviewdetails bookviewdetails = new bookviewdetails(clickedPrice, clickedBookTitle, user);
            bookviewdetails.Show();
            this.Hide();
        }

        

        private void usernameshow_Click(object sender, EventArgs e)
        {
         
        }

        private void gButtonuserlogout_Click(object sender, EventArgs e)
        {
            DialogResult check = MessageBox.Show("Are you sure you want to logout?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (check == DialogResult.Yes)
            {
                new Lginform().Show();
                this.Hide();
            }
        }

        private void totalbookcart_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            AddToCart2 addtocart = new AddToCart2(user);
            addtocart.Show();
            this.Hide();
        }

        private void booksearch_TextChanged(object sender, EventArgs e)
        {
            GetData();
        }

    }
}
