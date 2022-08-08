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
    public partial class Award : Form
    {
        public Award()
        {
            InitializeComponent();
        }

        private void Award_Load(object sender, EventArgs e)
        {
            LoadData();
            pnlAdddept.Enabled = false;
            lblAward.Hide();
            txtAwrdId.Hide();
            BindEmp();
        }

        private void BindEmp()
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
                    cmbAwardTo.Items.Add(dr[0].ToString());
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

        DataManager db = new DataManager();
        SqlCommand cmd;
        SqlConnection con;
        private void LoadData()
        {

            con = db.connection();
            con.Open();
            SqlDataAdapter sd = new SqlDataAdapter("select *from TblAward", con);

            try
            {
                dataGridView1.DataSource = null;
                DataSet ds = new DataSet();
                sd.Fill(ds, "TblAward");
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

        private void btnAddAward_Click(object sender, EventArgs e)
        {
            pnlAdddept.Enabled = true;
            btnRemoveAW.Enabled = false;
            btnUpdateAW.Enabled = false;
        }

        private void btnAddAW_Click(object sender, EventArgs e)
        {
            string query = $"insert into TblAward(awardName,awardPrice,awardedTo) values('{txtAwardName.Text}'," +
             $"{Convert.ToInt32(txtAwardPrice.Text)},'{cmbAwardTo.Text}')";
            bool status = db.Insert(query);
            if (status)
            {
                MessageBox.Show("Award Added successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                pnlAdddept.Enabled = false;
                LoadData();
                txtAwardName.Clear();
                txtAwardPrice.Clear();
                txtAwrdId.Clear();

            }
        }

        private void btnUpdateAW_Click(object sender, EventArgs e)
        {
            string Query = $"Update TblAward set awardName='{txtAwardName.Text}',awardPrice={Convert.ToInt32(txtAwardPrice.Text)}" +
                $",awardedTo='{cmbAwardTo.Text}' where awardID={Convert.ToInt32(txtAwrdId.Text)}";
            bool status = db.Insert(Query);
            if (status)
            {
                MessageBox.Show("Award Updated successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                pnlAdddept.Enabled = false;
                txtAwrdId.Clear();
                txtAwrdId.Hide();
                lblAward.Hide();
                txtAwardPrice.Clear();
                txtAwardName.Clear();
                cmbAwardTo.Text = "";
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnFindById_Click(object sender, EventArgs e)
        {
            con.Open();
            try
            {
                SqlCommand cmd = new SqlCommand($"select *from TblAward where awardID= '{txtFindById.Text}'", con);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    pnlAdddept.Enabled = true;
                    lblAward.Show();
                    txtAwrdId.Show();
                    btnAddAW.Enabled = false;
                    btnUpdateAW.Enabled = true;
                    btnRemoveAW.Enabled = true;
                    txtAwrdId.Text = dr["awardID"].ToString();
                     txtAwardName.Text = dr["awardName"].ToString();
                    txtAwardPrice.Text = dr["awardPrice"].ToString();
                    cmbAwardTo.Text = dr["awardedTo"].ToString();
                }
                else
                {
                    MessageBox.Show("No Record Found", "information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
              
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

        private void btnDash_Click(object sender, EventArgs e)
        {
            DashBoard frmdash = new DashBoard();
            frmdash.Show();
            this.Hide();
        }

        private void Award_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Diagnostics.Process.GetCurrentProcess().Kill();
            Application.Exit();
        }

        private void btnRemoveAW_Click(object sender, EventArgs e)
        {
            bool stuus = false;
            string query = $"DELETE FROM TblAward WHERE awardID='{Convert.ToInt32(txtAwrdId.Text)}'";
            stuus = db.Remove(query);
            if (stuus == true)
            {
                MessageBox.Show("  Award Removed Succesfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtFindById.Text = "";
                LoadData();
                pnlAdddept.Enabled = false;
            }
            else
            {
                MessageBox.Show("   Award Not Found", "information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtFindById.Text = "";
                txtFindById.Focus();
            }
        }
    }
}
