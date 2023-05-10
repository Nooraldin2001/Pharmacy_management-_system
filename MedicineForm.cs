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
using System.Data.Sql;
using PharmacyProject;

namespace Pharmacy
{
    public partial class MedicineForm : Form
    {
        private void MedicineForm_Load(object sender, EventArgs e)
        {
            populate();
        }
        public MedicineForm()
        {
            InitializeComponent();
            backBTN.FlatStyle = FlatStyle.Flat;
            backBTN.FlatAppearance.BorderSize = 0;
            //nameArabicTB.Text = "اسم الدواء";
            //nameEnglishTB.Text = "English Name";
            //companyNameTB.Text = "اسم الشركة";
            //manifactureNameTB.Text = "اسم المورد";
            //BPriceTB.Text = "سعر البيع";
            //SPriceTB.Text = "سعر الشراء";
            //taxratioTB.Text = "ضريبة";
            //MaxbuyingTB.Text = "حد البيع";
            //stockTB.Text = "القطع المتوفرة";
            //MaxSelllingTB.Text = "حد الشراء";
        }

        Connection cn = new Connection();
        string query;


        SqlConnection Con = new SqlConnection(@"Data Source=noor\sqlexpress;Initial Catalog=PHARMACY1;Integrated Security=True");

        public void populate()
        {
            try
            {
                //(MedId,MedName,ManName,Spercentage,ExpDate,Sprice,Bprice,CompanyName,Stock,MinBuyingRange,MaxSelingRange,MedNameArabic,TaxRatio)
                Con.Open();
                string myqury = "SELECT MedId AS [كوود الدواء],MedName AS [اسم الدواء],MedNameArabic AS [الاسم بالعربي],ManName AS [اسم المورد],Spercentage AS [نسبة البيع],ExpDate AS [تاريخ النتهاء],Sprice AS [سعر الشراء],Bprice AS [سعر البيع],CompanyName AS [اسم الشركة],Stock AS [القطع المتوفرة],MinBuyingRange AS [حد البيع],MaxSelingRange AS [حد الشراء],TaxRatio AS [الضريبة المضافة],Barcode FROM Medicine";
                SqlDataAdapter dataadapter = new SqlDataAdapter(myqury, Con);
                SqlCommandBuilder comandbuilder = new SqlCommandBuilder(dataadapter);
                var Ds = new DataSet();
                dataadapter.Fill(Ds);
                MedGridView1.ReadOnly = true;
                MedGridView1.DataSource = Ds.Tables[0];
                Con.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("خطاء في الادخال", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        //public void fillcombobox()
        //{
        //    Con.Open();
        //    SqlCommand cmd = new SqlCommand("Select MedName from Medicine", Con);
        //    SqlDataReader rdr;
        //    rdr = cmd.ExecuteReader();
        //    DataTable dt = new DataTable();
        //    dt.Columns.Add("MedName", typeof(string));
        //    dt.Load(rdr);
        //    medSearchcCB.ValueMember = "MedName";
        //    medSearchcCB.DataSource = dt;
        //    Con.Close();

        //    populate();
        //}


        private void backBTN_Click(object sender, EventArgs e)
        {
            MainmenuForm mainmenu = new MainmenuForm();
            mainmenu.Show();
            Hide();
        }

        private void RemoveBTN_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialog = MessageBox.Show("هل توافق على حذف الصنف", "تحزير", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (dialog == DialogResult.Yes)
                {
                    if (BarcodeTB.Text == "")
                    {
                        MessageBox.Show("تم حذف الصنف مسبقاً");
                    }
                    else
                    {
                        query = "delete from Medicine where Barcode= '" + BarcodeTB.Text + "';";
                        cn.setData(query, "تم حذف الصنف بنجاح");
                        populate();
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("خطاء في الادخال", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void EditBTN_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialog = MessageBox.Show("هل توافق على تعديل بيانات هذا الصنف", "تحزير", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (dialog == DialogResult.Yes)
                {
                    if (nameArabicTB.Text == "" || nameEnglishTB.Text == "" || manifactureNameTB.Text == "" || companyNameTB.Text == "" || BPriceTB.Text == "" || SPriceTB.Text == "" || taxratioTB.Text == "" || MaxbuyingTB.Text == "" || MaxSelllingTB.Text == "" || stockTB.Text == "" || ExpireDate.Text == "")
                    {
                        MessageBox.Show("أختر الصنف من فضلك");
                    }
                    else if (BarcodeTB.Text == "")
                    {
                        MessageBox.Show("هذا الصنف غير موجود");
                    }
                    else
                    {
                        query = "UPDATE Medicine SET MedName = '" + nameEnglishTB.Text + "',ManName = N'" + manifactureNameTB.Text + "', ExpDate = '" + ExpireDate.Value.ToString() + "',Sprice = '" + float.Parse(SPriceTB.Text) + "',Bprice = '" + float.Parse(BPriceTB.Text) + "', CompanyName = N'" + companyNameTB.Text + "',Stock='" + Convert.ToInt32(stockTB.Text) + "',MaxSelingRange='" + Convert.ToInt32(MaxSelllingTB.Text) + "',MinBuyingRange='" + Convert.ToInt32(MaxbuyingTB.Text) + "',MedNameArabic= N'" + nameArabicTB.Text + "',TaxRatio='" + float.Parse(taxratioTB.Text) + "' WHERE Barcode= '" + BarcodeTB.Text + "';";
                        cn.setData(query, "تم تعديل الصنف بنجاح");
                        populate();
                    }
                }
            }
            catch
            {
                MessageBox.Show("خطاء في الادخال", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void AddBTN_Click(object sender, EventArgs e)
        {
            try
            {
                if (nameArabicTB.Text == "" || nameEnglishTB.Text == "" || manifactureNameTB.Text == "" || companyNameTB.Text == "" || BPriceTB.Text == "" || SPriceTB.Text == "" || taxratioTB.Text == "" || MaxbuyingTB.Text == "" || MaxSelllingTB.Text == "" || stockTB.Text == "" || ExpireDate.Text == "" || BarcodeTB.Text == "")
                {
                    MessageBox.Show("أملاء جميع القيم من فضلك او اكتب 0");
                }
                else
                {
                    //Another queery option
                    query = "insert into Medicine(MedName,ManName,ExpDate,Sprice,Bprice,CompanyName,Stock,MinBuyingRange,MaxSelingRange,MedNameArabic,TaxRatio,Barcode) values('" + nameEnglishTB.Text + "',N'" + manifactureNameTB.Text + "','" + ExpireDate.Value.ToString() + "','" +float.Parse(SPriceTB.Text) + "','" +float.Parse(BPriceTB.Text) + "',N'" + companyNameTB.Text + "','" +Convert.ToInt32(stockTB.Text) + "','" + Convert.ToInt32(MaxbuyingTB.Text) + "','" + Convert.ToInt32(MaxSelllingTB.Text) + "',N'" + nameArabicTB.Text + "','" + float.Parse(taxratioTB.Text) + "','" + BarcodeTB.Text + "')";
                    cn.setData(query, "تم اضافة الصنف");
                    populate();
                }
            }
            catch(Exception)
            {
                MessageBox.Show("خطاء في الادخال","ERROR",MessageBoxButtons.OK,MessageBoxIcon .Error);
            }
        }
            

        //private void nameArabicTB_Leave(object sender, EventArgs e)
        //{
        //    if (nameArabicTB.Text == "")
        //    {
        //        nameArabicTB.Text = "اسم الدواء";
        //    }
             
        //}

        //private void nameArabicTB_Enter(object sender, EventArgs e)
        //{
        //    if (nameArabicTB.Text == "اسم الدواء")
        //    {
        //        nameArabicTB.Text = "";
        //    }
        //}

        //private void nameEnglishTB_Leave(object sender, EventArgs e)
        //{
        //    if (nameEnglishTB.Text == "")
        //    {
        //        nameEnglishTB.Text = "English Name";
        //    }

        //}

        //private void nameEnglishTB_Enter(object sender, EventArgs e)
        //{
        //    if (nameEnglishTB.Text == "English Name")
        //    {
        //        nameEnglishTB.Text = "";
        //    }
        //}

        //private void companyNameTB_Leave(object sender, EventArgs e)
        //{
        //    if (companyNameTB.Text == "")
        //    {
        //        companyNameTB.Text = "اسم الشركة";
        //    }
        //}

        //private void companyNameTB_Enter(object sender, EventArgs e)
        //{
        //    if (companyNameTB.Text == "اسم الشركة")
        //    {
        //        companyNameTB.Text = "";
        //    }
        //}

        //private void manifactureNameTB_Enter(object sender, EventArgs e)
        //{
        //    if (manifactureNameTB.Text == "اسم المورد")
        //    {
        //        manifactureNameTB.Text = "";
        //    }
        //}

        //private void manifactureNameTB_Leave(object sender, EventArgs e)
        //{
        //    if (manifactureNameTB.Text == "")
        //    {
        //        manifactureNameTB.Text = "اسم المورد";
        //    }

        //}

        //private void BPriceTB_Leave(object sender, EventArgs e)
        //{
        //    if (BPriceTB.Text == "")
        //    {
        //        BPriceTB.Text = "سعر البيع";
        //    }

        //}

        //private void BPriceTB_Enter(object sender, EventArgs e)
        //{
        //    if (BPriceTB.Text == "سعر البيع")
        //    {
        //        BPriceTB.Text = "";
        //    }
        //}

        //private void SPriceTB_Leave(object sender, EventArgs e)
        //{
        //    if (SPriceTB.Text == "")
        //    {
        //        SPriceTB.Text = "سعر الشراء";
        //    }


        //}

        //private void SPriceTB_Enter(object sender, EventArgs e)
        //{
        //    if (SPriceTB.Text == "سعر الشراء")
        //    {
        //        SPriceTB.Text = "";
        //    }
        //}

        //private void taxratioTB_Enter(object sender, EventArgs e)
        //{
        //    if (taxratioTB.Text == "ضريبة")
        //    {
        //        taxratioTB.Text = "";
        //    }
        //}

        //private void taxratioTB_Leave(object sender, EventArgs e)
        //{
        //    if (taxratioTB.Text == "")
        //    {
        //        taxratioTB.Text = "ضريبة";
        //    }
        //}

        //private void MaxbuyingTB_Leave(object sender, EventArgs e)
        //{
        //    if (MaxbuyingTB.Text == "")
        //    {
        //        MaxbuyingTB.Text = "حد البيع";
        //    }
        //}

        //private void MaxbuyingTB_Enter(object sender, EventArgs e)
        //{
        //    if (MaxbuyingTB.Text == "حد البيع")
        //    {
        //        MaxbuyingTB.Text = "";
        //    }
        //}

        //private void stockTB_Leave(object sender, EventArgs e)
        //{
        //    if (stockTB.Text == "")
        //    {
        //        stockTB.Text = "عددالقطع المتوفرة";
        //    }
        //}

        //private void stockTB_Enter(object sender, EventArgs e)
        //{
        //    if (stockTB.Text == "عددالقطع المتوفرة")
        //    {
        //        stockTB.Text = "";
        //    }
        //}

        //private void MaxSelllingTB_Leave(object sender, EventArgs e)
        //{
        //    if (MaxSelllingTB.Text == "")
        //    {
        //        MaxSelllingTB.Text = "حد الشراء";
        //    }
        //}

        //private void MaxSelllingTB_Enter(object sender, EventArgs e)
        //{
        //    if (MaxSelllingTB.Text == "حد الشراء")
        //    {
        //        MaxSelllingTB.Text = "";
        //    }
        //}

        private void MedGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            nameEnglishTB.Text = MedGridView1.SelectedRows[0].Cells[1].Value.ToString();
            manifactureNameTB.Text = MedGridView1.SelectedRows[0].Cells[3].Value.ToString();
            ExpireDate.Text = MedGridView1.SelectedRows[0].Cells[4].Value.ToString();
            SPriceTB.Text = MedGridView1.SelectedRows[0].Cells[7].Value.ToString();
            BPriceTB.Text = MedGridView1.SelectedRows[0].Cells[6].Value.ToString();
            companyNameTB.Text = MedGridView1.SelectedRows[0].Cells[8].Value.ToString();
            stockTB.Text = MedGridView1.SelectedRows[0].Cells[9].Value.ToString();
            MaxbuyingTB.Text = MedGridView1.SelectedRows[0].Cells[11].Value.ToString();
            MaxSelllingTB.Text = MedGridView1.SelectedRows[0].Cells[10].Value.ToString();
            nameArabicTB.Text = MedGridView1.SelectedRows[0].Cells[2].Value.ToString();
            taxratioTB.Text = MedGridView1.SelectedRows[0].Cells[12].Value.ToString();
            BarcodeTB.Text = MedGridView1.SelectedRows[0].Cells[13].Value.ToString();
        }

        //private void medSearchTB_Enter(object sender, EventArgs e)
        //{
        //    if (medSearchTB.Text == "بحث")
        //    {
        //        medSearchTB.Text = "";
        //    }
        //}

        //private void medSearchTB_Leave(object sender, EventArgs e)
        //{
        //    if (medSearchTB.Text == "")
        //    {
        //        medSearchTB.Text = "بحث";
        //    }
        //}

        private void medSearchTB_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (medSearchcCB.Text == "الاسم بالعربي")
                {
                    SqlDataAdapter sda = new SqlDataAdapter("SELECT MedId AS [كوود الدواء],MedName AS [اسم الدواء],MedNameArabic AS [الاسم بالعربي],ManName AS [اسم المورد],Spercentage AS [نسبة البيع],ExpDate AS [تاريخ النتهاء],Sprice AS [سعر البيع],Bprice AS [سعر الشراء],CompanyName AS [اسم الشركة],Stock AS [القطع المتوفرة],MinBuyingRange AS [حد البيع],MaxSelingRange AS [حد الشراء],TaxRatio AS [الضريبة المضافة] FROM Medicine where MedNameArabic like N'" + medSearchTB.Text + "%'", Con);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    MedGridView1.DataSource = dt;
                }
                else if (medSearchcCB.Text == "الاسم بالانجليزي")
                {
                    SqlDataAdapter sda = new SqlDataAdapter("SELECT MedId AS [كوود الدواء],MedName AS [اسم الدواء],MedNameArabic AS [الاسم بالعربي],ManName AS [اسم المورد],Spercentage AS [نسبة البيع],ExpDate AS [تاريخ النتهاء],Sprice AS [سعر البيع],Bprice AS [سعر الشراء],CompanyName AS [اسم الشركة],Stock AS [القطع المتوفرة],MinBuyingRange AS [حد البيع],MaxSelingRange AS [حد الشراء],TaxRatio AS [الضريبة المضافة] FROM Medicine where MedName like '" + medSearchTB.Text + "%'", Con);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    MedGridView1.DataSource = dt;
                }
                else if (medSearchcCB.Text == "اسم المورد")
                {
                    SqlDataAdapter sda = new SqlDataAdapter("SELECT MedId AS [كوود الدواء],MedName AS [اسم الدواء],MedNameArabic AS [الاسم بالعربي],ManName AS [اسم المورد],Spercentage AS [نسبة البيع],ExpDate AS [تاريخ النتهاء],Sprice AS [سعر البيع],Bprice AS [سعر الشراء],CompanyName AS [اسم الشركة],Stock AS [القطع المتوفرة],MinBuyingRange AS [حد البيع],MaxSelingRange AS [حد الشراء],TaxRatio AS [الضريبة المضافة] FROM Medicine where ManName like N'" + medSearchTB.Text + "%'", Con);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    MedGridView1.DataSource = dt;
                }
                else if (medSearchcCB.Text == "Barcode")
                {
                    SqlDataAdapter sda = new SqlDataAdapter("SELECT MedId AS [كوود الدواء],MedName AS [اسم الدواء],MedNameArabic AS [الاسم بالعربي],ManName AS [اسم المورد],Spercentage AS [نسبة البيع],ExpDate AS [تاريخ النتهاء],Sprice AS [سعر البيع],Bprice AS [سعر الشراء],CompanyName AS [اسم الشركة],Stock AS [القطع المتوفرة],MinBuyingRange AS [حد البيع],MaxSelingRange AS [حد الشراء],TaxRatio AS [الضريبة المضافة],Barcode FROM Medicine where Barcode like N'" + medSearchTB.Text + "%'", Con);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    MedGridView1.DataSource = dt;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("خطاء في الادخال", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}