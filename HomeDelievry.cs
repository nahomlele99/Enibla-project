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
    public partial class HomeDelievry : Form
    {
        public HomeDelievry()
        {
            InitializeComponent();
          
           
        }
       
     private void guna2Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void HomeDelievry_Load(object sender, EventArgs e)
        {
           
            

        }

        private void btnDeliverySetting_Click(object sender, EventArgs e)
        {
            DeliverySetting form = new DeliverySetting();
            form.Show();
            this.Hide();
           // ShowSubMenu(settingpanel);
            
        }

        private void guna2CircleButton3_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Visible = true;
        }

        private void btnPersonType_Click(object sender, EventArgs e)
        {

        }

        private void btnNo(object sender, EventArgs e)
        {

        }
    }
}
