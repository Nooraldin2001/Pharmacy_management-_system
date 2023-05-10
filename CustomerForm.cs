using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using PharmacyProject;

namespace PharmacyProject
{
    public partial class CustomerForm : Form
    {
        public CustomerForm()
        {
            InitializeComponent();
            populate();
        }
        Connection cn = new Connection();
        string query;
        SqlConnection Con = new SqlConnection(@"Data Source=noor\sqlexpress;Initial Catalog=PHARMACY1;Integrated Security=True");

        public void populate()
        {
            try
            {
                //BarCodeBill AS[كوود الفتورة]
                Con.Open();
                string myqury = "SELECT CusId AS[ID],CusName AS[الاسم], CusPhone AS[رقم التلفون],CusAdress AS[العنوان], DispenDate AS[تاريخ الصرف],CusDiebt AS[الدين], Discount AS[الخصم],PatientHistory AS[التاريخ المرضي] FROM Customer ";
                SqlDataAdapter dataadapter = new SqlDataAdapter(myqury, Con);
                SqlCommandBuilder comandbuilder = new SqlCommandBuilder(dataadapter);
                var Ds = new DataSet();
                dataadapter.Fill(Ds);
                cusDataGridView.ReadOnly = true;
                cusDataGridView.DataSource = Ds.Tables[0];
                Con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("خطأ فى البيانات", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ExitCircularBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void insertBtn_Click(object sender, EventArgs e)
        {           
            try
            {
                if (cusDiscountTb.Text == "" || cusAdressTb.Text == "" || cusDiebtTb.Text == "" || cusPhoneTb.Text == "" || cusNameTb.Text == "" || PatientHistoryRtb.Text == "" || DispenDateDtp.Text == "")
                {
                    MessageBox.Show("إدخال خاطئ الرجاء المحاولة مرة اخرى");
                }
                else
                {
                    query = ("insert into Customer(Discount,CusAdress,CusDiebt,CusPhone,CusName,PatientHistory,DispenDate) values('" + cusDiscountTb.Text + "',N'" + cusAdressTb.Text + "','" + cusDiebtTb.Text + "','" + cusPhoneTb.Text + "',N'" + cusNameTb.Text + "',N'" + PatientHistoryRtb.Text + "','" + DispenDateDtp.Value.ToString() + "')");
                    cn.setData(query, "تم اضافة العميل بنجاح");
                    populate();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("خطاء في البيانات", "ERORR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialog = MessageBox.Show("هل توافق على حذف العميل", "تحزير", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialog == DialogResult.Yes)
                {
                    if (cusNameTb.Text == "")
                    {
                        MessageBox.Show("تم حذف الموظف مسبقاً");
                    }
                    else
                    {
                        query = "delete from Customer where CusName = N'" + cusNameTb.Text + "';";
                        cn.setData(query, "تم حذف الموظف بنجاح");
                        populate();
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("خطاء في البيانات", "ERORR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CustomerForm_Load(object sender, EventArgs e)
        {
            populate();
        }

        

        //private void cusNameTb_Enter(object sender, EventArgs e)
        //{
        //    if (cusNameTb.Text == "اسم العميل")
        //    {
        //        cusNameTb.Text = "";
        //    }
        //}

        //private void cusNameTb_Leave(object sender, EventArgs e)
        //{
        //    if (cusNameTb.Text == "")
        //    {
        //        cusNameTb.Text = "اسم العميل";
        //    }
        //}

        //private void cusPhoneTb_Enter_1(object sender, EventArgs e)
        //{
        
        //        if (cusPhoneTb.Text == "رقم تلفون العميل")
        //        {
        //            cusPhoneTb.Text = "";
        //        }
            
        //}

        //private void cusPhoneTb_Leave_1(object sender, EventArgs e)
        //{
        //    if (cusPhoneTb.Text == "")
        //    {
        //        cusPhoneTb.Text = "رقم تلفون العميل";
        //    }
        //}

        //private void cusAdressTb_Enter_1(object sender, EventArgs e)
        //{
        //    if (cusAdressTb.Text == "عنوان العميل")
        //    {
        //        cusAdressTb.Text = "";
        //    }
        //}

        //private void cusAdressTb_Leave_1(object sender, EventArgs e)
        //{
        //    if (cusAdressTb.Text == "")
        //    {
        //        cusAdressTb.Text = "عنوان العميل";
        //    }
        //}

        //private void cusDiebtTb_Enter_1(object sender, EventArgs e)
        //{
        //    if (cusDiebtTb.Text == "المبلغ المستحق ")
        //    {
        //        cusDiebtTb.Text = "";
        //    }
        //}

        //private void cusDiebtTb_Leave_1(object sender, EventArgs e)
        //{
        //    if (cusDiebtTb.Text == "")
        //    {
        //        cusDiebtTb.Text = "المبلغ المستحق ";
        //    }
        //}

        //private void cusDiscountTb_Enter_1(object sender, EventArgs e)
        //{
        //    if (cusDiscountTb.Text == "نسبة الخصم")
        //    {
        //        cusDiscountTb.Text = "";
        //    }
        //}

        //private void cusDiscountTb_Leave_1(object sender, EventArgs e)
        //{
        //    if (cusDiscountTb.Text == "")
        //    {
        //        cusDiscountTb.Text = "نسبة الخصم";
        //    }
        //}

        //private void PatientHistoryRtb_Enter_1(object sender, EventArgs e)
        //{
        //    if (PatientHistoryRtb.Text == "التاريخ المرضي للعميل")
        //    {
        //        PatientHistoryRtb.Text = "";
        //    }
        //}

        //private void PatientHistoryRtb_Leave_1(object sender, EventArgs e)
        //{
        //    if (PatientHistoryRtb.Text == "")
        //    {
        //        PatientHistoryRtb.Text = "التاريخ المرضي للعميل";
        //    }
        //}

        private void cusDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                cusNameTb.Text = cusDataGridView.SelectedRows[0].Cells[1].Value.ToString();
                cusPhoneTb.Text = cusDataGridView.SelectedRows[0].Cells[2].Value.ToString();
                cusAdressTb.Text = cusDataGridView.SelectedRows[0].Cells[3].Value.ToString();
                DispenDateDtp.Text = cusDataGridView.SelectedRows[0].Cells[4].Value.ToString();
                cusDiebtTb.Text = cusDataGridView.SelectedRows[0].Cells[5].Value.ToString();
                cusDiscountTb.Text = cusDataGridView.SelectedRows[0].Cells[6].Value.ToString();
                PatientHistoryRtb.Text = cusDataGridView.SelectedRows[0].Cells[7].Value.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("حدث خطاء", "ERORR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialog = MessageBox.Show("هل انته واثق من تعديل بينات العميل", "تحزير", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (dialog == DialogResult.Yes)
                {
                    if (cusNameTb.Text == "")
                    {
                        MessageBox.Show("العميل غير موجود");
                    }
                    else
                    {
                        query = "UPDATE Customer SET Discount = '" + cusDiscountTb.Text + "',CusAdress = N'" + cusAdressTb.Text + "',CusDiebt = '" + cusDiebtTb.Text + "', CusPhone = '" + cusPhoneTb.Text + "',PatientHistory=N'" + PatientHistoryRtb.Text + "',DispenDate='" + DispenDateDtp.Value.ToString() + "' WHERE CusName = N'" + cusNameTb.Text + "';";
                        cn.setData(query, "تم تعديل بيانات العميل");
                        populate();
                    }
                }
           }
            catch (Exception)
            {
                MessageBox.Show("خطاء في البيانات", "ERORR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void searchCusBtn_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (searchCusCB.Text == "الاسم")
                {
                    SqlDataAdapter sda = new SqlDataAdapter("SELECT CusId AS[ID],CusName AS[الاسم], CusPhone AS[رقم التلفون],CusAdress AS[العنوان], DispenDate AS[تاريخ الصرف],CusDiebt AS[الدين], Discount AS[الخصم],PatientHistory AS[التاريخ المرضي] FROM Customer where CusName like N'" + searchCusBtn.Text + "%'", Con);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    cusDataGridView.DataSource = dt;
                }
                else if (searchCusCB.Text == "رقم التلفون")
                {
                    SqlDataAdapter sda = new SqlDataAdapter("SELECT CusId AS[ID],CusName AS[الاسم], CusPhone AS[رقم التلفون],CusAdress AS[العنوان], DispenDate AS[تاريخ الصرف],CusDiebt AS[الدين], Discount AS[الخصم],PatientHistory AS[التاريخ المرضي] FROM Customer where CusPhone like '" + searchCusBtn.Text + "%'", Con);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    cusDataGridView.DataSource = dt;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("حاول مرة اخرى", "ERORR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void searchCusBtn_Enter(object sender, EventArgs e)
        {
            if (searchCusBtn.Text == "بحث")
            {
                searchCusBtn.Text = "";
            }
        }

        private void searchCusBtn_Leave(object sender, EventArgs e)
        {
            if (searchCusBtn.Text == "")
            {
                searchCusBtn.Text = "بحث";
            }
            populate();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            MainmenuForm menu = new MainmenuForm();
            menu.Show();
            Hide();
        }
    }
}
