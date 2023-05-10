using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;


namespace PharmacyProject
{
    public partial class Reports : Form
    {
        public Reports()
        {
            InitializeComponent();
            //BestSeller();
            
            //Capital();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=DESKTOP-JMPCOGK\SQLEXPRESS;Initial Catalog=Pharmacy;Integrated Security=True");

        private void BestSeller()
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("bestseller", Con);
            cmd.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            ReportsDgv.DataSource = dt;
            Con.Close();
        }

        private void expireDate()
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("expier", Con);
            cmd.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            ReportsDgv.DataSource = dt;
            Con.Close();
        }

        private void minimum()
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("minimum", Con);
            cmd.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            ReportsDgv.DataSource = dt;
            Con.Close();
        }
        private void Capital()
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("capital", Con);
            cmd.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            ReportsDgv.DataSource = dt;
            Con.Close();
        }
        private void backBTN_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainmenuForm menu = new MainmenuForm();
            menu.Show();
        }

        private void creditor()
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("creditor", Con);
            cmd.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            ReportsDgv.DataSource = dt;
            Con.Close();
        }
        private void Debtor()
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("Debtor", Con);
            cmd.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            ReportsDgv.DataSource = dt;
            Con.Close();
        }
        private void Totalsales()
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("Totalsales", Con);
            cmd.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            ReportsDgv.DataSource = dt;
            Con.Close();
        }

        private void totalpurchases()
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("totalpurchases", Con);
            cmd.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            ReportsDgv.DataSource = dt;
            Con.Close();
        }

        private void profits()
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("profits", Con);
            cmd.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            ReportsDgv.DataSource = dt;
            Con.Close();
        }
        private void Discount()
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("Discount", Con);
            cmd.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            ReportsDgv.DataSource = dt;
            Con.Close();
        }

        private void TypeReportscomboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (TypeReportscomboBox1.SelectedText.ToString() == "اصناف قربة على انتهاء الصلاحية ")
            {
                expireDate();
            }
            else if (TypeReportscomboBox1.SelectedText.ToString() == "أصناف قلت عن الحد الأدنى")
            {
                minimum();
            }
            else if (TypeReportscomboBox1.SelectedText.ToString() == "المدين")
            {
                Debtor();
            }
            else if (TypeReportscomboBox1.SelectedText.ToString() == "الدائن")
            {
                creditor();
            }
            else if (TypeReportscomboBox1.SelectedText.ToString() == "اجمالى ما تم بيعه")
            {
                Totalsales();
            }
            else if (TypeReportscomboBox1.SelectedText.ToString() == "اجمالى ما تم صرفه")
            {
                totalpurchases();
            }
            else if (TypeReportscomboBox1.SelectedText.ToString() == "اجمالى الأرباح")
            {
                profits();
            }
            else if (TypeReportscomboBox1.SelectedText.ToString() == "رأس المال")
            {
                Capital();
            }
            else if (TypeReportscomboBox1.SelectedText.ToString() == "اعلا خصم")
            {
                Discount();
            }
        }

        private void Reports_Load(object sender, EventArgs e)
        {

        }

        private void TypeReportscomboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
