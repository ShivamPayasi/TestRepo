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
    public partial class PaySlip : Form
    {
        public PaySlip()
        {
            InitializeComponent();
        }

        private void PaySlip_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Diagnostics.Process.GetCurrentProcess().Kill();
            Application.Exit();
        }

        private void PaySlip_Load(object sender, EventArgs e)
        {
            pnlAdddept.Enabled = false;
            LoadData();
        }
        SqlConnection con;
        SqlCommand cmd;
        DataManager db = new DataManager();
        private void LoadData()
        {
            con = db.connection();
            con.Open();
            SqlDataAdapter sd = new SqlDataAdapter("select *from TblSlip", con);

            try
            {
                dataGridView1.DataSource = null;
                DataSet ds = new DataSet();
                sd.Fill(ds, "TblEmp");
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
        }
        private void btnDash_Click(object sender, EventArgs e)
        {
            DashBoard frmdash = new DashBoard();
            frmdash.Show();
            this.Hide();
        }

        private void btnAddDepartmentBtn_Click(object sender, EventArgs e)
        {
            pnlAdddept.Enabled = true;
            LoadEmp();
        }

        private void LoadEmp()
        {
            con = db.connection();
            try
            {
                string query = "select empName from TblEmp";
                con.Open();
                cmd = new SqlCommand(query, con);
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    cmbEmp.Items.Add(dr[0].ToString());
                }
                dr.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
            finally
            {
                con.Close();
            }
        }
    

        private void btnAddAW_Click(object sender, EventArgs e)
        {
            bool status;
            string query;
            query = $"insert into TblSlip(slipName,slipAmount,description,empId) values('{txtSname.Text}',{Convert.ToInt32(txtSAmmount.Text)},'{txtDec.Text}','{cmbEmp.Text}') ";
            status = db.Insert(query);
            if (status)
            {
                MessageBox.Show("Pay slip Created successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                pnlAdddept.Enabled = false;
                LoadData();
                txtFindById.Clear();
                txtSAmmount.Clear();
                txtSId.Clear();
                txtSname.Clear();
                cmbEmp.DataSource = null;


            }
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            con.Open();
            try
            {
                SqlCommand cmd = new SqlCommand($"select *from TblSlip where slipId= '{txtFindById.Text}'", con);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {

                    pnlAdddept.Enabled = true;
                    lblAward.Show();
                    txtSId.Show();
                    btnAddAW.Enabled = false;
                    btnUpdateAW.Enabled = true;

                    txtSId.Text = dr["slipId"].ToString();
                    txtSname.Text = dr["slipName"].ToString();
                    txtSAmmount.Text = dr["slipAmount"].ToString();
                    txtDec.Text = dr["description"].ToString();
                    txtSAmmount.Text = dr["empId"].ToString();
                }
            

            
                else
                {
                    MessageBox.Show("No Record Found", "information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            catch (Exception)
            {

            }
            finally
            {
                con.Close();
            }
        }

        private void btnUpdateAW_Click(object sender, EventArgs e)
        {
            bool status;
            string query;
            query = $"update  TblSlip set slipName='{txtSname.Text}',slipAmount={Convert.ToInt32(txtSAmmount.Text)},description='{txtDec.Text}',empId='{cmbEmp.Text}' where slipId={txtSId.Text}";
            status = db.update(query);
            if (status)
            {
                MessageBox.Show("Expence Updated successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                pnlAdddept.Enabled = false;
                LoadData();
                txtSId.Clear();
                txtSname.Clear();
                txtSAmmount.Clear();
                txtDec.Clear();
                pnlAdddept.Enabled = false;

            }
        }
    }
}


