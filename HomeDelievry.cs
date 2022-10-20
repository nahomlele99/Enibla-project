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
            customize();
        }
        private void customize()
        {

            panelDeliveryAcceptnace.Visible = false;
        }
        private void hideSubMenu()
        {
            if (panelDeliveryAcceptnace.Visible == true)
                panelDeliveryAcceptnace.Visible = false; ;
           
        }
        private void ShowSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;

            }

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
            ShowSubMenu(panelDeliveryAcceptnace);
        }
    }
}
