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
            //Dashboard.both();
            InitializeComponent();
            home = this;

        }


        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
            searchPage search = new searchPage();
            search.Show();
            this.Hide();
        }

        private void pictureBox4_MouseEnter(object sender, EventArgs e)
        {
            searchPic.BackColor = System.Drawing.Color.White;
            searchPic.Image = Image.FromFile(@"C:\Users\User\Documents\C# projects\Icons used\Enebla_Icons_-07.png");
            SearchButton.IdleFillColor = System.Drawing.Color.White;
            
        }

        private void bunifuThinButton23_DragLeave(object sender, EventArgs e)
        {
            Color Mytheme = ColorTranslator.FromHtml("#F7971F");
            searchPic.BackColor = Mytheme;
            SearchButton.IdleFillColor = Mytheme;
            searchPic.Image = Image.FromFile(@"C:\Users\User\Documents\C# projects\Icons used\Enebla_Icons-09.png");

        }

        private void SettingPic_MouseEnter(object sender, EventArgs e)
        {
            SettingPic.BackColor = System.Drawing.Color.White;
            //searchPic.Image
            SettingButton.IdleFillColor = System.Drawing.Color.White;
            SettingPic.Image = Image.FromFile(@"C:\Users\User\Documents\C# projects\Icons used\Enebla_Icons_-08.png");
        }

        private void SettingPic_MouseLeave(object sender, EventArgs e)
        {
            Color Mytheme = ColorTranslator.FromHtml("#F7971F");
            SettingPic.BackColor = Mytheme;
            SettingButton.IdleFillColor = Mytheme;
            SettingPic.Image = Image.FromFile(@"C:\Users\User\Documents\C# projects\Icons used\Enebla_Icons-10.png");

        }

        private void HistoryPic_MouseEnter(object sender, EventArgs e)
        {
            HistoryPic.BackColor = System.Drawing.Color.White;
            HistoryPic.Image = Image.FromFile(@"C:\Users\User\Documents\C# projects\Icons used\Enebla_Icons_-09.png");

            HistoryButton.IdleFillColor = System.Drawing.Color.White;

        }

        private void HistoryPic_MouseLeave(object sender, EventArgs e)
        {
            Color Mytheme = ColorTranslator.FromHtml("#F7971F");
            HistoryPic.BackColor = Mytheme;
            HistoryPic.Image = Image.FromFile(@"C:\Users\User\Documents\C# projects\Icons used\Enebla_Icons-11.png");
            HistoryButton.IdleFillColor = Mytheme;

        }

        private void LogoutPic_MouseEnter(object sender, EventArgs e)
        {

            LogoutPic.BackColor = System.Drawing.Color.White;
            LogoutButton.IdleFillColor = System.Drawing.Color.White;
            LogoutPic.Image = Image.FromFile(@"C:\Users\User\Documents\C# projects\Icons used\Enebla_Icons_-10.png");

        }

        private void LogoutPic_MouseLeave(object sender, EventArgs e)
        {
            Color Mytheme = ColorTranslator.FromHtml("#F7971F");
            LogoutPic.BackColor = Mytheme;
            LogoutButton.IdleFillColor = Mytheme;
            LogoutPic.Image = Image.FromFile(@"C:\Users\User\Documents\C# projects\Icons used\Enebla_Icons-12.png");

        }

        private void SettingButton_Click(object sender, EventArgs e)
        {
            SettingPage settings = new SettingPage();
            settings.Show();
            this.Hide();
        }

        private void HistoryButton_Click(object sender, EventArgs e)
        {
            HistoryPage history =new HistoryPage();
            history.Show();
            this.Hide();
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            Additional Additionalorder = new Additional();
            Additionalorder.Show();
            this.Hide();
        }

        private void HotelNextButton_Click(object sender, EventArgs e)
        {
            //This is the button to change the hotel plus the curent hotel product list
            new HomePage();
        }

        private void bunifuThinButton24_Click(object sender, EventArgs e)
        {
            // This is the button to choose another food from the list
        }
    }
}
