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

namespace ItManagementSystem
{
    public partial class frmStdReg : Form
    {
        public frmStdReg()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-517JTTN\SQLEXPRESS;Initial Catalog=ItManagementSystem;Integrated Security=True");

        private void frmStdReg_Load(object sender, EventArgs e)
        {

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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                string firstName = txtFirstName.Text;
                 string lastName = txtLastName.Text;
                     int contact = int.Parse(txtContact.Text);
            DateTime dateofbirth = DTDateofBirth.Value;
                   string gender = "";
                         if (RadFemale.Checked)
                         {
                          gender = "Female";
                         }
                         else if (RadMale.Checked)
                         {
                          gender = "Male";
                         }

            string address = txtAddress.Text;

            // sql query
            string query = "INSERT INTO ItManagementSystem VALUES('" + firstName + "','" + lastName + "'," + contact + ",'" + dateofbirth + "'," + gender + ",'" + address + "')";
            
            // sql command
            SqlCommand cmnd = new SqlCommand(query,con);
            cmnd.Parameters.AddWithValue("@FirstName", firstName);
            cmnd.Parameters.AddWithValue("@LastName", lastName);
            cmnd.Parameters.AddWithValue("@Contact", Contact);
            cmnd.Parameters.AddWithValue("@DateofBirthday", DTDateofBirth);
            cmnd.Parameters.AddWithValue("@Gender", gender);
            cmnd.Parameters.AddWithValue("@Address", address);

            con.Open();
                MessageBox.Show("Save Successfilly!");

                string sqltm = "Select " frmStdReg";
                        SqlDataAdapter SDA = new SqlDataAdapter(sqltm,con);
                                DataSet ds = new System.Data.DataSet();
                  SDA.Fill(ds, "Student");
                  DTDateofBirth.DataSource = ds.Tables[0];

                txtFirstName.Clear();
                txtLastName.Clear();
                txtContact.Clear();
                txtAddress.Clear();
                RadFemale.Checked = false;
                RadMale.Checked = false;
                DTDateofBirth.Value = DateTime.Now;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error While Saving" + ex);
            }
            finally
            {
            // closing the connection
                con.Close();
            }

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
                txtFirstName.Clear();
                txtLastName.Clear();
                txtContact.Clear();
                txtAddress.Clear();
                RadFemale.Checked = false;
                RadMale.Checked = false;
                DTDateofBirth.Value = DateTime.Now;
        }

        private void DTDateofBirth_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
