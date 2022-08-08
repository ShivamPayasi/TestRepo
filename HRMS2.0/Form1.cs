using HRMS_management;
using System.Data.SqlClient;

namespace HRMS2._0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        DataManager db = new DataManager();
        private void btnLogin_Click(object sender, EventArgs e)
        {

            SqlConnection con = db.connection();
            con.Open();
            

            try
            {
                SqlCommand cmd = new SqlCommand($"select UserName from TblLogin where UserName='{txtUserName.Text}' AND userPass='{txtUserPass.Text}'", con);
                SqlDataReader Dr;
                   Dr= cmd.ExecuteReader();
                if (Dr.Read())
                {
                    DashBoard frm1 = new DashBoard();
                 frm1.Show();
                    this.Hide();

                }
                else
                {
                    MessageBox.Show("Enter valid User Name Or Password", "error");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString());
            }
            finally
            {
                con.Close();
            }
        }

        private void btnForgotPass_Click(object sender, EventArgs e)
        {
            ForgotPassword FrnFg = new ForgotPassword();
            FrnFg.Show();
            this.Hide();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Diagnostics.Process.GetCurrentProcess().Kill();
            Application.Exit();
        }

        private void txtUserPass_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            AdminGignUp adminGignUp = new AdminGignUp();
            adminGignUp.Show();
            //Application.Run(adminGignUp);
            this.Hide();
        }
    }
}