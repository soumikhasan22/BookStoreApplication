using System;
using System.Data;
using System.Windows.Forms;

namespace BookStoreApplication.AdministratorUC
{
    public partial class UC_ViewUser : UserControl
    {
        function fn = new function();
        string query;
        public UC_ViewUser()
        {
            InitializeComponent();
        }

        private void gunaDataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void UC_ViewUser_Load(object sender, EventArgs e)
        {
            query = "select * from users";
            DataSet ds = fn.getData(query);
            gunaDataGridView2.DataSource = ds.Tables[0];
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {
            query = "select * from users where username like '" + txtUserName.Text + "%'";
            DataSet ds = fn.getData(query);
            gunaDataGridView2.DataSource = ds.Tables[0];
        }

        string userName;
        private void gunaDataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                userName = gunaDataGridView2.Rows[e.RowIndex].Cells[6].Value.ToString();
            }
            catch
            {

            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }
    }
}
