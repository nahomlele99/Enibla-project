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
    public partial class SettingPage : Form
    {
        public SettingPage()
        {
            InitializeComponent();
        }

        private void HomeButton_Click(object sender, EventArgs e)
        {
            HomePage home = new HomePage();
            home.Show();
            this.Hide();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {

        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            searchPage search = new searchPage();
            search.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            //label1.Font.Underline;
        }
    }
}
