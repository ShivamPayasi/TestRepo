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
    public partial class ForgotPassword : Form
    {
        public ForgotPassword()
        {
            InitializeComponent();
        }
        DataManager db = new DataManager(); 
        private void button1_Click(object sender, EventArgs e)
        {
          
            if (txtUserName.Text != "" & txtAns.Text != "")
            {
                SqlConnection con = db.connection();

                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand($"select userPass from TblLogin where UserName='{txtUserName.Text}' AND SecurityQuest='{cmbQuest.Text}' And SecurtyAns='{txtAns.Text}'", con);
                    SqlDataReader dr;
                    dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        panel1.Show();
                    }
                    else
                    {
                        txtUserName.Focus();
                        MessageBox.Show("No user found" , "Informatin", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                }
                catch (Exception Ex)
                {
                    MessageBox.Show("Error" + Ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); 

                }
                finally
                {
                    con.Close();
                }
            }
            else
            {
                MessageBox.Show("Please enter the Username and Security credentials", "Warning",MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void ForgotPassword_Load(object sender, EventArgs e)
        {
            panel1.Hide();
            btnDash.Enabled = false;
            btnLogin.Enabled = false;
        }

        private void btnSHow_Click(object sender, EventArgs e)
        {
            if (btnSHow.Text =="Show")
            {
                txtNewPass.PasswordChar ='\0';
                btnSHow.Text = "Hide";
            }
            else if (btnSHow.Text == "Hide")
            {
                txtNewPass.PasswordChar = '*';
                btnSHow.Text = "Show";
            }
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            if (txtNewPass.Text != "" & txtConfirmPass.Text != "" & txtNewPass.Text== txtConfirmPass.Text)
            {
                SqlConnection con = db.connection();
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand($"update  TblLogin set userPass='{txtNewPass}' where UserName='{txtUserName.Text}' ",con);
                    cmd.ExecuteNonQuery();
                    btnDash.Enabled = true;
                    btnLogin.Enabled = true;
                    MessageBox.Show("Password Updated successfully", "Informaion ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                }
                catch (Exception)
                {

                    throw;
                }


            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (btnShow2.Text == "Show")
            {
                txtConfirmPass.PasswordChar = '\0';
                btnShow2.Text = "Hide";
            }
            else if (btnShow2.Text == "Hide")
            {
                txtConfirmPass.PasswordChar = '*';
                btnShow2.Text = "Show";
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Form1 frnLog = new Form1();
            frnLog.Show();
            this.Hide();
        }

        private void btnDash_Click(object sender, EventArgs e)
        {
            DashBoard frmDash = new DashBoard();
            frmDash.Show();
            this.Hide();
        }

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {

        }

        private void ForgotPassword_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Diagnostics.Process.GetCurrentProcess().Kill();
            Application.Exit();
        }
    }
}
