using System;
using System.Windows.Forms;

namespace _40972364_Seshayi_Prac3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            IsMdiContainer = true; // Set Form1 as an MDI container
        }

        private void tsListDVD_Click(object sender, EventArgs e)
        {
            frmDVDNew childForm = new frmDVDNew();
            childForm.MdiParent = this; // Set Form1 as the MDI parent
            childForm.Show();
        }
        private void tsListDVDOne_Click(object sender, EventArgs e)
        {

        }

        private void tsExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

