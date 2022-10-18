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
    public partial class searchPage : Form
    {
        public static searchPage search;
        public searchPage()
        {
            InitializeComponent();
            search = this;
            
        }

        private void bunifuThinButton26_Click(object sender, EventArgs e)
        {
            HomePage home = new HomePage();
            home.Show();
            this.Hide();
        }
        private void homeHover(object sender, EventArgs e)
        {
           // pictureBox7.Image= ((System.Drawing.Bitmap)(Properties.Resources.));
        }

        private void label3_Click(object sender, EventArgs e)
        {
            if (UnderlinePanel.Location.X == 200)
            {
                UnderlinePanel.Location = new Point(UnderlinePanel.Location.X + 100, UnderlinePanel.Location.Y);
            }
            else if(UnderlinePanel.Location.X == 420)
            {
                UnderlinePanel.Location = new Point(UnderlinePanel.Location.X - 120, UnderlinePanel.Location.Y);
            }
            else if (UnderlinePanel.Location.X== 520)
            {
                UnderlinePanel.Location = new Point(UnderlinePanel.Location.X - 220, UnderlinePanel.Location.Y);
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            if (UnderlinePanel.Location.X == 300)
            {
                UnderlinePanel.Location = new Point(UnderlinePanel.Location.X + 120, UnderlinePanel.Location.Y);
            }
            else if (UnderlinePanel.Location.X == 200)
            {
                UnderlinePanel.Location = new Point(UnderlinePanel.Location.X + 220, UnderlinePanel.Location.Y);
            }
            else if (UnderlinePanel.Location.X == 520)
            {
                UnderlinePanel.Location = new Point(UnderlinePanel.Location.X - 100, UnderlinePanel.Location.Y);
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {
            if (UnderlinePanel.Location.X == 200)
            {
                UnderlinePanel.Location = new Point(UnderlinePanel.Location.X + 320, UnderlinePanel.Location.Y);
            }
            else if (UnderlinePanel.Location.X == 420){
                UnderlinePanel.Location = new Point(UnderlinePanel.Location.X + 100, UnderlinePanel.Location.Y);

            }
            else if (UnderlinePanel.Location.X == 300)
            {
                UnderlinePanel.Location = new Point(UnderlinePanel.Location.X + 220, UnderlinePanel.Location.Y);

            }

        }

        private void label2_Click(object sender, EventArgs e)
        {
            if (UnderlinePanel.Location.X == 300)
            {
                UnderlinePanel.Location = new Point(UnderlinePanel.Location.X - 100, UnderlinePanel.Location.Y);

            }
            else if(UnderlinePanel.Location.X == 420)
            {
                UnderlinePanel.Location = new Point(UnderlinePanel.Location.X - 220, UnderlinePanel.Location.Y);
            }
            else if(UnderlinePanel.Location.X == 520)
            {
                UnderlinePanel.Location = new Point(UnderlinePanel.Location.X - 320, UnderlinePanel.Location.Y);
            }
        }
    }
    
}

