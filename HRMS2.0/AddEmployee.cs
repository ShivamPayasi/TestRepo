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
    public partial class AddEmployee : Form
    {
        public AddEmployee()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        DataManager db = new DataManager();
        SqlCommand cmd;
        SqlConnection con;
        private void AddEmployee_Load(object sender, EventArgs e)
        {
       
        }

        private void CheckStatus()
        {
           
        }

        private void GetEmp()
        {
            SqlConnection con = db.connection();
            con.Open();
            SqlCommand cmd = new SqlCommand($"select *from TblEmp where empId='{db.EmpId}'", con);
            SqlDataReader dr = cmd.ExecuteReader();
            txtEmpId.Text = db.EmpId;
            if (dr.Read())
            {
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
        private void LoadDept()
        {
            con = db.connection();
            try
            {
                string query = "select deptId from TblDept";
                con.Open();
                cmd = new SqlCommand(query, con);
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                SqlDataReader dr=cmd.ExecuteReader();
                while (dr.Read())
                {
                    cmbDeptId.Items.Add(dr[0].ToString());
                }
                dr.Close();
                //DataSet ds=new DataSet();
                //da.Fill(ds);
                //cmbDeptId.DataSource = ds.Tables[0].Columns;
                ////cmbDeptId.DisplayMember = "deptId";
                ////cmbDeptId.ValueMember = "deptId";
                //cmd.ExecuteNonQuery();
            }
            catch (Exception ex )
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

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddEmployee_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Diagnostics.Process.GetCurrentProcess().Kill();
            Application.Exit();
        }

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

                MessageBox.Show("Employee Added successFully! ","Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                clearBox();
                this.Hide();
                Employee frmEmp = new Employee();
                frmEmp.Show();


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            finally
            {
                con.Close();
            }
            //  string qury = $"insert into TblEmp values('{txtEmpId.Text}','{txtName.Text}','{txtEmpId.Text}'" +
            //      $",'{txtPhone.Text}','{cmbDeptId.Text}','{txtEducation.Text}','{txtCity.Text}'" +
            //      $",'{txtCity.Text}','{txtState.Text}',{Convert.ToInt32(txtSalary.Text)},'{Convert.ToString(dtDob.Value.Date)}'" +
            //      $",'{cmbGender.Text}',{ms.ToArray})";
            //bool status=db.Insert(qury);
            //  if (status)
            //  {
            //      MessageBox.Show("done");
            //  }
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

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp; *.png";
            if (open.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image=Image.FromFile(open.FileName);
            }
        }
    }
}
