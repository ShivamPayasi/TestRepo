using HRMS_management;
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

namespace HRMS2._0
{
    public partial class AdminGignUp : Form
    {
        public AdminGignUp()
        {
            InitializeComponent();
        }

        private void AdminGignUp_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Diagnostics.Process.GetCurrentProcess().Kill();
            Application.Exit();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSign_Click(object sender, EventArgs e)
        {
            if(txtUserName.Text!="" && txtPass.Text != "" && txtConfirmPass.Text != "" && txtAns.Text != "" && cmbQuest.Text != "")
            {
                if (txtPass.Text == txtConfirmPass.Text)
                {
                    if(cmbQuest.Text != "------Choose Question----")
                    {
                        DataManager db = new DataManager();
                        SqlConnection con = db.connection();
                        SqlCommand cmd; ;
                        string query;
                        query = $"insert into TblLogin(UserName,userPass,SecurityQuest,SecurtyAns) values('{txtUserName.Text}','{txtPass.Text}','{cmbQuest.Text}','{txtAns.Text}') ";
                        bool status = db.Insert(query);
                        if (status)
                        {
                            MessageBox.Show("Admin Created sucess fully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            btndash.Enabled = true;
                            btnLogin.Enabled = true;
                        }
                        else
                        {

                        }
                    }
                    else
                    {
                        MessageBox.Show("Plese choose a sequrity question","Information",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                        cmbQuest.Focus();
                    }
                    
                }
                else
                {
                    MessageBox.Show("Both passwords are Not same", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtConfirmPass.Clear();
                    txtConfirmPass.Focus();
                }
            }
            else
            {
                MessageBox.Show("All Feilds Are Required !","Warning", MessageBoxButtons.OK,MessageBoxIcon.Hand);
                txtUserName.Focus();
            }
            
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Form1 frmLog = new Form1();
            frmLog.Show();
            this.Hide();

        }

        private void AdminGignUp_Load(object sender, EventArgs e)
        {
            btnLogin.Enabled = false;
            btndash.Enabled = false;
        }

        private void btndash_Click(object sender, EventArgs e)
        {
            DashBoard frmdash = new DashBoard();
            frmdash.Show();
            this.Hide();

        }
    }
}
  