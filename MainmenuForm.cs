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
using PharmacyProject;
using Pharmacy;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Collections;
using System.Runtime.CompilerServices;
using System.Reflection.Emit;

namespace PharmacyProject
{
    public partial class MainmenuForm : Form
    {
        public MainmenuForm()
        {
            InitializeComponent();
            
        }

        Connection fn = new Connection();
        // string position;
       
        

        private void ExitCircularBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
           
        }

        private void LogoutBtn_Click(object sender, EventArgs e)
        {
            Login lg = new Login();
            lg.Show();
            this.Hide();
        }

        private void InfoCircularBtn_Click(object sender, EventArgs e)
        {
            INFO accountInfo = new INFO();
            accountInfo.Show();
            this.Hide();
        }

        private void CashierCircularBtn7_Click(object sender, EventArgs e)
        {
            BillingForm casher = new BillingForm();
            casher.Show();
        }

        private void CusCircularBtn_Click(object sender, EventArgs e)
        {
            CustomerForm CusForm = new CustomerForm();
            CusForm.Show();
            this.Hide();
        }

        private void ManfactureCircularBtn_Click(object sender, EventArgs e)
        {
            MEDmanForm mEDmanForm = new MEDmanForm();
            mEDmanForm.Show();
            this.Hide();
        }

        private void ReportsCircularBtn_Click(object sender, EventArgs e)
        {

            Reports report = new Reports();
            report.Show();
            this.Hide();
        }

        private void MedCircularBtn_Click(object sender, EventArgs e)
        {
            MedicineForm Drugs = new MedicineForm();
            Drugs.Show();
            this.Hide();
        }

        private void MainmenuForm_Load(object sender, EventArgs e)
        {

            //int a = int.Parse(lg.acccess.ToString());
            //int b = int.Parse(lg.confirmBTN.Text);
            // int c = int.Parse(lg.label1.Text);
            //int c = Convert.ToInt32(lg.label1.Text);
            //MessageBox.Show(c.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            //if (c == 2)
            //{
            //    MessageBox.Show(c.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            //    button1.Enabled = false;
            //    CusCircularBtn.Enabled = false;
            //    ManfactureCircularBtn.Enabled = false;
            //    MedCircularBtn.Enabled = false;
            //    ReportsCircularBtn.Enabled = false;
            //}
        }
        private void button1_Click(object sender, EventArgs e)
        {
            EmployeeForm employee = new EmployeeForm();
            employee.Show();
            this.Hide();
        }

       
    }
}
