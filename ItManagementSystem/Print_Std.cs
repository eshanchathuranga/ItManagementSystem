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
    public partial class frmPrintStd : Form
    {
        public frmPrintStd()
        {
            InitializeComponent();
        }

        private void btnStudent_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmStdReg obj = new frmStdReg();
            obj.Show();
        }

        private void btnRegistration_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmStdReg obj = new frmStdReg();
            obj.Show();
        }

        private void btnManageStudent_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMngStd obj = new frmMngStd();
            obj.Show();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmPrintStd obj = new frmPrintStd();
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

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void frmPrintStd_Load(object sender, EventArgs e)
        {

        }

        private void btnPrin_Click(object sender, EventArgs e)
        {

        }
    }
}
