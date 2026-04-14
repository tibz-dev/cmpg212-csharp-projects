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

namespace Seshayi_40972364_Prac5
{
    public partial class Products : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\sesha\Desktop\SCHOOL WORK\CMPG212\Seshayi_40972364_Prac5\Data.mdf"";Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataSet ds = new DataSet();
        public Products()
        {
            InitializeComponent();
        }

        private void btnViewAll_Click(object sender, EventArgs e)
        {
            try 
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(@"SELECt * FROM ProductsT", conn);
                adapter = new SqlDataAdapter();
                ds = new DataSet();

                adapter.SelectCommand = cmd;
                adapter.Fill(ds, "ProductsT");
                dataGridView1.DataSource = ds;
                dataGridView1.DataMember = "ProductsT";

                conn.Close();
            }
            catch(Exception ex) 
            {
                MessageBox.Show("SQL Error: " + ex.Message);
            }
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(@"SELECT * FROM ProductsT ORDER BY ProductPrice ASC", conn);
                adapter = new SqlDataAdapter();
                ds = new DataSet();

                adapter.SelectCommand = cmd;
                adapter.Fill(ds, "ProductsT");
                dataGridView1.DataSource = ds;
                dataGridView1.DataMember = "ProductsT";

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("SQL Error: " + ex.Message);
            }
        }

        private void btnViewSale_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(@"SELECT * FROM ProductsT WHERE ProductPrice < 25", conn);
                adapter = new SqlDataAdapter();
                ds = new DataSet();

                adapter.SelectCommand = cmd;
                adapter.Fill(ds, "ProductsT");
                dataGridView1.DataSource = ds;
                dataGridView1.DataMember = "ProductsT";

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("SQL Error: " + ex.Message);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(@"SELECT * FROM ProductsT WHERE Category = '" + comboBox1.Text + "'", conn);
                adapter = new SqlDataAdapter();
                ds = new DataSet();

                adapter.SelectCommand = cmd;
                adapter.Fill(ds, "ProductsT");
                dataGridView1.DataSource = ds;
                dataGridView1.DataMember = "ProductsT";

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("SQL Error: " + ex.Message);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string ProductName = Convert.ToString(txtBoxSearch.Text);
            try
            {

                conn.Open();
                SqlCommand cmd = new SqlCommand(@"SELECT * FROM ProductsT WHERE ProductName LIKE '%" + ProductName + "%'", conn);
                adapter = new SqlDataAdapter();
                ds = new DataSet();

                adapter.SelectCommand = cmd;
                adapter.Fill(ds, "ProductsT");
                dataGridView1.DataSource = ds;
                dataGridView1.DataMember = "ProductsT";

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("SQL Error: " + ex.Message);
            }
        }

        

        private void txtBoxSearch_TextChanged(object sender, EventArgs e)
        {
            /*string ProductName = Convert.ToString(txtBoxSearch.Text);
            try
            {

                conn.Open();
                SqlCommand cmd = new SqlCommand(@"SELECT * FROM ProductsT WHERE ProductName LIKE '%" + ProductName + "%'", conn);
                adapter = new SqlDataAdapter();
                ds = new DataSet();

                adapter.SelectCommand = cmd;
                adapter.Fill(ds, "ProductsT");
                dataGridView1.DataSource = ds;
                dataGridView1.DataMember = "ProductsT";

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("SQL Error: " + ex.Message);
            }*/
        }

        private void Products_Load(object sender, EventArgs e)
        {

        }
    }
 }


