using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Seshayi_40972364_Prac5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void viewToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void stationeryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Products productsForm = new Products();
            productsForm.Show();
        }

        private void editProductsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditProducts editForm = new EditProducts();
            editForm.Show();
        }
    }
}
