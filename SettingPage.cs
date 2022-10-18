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
            //PublicProfile.Font.Underline
        }

        private void HistoryButton_Click(object sender, EventArgs e)
        {
            HistoryPage history = new HistoryPage();
            history.Show();
            this.Hide();
        }

        private void panel1_Scroll(object sender, ScrollEventArgs e)
        {
            if(e.NewValue <= 0)
            {
                PublicProfile.ForeColor= Color.Orange;
                PersonalInformation.ForeColor = Color.Black;
                AccountManagement.ForeColor = Color.Black;
                PrivacySecurity.ForeColor = Color.Black;




            }
            else if(e.NewValue >= 400 && e.NewValue <= 500)
            {
                PersonalInformation.ForeColor= Color.Orange;
                AccountManagement.ForeColor = Color.Black;
                PublicProfile.ForeColor = Color.Black;
                PrivacySecurity.ForeColor = Color.Black;



            }
            else if(e.NewValue >= 750 && e.NewValue <= 800)
            {
                PublicProfile.ForeColor = Color.Black;
                PersonalInformation.ForeColor = Color.Black;
                PrivacySecurity.ForeColor = Color.Black;
                AccountManagement.ForeColor = Color.Orange;
            }
            else if (e.NewValue >= 850 && e.NewValue <= 950)
            {
                PublicProfile.ForeColor = Color.Black;
                PersonalInformation.ForeColor = Color.Black;
                AccountManagement.ForeColor = Color.Black;
                PrivacySecurity.ForeColor = Color.Orange;
            }
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
    }
}
