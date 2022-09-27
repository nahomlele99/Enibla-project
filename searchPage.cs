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
    public partial class searchPage : Form
    {
        public static searchPage search;
        public searchPage()
        {
            InitializeComponent();
            search = this;
        }

        private void bunifuThinButton26_Click(object sender, EventArgs e)
        {
            HomePage home = new HomePage();
            home.Show();
            this.Hide();
        }
        private void homeHover(object sender, EventArgs e)
        {
           // pictureBox7.Image= ((System.Drawing.Bitmap)(Properties.Resources.));
        }
    }
}
