using Pharmacy;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PharmacyProject
{
    public partial class INFO : Form
    {
        public INFO()
        {
            InitializeComponent();
        }
        Connection cn = new Connection();
        string query;
        private void confirmBTN_Click(object sender, EventArgs e)
        {
            changePassword();
           
        }
        private void insertInfo()
        { try
            {
                query = ("insert into PHinfo(PhName,Logo,PhPhone,PhAdress,PHCR) values(N'" + PhNameTB.Text + "','" + logoPharmacy + "','" + int.Parse(phPhoneTB.Text) + "',N'" + phAddressTB.Text + "',N'" + PHCRTB.Text + "')");
                cn.setDataNo(query);
            }
            catch (Exception ex)
            {
                MessageBox.Show("برجاء ادخال البيانات بصورة صحيحة", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void changePassword()
        {
            try
            {
                query = "UPDATE Employee SET EmpPassword ='" + changePasswordTB.Text + "' where EmpName= N'" + FullNameTB.Text + "' and Nid='" + UserIDTB.Text + "'";
                cn.setData(query, "تم تغير الرقم السري بنجاح");
            }
            catch (Exception ex)
            {
                MessageBox.Show("برجاء ادخال البيانات بصورة صحيحة", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    private void medicineInfoBTN_Click(object sender, EventArgs e)
        {
            MedicineForm med = new  MedicineForm();
            med.Show();
            this.Hide();
        }

        private void BackBTN_Click(object sender, EventArgs e)
        {
            MainmenuForm main = new MainmenuForm();
            main.Show();
            this.Hide();
        }

        private void INFO_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            insertInfo();
        }

        private void TotalCashinSafeTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void deleteBillbtn_Click(object sender, EventArgs e)
        {
            query = "DELETE FROM Billing;";
            cn.setData(query, "تم حذف ارشيف الفواتير بنجاح");
        }

        private void deleteOrderBtn_Click(object sender, EventArgs e)
        {
            query = "DELETE FROM [Order];";
            cn.setData(query, "تم حذف الفواتير الفوريه بنجاح");
        }
    }
}
