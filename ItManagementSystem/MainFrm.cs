using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ItManagementSystem
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void MainFrm_Load(object sender, EventArgs e)
        {

        }

        private void btnStudent_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmStdReg obj = new frmStdReg();
            obj.Show();
        }

        private void btnCourse_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmNwCrs obj = new frmNwCrs();
            obj.Show();
        }

        private void btnDashBoard_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMain obj = new frmMain();
            obj.Show();
        }

        private void btnStudent_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            frmStdReg obj = new frmStdReg();
            obj.Show();
        }

        private void btnCourse_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            frmNwCrs obj = new frmNwCrs();
            obj.Show();
        }

        private void btnDashBoard_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            frmMain obj = new frmMain();
            obj.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
