using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _40972364_Seshayi_Prac4
{
    public partial class EditProducts : Form
    {
        public EditProducts()
        {
            InitializeComponent();
        }

        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\sesha\source\repos\40972364_Seshayi_Prac4\40972364_Seshayi_Prac4\Producuts.mdf;Integrated Security=True";

        SqlConnection connection;
        SqlCommand command;
        SqlDataAdapter adapter;
        DataSet dataSet;

        private void btnInserProduct_Click(object sender, EventArgs e)
        {

            try
            {
                string productID = txtProductID.Text;
                string productName = txtProductName.Text;
                string productBrand = tbBrand.Text;
                decimal price = decimal.Parse(tbPrice.Text);

                // Ensure that the connection string is properly initialized
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // SQL query to insert a new product into the ProductsTable
                    string sqlInsert = "INSERT INTO ProductsTable (ProductID, ProductName, Brand, Price) VALUES (@ProductID, @ProductName, @Brand, @Price)";

                    // Initialize the SqlCommand with the SQL query and connection
                    using (SqlCommand command = new SqlCommand(sqlInsert, connection))
                    {
                        // Add parameters to the SqlCommand
                        command.Parameters.AddWithValue("@ProductID", productID);
                        command.Parameters.AddWithValue("@ProductName", productName);
                        command.Parameters.AddWithValue("@Brand", productBrand);
                        command.Parameters.AddWithValue("@Price", price);

                        // Execute the insert command
                        int rowsAffected = command.ExecuteNonQuery();

                        // Check if the insert was successful
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Product inserted successfully.");
                            
                            //clearing input
                            txtProductID.Clear();
                            txtProductName.Clear();
                            tbBrand.Clear();
                            tbPrice.Clear();
                        }
                        else
                        {
                            MessageBox.Show("Failed to insert product.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }

        private void btnDeleteProduct_Click(object sender, EventArgs e)
        {
            try
            {
                int productID = int.Parse(tbDeleteProduct.Text);

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // SQL query to delete a product from the ProductsTable based on ProductID
                    string sqlDelete = "DELETE FROM ProductsTable WHERE ProductID = @ProductID";

                    // Initialize the SqlCommand with the SQL query and connection
                    using (SqlCommand command = new SqlCommand(sqlDelete, connection))
                    {
                        // Add the ProductID parameter to the SqlCommand
                        command.Parameters.AddWithValue("@ProductID", productID);

                        // Execute the delete command
                        int rowsAffected = command.ExecuteNonQuery();

                        // Check if the delete was successful
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Product deleted successfully.");
                            tbDeleteProduct.Clear();
                        }
                        else
                        {
                            MessageBox.Show("No product found with the specified ID.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }

        private void EditProducts_Load(object sender, EventArgs e)
        {

        }
    }
}
