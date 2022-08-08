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
    public partial class DashBoard : Form
    {
        private SqlCommand cmd;

        public DashBoard()
        {
            InitializeComponent();
        }
       
        private void DashBoard_Load(object sender, EventArgs e)
        {
            LoadDept();
            LoadEmp();
            LoadReward();
            //LoadExp();
            loadPayslips();
        }

        private void loadPayslips()
        {
            SqlConnection con = db.connection();
            try
            {
                con.Open();
                cmd = new SqlCommand("SELECT COUNT(*) FROM dbo.TblSlip", con);
                int count = (int)cmd.ExecuteScalar();
                lblPayslips.Text = (count) + "-Slips";
              
            }
            catch (Exception)
            {

            }
            finally
            {
                con.Close();
            }
        }

        private void LoadExp()
        {
            SqlConnection con = db.connection();
            try
            {
                con.Open();
                cmd = new SqlCommand("SELECT COUNT(*) FROM dbo.TblExp", con);
                int count = (int)cmd.ExecuteScalar();
                lblEmp.Text = "";
                panel5.Text += (count) + "-Expenses";
            }
            catch (Exception)
            {

            }
            finally
            {
                con.Close();
            }
        }

        private void LoadReward()
        {
            SqlConnection con = db.connection();
            try
            {
                con.Open();
                cmd = new SqlCommand("SELECT COUNT(*) FROM dbo.TblAward", con);
                int count = (int)cmd.ExecuteScalar();
                lblReward.Text = (count) + "-Reward";
              
            }
            catch (Exception)
            {

            }
            finally
            {
                con.Close();
            }
        }

        private void LoadEmp()
        {
            SqlConnection con = db.connection();
            try
            {
                con.Open();
                cmd = new SqlCommand("SELECT COUNT(*) FROM dbo.TblEmp", con);
                int count = (int)cmd.ExecuteScalar();
                lblEmp.Text = (count) + "-Employees";
           
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        DataManager db = new DataManager();
        private void LoadDept()
        {
            SqlConnection con = db.connection();
            try
            {
                con.Open();
                cmd = new SqlCommand("SELECT COUNT(*) FROM dbo.TblDept",con);
                int count = (int)cmd.ExecuteScalar();
                lblDept.Text = "";
                lblDept.Text +=(count)+ "-Departments"; 
            }
            catch (Exception)
            {

            }
            finally
            {
                con.Close();
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnDepartment_Click(object sender, EventArgs e)
        {
            DepartMent frmDept = new DepartMent();
            frmDept.Show();
            this.Hide();
        }

        private void btnEmployee_Click(object sender, EventArgs e)
        {
            Employee frmEmp = new Employee();
            frmEmp.Show();
            this.Hide();
        }

        private void DashBoard_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Diagnostics.Process.GetCurrentProcess().Kill();
            Application.Exit();
        }

        private void btnAward_Click(object sender, EventArgs e)
        {
            Award frmAw = new Award();
            frmAw.Show();
            this.Hide();

        }

        private void btnExpenses_Click(object sender, EventArgs e)
        {
            Expences frmexp = new Expences();
            frmexp.Show();
            this.Hide();
        }

        private void btnPaySlips_Click(object sender, EventArgs e)
        {
            PaySlip frmSlip = new PaySlip();
            frmSlip.Show();
            this.Hide();
        }
    }
}
