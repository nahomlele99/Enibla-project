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
    public partial class DeliveryHome : Form
    {
        public DeliveryHome()
        {
            InitializeComponent();
        }

        private void DeliveryHome_Load(object sender, EventArgs e)
        {
            label5.Text = DateTime.Now.ToLongDateString();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button13_Click(object sender, EventArgs e)
        {

        }

        private void guna2Panel11_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2PictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button20_Click(object sender, EventArgs e)
        {
            DelieveryLogin form = new DelieveryLogin();
            form.Show();
            this.Hide();
        }
    }
}
