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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\sesha\source\repos\40972364_Seshayi_Prac4\40972364_Seshayi_Prac4\Producuts.mdf;Integrated Security=True";

        SqlConnection connection;
        SqlCommand command;
        SqlDataAdapter adapter;
        DataSet dataSet;

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void toolStripMenuExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void toolStripListAndSearch_Click(object sender, EventArgs e)
        {
            ViewProducts childForm = new ViewProducts();
            childForm.MdiParent = this; // Set Form1 as the MDI parent
            childForm.Show();

        }

        private void toolStripInsertandDelete_Click(object sender, EventArgs e)
        {
            EditProducts childForm = new EditProducts();
            childForm.MdiParent = this; // Set Form1 as the MDI parent
            childForm.Show();
        }
    }
}
