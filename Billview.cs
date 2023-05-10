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

namespace PharmacyProject
{
    public partial class Billview : Form
    {
        public Billview()
        {
            InitializeComponent();
            populateBill();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=noor\sqlexpress;Initial Catalog=PHARMACY1;Integrated Security=True");
        string query;
        Connection cn = new Connection();
        private void searchBill()
        {
            try
            {
                //(MedId,MedName,ManName,Spercentage,ExpDate,Sprice,Bprice,CompanyName,Stock,MinBuyingRange,MaxSelingRange,MedNameArabic,TaxRatio)
                Con.Open();
                string myqury = "SELECT BillNum AS [رقم العملية],ManId AS [اسم المورد],BillDate AS [تاريخ الفتورة],BillType AS [نوع الفتورة],TotalCash AS [الأجمالي],CategorySafe AS [الخزينة],PaymentType AS [طريقة الدفع], empName AS [اسم الموظف] FROM Billing where CategorySafe like N'" + categorySafeCB.SelectedItem.ToString() + "%'";
                SqlDataAdapter dataadapter = new SqlDataAdapter(myqury, Con);
                SqlCommandBuilder comandbuilder = new SqlCommandBuilder(dataadapter);
                var Ds = new DataSet();
                dataadapter.Fill(Ds);
                BillViewDgv.ReadOnly = true;
                BillViewDgv.DataSource = Ds.Tables[0];
                Con.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("خطاء في البيانات", "ERORR", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
        public void populateBill()
        {
            try
            {
                //(MedId,MedName,ManName,Spercentage,ExpDate,Sprice,Bprice,CompanyName,Stock,MinBuyingRange,MaxSelingRange,MedNameArabic,TaxRatio)
                Con.Open(); //(, , , , , , , , , )
                string myqury = "SELECT BillNum AS [رقم العملية],ManId AS [اسم المورد],BillDate AS [تاريخ الفتورة],BillType AS [نوع الفتورة],TotalCash AS [الأجمالي],CategorySafe AS [الخزينة],PaymentType AS [طريقة الدفع], empName AS [اسم الموظف] FROM Billing";
                SqlDataAdapter dataadapter = new SqlDataAdapter(myqury, Con);
                SqlCommandBuilder comandbuilder = new SqlCommandBuilder(dataadapter);
                var Ds = new DataSet();
                dataadapter.Fill(Ds);
                BillViewDgv.ReadOnly = true;
                BillViewDgv.DataSource = Ds.Tables[0];
                Con.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("خطاء في البيانات", "ERORR", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
           
        }
        public void DailyBill()
        {
            try
            {
                //(MedId,MedName,ManName,Spercentage,ExpDate,Sprice,Bprice,CompanyName,Stock,MinBuyingRange,MaxSelingRange,MedNameArabic,TaxRatio)
                Con.Open(); //(, , , , , , , , , )
                string myqury = "SELECT orderID AS [رقم العملية],proID AS [كوود الدواء],proName AS [اسم الدواء],proQty AS [عدد الوحدات],unitPrice AS [سعر الوحدة],subTotal AS [الاجمالي قبل الضريبة و الخصم] FROM [Order]";
                SqlDataAdapter dataadapter = new SqlDataAdapter(myqury, Con);
                SqlCommandBuilder comandbuilder = new SqlCommandBuilder(dataadapter);
                var Ds = new DataSet();
                dataadapter.Fill(Ds);
                BillViewDgv.ReadOnly = true;
                BillViewDgv.DataSource = Ds.Tables[0];
                Con.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("خطاء في البيانات", "ERORR", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void categorySafeCB_SelectionChangeCommitted(object sender, EventArgs e)
        {
            searchBill();
        }

        private void resetBillbtn_Click(object sender, EventArgs e)
        {
            populateBill();
        }

        private void Billview_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DailyBill();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                query = "DELETE FROM Billing WHERE CategorySafe= '" + categorySafeCB.SelectedItem.ToString() + "';";
                cn.setData(query, "تم حذف الصنف بنجاح");
                populateBill();
            }
            catch (Exception)
            {
                MessageBox.Show("حدث خطأ في الحذف", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
