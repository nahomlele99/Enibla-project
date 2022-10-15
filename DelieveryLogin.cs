using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace Enibla_project
{
    public partial class DelieveryLogin : Form
    {
        public DelieveryLogin()
        {
            InitializeComponent();
        }

        private void bunifuThinButton22_MouseEnter(object sender, EventArgs e)
        {
            btnGoogle.Font = new Font("Century Gothic", 12);
        }

        private void btnGoogle_Click(object sender, EventArgs e)
        {

        }

        private void btnGoogle_MouseLeave(object sender, EventArgs e)
        {
            btnGoogle.Font = new Font("Century Gothic", 14);

        }

        private void bunifuThinButton21_MouseEnter(object sender, EventArgs e)
        {
            bunifuThinButton21.Font= new Font("Century Gothic", 12);

        }
        private void bunifuThinButton21_MouseLeave(object sender, EventArgs e)
        {
            bunifuThinButton21.Font = new Font("Century Gothic", 14);

        }

        private void randomHotelHome1_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
            joinAsPage joinAs = new joinAsPage();
            joinAs.Show();
            this.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_MouseEnter(object sender, EventArgs e)
        {

        }

        private void label4_MouseEnter(object sender, EventArgs e)
        {
            label4.Font = new Font("Century Gothic", 10);


        }
        private void label4_MouseLeave(object sender, EventArgs e)
        {
            label4.Font = new Font("Century Gothic", 12);


        }
    }
}
