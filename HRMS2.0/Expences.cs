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
    public partial class Expences : Form
    {
        public Expences()
        {
            InitializeComponent();
        }

        private void btnDash_Click(object sender, EventArgs e)
        {
            DashBoard frmdash = new DashBoard();
            frmdash.Show();
            this.Hide();
        }

        private void Expences_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Diagnostics.Process.GetCurrentProcess().Kill();
            Application.Exit();
        }

        private void Expences_Load(object sender, EventArgs e)
        {
            LoadExp();
            pnlAdddept.Enabled = false;
        }

        SqlConnection con;
        SqlCommand cmd;
        DataManager db = new DataManager(); 
        private void LoadExp()
        {
            con = db.connection();
            con.Open();
            SqlDataAdapter sd = new SqlDataAdapter("select *from TblExp", con);

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

        private void btnAddDepartmentBtn_Click(object sender, EventArgs e)
        {
            pnlAdddept.Enabled = true;
           
        }

        private void btnAddAW_Click(object sender, EventArgs e)
        {
            bool status;
            string query;
            query = $"insert into TblExp(expAmmount,expDescription) values({Convert.ToInt32(txtAmt.Text)},'{txtExDes.Text}') ";
            status = db.Insert(query);
            if (status)
            {
                MessageBox.Show("Award Added successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                pnlAdddept.Enabled = false;
                LoadExp();
                txtExDes.Clear();
                txtExId.Clear();
                txtAmt.Clear();

            }
        }

        private void btnUpdateAW_Click(object sender, EventArgs e)
        {
            //    con = new SqlConnection();
            //    cmd = new SqlCommand("");
            bool status;
            string query;
            query = $"update  TblExp set expAmmount={Convert.ToInt32(txtAmt.Text)},expDescription='{txtExDes.Text}' where expenceId={txtExId.Text}";
            status = db.update(query);
            if (status)
            {
                MessageBox.Show("Expence Updated successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                pnlAdddept.Enabled = false;
                LoadExp();
                txtExDes.Clear();
                txtExId.Clear();
                txtAmt.Clear();

            }
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            con.Open();
            try
            {
                SqlCommand cmd = new SqlCommand($"select *from TblExp where expenceId= '{txtFindById.Text}'", con);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {

                    pnlAdddept.Enabled = true;
                    lblAward.Show();
                    txtExId.Show();
                    btnAddAW.Enabled = false;
                    btnUpdateAW.Enabled = true;

                    txtExId.Text = dr["expenceId"].ToString();
                    txtAmt.Text = dr["expAmmount"].ToString();
                    txtExDes.Text = dr["expDescription"].ToString();
                }
                else
                {
                    MessageBox.Show("No Record Found", "information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            catch(Exception)
            {

            }
            finally
            {
                con.Close();
            }
            }
    }
}
