using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Enibla_project
{
    public partial class joinAsPage : Form
    {
        public joinAsPage()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {   
            loginPage login = new loginPage();
            login.Show();
            this.Hide();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            SignupPage signup = new SignupPage();
            signup.Show();
            this.Hide();

        }
    }
}
