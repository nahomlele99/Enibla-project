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
    public partial class termsAndConditions : Form
    {
        public termsAndConditions()
        {
            InitializeComponent();
        }

        private void label4_MouseEnter(object sender, EventArgs e)
        {
            label4.Font= new Font("Microsoft Sans Serif", 20);
            label4.ForeColor = Color.Red;
            label4.Location = new Point(753, 7);
        }

        private void label4_MouseLeave(object sender, EventArgs e)
        {
            label4.Font = new Font("Microsoft Sans Serif", 16);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(753, 9);
        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
