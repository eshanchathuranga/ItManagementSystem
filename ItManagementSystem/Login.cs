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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        
            {
                string User_Name = txtUserName.Text;
                string pass = txtPassword.Text;

                if (User_Name == "Poornima$098" && pass == "1234")
                {
                    MessageBox.Show("login Success !");
                    this.Hide();
                    frmMain obj = new frmMain();
                    obj.Show();
                }
                else
                {
                    MessageBox.Show("Login not Success");
                }
            }
        
    }
}
