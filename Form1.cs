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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            pbar.Value = 0;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pbar.Value += 2;
            if(pbar.Value == 100)
            {
                timer1.Enabled=false;
                loginPage login = new loginPage();
                login.Show();
                this.Hide();

            }
        }
    }
}
