using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace BookStoreApplication.UserUC
{
    public partial class AddToCart2 : Form
    {
        SqlConnection cn;
        SqlCommand cm;
        SqlDataReader dr;

        private PictureBox pic = new PictureBox();
        private Label price;
        private Label bookTitle;
        private string user;

        public AddToCart2(string user)
        {
            InitializeComponent();
            this.user = user;
            cn = new SqlConnection();
            cn.ConnectionString = "Data Source = LAPTOP-M46LEEKM\\SQLEXPRESS;Initial Catalog=BookUser;Integrated Security= True";
            label1.Text = user;
        }

        private void AddToCart2_Load(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void RefreshData()
        {
            GetData();
            CalculateTotal();
            RefreshFlowLayout();
        }

        private void RefreshFlowLayout()
        {
            // Clear existing controls in the flowLayoutPanel1
            flowLayoutPanel1.Controls.Clear();

            // Add updated controls
            try
            {
                cn.Open();

                string tableName = $"{user}Cart";
                if (TableExists(tableName))
                {
                    cm = new SqlCommand($"SELECT bookimage, bookTitle, price FROM {tableName}", cn);
                    dr = cm.ExecuteReader();

                    while (dr.Read())
                    {
                        long len = dr.GetBytes(0, 0, null, 0, 0);
                        byte[] array = new byte[System.Convert.ToInt32(len) + 1];
                        dr.GetBytes(0, 0, array, 0, System.Convert.ToInt32(len));

                        pic = new PictureBox
                        {
                            Width = 100,
                            Height = 100,
                            BackgroundImageLayout = ImageLayout.Stretch,
                            BorderStyle = BorderStyle.FixedSingle
                        };

                        price = new Label
                        {
                            Name = "price",
                            Text = dr["price"].ToString(),
                            Width = 25,
                            BackColor = Color.FromArgb(255, 121, 121),
                            TextAlign = ContentAlignment.MiddleCenter
                        };

                        bookTitle = new Label
                        {
                            Name = "bookTitle",
                            Text = dr["bookTitle"].ToString(),
                            BackColor = Color.FromArgb(46, 134, 222),
                            TextAlign = ContentAlignment.MiddleCenter,
                            Dock = DockStyle.Bottom
                        };

                        MemoryStream ms = new MemoryStream(array);
                        Bitmap bitmap = new Bitmap(ms);
                        pic.BackgroundImage = bitmap;
                        pic.Controls.Add(bookTitle);
                        pic.Controls.Add(price);

                        flowLayoutPanel1.Controls.Add(pic);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (cn.State == ConnectionState.Open)
                    cn.Close();
            }
        }

        private void GetData()
        {
            try
            {
                cn.Open();

                string tableName = $"{user}Cart";
                if (TableExists(tableName))
                {
                    cm = new SqlCommand($"SELECT bookimage, bookTitle, price FROM {tableName}", cn);
                    dr = cm.ExecuteReader();

                    while (dr.Read())
                    {
                        long len = dr.GetBytes(0, 0, null, 0, 0);
                        byte[] array = new byte[System.Convert.ToInt32(len) + 1];
                        dr.GetBytes(0, 0, array, 0, System.Convert.ToInt32(len));

                        pic = new PictureBox
                        {
                            Width = 100,
                            Height = 100,
                            BackgroundImageLayout = ImageLayout.Stretch,
                            BorderStyle = BorderStyle.FixedSingle
                        };

                        price = new Label
                        {
                            Name = "price",
                            Text = dr["price"].ToString(),
                            Width = 25,
                            BackColor = Color.FromArgb(255, 121, 121),
                            TextAlign = ContentAlignment.MiddleCenter
                        };

                        bookTitle = new Label
                        {
                            Name = "bookTitle",
                            Text = dr["bookTitle"].ToString(),
                            BackColor = Color.FromArgb(46, 134, 222),
                            TextAlign = ContentAlignment.MiddleCenter,
                            Dock = DockStyle.Bottom
                        };

                        MemoryStream ms = new MemoryStream(array);
                        Bitmap bitmap = new Bitmap(ms);
                        pic.BackgroundImage = bitmap;
                        pic.Controls.Add(bookTitle);
                        pic.Controls.Add(price);

                        flowLayoutPanel1.Controls.Add(pic);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (cn.State == ConnectionState.Open)
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

        private void CalculateTotal()
        {
            try
            {
                cn.Open();

                string tableName = $"{user}Cart";
                if (TableExists(tableName))
                {
                    cm = new SqlCommand($"SELECT SUM(price) AS TotalSum FROM {tableName}", cn);
                    object result = cm.ExecuteScalar();

                    if (result != DBNull.Value)
                    {
                        int total = Convert.ToInt32(result);
                        label3.Text = total.ToString();
                    }
                    else
                    {
                        MessageBox.Show("No data found.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    label3.Text = "0";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (cn.State == ConnectionState.Open)
                    cn.Close();
            }
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            DeleteUserCart();
            RefreshData();
        }

        private void button_back_Click(object sender, EventArgs e)
        {
            UC_New uc = new UC_New(user);
            uc.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            // Your label click event logic here
        }

        private void button_order_Click(object sender, EventArgs e)
        {
            try
            {
                cn.Open();

                string tableName = $"{user}Cart";
                if (TableExists(tableName))
                {
                    string insertQuery = "INSERT INTO [Order] (customer, bookTitle, authorName, isbnNo, genre, price, bookimage, date) " +
                                        $"SELECT @Customer, bookTitle, authorName, isbnNo, genre, price, bookimage, @Date FROM {tableName}";

                    using (SqlCommand insertCommand = new SqlCommand(insertQuery, cn))
                    {
                        insertCommand.Parameters.AddWithValue("@Date", DateTime.Now);
                        insertCommand.Parameters.AddWithValue("@Customer", user);
                        insertCommand.ExecuteNonQuery();
                    }

                    MessageBox.Show("Order placed successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    DeleteUserCart();
                    RefreshData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (cn.State == ConnectionState.Open)
                    cn.Close();
            }
        }


        private void DeleteUserCart()
        {
            try
            {
                string tableName = $"{user}Cart";

                if (cn.State == ConnectionState.Closed)
                {
                    cn.Open();
                }

                if (TableExists(tableName))
                {
                    string deleteTableQuery = $"DROP TABLE {tableName}";

                    using (SqlCommand deleteTableCommand = new SqlCommand(deleteTableQuery, cn))
                    {
                        deleteTableCommand.ExecuteNonQuery();
                        MessageBox.Show("UserCart deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show($"Table {tableName} does not exist.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error deleting userCart table: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (cn.State == ConnectionState.Open)
                    cn.Close();
            }
        }



    }
}
