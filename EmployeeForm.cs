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
using Pharmacy;
using PharmacyProject;

namespace Pharmacy
{
    public partial class EmployeeForm : Form
    {
        public EmployeeForm()
        {
            InitializeComponent();
        }

        Connection cn = new Connection();
        string query;
        SqlConnection Con = new SqlConnection(@"Data Source=noor\sqlexpress;Initial Catalog=PHARMACY1;Integrated Security=True");

        public void populate()
        {
            Con.Open();
            string myqury = "SELECT EmpName AS [الاسم],EmpPhone AS [رقم التلفون],EmpShift AS [الوردية],Nid AS [الرقم القومي],EmpGender AS [النوع],EmpStatus AS [الحالة الاجتماعية],EmpAdress AS [العنوان],EmpMalitary AS [الموقف التجنيدي],EmpPosition AS [الوظيفة],EmpPassword AS [كلمة المرور],Phid AS [كوود الصيدلية],EmpSalary AS [الراتب] FROM Employee ";
            SqlDataAdapter dataadapter = new SqlDataAdapter(myqury, Con);
            SqlCommandBuilder comandbuilder = new SqlCommandBuilder(dataadapter);
            var Ds = new DataSet();
            dataadapter.Fill(Ds);
            empGridView.ReadOnly = true;
            empGridView.DataSource = Ds.Tables[0];
            Con.Close();
        }
        //public void fillcombobox()
        //{
        //    SqlConnection Con = new SqlConnection(@"Data Source=noor\sqlexpress;Initial Catalog=PHARMACY1;Integrated Security=True");
        //    Con.Open();
        //    SqlCommand cmd = new SqlCommand("Select EmpName from Employee", Con);
        //    SqlDataReader rdr;
        //    rdr = cmd.ExecuteReader();
        //    DataTable dt = new DataTable();
        //    dt.Columns.Add("Employee", typeof(string));
        //    dt.Load(rdr);
        //    empSearchcCB.ValueMember = "Employee";
        //    empSearchcCB.DataSource = dt;
        //    Con.Close();
        //    populate();
        //}

        private void EmployeeForm_Load(object sender, EventArgs e)
        {
            populate();
            //fillcombobox();
        }

        private void backBTN_Click(object sender, EventArgs e)
        {
            MainmenuForm menu = new MainmenuForm();
            menu.ShowDialog();
            Hide();
        }

