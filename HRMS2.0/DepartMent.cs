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
    public partial class DepartMent : Form
    {
        public DepartMent()
        {
            InitializeComponent();
        }
        DataManager db=new DataManager();
        SqlConnection con;
        SqlCommand cmd;
        private void btnDepartment_Click(object sender, EventArgs e)
        {btnAddDept.Enabled = true;
            SqlConnection con = db.connection();
            try
            {
                con.Open();
               cmd=new SqlCommand ("SELECT COUNT(*) FROM dbo.TblDept",con);
                int count=(int)cmd.ExecuteScalar();
                txtDeptId.Text +="DEPT"+(count + 1);
                pnlAdddept.Visible = true;
                btnAddDept.Enabled = true;
            }
            catch (Exception)
            {
      
            }
            finally
            {
                con.Close();
            }

        }

        private void DepartMent_Load(object sender, EventArgs e)
        {
            pnlAdddept.Visible=false;
            //btnUpdate.Enabled = false;
            //btnRemove.Enabled = false;
            //btnAddDept.Enabled = false;
            btnAddDept.Enabled = false;    
            btnRemoveBtn.Enabled= false;
            btnUpdateBtn.Enabled = false;
            LoadData();
            
        }

        private void btnAddDept_Click(object sender, EventArgs e)
        {
            con = db.connection();

            try
            {
                con.Open();
                cmd = new SqlCommand($"insert into TblDept values('{txtDeptId.Text}','{txtDeptName.Text}','{txtDeptDescription.Text}')",con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Depatment Added successfully ", "information", MessageBoxButtons.OK, MessageBoxIcon.Information);
           
                LoadData();
                txtDeptDescription.Text = "";
                txtDeptId.Text = "";
                txtDeptName.Text = "";
                pnlAdddept.Visible = false;
                btnAddDept.Enabled = false;
            }
            catch (Exception Ex)
            {
                MessageBox.Show(" Errorr in Adding  Depatment:" + Ex.Message, "information", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            finally
            {
                con.Close();

            }
        }

        private void LoadData()
        {
            con = db.connection();
            con.Open();
            SqlDataAdapter sd = new SqlDataAdapter("select *from TblDept",con);

            try
            {
                dataGridView1.DataSource = null;
                DataSet ds = new DataSet();
                sd.Fill(ds, "TblDept");
                dataGridView1.DataSource = ds.Tables[0];
              
         
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                con.Close();
            }
              //  dataGridView1.DataSource = //data Source is students list
         
        }
        
        private void btnFind_Click(object sender, EventArgs e)
        {
            SqlConnection con = db.connection();
            con.Open();
            try
            {
                SqlCommand cmd = new SqlCommand($"select *from TblDept where deptId= '{txtFindById.Text}'", con);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    pnlAdddept.Visible = true;
                    txtDeptId.Text = dr["deptId"].ToString();
                    txtDeptId.ReadOnly = true;
                    txtDeptName.Text = dr["deptname"].ToString();
                    txtDeptDescription.Text = dr["deptDisciption"].ToString();
                }
                else
                {
                    MessageBox.Show("No Record Found" , "information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                btnAddDept.Enabled = false;
                btnRemoveBtn.Enabled = true;
                btnUpdateBtn.Enabled = true;
            }
            
            catch (Exception Ex)
            {
                MessageBox.Show("Exception" + Ex.Message, "information", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            finally
            {
                con.Close();
            }
        }

        private void FinfBYID(string text)
        {
           
        }

        private void btnRemoveBtn_Click(object sender, EventArgs e)
        {
      
           
        }

        private void btnUpdateBtn_Click(object sender, EventArgs e)
        {

        }

        private void btnRemoveBtn_Click_1(object sender, EventArgs e)
        {
            bool stuus = false;
            string query = $"DELETE FROM TblDept WHERE deptId='{txtDeptId.Text}'";
            stuus = db.Remove(query);
            if (stuus == true)
            {
                MessageBox.Show("  Depatment Removed Succesfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtFindById.Text = "";
                LoadData();
                pnlAdddept.Visible = false;
                btnAddDept.Enabled = false;
                btnRemoveBtn.Enabled = false;
                btnUpdateBtn.Enabled = false;

            }
            else
            {
                MessageBox.Show("   Depatment Not Found", "information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtFindById.Text = "";
                txtFindById.Focus();
            }
        }

        private void btnUpdateBtn_Click_1(object sender, EventArgs e)
        {
            bool status = false;

            string query;
            query = $"Update TblDept set deptName='{txtDeptName.Text}' ,deptDisciption='{txtDeptDescription.Text}' Where deptId='{txtDeptId.Text}'";
            status = db.update(query);
            if (status == true)
            {
                MessageBox.Show("  Depatment Updated Succesfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtFindById.Text = "";
                LoadData();
                pnlAdddept.Visible = false;
                btnAddDept.Enabled = false;
                btnRemoveBtn.Enabled = false;
                btnUpdateBtn.Enabled = false;

            }
            else
            {
                MessageBox.Show("Depatment Not Found", "information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtFindById.Text = "";
                txtFindById.Focus();
            }
;           
        }

        private void DepartMent_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Diagnostics.Process.GetCurrentProcess().Kill();
            Application.Exit();
        }

        private void btnDash_Click(object sender, EventArgs e)
        {
            DashBoard frmdash = new DashBoard();
            frmdash.Show();
            this.Hide();
        }
    }
}
