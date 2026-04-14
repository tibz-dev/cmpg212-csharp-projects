using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Seshayi_40972364_Prac1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //declaring variables
        
        //Connection string
        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\SL301\Documents\Seshayi_40972364_Prac1\40972364_Seshayi_Prac1_DB.mdf;Integrated Security=True";


        SqlConnection connection;
        SqlCommand command;
        SqlDataAdapter adapter;
        DataSet dataSet;
        SqlDataReader theReader;

        private void btnConnect_Click(object sender, EventArgs e)
        {
            connection = new SqlConnection(connectionString);

            //opening and closing the connection to test
            connection.Open();
            connection.Close();

            MessageBox.Show("Connection Succesfull!!");
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            connection.Open();
            try
            {
                //displaying data in  the database
                adapter = new SqlDataAdapter();
                dataSet = new DataSet();

                string sqlString = "SELECT * FROM Prac1DBTB";

                command = new SqlCommand(sqlString, connection);
                adapter.SelectCommand = command;

                //filling  dataset with source table
                adapter.Fill(dataSet, "SourceTable");
                dataGridView1.DataSource = dataSet;
                dataGridView1.DataMember = "SourceTable";
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error Displaying Infos: " + ex.Message); 
            }

         
            
            

            connection.Close();

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            
            Close();
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            connection.Open();

            
            string sqlString = "SELECT * FROM Prac1DBTB";

            command = new SqlCommand(sqlString, connection);
            theReader = command.ExecuteReader();

            int numberOfRecords = 0;

            //counting the number of records in the database
            while (theReader.Read())
            {
                numberOfRecords++;
            }

            //displaying the database
            MessageBox.Show("The database has " + numberOfRecords + " record(s).");
            connection.Close();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {


            connection.Open();

            try
            {
               
                int StudentID = int.Parse(textBox1.Text);
                
                SqlCommand command = new SqlCommand("INSERT INTO Prac1DBTB (StudentID, Name, Surname, Sport_Code) VALUES (@Value1, @Value2, @Value3, @Value4)", connection);

                //adding the records to 
                command.Parameters.AddWithValue("@Value1", StudentID);
                command.Parameters.AddWithValue("@Value2", textBox2.Text);
                command.Parameters.AddWithValue("@Value3", textBox3.Text);
                command.Parameters.AddWithValue("@Value4", textBox4.Text);

                int rowsAffected = command.ExecuteNonQuery();

                MessageBox.Show(rowsAffected + " row(s) inserted.");

                //clearing all input
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
                ///textBox5.Clear();
               
                

            }
            catch (Exception ex)
            {
                MessageBox.Show("Enter theinformation: Make Sure you enter the correct Info");
            }
            connection.Close();




        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            using (SqlConnection connectionSql = new SqlConnection(connectionString))
            {
                connection.Open();

                string updateQuery = "UPDATE Data SET @Value4 = Sport_Code WHERE StudentID = @Value1";

                using (SqlCommand command = new SqlCommand(updateQuery,connectionSql))
                {
                    int StudentID = int.Parse(textBox1.Text);

                    command.Parameters.AddWithValue("@Value1", StudentID);
                    command.Parameters.AddWithValue("@Value4", int.Parse(textBox4.Text));
                    try
                    {


                        //updating information in the database table by exucuting the uopdate query
                        command.ExecuteNonQuery();


                        

                        int rowsAffected = command.ExecuteNonQuery();
                        if(rowsAffected >= 0) 
                        {
                            //showing the number of rows updated
                            MessageBox.Show(rowsAffected + " row(s) updated.");
                        }
                        else
                        {
                            //displaying the error message if there's an error updating database
                            MessageBox.Show("Error");
                        }

                        

                        //clearing all input
                        textBox1.Clear();
                        textBox2.Clear();
                        textBox3.Clear();
                        textBox4.Clear();
                        textBox5.Clear();


                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error updating database: " + ex.Message);
                    }

                }

            }
            connection.Close();

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            connection.Open();

            try
            {
                int recordsToDelete = int.Parse(textBox5.Text);
                
                textBox5.Visible = true;
                
                if (recordsToDelete>=0)
                {
                    
                    SqlCommand command = new SqlCommand("DELETE FROM Prac1DBTB WHERE @Value1 = StudentID ", connection);
                    command.Parameters.AddWithValue("@Value1", recordsToDelete);
                    command.ExecuteNonQuery();
                    int rowsAffected = adapter.DeleteCommand.ExecuteNonQuery();
                    MessageBox.Show(rowsAffected + " row(s) deleted.");
                }
                else
                {
                    MessageBox.Show("Record Not Found");
                }

                //clearing all input
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
                textBox5.Clear();

                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting from database: " + ex.Message);
            }
            connection.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
      
        }
    }
}
