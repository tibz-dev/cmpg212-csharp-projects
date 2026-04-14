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

namespace _40972364_Seshayi_Prac4
{
    public partial class ViewProducts : Form
    {
        public ViewProducts()
        {
            InitializeComponent();
        }
        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\sesha\source\repos\40972364_Seshayi_Prac4\40972364_Seshayi_Prac4\Producuts.mdf;Integrated Security=True";

        SqlConnection connection;
        SqlCommand command;
        SqlDataAdapter adapter;
        DataSet dataSet;

        private void ViewProducts_Load(object sender, EventArgs e)
        {
            try
            {
                // Create a new SqlConnection using the connection string
                connection = new SqlConnection(connectionString);


                // Open the connection
                connection.Open();
                // Close the connection
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            try
            {
                // Using statement to ensure the connection is properly opened
                using (connection)
                {
                    // Open the connection if it's not already open
                    if (connection.State != ConnectionState.Open)
                        connection.Open();

                    // Initialize the SqlDataAdapter and DataSet
                    adapter = new SqlDataAdapter();
                    dataSet = new DataSet();

                    // SQL query to select all data from the 
                    string SqlString = "SELECT * FROM ProductsTable";

                    // Initialize the SqlCommand with the SQL query and connection
                    command = new SqlCommand(SqlString, connection);
                    adapter.SelectCommand = command;

                    // Fill the DataSet with the data from the BoneKosTable
                    adapter.Fill(dataSet, "SourceTable");

                    // Set the DataGridView's DataSource to the DataSet
                    dataGridView1.DataSource = dataSet;
                    // Set the DataGridView's DataMember to the table name in the DataSet
                    dataGridView1.DataMember = "SourceTable";
                    connection.Close();

                    
                    if(comboBoxSelectBrand.SelectedIndex==0)
                    {

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            try
            {
                // Using statement to ensure the connection is properly opened
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    
                    // Initialize the SqlDataAdapter and DataSet
                    adapter = new SqlDataAdapter();
                    dataSet = new DataSet();

                    // SQL query to select all data from the 
                    string SqlString = "SELECT * FROM ProductsTable";

                    // Initialize the SqlCommand with the SQL query and connection
                    command = new SqlCommand(SqlString, connection);
                    adapter.SelectCommand = command;

                    // Fill the DataSet with the data from the BoneKosTable
                    adapter.Fill(dataSet, "SourceTable");

                    // Set the DataGridView's DataSource to the DataSet
                    dataGridView1.DataSource = dataSet;
                    // Set the DataGridView's DataMember to the table name in the DataSet
                    dataGridView1.DataMember = "SourceTable";
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

            

            

            try
            {
                string selectedBrand = comboBoxSelectBrand.SelectedItem.ToString();
                string productName = tbProductName.Text;

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    

                    // Initialize the SqlDataAdapter and DataSet
                    adapter = new SqlDataAdapter();
                    dataSet = new DataSet();

                    // SQL query to select data from the ProductsTable based on brand and/or product name
                    string SqlString = "SELECT * FROM ProductsTable WHERE Brand = @Brand OR ProductName LIKE @ProductName";

                    // Initialize the SqlCommand with the SQL query and connection
                    command = new SqlCommand(SqlString, connection);
                    command.Parameters.AddWithValue("@Brand", selectedBrand); // Add brand parameter
                    command.Parameters.AddWithValue("@ProductName", "%" + productName + "%"); // Add product name parameter with wildcard
                    adapter.SelectCommand = command;

                    // Fill the DataSet with the data from the ProductsTable
                    adapter.Fill(dataSet, "SourceTable");

                    // Set the DataGridView's DataSource to the DataSet
                    dataGridView1.DataSource = dataSet;
                    // Set the DataGridView's DataMember to the table name in the DataSet
                    dataGridView1.DataMember = "SourceTable";
                    connection.Close();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