        private void AddBTN_Click(object sender, EventArgs e)
        {
            string Name = nameEmpLoyeeTB.Text;
            string Password = PasswordEmployeeTB.Text;
            Int64 Phone = Int64.Parse(phoneEmployeeTB.Text);
            string Gender = empGenderCB.SelectedItem.ToString();
            Int64 salary = Int64.Parse(SalaryEmployeeTB.Text);
            string status = empStatusCB.SelectedItem.ToString();
            string adress = AddressEmployeeTB.Text;
            string military = empMalitaryCB.SelectedItem.ToString();
            string role = empPositionCB.SelectedItem.ToString();
            string shift = empShiftCB.SelectedItem.ToString();
            string NID = NationalIDTB.Text;
            try
            {
                if (nameEmpLoyeeTB.Text == "" || PasswordEmployeeTB.Text == "" || phoneEmployeeTB.Text == "" || SalaryEmployeeTB.Text == "" || NationalIDTB.Text == "" )
                {
                    MessageBox.Show("أملاء جميع القيم من فضلك");
                }
                else
                {
                    query = "insert into Employee(Nid,EmpGender,EmpSalary,EmpStatus,EmpAdress,EmpMalitary,EmpName,EmpPhone,EmpPosition,EmpPassword,EmpShift) values('" + NID + "',N'" + Gender + "'," + salary + ",N'" + status + "',N'" + adress + "',N'" + military + "',N'" + Name + "'," + Phone + ",N'" + role + "'," + Password + ",N'" + shift + "')";
                    cn.setData(query, "تم إضافة الموظف بنجاح");
                    populate();
                }
                    
            }
            catch (Exception)
            {
                MessageBox.Show("خطاء في البيانات", "ERORR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //private void nameEmpLoyeeTB_Enter(object sender, EventArgs e)
        //{
        //    if (nameEmpLoyeeTB.Text == "اسم بالكامل")
        //    {
        //        nameEmpLoyeeTB.Text = "";
        //    }
        //}

        //private void nameEmpLoyeeTB_Leave(object sender, EventArgs e)
        //{
        //    if (nameEmpLoyeeTB.Text == "")
        //    {
        //        nameEmpLoyeeTB.Text = "اسم بالكامل";
        //    }
        //}

        //private void PasswordEmployeeTB_Enter(object sender, EventArgs e)
        //{
        //    if (PasswordEmployeeTB.Text == "كلمة المرور")
        //    {
        //        PasswordEmployeeTB.Text = "";
        //    }
        //}

        //private void PasswordEmployeeTB_Leave(object sender, EventArgs e)
        //{
        //    if (PasswordEmployeeTB.Text == "")
        //    {
        //        PasswordEmployeeTB.Text = "كلمة المرور";
        //    }
        //}

        //private void phoneEmployeeTB_Enter(object sender, EventArgs e)
        //{
        //    if (phoneEmployeeTB.Text == "رقم التليفون")
        //    {
        //        phoneEmployeeTB.Text = "";
        //    }
        //}

        //private void phoneEmployeeTB_Leave(object sender, EventArgs e)
        //{
        //    if (phoneEmployeeTB.Text == "")
        //    {
        //        phoneEmployeeTB.Text = "رقم التليفون";
        //    }
        //}

        //private void SalaryEmployeeTB_Enter(object sender, EventArgs e)
        //{
        //    if (SalaryEmployeeTB.Text == "راتب الموظف")
        //    {
        //        SalaryEmployeeTB.Text = "";
        //    }
        //}

        //private void SalaryEmployeeTB_Leave(object sender, EventArgs e)
        //{

        //    if (SalaryEmployeeTB.Text == "")
        //    {
        //        SalaryEmployeeTB.Text = "راتب الموظف";
        //    }
        //}

        //private void AddressEmployeeTB_Enter(object sender, EventArgs e)
        //{

        //    if (AddressEmployeeTB.Text == "عنوان الموظف")
        //    {
        //        AddressEmployeeTB.Text = "";
        //    }
        //}

        //private void AddressEmployeeTB_Leave(object sender, EventArgs e)
        //{
        //    if (AddressEmployeeTB.Text == "")
        //    {
        //        AddressEmployeeTB.Text = " عنوان الموظف";
        //    }
        //}

        //private void NationalIDTB_Enter(object sender, EventArgs e)
        //{
        //    if (NationalIDTB.Text=="الرقم القومى")
        //    {
        //        NationalIDTB.Text = "";
        //    }
        //}

        //private void NationalIDTB_Leave(object sender, EventArgs e)
        //{
        //    if (NationalIDTB.Text=="")
        //    {
        //        NationalIDTB.Text = "الرقم القومى";
        //    }
        //}

        //private void phIDTB_Enter(object sender, EventArgs e)
        //{
        //    if (phIDTB.Text=="PHID")
        //    {
        //        phIDTB.Text = "";
        //    }
        //}

        //private void phIDTB_Leave(object sender, EventArgs e)
        //{
        //    if (phIDTB.Text == "")
        //    {
        //        phIDTB.Text = "PHID";
        //    }
        //}

        private void RemoveBTN_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialog = MessageBox.Show("هل توافق على حذف الموظف", "تحزير", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (dialog == DialogResult.Yes)
                {
                    if (NationalIDTB.Text == "")
                    {
                        MessageBox.Show("تم حذف الموظف مسبقاً");
                    }
                    else
                    {
                        query = "delete from Employee where Nid = '" + NationalIDTB.Text + "';";
                        cn.setData(query, "تم حذف الموظف بنجاح");
                        populate();
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("خطاء في البيانات ", "ERORR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void EditBTN_Click(object sender, EventArgs e)
        {
            string Name = nameEmpLoyeeTB.Text;
            string Password = PasswordEmployeeTB.Text;
            Int64 Phone = Int64.Parse(phoneEmployeeTB.Text);
            string Gender = empGenderCB.SelectedItem.ToString();
            Int64 salary = Int64.Parse(SalaryEmployeeTB.Text);
            string status = empStatusCB.SelectedItem.ToString();
            string adress = AddressEmployeeTB.Text;
            string military = empMalitaryCB.SelectedItem.ToString();
            string role = empPositionCB.SelectedItem.ToString();
            string shift = empShiftCB.SelectedItem.ToString();
            string NID = NationalIDTB.Text;
            //string phid = phIDTB.Text;  , Phid = '" + phid + "' forieng key 
            try
            {
                query = "UPDATE Employee SET EmpName = N'" + Name + "', EmpPassword = '" + Password + "',EmpPhone = '" + Phone + "', EmpGender = '" + Gender + "',EmpSalary='" + salary + "', EmpAdress = N'" + adress + "', EmpMalitary = N'" + military + "', EmpPosition = '" + role + "', EmpShift = N'" + shift + "',EmpStatus = N'" + status + "' WHERE Nid = '" + NID + "';";
                cn.setData(query, "تم التعديل بنجاح");
                populate();
            }
            catch (Exception)
            {
                MessageBox.Show("خطاء في البيانات ", "ERORR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //populate();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
          NationalIDTB.Text = empGridView.SelectedRows[0].Cells[3].Value.ToString();
          phIDTB.Text = empGridView.SelectedRows[0].Cells[10].Value.ToString();
          SalaryEmployeeTB.Text = empGridView.SelectedRows[0].Cells[11].Value.ToString();
          AddressEmployeeTB.Text = empGridView.SelectedRows[0].Cells[6].Value.ToString();
          nameEmpLoyeeTB.Text = empGridView.SelectedRows[0].Cells[0].Value.ToString();
          phoneEmployeeTB.Text = empGridView.SelectedRows[0].Cells[1].Value.ToString();
          PasswordEmployeeTB.Text = empGridView.SelectedRows[0].Cells[9].Value.ToString();
          empPositionCB.Text = empGridView.SelectedRows[0].Cells[8].Value.ToString();
          empGenderCB.Text = empGridView.SelectedRows[0].Cells[4].Value.ToString();   
          empStatusCB.Text = empGridView.SelectedRows[0].Cells[5].Value.ToString();
          empShiftCB.Text = empGridView.SelectedRows[0].Cells[2].Value.ToString();
          empMalitaryCB.Text = empGridView.SelectedRows[0].Cells[7].Value.ToString();
        }
        private void empSearchTB_TextChanged(object sender, EventArgs e)
        {
            try {
                if (empSearchcCB.Text == "البحث بالرقم القومي")
                {
                    SqlDataAdapter sda = new SqlDataAdapter("SELECT EmpName AS [الاسم],EmpPhone AS [رقم التلفون],EmpShift AS [الوردية],Nid AS [الرقم القومي],EmpGender AS [النوع],EmpStatus AS [الحالة الاجتماعية],EmpAdress AS [العنوان],EmpMalitary AS [الموقف التجنيدي],EmpPosition AS [الوظيفة],EmpPassword AS [كلمة المرور],Phid AS [كوود الصيدلية],EmpSalary AS [الراتب] FROM Employee where Nid like '" + empSearchTB.Text + "%'", Con);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    empGridView.DataSource = dt;
                }
                else if (empSearchcCB.Text == "البحث بالاسم")
                {
                    SqlDataAdapter sda = new SqlDataAdapter("SELECT EmpName AS [الاسم],EmpPhone AS [رقم التلفون],EmpShift AS [الوردية],Nid AS [الرقم القومي],EmpGender AS [النوع],EmpStatus AS [الحالة الاجتماعية],EmpAdress AS [العنوان],EmpMalitary AS [الموقف التجنيدي],EmpPosition AS [الوظيفة],EmpPassword AS [كلمة المرور],Phid AS [كوود الصيدلية],EmpSalary AS [الراتب] FROM Employee where EmpName like N'" + empSearchTB.Text + "%'", Con);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    empGridView.DataSource = dt;
                }
            }catch(Exception ex)
            {
                MessageBox.Show("برجاء البحث بطريقة صحيحة", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }


        private void empSearchTB_Enter(object sender, EventArgs e)
        {
            if (empSearchTB.Text == "بحث")
            {
                empSearchTB.Text = "";
            }
        }

        private void empSearchTB_Leave(object sender, EventArgs e)
        {
            if (empSearchTB.Text == "")
            {
                empSearchTB.Text = "بحث";
            }
        }
    }
}
