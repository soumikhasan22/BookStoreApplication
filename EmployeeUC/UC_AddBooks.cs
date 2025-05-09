using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Xml.Linq;
using System.Data.SqlClient;
using System.IO;

namespace BookStoreApplication.EmployeeUC
{
    public partial class UC_AddBooks : UserControl
    {
        function fn = new function();
        string query;
        public UC_AddBooks()
        {
            InitializeComponent();
        }

        private void label4_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtIsbn_TextChanged(object sender, EventArgs e)
        {
            query = "select * from allbooks where isbnNo='" + txtIsbn.Text + "'";
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

        private void UC_AddBooks_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtTitle.Text == "" || txtAuthor.Text == "" || txtIsbn.Text == "" || txtGenre.Text == "" || txtPrice.Text == "")
            {
                MessageBox.Show("Please fill all the blanks.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    string title = txtTitle.Text;
                    string author = txtAuthor.Text;
                    string isbn = txtIsbn.Text;
                    string genre = txtGenre.Text;
                    Int64 price = Int64.Parse(txtPrice.Text);

                    // Convert the image to a byte array
                    byte[] imageBytes = null;
                    if (guna2PictureBox1.Image != null)
                    {
                        ImageConverter converter = new ImageConverter();
                        imageBytes = (byte[])converter.ConvertTo(guna2PictureBox1.Image, typeof(byte[]));
                    }

                    // Insert the data into the database, including the image
                    query = "INSERT INTO allbooks (bookTitle, authorName, isbnNo, genre, price, bookimage) " +
                            "VALUES ('" + title + "','" + author + "','" + isbn + "','" + genre + "'," + price + ", @image)";

                    fn.setDataWithImage(query, "Added successfully.", imageBytes);
                }
                catch (Exception)
                {
                    MessageBox.Show("Invalid input or error saving image.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private byte[] ImageToByteArray(Image image)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                return ms.ToArray();
            }
        }


        private void guna2Button1_Click(object sender, EventArgs e)
        {

                using (OpenFileDialog openFileDialog = new OpenFileDialog())
                {
                    openFileDialog.Filter = "Image Files (*.png; *.jpg; *.jpeg; *.gif; *.bmp)|*.png; *.jpg; *.jpeg; *.gif; *.bmp|All files (*.*)|*.*";
                    openFileDialog.Title = "Select an Image";

                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        try
                        {
                        // Load the selected image into the PictureBox
                            guna2PictureBox1.Image = new System.Drawing.Bitmap(openFileDialog.FileName);
                            guna2PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error loading image: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            
        }

        private void resetBtn_Click(object sender, EventArgs e)
        {
            txtTitle.Text = string.Empty;
            txtAuthor.Text = string.Empty;
            txtGenre.Text = string.Empty;
            txtIsbn.Text = string.Empty;
            txtPrice.Text = string.Empty;
            guna2PictureBox1.Image = null;
        }
    }
}
