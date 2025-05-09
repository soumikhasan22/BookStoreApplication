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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace BookStoreApplication.EmployeeUC
{
    public partial class UC_ModifyBooks : UserControl
    {
        function fn = new function();
        string query;
        public UC_ModifyBooks()
        {
            InitializeComponent();
        }

        private void UC_ModifyBooks_Load(object sender, EventArgs e)
        {

            query = "select * from allbooks";
            DataSet ds = fn.getData(query);
            gunaDataGridView2.DataSource = ds.Tables[0];
        }

        private void gunaDataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtIsbn_TextChanged(object sender, EventArgs e)
        {
            query = "select * from allbooks where isbnNO like '" + txtIsbn.Text + "%'";
            DataSet ds = fn.getData(query);
            gunaDataGridView2.DataSource = ds.Tables[0];
        }

        private void gunaDataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string isbn;
            
            try
            {
                isbn = gunaDataGridView2.Rows[e.RowIndex].Cells[2].Value.ToString();
            }
            catch
            {

            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // Check if a row is selected
            if (gunaDataGridView2.SelectedRows.Count > 0)
            {
                // Get the ISBN from the selected row
                string isbn = gunaDataGridView2.SelectedRows[0].Cells[2].Value.ToString();

                // Confirm deletion with the user
                DialogResult result = MessageBox.Show("Are you sure you want to delete this book?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    // Delete the book from the database
                    DeleteBook(isbn);

                    // Refresh the grid after deletion
                    RefreshDataGridView();
                }
            }
            else
            {
                MessageBox.Show("Please select a row to delete.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void DeleteBook(string isbn)
        {
            try
            {
                // Define the delete query
                string deleteQuery = "DELETE FROM allbooks WHERE isbnNO = @isbn";

                using (SqlConnection connection = new SqlConnection(fn.connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(deleteQuery, connection))
                    {
                        // Add parameters
                        command.Parameters.Add("@isbn", SqlDbType.NVarChar).Value = isbn;

                        // Execute the delete query
                        command.ExecuteNonQuery();

                        MessageBox.Show("Book deleted successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }

                // Refresh the DataGridView with the updated data
                RefreshDataGridView();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void RefreshDataGridView()
        {
            // Refresh the DataGridView with the updated data
            DataSet ds = fn.getData("SELECT * FROM allbooks");
            gunaDataGridView2.DataSource = ds.Tables[0];
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSync_Click(object sender, EventArgs e)
        {
            RefreshDataGridView();
        }
    }
}
