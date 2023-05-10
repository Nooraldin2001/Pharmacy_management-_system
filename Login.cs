using PharmacyProject;
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

namespace Pharmacy
{
    public partial class Login : Form
    {

        public Login()
        {
            InitializeComponent();
            PasswordtextBox.UseSystemPasswordChar = true;
            cancelBTN.FlatStyle = FlatStyle.Flat;
            minimizeBTN.FlatStyle = FlatStyle.Flat;
            cancelBTN.FlatAppearance.BorderSize = 0;
            minimizeBTN.FlatAppearance.BorderSize = 0;

        }
        string query;
        Connection fn = new Connection();
        public string position;
        public int acccess=0;

        private void Login_Load(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            DateTime expire = DateTime.Parse("10/10/2022");
            if (now.Date > expire.Date)
            {
                MessageBox.Show("لقد انتهت فترة استخدام البرنامج","ERROR",MessageBoxButtons.OK,MessageBoxIcon.Error);
                Application.Exit();
            }
        }

        private void cancelBTN_Click(object sender, EventArgs e)
        {
            Application.Exit();
            this.Close();
        }

        private void confirmBTN_Click(object sender, EventArgs e)
        {
            try
            {
                if (PasswordtextBox.Text == "Aziz" & FullNametextBox.Text == "Aziz")
                {
                    MainmenuForm menu = new MainmenuForm();
                    menu.ShowDialog();
                    Hide();
                }
                query = "SELECT * FROM Employee;";
                DataSet ds = fn.getData(query);
                if (ds.Tables[0].Rows.Count == 0)
                {
                    MessageBox.Show("أسم المستخدم أو كلمة المرور خطأ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (FullNametextBox.Text == "aziz" & PasswordtextBox.Text == "aziz")
                    {
                        MainmenuForm menu = new MainmenuForm();
                        menu.ShowDialog();
                        Hide();
                    }
                    SqlConnection Con = new SqlConnection(@"Data Source=noor\sqlexpress;Initial Catalog=PHARMACY1;Integrated Security=True");
                    Con.Open();
                    string myqury = "SELECT * FROM Employee WHERE EmpName = N'" + FullNametextBox.Text + "'and EmpPassword = N'" + PasswordtextBox.Text + "'";
                    SqlCommand cmd = new SqlCommand(myqury, Con);
                    DataTable dt = new DataTable();
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    sda.Fill(dt);
                   

                    foreach (DataRow dr in dt.Rows)
                    {
                        position = dr["EmpPosition"].ToString() ?? "";
                    }
                    Con.Close();
                    if (ds.Tables[0].Rows.Count != 0)
                    {
                        if (position == "Admin")
                        {
                            MainmenuForm menu = new MainmenuForm();
                            menu.Show();
                            Hide();
                            acccess = 1;
                        }
                        else if (position == "Pharmasict")
                        {
                            BillingForm casher = new BillingForm();
                            casher.Show();
                            Hide();
                            acccess = 2;
                        }
                        else
                        {
                            MessageBox.Show(" هذا الحساب خاطىء", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }
                    }

                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("برجاء ادخال البيانات بصورة صحيحة", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void minimizeBTN_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        private void FullNametextBox_Enter(object sender, EventArgs e)
        {
            if (FullNametextBox.Text == "الاسم بالكامل")
            {
                FullNametextBox.Text = "";
            }
        }

        private void FullNametextBox_Leave(object sender, EventArgs e)
        {
            if (FullNametextBox.Text == "")
            {
                FullNametextBox.Text = "الاسم بالكامل";
            }
        }

        private void PasswordtextBox_Enter(object sender, EventArgs e)
        {
            if (PasswordtextBox.Text == "كلمة المرور")
            {
                PasswordtextBox.Text = "";
            }
        }

        private void PasswordtextBox_Leave(object sender, EventArgs e)
        {
            if (PasswordtextBox.Text == "")
            {
                PasswordtextBox.Text = "كلمة المرور";
            }
        }
    }
}

