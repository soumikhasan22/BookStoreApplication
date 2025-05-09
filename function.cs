using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookStoreApplication
{
    internal class function
    {
        public string connectionString = "Data Source = LAPTOP-M46LEEKM\\SQLEXPRESS;Initial Catalog=BookUser;Integrated Security= True";
        //public string connectionString = "Data Source = DESKTOP-QJP3HM2\\SQLEXPRESS;Initial Catalog=BookUser;Integrated Security= True";

        public SqlConnection getConnection()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source = LAPTOP-M46LEEKM\\SQLEXPRESS;Initial Catalog=BookUser;Integrated Security= True";
            //con.ConnectionString = "Data Source = DESKTOP-QJP3HM2\\SQLEXPRESS;Initial Catalog=BookUser;Integrated Security= True";
            return con;
        }

        public DataSet getData(string query)
        {
            SqlConnection con = getConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = query;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }

        public void setData(string query, string msg)
        {
            SqlConnection con = getConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            con.Open();
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show(msg, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void setDataWithParameters(string query, string successMessage, SqlParameter[] parameters)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Add regular parameters
                        command.Parameters.AddRange(parameters);

                        command.ExecuteNonQuery();
                        MessageBox.Show(successMessage, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        public void setDataWithImage(string query, string successMessage, byte[] imageBytes, params SqlParameter[] parameters)
        {
            using (SqlConnection connection = new SqlConnection("Data Source = LAPTOP-M46LEEKM\\SQLEXPRESS;Initial Catalog=BookUser;Integrated Security= True"))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Add regular parameters
                        command.Parameters.AddRange(parameters);

                        // Add image parameter
                        if (imageBytes != null)
                        {
                            SqlParameter imageParameter = new SqlParameter("@image", SqlDbType.Image);
                            imageParameter.Value = imageBytes;
                            command.Parameters.Add(imageParameter);
                        }

                        command.ExecuteNonQuery();
                        MessageBox.Show(successMessage, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public DataSet getData(string query, SqlParameter[] parameters = null)
        {
            DataSet ds = new DataSet();

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        if (parameters != null)
                        {
                            command.Parameters.AddRange(parameters);
                        }

                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            adapter.Fill(ds);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                // You might want to handle the exception in a way that makes sense for your application.
            }

            return ds;
        }

        public object getSingleData(string query)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection("Data Source = LAPTOP-M46LEEKM\\SQLEXPRESS;Initial Catalog=BookUser;Integrated Security= True"))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        object result = command.ExecuteScalar();
                        return result;
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle exceptions appropriately (e.g., log the error)
                Console.WriteLine("Error in getSingleData: " + ex.Message);
                throw;
            }
        }

        public void setData(string query, SqlParameter[] parameters)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection("Data Source = LAPTOP-M46LEEKM\\SQLEXPRESS;Initial Catalog=BookUser;Integrated Security= True"))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        if (parameters != null)
                        {
                            command.Parameters.AddRange(parameters);
                        }

                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle exceptions appropriately (e.g., log the error)
                Console.WriteLine("Error in setData: " + ex.Message);
                throw;
            }
        }






    }
}
