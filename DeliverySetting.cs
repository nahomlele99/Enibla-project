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
    public partial class DeliverySetting : Form
    {
        Delivery del;
        string Username;
        public DeliverySetting(Delivery dm)
        {
            InitializeComponent();
            customize();
            del = dm;
        }
        private void customize()
        {
            
            panelAccount.Visible = false;
            panelAbout.Visible = false;
        }
        private void hideSubMenu()
        {
            if (panelAccount.Visible == true)
                panelAccount.Visible = false;
            if (panelAbout.Visible == true)
                panelAbout.Visible = false;
            
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
        private void DeliverySetting_Load(object sender, EventArgs e)
        {
            openChild(new PersonalInfo(del));
           
        }

        private void btnAccount_Click(object sender, EventArgs e)
        {
            openChild(new PersonalInfo(del));
            ShowSubMenu(panelAccount);
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            ShowSubMenu(panelAbout);
        }

        private void btnPersonal_Click(object sender, EventArgs e)
        {
            
        }

        private void btnPassword_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void btnPrivacy_Click(object sender, EventArgs e)
        {
            openChild(new termsAndConditions());
            hideSubMenu();
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            openChild(new HelpCenter());
            hideSubMenu();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }
        private Form activeform = null;
        private void openChild(Form childform)
        {
            if (activeform != null)
                activeform.Close();
            activeform = childform;
            childform.TopLevel = false;
            childform.FormBorderStyle = FormBorderStyle.None;
            childform.Dock = DockStyle.Fill;
            panelChild.Controls.Add(childform);
            panelChild.Tag = childform;
            childform.BringToFront();
            childform.Show();

        }

        private void panelChild_Paint(object sender, PaintEventArgs e)
        {

        }

        private void LogOut_Click(object sender, EventArgs e)
        {
            openChild(new LogOut(del));
            hideSubMenu();
        }

        private void btnDeliverySetting_Click(object sender, EventArgs e)
        {

            HomeDelievry HD = new HomeDelievry(del.Username);
            HD.Show();
            this.Hide();
        }

        private void btnDeactivate_Click(object sender, EventArgs e)
        {
            openChild(new DeactivateAccount(del));
            hideSubMenu();

        }
    }
}
