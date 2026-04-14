using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace _40972364_Seshayi_Prac2
{
    public partial class Form1 : Form
    {
        // Database connection string
        //string ConnectionString = "";
        string ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=\\143.160.81.13\CTX_Redirected_Data$\40972364\Documents\40972364_Seshayi_Prac2\40972364_Seshayi_Prac2\Database1.mdf;Integrated Security=True";
       
        SqlConnection connection;
        SqlCommand command;
        SqlDataAdapter adapter;
        DataSet dataSet;


        public Form1()
        {
            InitializeComponent();
            // Initialize the connection string
            
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            // Create a new SqlConnection using the connection string
            connection = new SqlConnection(ConnectionString);
            // Empty the data grid view
            dataGV.DataSource = null;

            // Open the connection
            connection.Open();
            // Close the connection
            connection.Close();

            // Show a message box indicating the connection was successful
            MessageBox.Show("Connection Successful!!");
        }

        private void btnShowAllData_Click(object sender, EventArgs e)
        {
            // Empty the data grid view
            dataGV.DataSource = null;

            try
            {
                // Using statement to ensure the connection is properly closed
                using (connection)
                {
                    // Open the connection if it's not already open
                    if (connection.State != ConnectionState.Open)
                        connection.Open();

                    // Initialize the SqlDataAdapter and DataSet
                    adapter = new SqlDataAdapter();
                    dataSet = new DataSet();

                    // SQL query to select all data from the BoneKosTable
                    string SqlString = "SELECT * FROM BoneKosTable";

                    // Initialize the SqlCommand with the SQL query and connection
                    command = new SqlCommand(SqlString, connection);
                    adapter.SelectCommand = command;

                    // Fill the DataSet with the data from the BoneKosTable
                    adapter.Fill(dataSet, "SourceTable");

                    // Set the DataGridView's DataSource to the DataSet
                    dataGV.DataSource = dataSet;
                    // Set the DataGridView's DataMember to the table name in the DataSet
                    dataGV.DataMember = "SourceTable";
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                // Show an error message if an exception occurs
                MessageBox.Show("Error Displaying: " + ex.Message);
            }
        }

        private void btnMealAndPriceOnly_Click(object sender, EventArgs e)
        {
            // Empty the data grid view
            dataGV.DataSource = null;

            try
            {
                using (connection)
                {
                    if (connection.State != ConnectionState.Open)
                        connection.Open();

                    adapter = new SqlDataAdapter();
                    dataSet = new DataSet();

                    // SQL query to select only the Name and Price columns from the BoneKosTable
                    string sqlStringMealAndPrice = "SELECT Name, Price FROM BoneKosTable";
                    command = new SqlCommand(sqlStringMealAndPrice, connection);
                    adapter.SelectCommand = command;
                    adapter.Fill(dataSet, "SourceTable");
                    dataGV.DataSource = dataSet;
                    dataGV.DataMember = "SourceTable";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Displaying: " + ex.Message);
            }
        }

        private void btnMealsWithCheaps_Click(object sender, EventArgs e)
        {
            // Empty the data grid view
            dataGV.DataSource = null;

            try
            {
                using (connection)
                {
                    if (connection.State != ConnectionState.Open)
                        connection.Open();

                    adapter = new SqlDataAdapter();
                    dataSet = new DataSet();

                    // SQL query to select meals where the Name contains "Chips"
                    string sqlString = "SELECT * FROM BoneKosTable WHERE Name LIKE '%Chips%'";
                    command = new SqlCommand(sqlString, connection);
                    adapter.SelectCommand = command;
                    adapter.Fill(dataSet, "SourceTable");
                    dataGV.DataSource = dataSet;
                    dataGV.DataMember = "SourceTable";

                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Displaying: " + ex.Message);
            }
        }

        private void btnMealCostMoreThan150_Click(object sender, EventArgs e)
        {
            // Empty the data grid view
            dataGV.DataSource = null;

            try
            {
                using (connection)
                {
                    if (connection.State != ConnectionState.Open)
                        connection.Open();

                    adapter = new SqlDataAdapter();
                    dataSet = new DataSet();

                    // SQL query to select meals where the Price is greater than 150
                    string sqlString = "SELECT Name, Price FROM BoneKosTable WHERE Price > 150";
                    command = new SqlCommand(sqlString, connection);
                    adapter.SelectCommand = command;
                    adapter.Fill(dataSet, "SourceTable");
                    dataGV.DataSource = dataSet;
                    dataGV.DataMember = "SourceTable";

                    //connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Displaying: " + ex.Message);
            }
        }

        private void btnSortLowestToLargest_Click(object sender, EventArgs e)
        {
            // Empty the data grid view
            //connection.Open();
            dataGV.DataSource = null;

            try
            {
                using (connection)
                {
                    if (connection.State != ConnectionState.Open)
                        connection.Open();

                    adapter = new SqlDataAdapter();
                    dataSet = new DataSet();

                    // SQL query to select all meals sorted by Price from lowest to highest
                    string sqlString = "SELECT * FROM BoneKosTable ORDER BY Price";
                    command = new SqlCommand(sqlString, connection);
                    adapter.SelectCommand = command;
                    adapter.Fill(dataSet, "SourceTable");
                    dataGV.DataSource = dataSet;
                    dataGV.DataMember = "SourceTable";

                    //connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Displaying: " + ex.Message);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            // Close the form
            Close();
        }
    }
}


