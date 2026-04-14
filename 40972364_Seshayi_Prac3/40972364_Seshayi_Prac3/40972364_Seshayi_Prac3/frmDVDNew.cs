using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace _40972364_Seshayi_Prac3
{
    public partial class frmDVDNew : Form
    {
        public frmDVDNew()
        {
            InitializeComponent();
            //LoadData();
        }

        
        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\sesha\source\repos\40972364_Seshayi_Prac3\40972364_Seshayi_Prac3\Data.mdf;Integrated Security=True";

        SqlConnection connection;
        SqlCommand command;
        SqlDataAdapter adapter;
        DataSet dataSet;


        

        

        private void frmDVDNew_Load(object sender, EventArgs e)
        {
            //accessing the database
            try
            {
                // Create a new SqlConnection using the connection string
                connection = new SqlConnection(connectionString);
                

                // Open the connection
                connection.Open();
                // Close the connection
                connection.Close();
            }
            catch(Exception ex) 
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
                    string SqlString = "SELECT * FROM DVDs";

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
        private void btnActionMoviesS_Click(object sender, EventArgs e)
        {
            connection = new SqlConnection(connectionString);

            try
            {
                using (connection)
                {
                    if (connection.State != ConnectionState.Open)
                        connection.Open();

                    adapter = new SqlDataAdapter();
                    dataSet = new DataSet();

                    // SQL query to select meals where the Name contains "Chips"
                    string sqlString = "SELECT * FROM DVDs WHERE Type LIKE '%ACT%'";
                    command = new SqlCommand(sqlString, connection);
                    adapter.SelectCommand = command;
                    adapter.Fill(dataSet, "SourceTable");
                    dataGridView1.DataSource = dataSet;
                    dataGridView1.DataMember = "SourceTable";


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Displaying: " + ex.Message);
            }

        }

        private void scrollBar_Scroll(object sender, ScrollEventArgs e)
        {
            lblAge.Text = scrollBar.Value.ToString();

            // Create a new SqlConnection using the connection string
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    adapter = new SqlDataAdapter();
                    dataSet = new DataSet();

                    //string queryTest = "SELECT * FROM DVDs WHERE Age = {scrollBar.Value}";
                    // SQL query to select all data from the DVDs table where Age matches the scroll bar value
                    string queryTest = $"SELECT * FROM DVDs WHERE Age = {scrollBar.Value}";

                    // Initialize the SqlCommand with the SQL query and connection
                    SqlCommand command = new SqlCommand(queryTest, connection);

                    // Set the SelectCommand of the SqlDataAdapter
                    adapter.SelectCommand = command;

                    // Fill the DataSet with the data from the DVDs table
                    adapter.Fill(dataSet, "DVDs");

                    // Bind the DataGridView to the DataSet
                    dataGridView1.DataSource = dataSet.Tables["DVDs"];

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }

            }

            
        }
    }
}

