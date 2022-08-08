using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace HRMS_management
{
    public class DataManager
    {
        public string EmpId { get; set; } 
       
        public string ConString { get; set; } = @"Data Source=DESKTOP-PEQ09SV\SQLEXPRESS;Database=HRMS_DB;Integrated Security=True";
      
        public SqlConnection connection()
        {
            SqlConnection con = new SqlConnection(ConString);
            return con;
        }
        public bool update(string query)
        {
            SqlConnection con = connection();
            con.Open();
            try
            {
                
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception Ex)
            {

                MessageBox.Show(" Errorr in Updating information:" + Ex.Message, "information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            finally
            {
                con.Close();
            }
          
        }
        public bool Remove(string query)
        {
            SqlConnection con = connection();
            con.Open();
            try
            {

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception Ex)
            {

                MessageBox.Show(" Errorr in Removing  Information:" + Ex.Message, "information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            finally
            {
                con.Close();
            }
        }
        public bool Insert(string query)
        {
            SqlConnection con = connection();
            con.Open();
            try
            {

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception Ex)
            {

                MessageBox.Show(" Errorr in Adding  Information:" + Ex.Message, "information", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return false;
            }

            finally
            {
                con.Close();
            }
        }
    }
}
