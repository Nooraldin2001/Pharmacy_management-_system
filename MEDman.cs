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
using System.Configuration;

namespace PharmacyProject
{
    public partial class MEDmanForm : Form
    {
        public MEDmanForm()
        {
            InitializeComponent();
        }


        Connection cn = new Connection();
        string query;
        SqlConnection Con = new SqlConnection(@"Data Source=noor\sqlexpress;Initial Catalog=PHARMACY1;Integrated Security=True");

        public void populate()
        {
            try
            {
                //BillNum AS [رقم الفتورة]
                Con.Open();
                string myqury = "select ManId AS [كوود المورد], ManName AS [اسم المورد],ManEmp AS [اسم المندوب],ManPhone AS [رقم التلفون],ManAdress AS [العنوان],ManEmail AS [البريد الالكتروني],ManType AS [نوع المورد],ManCount AS [حساب المورد], ManDeibt AS [المبلغ المستحق], FundFirstMonth AS [بداية الشهر المالي],Notes AS [ملاحظات] FROM MEDman";
                SqlDataAdapter dataadapter = new SqlDataAdapter(myqury, Con);
                SqlCommandBuilder comandbuilder = new SqlCommandBuilder(dataadapter);
                var Ds = new DataSet();
                dataadapter.Fill(Ds);
                dataGridViewMan.ReadOnly = true;
                dataGridViewMan.DataSource = Ds.Tables[0];
                Con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("خطأ فى البيانات", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        //private void searchBartb_Leave(object sender, EventArgs e)
        //{
        //    if (searchBartb.Text == "")
        //    {
        //        searchBartb.Text = " بحث بأسم المورد";
        //        searchBartb.ForeColor = Color.Firebrick;
        //    }
        //}

        //private void searchBartb_Enter(object sender, EventArgs e)
        //{
        //    if (searchBartb.Text == " بحث بأسم المورد")
        //    {
        //        searchBartb.Text = "";
        //        searchBartb.ForeColor = Color.Black;
        //    }
        //}

        //private void ManCounttb_Enter(object sender, EventArgs e)
        //{
        //    if (ManCounttb.Text == "حساب المورد")
        //    {
        //        ManCounttb.Text = "";
        //        ManCounttb.ForeColor = Color.Black;
        //    }
        //}

        //private void ManCounttb_Leave(object sender, EventArgs e)
        //{
        //    if (ManCounttb.Text == "")
        //    {
        //        ManCounttb.Text = "حساب المورد";
        //        ManCounttb.ForeColor = Color.Firebrick;
        //    }
        //}

        //private void ManEmailtb_Enter(object sender, EventArgs e)
        //{
        //    if (ManEmailtb.Text == "البريد الالكتروني")
        //    {
        //        ManEmailtb.Text = "";
        //        ManEmailtb.ForeColor = Color.Black;
        //    }
        //}

        //private void ManEmailtb_Leave(object sender, EventArgs e)
        //{
        //    if (ManEmailtb.Text == "")
        //    {
        //        ManEmailtb.Text = "البريد الالكتروني";
        //        ManEmailtb.ForeColor = Color.Firebrick;
        //    }
        //}

        //private void ManPhonetb_Enter(object sender, EventArgs e)
        //{
        //    if (ManPhonetb.Text == "رقم المورد")
        //    {
        //        ManPhonetb.Text = "";
        //        ManPhonetb.ForeColor = Color.Black;
        //    }
        //}

        //private void ManPhonetb_Leave(object sender, EventArgs e)
        //{
        //    if (ManPhonetb.Text == "")
        //    {
        //        ManPhonetb.Text = "رقم المورد";
        //        ManPhonetb.ForeColor = Color.Firebrick;
        //    }
        //}

        //private void ManAdresstb_Enter(object sender, EventArgs e)
        //{
        //    if (ManAdresstb.Text == "العنوان")
        //    {
        //        ManAdresstb.Text = "";
        //        ManAdresstb.ForeColor = Color.Black;
        //    }
        //}

        //private void ManAdresstb_Leave(object sender, EventArgs e)
        //{
        //    if (ManAdresstb.Text == "")
        //    {
        //        ManAdresstb.Text = "العنوان";
        //        ManAdresstb.ForeColor = Color.Firebrick;
        //    }
        //}

        //private void ManNametb_Enter(object sender, EventArgs e)
        //{
        //    if (ManNametb.Text == "اسم المورد")
        //    {
        //        ManNametb.Text = "";
        //        ManNametb.ForeColor = Color.Black;
        //    }
        //}

        //private void ManNametb_Leave(object sender, EventArgs e)
        //{
        //    if (ManNametb.Text == "")
        //    {
        //        ManNametb.Text = "اسم المورد";
        //        ManNametb.ForeColor = Color.Firebrick;
        //    }
        //}

        //private void ManEmptb_Enter(object sender, EventArgs e)
        //{
        //    if (ManEmptb.Text == "اسم المندوب")
        //    {
        //        ManEmptb.Text = "";
        //        ManEmptb.ForeColor = Color.Black;
        //    }
        //}

        //private void ManEmptb_Leave(object sender, EventArgs e)
        //{
        //    if (ManEmptb.Text == "")
        //    {
        //        ManEmptb.Text = "اسم المندوب";
        //        ManEmptb.ForeColor = Color.Firebrick;
        //    }
        //}

        //private void ManDeibttb_Leave(object sender, EventArgs e)
        //{
        //    if (ManDeibttb.Text == "")
        //    {
        //        ManDeibttb.Text = "المبلغ المستحق";
        //        ManDeibttb.ForeColor = Color.Firebrick;
        //    }
        //}

        //private void ManDeibttb_Enter(object sender, EventArgs e)
        //{
        //    if (ManDeibttb.Text == "المبلغ المستحق")
        //    {
        //        ManDeibttb.Text = "";
        //        ManDeibttb.ForeColor = Color.Black;
        //    }
        //}

        //private void NotesRtb_Enter(object sender, EventArgs e)
        //{
        //    if (NotesRtb.Text == "ملاحظة (اذا وجد)")
        //    {
        //        NotesRtb.Text = "";
        //        NotesRtb.ForeColor = Color.Black;
        //    }
        //}

        //private void NotesRtb_Leave(object sender, EventArgs e)
        //{
        //    if (NotesRtb.Text == "")
        //    {
        //        NotesRtb.Text = "ملاحظة (اذا وجد)";
        //        NotesRtb.ForeColor = Color.Firebrick;
        //    }
        //}

        

        private void searchBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (searchBartb.Text != null)
                {
                    SqlDataAdapter sda = new SqlDataAdapter("select ManId AS [كوود المورد], ManName AS [اسم المورد],ManEmp AS [اسم المندوب],ManPhone AS [رقم التلفون],ManAdress AS [العنوان],ManEmail AS [البريد الالكتروني],ManType AS [نوع المورد],ManCount AS [حساب المورد], ManDeibt AS [المبلغ المستحق], FundFirstMonth AS [بداية الشهر المالي],Notes AS [ملاحظات] FROM MEDman where ManName like N'" + searchBartb.Text + "%'", Con);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    dataGridViewMan.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("برجاء ادخال البيانات بصورة صحيحة", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //Con.Open();
            //SqlCommand cmd = new SqlCommand("Select* from MEDman", Con);
            //SqlDataAdapter da = new SqlDataAdapter(cmd);
            //DataTable dt = new DataTable();
            //da.Fill(dt);
            //dataGridViewMan.DataSource = dt;
            //Con.Close();
            //populate();
        }

        private void insertBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (ManCounttb.Text == "" || NotesRtb.Text == "" || ManEmailtb.Text == "" || FundFirstMonthDtp.Text == "" || ManPhonetb.Text == "" || ManAdresstb.Text == "" || ManNametb.Text == "" || ManEmptb.Text == "" || ManTypeCB.SelectedItem.ToString() == null || ManDeibttb.Text == "")
                {
                    MessageBox.Show("ادخال خاطئ");
                }
                else
                {
                    query = "insert into MEDman(ManName,ManEmp,ManPhone,ManAdress,ManEmail,ManType,ManCount,ManDeibt,FundFirstMonth,Notes) values(N'" + ManNametb.Text + "',N'" + ManEmptb.Text + "','" + ManPhonetb.Text + "',N'" + ManAdresstb.Text + "','" + ManEmailtb.Text + "',N'" + ManTypeCB.SelectedItem.ToString() + "','" + ManCounttb.Text + "','" + ManDeibttb.Text + "','" + FundFirstMonthDtp.Value.ToString() + "',N'" + NotesRtb.Text + "')";
                    cn.setData(query, "تم اضافة المورد بنجاح");
                    populate();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("برجاء ادخال البيانات بصورة صحيحة", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            try
            {
                query = "UPDATE MEDman SET ManCount = '" + ManCounttb.Text + "',Notes = N'" + NotesRtb.Text + "',ManEmail='" + ManEmailtb.Text + "',FundFirstMonth ='" + FundFirstMonthDtp.Value.ToString() + "',ManPhone ='" + ManPhonetb.Text + "',ManAdress = N'" + ManAdresstb.Text + "',ManEmp =N'" + ManEmptb.Text + "',ManType =N'" + ManTypeCB.SelectedItem.ToString() + "',ManDeibt ='" + ManDeibttb.Text + "' WHERE ManName = N'" + ManNametb.Text + "';";
                cn.setData(query, "تم التعديل بنجاح");
                populate();
            }
            catch (Exception ex)
            {
                MessageBox.Show(" برجاء أختيار العنصر من الجدول لتعديله", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("هل توافق على حذف المورد", "تحذير", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            try
            {
                if (dialog == DialogResult.Yes)
                {
                    if (ManNametb.Text == "")
                    {
                        MessageBox.Show("عملية خاطئه");
                    }
                    else
                    {
                        query = "delete from MEDman where ManName = N'" + ManNametb.Text + "';";
                        cn.setData(query, "تم الحذف بنجاح");
                        populate();
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("برجاء أختيار العنصر من الجدول لحذفه", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void searchBartb_TextChanged(object sender, EventArgs e)
        {

        }

        private void MEDmanForm_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void dataGridViewMan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ManNametb.Text = dataGridViewMan.SelectedRows[0].Cells[1].Value.ToString();
            ManEmptb.Text = dataGridViewMan.SelectedRows[0].Cells[2].Value.ToString();
            ManPhonetb.Text = dataGridViewMan.SelectedRows[0].Cells[3].Value.ToString();
            ManAdresstb.Text = dataGridViewMan.SelectedRows[0].Cells[4].Value.ToString();
            ManEmailtb.Text = dataGridViewMan.SelectedRows[0].Cells[5].Value.ToString();
            ManTypeCB.Text = dataGridViewMan.SelectedRows[0].Cells[6].Value.ToString();
            ManCounttb.Text = dataGridViewMan.SelectedRows[0].Cells[7].Value.ToString();
            ManDeibttb.Text = dataGridViewMan.SelectedRows[0].Cells[8].Value.ToString();
            FundFirstMonthDtp.Text = dataGridViewMan.SelectedRows[0].Cells[9].Value.ToString();
            NotesRtb.Text = dataGridViewMan.SelectedRows[0].Cells[10].Value.ToString();
        }

        private void dataGridViewMan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
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
