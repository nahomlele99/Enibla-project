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
    public partial class SignupPage : Form
    {
        public SignupPage()
        {
            InitializeComponent();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            loginPage login = new loginPage();
            login.Show();
            this.Hide();
        }
    }
}
