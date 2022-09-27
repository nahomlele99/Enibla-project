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
    public partial class HomePage : Form
    {
        public static HomePage home;
        public HomePage()
        {
            InitializeComponent();
            home = this;
        }

        private void HomePage_Load(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
            searchPage search= new searchPage();
            search.Show();
            this.Hide();
        }
    }
}
