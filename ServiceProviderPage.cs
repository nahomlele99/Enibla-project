using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Enibla_project
{
    public partial class ServiceProviderPage : Form
    {
        public ServiceProviderPage()
        {
            InitializeComponent();
        }

        private void HomePageSp_Click(object sender, EventArgs e)
        {
            
        }

        private void HomePageSp_MouseEnter(object sender, EventArgs e)
        {
            HomeIcon.Visible = true;
        }

        private void HomePageSp_MouseLeave(object sender, EventArgs e)
        {
            HomeIcon.Visible =false;
        }

        private void ManageProductsSP_Click(object sender, EventArgs e)
        {

        }

        private void ManageProductsSP_MouseEnter(object sender, EventArgs e)
        {
            ManageIcon.Visible = true;
        }

        private void ManageProductsSP_MouseLeave(object sender, EventArgs e)
        {
            ManageIcon.Visible=false;
        }

        private void SettingSp_Click(object sender, EventArgs e)
        {

        }

        private void SettingSp_MouseEnter(object sender, EventArgs e)
        {
            settingIcon.Visible = true;
        }

        private void SettingSp_MouseLeave(object sender, EventArgs e)
        {
            settingIcon.Visible=false;
        }

        private void Delivery_Click(object sender, EventArgs e)
        {

        }

        private void Delivery_MouseEnter(object sender, EventArgs e)
        {
            DeliveryIcon.Visible = true;
        }

        private void Delivery_MouseLeave(object sender, EventArgs e)
        {
            DeliveryIcon.Visible =false;
        }

        private void ServiceProviderPage_Load(object sender, EventArgs e)
        {

        }
    }
}
