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
    public partial class Employee : Form
    {
        public Employee()
        {
            InitializeComponent();
        }
        private void GetEmp()
        {
            SqlConnection con = db.connection();
            con.Open();
            SqlCommand cmd = new SqlCommand($"select *from TblEmp where empId='{txtFindById.Text}'", con);
            SqlDataReader dr = cmd.ExecuteReader();
            txtEmpId.Text = db.EmpId;
            if (dr.Read())
            {
                txtEmpId.Text = dr["empId"].ToString();
                txtName.Text = dr["empName"].ToString();
                txtEmail.Text = dr["empEmail"].ToString();
                txtPhone.Text = dr["empPhone"].ToString();
                cmbDeptId.Text = dr["deptId"].ToString();
                txtEducation.Text = dr["empQualification"].ToString();
                txtCity.Text = dr["empCity"].ToString();
                txtState.Text = dr["empState"].ToString();
                txtSalary.Text = dr["empJoiningSalary"].ToString();
                dtDob.Text = dr["empDob"].ToString();
                cmbGender.Text = dr["empGender"].ToString();
                MemoryStream ms = new MemoryStream((byte[])dr["empPoto"]);
                pictureBox1.Image = Image.FromStream(ms);

            }
            con.Close();
        }

        private void Employee_Load(object sender, EventArgs e)
        {
            LoadData();
            panel1.Visible = false;
        }
        SqlConnection con;
        DataManager db = new DataManager();
        private void LoadData()
        {
            con = db.connection();
            con.Open();
            SqlDataAdapter sd = new SqlDataAdapter("select *from TblEmp", con);

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
            btnRemove.Enabled = false;
            btnUpdate.Enabled = false;
            AutoId();
            LoadDept();
            panel1.Visible = true;

        }
        private void LoadDept()
        {
            con = db.connection();
            try
            {
                string query = "select deptId from TblDept";
                con.Open();
                cmd = new SqlCommand(query, con);
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    cmbDeptId.Items.Add(dr[0].ToString());
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

        private void AutoId()
        {
            SqlConnection con = db.connection();
            try
            {
                con.Open();
                cmd = new SqlCommand("SELECT COUNT(*) FROM dbo.TblEmp", con);
                int count = (int)cmd.ExecuteScalar();
                txtEmpId.Text += "EMP" + (count + 1);

            }
            catch (Exception)
            {

            }
            finally
            {
                con.Close();
            }
        }
        private void btnFind_Click(object sender, EventArgs e)
        {
           
            SqlConnection con = db.connection();
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand($"select *from TblEmp where empId='{txtFindById.Text}'", con);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    panel1.Visible = true;
                    btnRemove.Enabled = true;
                    btnUpdate.Enabled = true;
                    btnAddEmployee.Enabled = false;
                    panel1.Visible = true;
                    GetEmp();
           
                }
                else
                {
                    MessageBox.Show("No Record Found for the following Id", "Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtFindById.Focus();
                }
                
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

        private void Employee_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Diagnostics.Process.GetCurrentProcess().Kill();
            Application.Exit();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp; *.png";
            if (open.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(open.FileName);
            }
        }
        SqlCommand cmd;
        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            con = db.connection();
            con.Open();
            try
            {
                MemoryStream ms = new MemoryStream();
                MemoryStream msp = new MemoryStream();
                pictureBox1.Image.Save(ms, pictureBox1.Image.RawFormat);
                cmd = new SqlCommand("insert into TblEmp(empId,empName,empEmail,empPhone,deptId,empQualification,empCity,empState,empJoiningSalary,empDob,empGender,empPoto)" +
                    " values(@empId_,@empName_,@empEmail_,@empPhone_,@deptId_,@empQualification_,@empCity_,@empState_,@empJoiningSalary_,@empDob_,@empGender_,@empPoto_);", con);
                cmd.Parameters.AddWithValue("@empId_", txtEmpId.Text);
                cmd.Parameters.AddWithValue("@empName_", txtName.Text);
                cmd.Parameters.AddWithValue("@empEmail_", txtEmail.Text);
                cmd.Parameters.AddWithValue("@empPhone_", txtPhone.Text);
                cmd.Parameters.AddWithValue("@deptId_", cmbDeptId.Text);
                cmd.Parameters.AddWithValue("@empQualification_", txtEducation.Text);
                cmd.Parameters.AddWithValue("@empCity_", txtCity.Text);
                cmd.Parameters.AddWithValue("@empState_", txtState.Text);
                cmd.Parameters.AddWithValue("@empJoiningSalary_", Convert.ToInt32(txtSalary.Text));
                cmd.Parameters.AddWithValue("@empDob_", dtDob.Text);
                cmd.Parameters.AddWithValue("@empGender_", cmbGender.Text);
                cmd.Parameters.AddWithValue("@empPoto_", ms.ToArray());
                cmd.ExecuteNonQuery();

                MessageBox.Show("Employee Added successFully! ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                clearBox();
                panel1.Visible = false;
                LoadData();


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            finally
            {
                con.Close();
            }
        }
        private void clearBox()
        {
            pictureBox1.Image = null;
            Action<Control.ControlCollection> func = null;

            func = (controls) =>
            {
                foreach (Control control in controls)
                    if (control is TextBox)
                        (control as TextBox).Clear();
                    else
                        func(control.Controls);
            };

            func(Controls);
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {

            bool status = false;
            string query = $"DELETE FROM TblEmp WHERE empId='{txtEmpId.Text}'";
            status = db.Remove(query);
            if (status)
            {
                MessageBox.Show("  Employee Deleted Succesfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtFindById.Text = "";
                LoadData();
                panel1.Visible = false;
            }
            else
            {
                MessageBox.Show("  Employee Deleted Succesfully", "Invalid Employee", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEmpId.Focus();

            }

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //string qury = $"update  TblEmp set empName='{txtName.Text}',empEmail'{txtEmpId.Text}'" +
            //      $",empPhone='{txtPhone.Text}',deptId='{cmbDeptId.Text}',empQualification='{txtEducation.Text}'" +
            //      $",empCity='{txtCity.Text}'" +
            //      $",empState='{txtState.Text}',empJoiningSalary={Convert.ToInt32(txtSalary.Text)},empDob='{dtDob.Text}'" +
            //      $",empGender='{cmbGender.Text}' where empId='{txtEmpId.Text}'";
            //bool status = db.Insert(qury);
            //if (status)
            //{
            //    MessageBox.Show("done");
            //    LoadData();
            //    panel1.Visible = false;
            //}
            try
            {
                con = db.connection();
                cmd = new SqlCommand($"update  TblEmp set empName = '{txtName.Text}', empEmail='{txtEmail.Text}'" +
                      $",empPhone='{txtPhone.Text}',deptId='{cmbDeptId.Text}',empQualification='{txtEducation.Text}'" +
                      $",empCity='{txtCity.Text}'" +
                      $",empState='{txtState.Text}',empJoiningSalary={Convert.ToInt32(txtSalary.Text)},empDob='{dtDob.Text}'" +
                      $",empGender='{cmbGender.Text}' where empId='{txtEmpId.Text}'", con);


                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data Updated Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
                panel1.Visible = false;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }

        private void btnDash_Click(object sender, EventArgs e)
        {
            DashBoard frmdash = new DashBoard();
            frmdash.Show();
            this.Hide();
        }
    }
}
