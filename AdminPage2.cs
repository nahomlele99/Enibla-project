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
    public partial class AdminPage2 : Form
    {
        public AdminPage2()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (pic1.Visible == true)
            {
                pic2.Visible = true;
                pic3.Visible = false;
                pic1.Visible = false;
            }
            else if (pic2.Visible == true)
            {
                pic2.Visible = false;
                pic1.Visible = false;
                pic3.Visible = true;

            }
            else if (pic3.Visible == true)
            {
                pic2.Visible = false;
                pic1.Visible = true;
                pic3.Visible = false;

            }
        }

        private void pic2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            loginPage form = new loginPage();
            form.Show();
            this.Hide();
        }

        private void lblHome_Click(object sender, EventArgs e)
        {
            loginPage form = new loginPage();
            form.Show();
            this.Hide();

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Shopping form = new Shopping();
            form.Show();
            this.Hide();

        }
    }
}
