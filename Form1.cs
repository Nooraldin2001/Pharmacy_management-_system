using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pharmacy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Progressbar1.Value = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Progressbar1.Value += 1;
            Progressbar1.Text = Progressbar1.Value.ToString() + "%";
            if (Progressbar1.Value == 100)
            {
                timer1.Enabled = false;
                Login log_in = new Login();
                log_in.Show();
                this.Hide();
            }
        }
    }
}
