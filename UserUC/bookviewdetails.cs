using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace BookStoreApplication.UserUC
{
    public partial class bookviewdetails : Form
    {
        private string clickedPrice;
        private string clickedBookTitle;
        public string user;

        SqlConnection cn;
        SqlCommand cm;
        SqlDataReader dr;

        function fn = new function();

        public bookviewdetails(string clickedPrice, string clickedBookTitle, string user)
        {
            InitializeComponent();
            this.clickedPrice = clickedPrice;
            this.clickedBookTitle = clickedBookTitle;
            bookTitleLabel.Text = clickedBookTitle;
            pricelabel.Text = clickedPrice;

            // Retrieve additional details from the database
            RetrieveAdditionalDetails();
            this.user = user;
            txtnamebookview.Text = user;

            cn = new SqlConnection();
            cn.ConnectionString = "Data Source = LAPTOP-M46LEEKM\\SQLEXPRESS;Initial Catalog=BookUser;Integrated Security= True";
        }

        private void RetrieveAdditionalDetails()
        {
            try
            {
                // Use the function fn for database connectivity
                string query = "SELECT authorName, isbnNo, genre, bookimage FROM allbooks WHERE bookTitle = @BookTitle";
                SqlParameter[] parameters = { new SqlParameter("@BookTitle", clickedBookTitle) };
                DataSet ds = fn.getData(query, parameters);

                if (ds.Tables[0].Rows.Count > 0)
                {
                    string authorName = ds.Tables[0].Rows[0]["authorName"].ToString();
                    string isbnNo = ds.Tables[0].Rows[0]["isbnNo"].ToString();
                    string genre = ds.Tables[0].Rows[0]["genre"].ToString();
                    byte[] bookImageBytes = (byte[])ds.Tables[0].Rows[0]["bookimage"];

                    // Set the retrieved details to your UI controls
                    authorNameLabel.Text = authorName;
                    isbnlabel.Text = isbnNo;

                    // Set the PictureBox image from the retrieved byte array
                    SetPictureBoxImage(bookImageBytes);
                }
                else
                {
                    MessageBox.Show("Details not found for the selected book.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SetPictureBoxImage(byte[] imageBytes)
        {
            try
            {
                if (imageBytes != null && imageBytes.Length > 0)
                {
                    using (MemoryStream ms = new MemoryStream(imageBytes))
                    {
                        pictureBox1.Image = Image.FromStream(ms);
                    }
                }
                else
                {
                    MessageBox.Show("Image data is null or empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (ArgumentException ex)
            {
                // Handle the case where the image data is not a valid image format
                MessageBox.Show("Error: Invalid image format - " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                // Handle other exceptions
                MessageBox.Show("Error setting PictureBox image: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Back_Button_Click(object sender, EventArgs e)
        {
            UC_New uc = new UC_New(user);
            uc.Show();
            this.Hide();
        }

        private void button_addcart_Click(object sender, EventArgs e)
        {
            try
            {
                // Check if the 'user' Cart table exists
                if (!CheckIfTableExists())
                {
                    // If the table does not exist, create it
                    CreateCartTable();
                }

                // Copy data to the 'user' Cart table
                CopyDataToCartTable();

                MessageBox.Show("Book added to cart successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool CheckIfTableExists()
        {
            // Check if the 'user' Cart table exists in the database
            string query = "IF OBJECT_ID('" + user + "Cart', 'U') IS NOT NULL SELECT 1 ELSE SELECT 0";
            int result = Convert.ToInt32(fn.getSingleData(query));

            return result == 1;
        }

        private void CreateCartTable()
        {
            // Create the 'user' Cart table in the database
            string createTableQuery = "CREATE TABLE [" + user + "Cart] ("
                                    + "id INT IDENTITY(1,1) PRIMARY KEY,"
                                    + "bookTitle VARCHAR(50),"
                                    + "authorName VARCHAR(50),"
                                    + "isbnNo VARCHAR(50),"
                                    + "genre VARCHAR(50),"
                                    + "price BIGINT,"
                                    + "bookimage VARBINARY(MAX)"
                                    + ")";
            fn.setData(createTableQuery, (SqlParameter[])null);
        }

        private void CopyDataToCartTable()
        {
            try
            {
                // Check if the 'user' Cart table exists
                if (!CheckIfTableExists())
                {
                    // If the table does not exist, create it
                    CreateCartTable();
                }

                // Copy data to the 'user' Cart table
                // Use parameters directly in the INSERT INTO statement
                string insertQuery = "INSERT INTO [" + user + "Cart] (bookTitle, authorName, isbnNo, genre, price, bookimage) VALUES (@BookTitle, @AuthorName, @IsbnNo, CONVERT(varbinary(max), @Genre), @Price, @BookImage)";

                // Retrieve additional details from the database
                string isbnQuery = "SELECT genre FROM allbooks WHERE isbnNo = '" + isbnlabel.Text + "'";
                string bookImageQuery = "SELECT bookimage FROM allbooks WHERE isbnNo = '" + isbnlabel.Text + "'";

                // Get additional details as scalar values
                string genre = fn.getSingleData(isbnQuery) as string;
                byte[] bookImageBytes = fn.getSingleData(bookImageQuery) as byte[];

                // Create parameters
                SqlParameter[] parameters =
                {
                    new SqlParameter("@BookTitle", SqlDbType.VarChar, 50) { Value = clickedBookTitle },
                    new SqlParameter("@AuthorName", SqlDbType.VarChar, 50) { Value = authorNameLabel.Text },
                    new SqlParameter("@IsbnNo", SqlDbType.VarChar, 50) { Value = isbnlabel.Text },
                    new SqlParameter("@Genre", SqlDbType.VarChar, 255) { Value = genre },
                    new SqlParameter("@Price", SqlDbType.BigInt) { Value = Convert.ToInt64(clickedPrice) },
                    new SqlParameter("@BookImage", SqlDbType.VarBinary, -1) { Value = bookImageBytes }
        };

                // Execute the query
                fn.setData(insertQuery, parameters);

                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonBUY_Click(object sender, EventArgs e)
        {
            try
            {
                // Check if the 'user' Cart table exists
                if (!CheckIfTableExists())
                {
                    // If the table does not exist, create it
                    CreateCartTable();
                }

                // Copy data to the 'user' Cart table
                // Use parameters directly in the INSERT INTO statement
                string insertQuery = "INSERT INTO [Order] (customer, bookTitle, authorName, isbnNo, genre, price, bookimage, date) VALUES (@Customer, @BookTitle, @AuthorName, @IsbnNo, CONVERT(varbinary(max), @Genre), @Price, @BookImage, @Date)";

                // Retrieve additional details from the database
                string isbnQuery = "SELECT genre FROM allbooks WHERE isbnNo = '" + isbnlabel.Text + "'";
                string bookImageQuery = "SELECT bookimage FROM allbooks WHERE isbnNo = '" + isbnlabel.Text + "'";

                // Get additional details as scalar values
                string genre = fn.getSingleData(isbnQuery) as string;
                byte[] bookImageBytes = fn.getSingleData(bookImageQuery) as byte[];

                // Create parameters
                SqlParameter[] parameters =
                {
                    new SqlParameter("@Customer", SqlDbType.VarChar, 50) { Value = user },
                    new SqlParameter("@BookTitle", SqlDbType.VarChar, 50) { Value = clickedBookTitle },
                    new SqlParameter("@AuthorName", SqlDbType.VarChar, 50) { Value = authorNameLabel.Text },
                    new SqlParameter("@IsbnNo", SqlDbType.VarChar, 50) { Value = isbnlabel.Text },
                    new SqlParameter("@Genre", SqlDbType.VarChar, 50) { Value = genre },
                    new SqlParameter("@Price", SqlDbType.BigInt) { Value = Convert.ToInt64(clickedPrice) },
                    new SqlParameter("@BookImage", SqlDbType.VarBinary, -1) { Value = bookImageBytes },
                    new SqlParameter("@Date", SqlDbType.VarChar, 50) { Value = DateTime.Now.ToString()}
                };

                // Execute the query
                fn.setData(insertQuery, parameters);

                MessageBox.Show("Order placed successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void bookviewdetails_Load(object sender, EventArgs e)
        {

        }
    }
}
