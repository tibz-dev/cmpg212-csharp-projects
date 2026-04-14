using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Seshayi_40972364_Prac5
{
    public partial class EditProducts : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\sesha\Desktop\SCHOOL WORK\CMPG212\Seshayi_40972364_Prac5\Data.mdf"";Integrated Security=True");
        public EditProducts()
        {
            InitializeComponent();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            int ProductID = Convert.ToInt32(txtBID.Text);
            string ProductName = Convert.ToString(txtBName.Text);
            string Category = Convert.ToString(txtBcategory.Text);
            decimal ProductPrice = Convert.ToDecimal(txtBPrice.Text);

            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand($"INSERT INTO ProductsT (ProductID, ProductName,Category, ProductPrice) VALUES('{ProductID}', '{ProductName}', '{Category}', '{ProductPrice}')", conn);
            
                SqlDataAdapter adapter = new SqlDataAdapter();

                adapter.InsertCommand = cmd;
                adapter.InsertCommand.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Insert Successful");
                txtBPrice.Text = " ";
                txtBName.Text = " ";
                txtBcategory.Text = " ";
                txtBID.Text = " ";

            }
            catch(Exception ex) 
            {
                MessageBox.Show("SQL Error: " + ex.Message);
            }
        }

        private void btnDelID_Click(object sender, EventArgs e)
        {
            int DelProductID = Convert.ToInt32(txtBDelID.Text);

            try 
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand($"DELETE FROM ProductsT WHERE ProductID = {DelProductID}", conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Product DEleted Successfully");

                conn.Close();
            }
            catch(Exception ex) 
            {
                MessageBox.Show("SQL Errro: "+ ex.Message);
            }
            txtBDelID.Text = " ";


        }

        private void btnDelCategory_Click(object sender, EventArgs e)
        {
           

            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(@"DELETE FROM ProductsT WHERE Category LIKE '%"+ comboBox2.Text + "%'", conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Product DEleted Successfully");

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("SQL Errro: " + ex.Message);
            }
            comboBox2.Text = "Select Cartegory";
        }

        private void btnDelAll_Click(object sender, EventArgs e)
        {
            int DelProductID = Convert.ToInt32(txtBDelID.Text);

            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand($"DELETE FROM ProductsT WHERE ProductID = {DelProductID}", conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Product DEleted Successfully");

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("SQL Errro: " + ex.Message);
            }
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand($"DELETE FROM ProductsT WHERE ProductID LIKE '%" + comboBox2.Text + "%'", conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Product DEleted Successfully");

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("SQL Errro: " + ex.Message);
            }

        }

        private void EditProducts_Load(object sender, EventArgs e)
        {

        }
    }
}
