using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PharmacyProject
{
    class Connection
    {
        protected SqlConnection getconnection()
        {
            SqlConnection Con = new SqlConnection();
            Con.ConnectionString = @"Data Source=noor\sqlexpress;Initial Catalog=PHARMACY1;Integrated Security=True";
            return Con;
        }
        
        public void setData(string query,string msg)
        {
            SqlConnection Con =getconnection();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = Con;
            Con.Open();
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();
            Con.Close();
            MessageBox.Show(msg,"بيانات",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        public void setDataNo(string query)
        {
            SqlConnection Con = getconnection();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = Con;
            Con.Open();
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();
            Con.Close();
        }

        public DataSet getData(string query)
        {
            SqlConnection Con = getconnection();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection= Con;
            cmd.CommandText = query;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }
    }
}
