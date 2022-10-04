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

        private void bunifuThinButton21_MouseEnter(object sender, EventArgs e)
        {
            label2.Location = new Point(260, 219);
            label2.BackColor = Color.White;
        }

        private void bunifuThinButton21_MouseLeave(object sender, EventArgs e)
        {
            label2.Location=new Point (260, 253);
            label2.BackColor = Color.WhiteSmoke;
        }

        private void bunifuThinButton22_MouseEnter(object sender, EventArgs e)
        {
            label3.Location = new Point(587, 219);
            label3.BackColor = Color.White;
        }
        private void bunifuThinButton22_MouseLeave(object sender, EventArgs e)
        {
            label3.Location = new Point(587, 253);
            label3.BackColor = Color.WhiteSmoke;
        }

        private void label6_MouseEnter(object sender, EventArgs e)
        {
            label6.Font = new Font("Microsoft Sans Serif", 12);
        }
        private void label6_MouseLeave(object sender, EventArgs e)
        {
            label6.Font = new Font("Microsoft Sans Serif", 14);
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            //hotel signup area
        }
    }
}
