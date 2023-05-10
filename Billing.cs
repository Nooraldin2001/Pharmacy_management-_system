using Pharmacy;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PharmacyProject
{
    public partial class BillingForm : Form
    {
        public BillingForm()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=noor\sqlexpress;Initial Catalog=PHARMACY1;Integrated Security=True");

        private void Billing_Load(object sender, EventArgs e)
        {
            //this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            //this.TopMost = true;
            //WindowState = FormWindowState.Maximized;
            populateMedicine();
            cusFillCB();
            manFillCB();
            empfill();
        }
       // Bitmap bitmap;
        Connection cn = new Connection();
        string query;

        private void PrintBTN_Click(object sender, EventArgs e)
        {
            //Panel panel = new Panel();
            //this.Controls.Add(panel);
            //Graphics graphics = panel.CreateGraphics();
            //Size size = this.ClientSize;
            //bitmap = new Bitmap(size.Width, size.Height, graphics);
            //graphics = Graphics.FromImage(bitmap);
            //Point point1 = PointToScreen(panel.Location);
            //graphics.CopyFromScreen(point1.X, point1.Y, 0, 0, size);
            //printPreviewDialog1.Document = printDocument1;
            //printPreviewDialog1.ShowDialog();
        }
        int medID, medQty, mPrice, mtotal, pos = 60;
        string mName;
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("Pharmacy", new Font("Century Gothic", 12, FontStyle.Bold), Brushes.Red, new Point(80));
            e.Graphics.DrawString("ID   الاجمالي     الكمية  الوحدة    اسم الدواء", new Font("Century Gothic", 10, FontStyle.Bold), Brushes.Red, new Point(26, 40));
            foreach(DataGridViewRow row in BillGrv.Rows)
            {
                medID = Convert.ToInt32(row.Cells["Column1"].Value);
                mName = "" + row.Cells["Column5"].Value;
                mPrice = Convert.ToInt32(row.Cells["Column3"].Value);
                medQty = Convert.ToInt32(row.Cells["Column2"].Value);
                mtotal = Convert.ToInt32(row.Cells["Column4"].Value);

                e.Graphics.DrawString("" + medID, new Font("Century Gothic", 8, FontStyle.Bold), Brushes.Blue, new Point(26,pos));
                e.Graphics.DrawString("" + mName, new Font("Century Gothic", 8, FontStyle.Bold), Brushes.Blue, new Point(45,pos));
                e.Graphics.DrawString("" + mPrice, new Font("Century Gothic", 8, FontStyle.Bold), Brushes.Blue, new Point(120,pos));
                e.Graphics.DrawString("" + medQty, new Font("Century Gothic", 8, FontStyle.Bold), Brushes.Blue, new Point(170,pos));
                e.Graphics.DrawString("" + mtotal, new Font("Century Gothic", 8, FontStyle.Bold), Brushes.Blue, new Point(235,pos));
                pos = pos + 20;
            }
            e.Graphics.DrawString("الاجمالي : " + grdTotalTb.Text, new Font("Century Gothic", 12, FontStyle.Bold), Brushes.Red, new Point(50, pos + 50));
            BillGrv.Rows.Clear();
            BillGrv.Refresh();
            pos = 100;
            grdTotalTb.Text = "";
            n = 0;
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainmenuForm menu = new MainmenuForm();
            menu.Show();
        }

        private void CreateCustomerBTN_Click(object sender, EventArgs e)
        {
            CustomerForm customer = new CustomerForm();
            customer.Show();
        }

        public void populateMedicine()
        {
            try
            {
                //(MedId,MedName,ManName,Spercentage,ExpDate,Sprice,Bprice,CompanyName,Stock,MinBuyingRange,MaxSelingRange,MedNameArabic,TaxRatio)
                Con.Open();
                string myqury = "SELECT MedId AS [كوود الدواء],MedName AS [اسم الدواء],Stock AS [القطع المتوفرة],Bprice AS [سعر البيع],MedNameArabic AS [الاسم بالعربي],ManName AS [اسم المورد],ExpDate AS [تاريخ الانتهاء],TaxRatio AS [الضريبة المضافة] FROM Medicine";
                SqlDataAdapter dataadapter = new SqlDataAdapter(myqury, Con);
                SqlCommandBuilder comandbuilder = new SqlCommandBuilder(dataadapter);
                var Ds = new DataSet();
                dataadapter.Fill(Ds);
                medViewDgv.ReadOnly = true;
                medViewDgv.DataSource = Ds.Tables[0];
                Con.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("خطاء في البيانات", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
        //private void getMedTax()
        //{
        //    Con.Open();
        //    string myqury = "SELECT TaxRatio FROM Medicine where MedName = '" + medViewDgv.SelectedRows[0].Cells[1].Value.ToString() + "'";
        //    SqlCommand cmd = new SqlCommand(myqury, Con);
        //    DataTable dt = new DataTable();
        //    SqlDataAdapter sda = new SqlDataAdapter(cmd);
        //    sda.Fill(dt);
        //    medTaxTb.Text = dt.ToString();
        //    Con.Close();
        //}

        public void cusFillCB()
        {
            try
            {
                Con.Open();
                SqlCommand cmd = new SqlCommand("Select CusId from Customer", Con);
                SqlDataReader rdr;
                rdr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Columns.Add("CusId", typeof(int));
                dt.Load(rdr);
                cusCB.ValueMember = "CusId";
                cusCB.DataSource = dt;
                Con.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("خطاء في البيانات", "ERORR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void getCusName()
        {
            try
            {
                Con.Open();
                string myqury = "SELECT * FROM Customer where CusId = '" + cusCB.SelectedValue.ToString() + "'";
                SqlCommand cmd = new SqlCommand(myqury, Con);
                DataTable dt = new DataTable();
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                sda.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    customerNameTB.Text = dr["CusName"].ToString();
                }
                Con.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("خطاء في البيانات", "ERORR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void manFillCB()
        {
            try
            {
                Con.Open();
                SqlCommand cmd = new SqlCommand("Select ManId from MEDman", Con);
                SqlDataReader rdr;
                rdr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Columns.Add("ManId", typeof(int));
                dt.Load(rdr);
                manIDcb.ValueMember = "ManId";
                manIDcb.DataSource = dt;
                Con.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("خطاء في البيانات", "ERORR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void empfill()
        {
            try
            {
                Con.Open();
                SqlCommand cmd = new SqlCommand("Select EmpName from Employee", Con);
                SqlDataReader rdr;
                rdr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Columns.Add("EmpName", typeof(string));
                dt.Load(rdr);
                empCB.ValueMember = "EmpName";
                empCB.DataSource = dt;
                Con.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("خطاء في البيانات", "ERORR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void getManName()
        {
            try
            {
                Con.Open();
                string myqury = "SELECT * FROM MEDman where ManId = '" + manIDcb.SelectedValue.ToString() + "'";
                SqlCommand cmd = new SqlCommand(myqury, Con);
                DataTable dt = new DataTable();
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                sda.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    ManfuctureNameTB.Text = dr["ManName"].ToString();
                }
                Con.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("خطاء في البيانات", "ERORR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Reset()
        {
            medName = "";
            quantityMedicineTB.Text = "";
            Key = 0;

        }
        int Key = 0;
        string medName;
        int stock,proID;
        int n = 0;
        int newQTy;
        float medPrice;
        float total = 0;
        private void resetMedicineBTN_Click(object sender, EventArgs e)
        {
            populateMedicine();
        }
        
        private void AddToBillBTN_Click(object sender, EventArgs e)
        {
            try
            {
                if (Key == 0)
                {
                    MessageBox.Show("اختر الدواء من فضلك");
                }
                else if (quantityMedicineTB.Text == "")
                {
                    MessageBox.Show("حدد الكمية من فضلك");
                }
                else if (quantityMedicineTB.Text == "الكمية")
                {
                    MessageBox.Show("حدد الكمية من فضلك");
                }
                else if (Convert.ToInt32(quantityMedicineTB.Text) <= 0)
                {
                    MessageBox.Show("خطاء في البيانات");
                }
                else if (Convert.ToInt32(quantityMedicineTB.Text) > stock)
                {
                    MessageBox.Show("الكمية غير كافية");
                }
                else if (quantityMedicineTB.Text == "")
                {
                    MessageBox.Show("حدد الكمية المطلوبه");
                }
                else
                {
                    float SubTotal = float.Parse(quantityMedicineTB.Text) * medPrice;
                    total = total + SubTotal;
                    DataGridViewRow newRow = new DataGridViewRow();
                    newRow.CreateCells(BillGrv);
                    newRow.Cells[0].Value = proID;
                    newRow.Cells[1].Value = medName;
                    newRow.Cells[2].Value = quantityMedicineTB.Text;
                    newRow.Cells[3].Value = medPrice;
                    newRow.Cells[4].Value = SubTotal;
                    BillGrv.Rows.Add(newRow);
                    subtotalTb.Text = "" + total;
                    newQTy = stock - Convert.ToInt32(quantityMedicineTB.Text);
                    insertOrder();
                    updatemeQty();
                    Reset();
                    populateMedicine();
                }
            }
           catch (Exception)
           {
               MessageBox.Show("خطاء في البيانات", "ERORR", MessageBoxButtons.OK, MessageBoxIcon.Error);
           }
        }
        private void insertOrder()
        {
            try
            {
                query = "INSERT INTO [Order](proID,proQty,proName,unitPrice,subTotal) VALUES('" + proID + "','" + Convert.ToInt32(quantityMedicineTB.Text) + "',N'" + medName + "','" + Convert.ToDouble(medPrice) + "','" + float.Parse(subtotalTb.Text) + "')";
                cn.setDataNo(query);
            }
            catch (Exception)
            {
                MessageBox.Show("خطاء في البيانات", "ERORR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void updateCusDiebt()
        {
            try
            {
                if (paymentMethodCb.SelectedItem.ToString() == "أجل")
                {
                    query = "UPDATE Customer SET CusDiebt = '" + grdTotalTb.Text + "' WHERE CusId = '" + cusCB.SelectedValue + "';";
                    cn.setDataNo(query);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("خطاء في البيانات", "ERORR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void updatemeQty()
        {
            try
            {
                query = "UPDATE Medicine SET Stock = '" + newQTy + "' WHERE MedId = '" + Key + "';";
                cn.setDataNo(query);
            }
            catch (Exception)
            {
                MessageBox.Show("خطاء في البيانات", "ERORR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void medViewDgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                proID = Convert.ToInt32(medViewDgv.SelectedRows[0].Cells[0].Value.ToString());
                medName = medViewDgv.SelectedRows[0].Cells[1].Value.ToString();
                stock = Convert.ToInt32(medViewDgv.SelectedRows[0].Cells[2].Value.ToString());
                medPrice = float.Parse(medViewDgv.SelectedRows[0].Cells[3].Value.ToString());
                //SPriceTB.Text = MedGridView1.SelectedRows[0].Cells[5].Value.ToString();
                if (medName == "")
                {
                    Key = 0;
                }
                else
                {
                    Key = Convert.ToInt32(medViewDgv.SelectedRows[0].Cells[0].Value.ToString());
                }
            }
            catch (Exception)
            {
                MessageBox.Show("خطاء في البيانات", "ERORR", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void quantityMedicineTB_Enter(object sender, EventArgs e)
        {
            if (quantityMedicineTB.Text == "الكمية")
            {
                quantityMedicineTB.Text = "";
            }
        }

        private void quantityMedicineTB_Leave(object sender, EventArgs e)
        {
            if (quantityMedicineTB.Text == "")
            {
                quantityMedicineTB.Text = "الكمية";
            }
        }

        private void medTaxTb_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if (medTaxTb.Text == "")
                {

                }
                else if (subtotalTb.Text == "")
                {
                    MessageBox.Show("قم بأضافة الأدوية");
                    VATtb.Text = "";
                }
                else
                {
                    try
                    {
                        double VAT = (Convert.ToDouble(medTaxTb.Text) / 100) * float.Parse(subtotalTb.Text);
                        VATtb.Text = "" + VAT;
                        grdTotalTb.Text = "" + (float.Parse(subtotalTb.Text) + Convert.ToDouble(VATtb.Text));
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);

            }

        }

        private void dicountMed_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if (dicountMed.Text == "")
                {

                }
                else if (subtotalTb.Text == "")
                {
                    MessageBox.Show("قم بأضافة الأدوية");
                    dicountMed.Text = "";
                }
                else
                {
                    double Disc = (Convert.ToDouble(dicountMed.Text) / 100) * float.Parse(subtotalTb.Text);
                    dicountView.Text = "" + Disc;
                    grdTotalTb.Text = "" + (float.Parse(subtotalTb.Text) + Convert.ToDouble(VATtb.Text) - Convert.ToDouble(dicountView.Text));
                }
            }
            catch (Exception)
            {
                MessageBox.Show("خطاء في البيانات", "ERORR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void manIDcb_SelectionChangeCommitted(object sender, EventArgs e)
        {
            getManName();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DateTime mytoday = new DateTime();
            mytoday = DateTime.Now;
            BillDtp.Value = mytoday;
        }
        private void insertBill()
        {
            try
            {
                //,BarCodeBill
                string myquery = "insert into Billing(ManId,BillDate,BillType,TotalCash,CategorySafe,PaymentType,empName) values('" + manIDcb.SelectedValue + "','" + BillDtp.Value.ToString() + "',N'" + BillType.SelectedItem.ToString() + "','" +float.Parse(grdTotalTb.Text) + "',N'" + categorySafecomboBox2.SelectedItem.ToString() + "',N'" + paymentMethodCb.SelectedItem.ToString() + "',N'" + empCB.SelectedValue.ToString() + "')";
                cn.setData(myquery, "تم حفظ الفتورة بنجاح");
            }
            catch(Exception ex)
            {
                MessageBox.Show("يرجى ملىء كل الخانات", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);   
            }
            //if (nameArabicTB.Text == "" || nameEnglishTB.Text == "" || manifactureNameTB.Text == "" || companyNameTB.Text == "" || BPriceTB.ToString() == null || SPriceTB.ToString() == null || taxratioTB.ToString() == null || MaxbuyingTB.ToString() == null || MaxSelllingTB.ToString() == null || stockTB.ToString() == null || ExpireDate.Text == null)
            //{
            //    MessageBox.Show("ادخال خاطئ");
            //}
            //else
            //{

            //}
        }
        private void SaveBTN_Click(object sender, EventArgs e)
        {
            insertBill();
            updateCusDiebt();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Billview view = new Billview();
            view.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MedicineForm medicineForm = new MedicineForm();
            medicineForm.Show();
            
        }

        private void CreateManfuctureBTN_Click(object sender, EventArgs e)
        {
            MEDmanForm medman = new MEDmanForm();
            medman.Show();
        }

        private void ManifactureREfreshBTN_Click(object sender, EventArgs e)
        {
            manFillCB();
        }

        private void empCB_SelectionChangeCommitted(object sender, EventArgs e)
        {
            //empfill();
        }

        private void medTaxTb_Leave(object sender, EventArgs e)
        {
            if (medTaxTb.Text == "")
            {
                medTaxTb.Text = "الضريبة(%)";
            }
        }

        private void medTaxTb_Enter(object sender, EventArgs e)
        {
            if (medTaxTb.Text == "الضريبة(%)")
            {
                medTaxTb.Text = "";
            }
        }

        private void dicountMed_Enter(object sender, EventArgs e)
        {
            if (dicountMed.Text == "نسبة الخصم(%)")
            {
                dicountMed.Text = "";
            }
        }

        private void dicountMed_Leave(object sender, EventArgs e)
        {
            if (dicountMed.Text == "")
            {
                dicountMed.Text = "نسبة الخصم(%)";
            }
        }

        private void MedicineNameTB_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (medSearchcCB.Text == "Barcode")
                {
                    SqlDataAdapter sda = new SqlDataAdapter("SELECT MedId AS [كوود الدواء],MedName AS [اسم الدواء],Stock AS [القطع المتوفرة],Bprice AS [سعر البيع],MedNameArabic AS [الاسم بالعربي],ManName AS [اسم المورد],ExpDate AS [تاريخ الانتهاء],TaxRatio AS [الضريبة المضافة],Barcode FROM Medicine where Barcode like N'" + MedicinesearchTB.Text + "%'", Con);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    medViewDgv.DataSource = dt;
                }
                else if (medSearchcCB.Text == "اسم الدواء")
                {
                    SqlDataAdapter sda = new SqlDataAdapter("SELECT MedId AS [كوود الدواء],MedName AS [اسم الدواء],Stock AS [القطع المتوفرة],Bprice AS [سعر البيع],MedNameArabic AS [الاسم بالعربي],ManName AS [اسم المورد],ExpDate AS [تاريخ الانتهاء],TaxRatio AS [الضريبة المضافة],Barcode FROM Medicine where MedName like '" + MedicinesearchTB.Text + "%'", Con);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    medViewDgv.DataSource = dt;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("خطاء في الادخال", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BillType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (BillType.Text == "وارد")
            {
                MedicineForm Addmedicin = new MedicineForm();
                Addmedicin.Show();
            }
        }

        private void customerRefreshBTN_Click(object sender, EventArgs e)
        {
            cusFillCB();
        }

        int flag = 0;
        private void printBtn_Click_1(object sender, EventArgs e)
        {
            printDocument1.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("pprnm", 285, 600);
            if(printPreviewDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        private void cusCB_SelectionChangeCommitted(object sender, EventArgs e)
        {
            getCusName();   
        }
    }
}
