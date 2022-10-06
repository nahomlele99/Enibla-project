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
    public partial class SignupPage : Form
    {
        public SignupPage()
        {
            InitializeComponent();
        }
        string imglocation= "";

        private void label8_Click(object sender, EventArgs e)
        {
            loginPage login = new loginPage();
            login.Show();
            this.Hide();
        }

        private void label10_Click(object sender, EventArgs e)
        {
            termsAndConditions terms = new termsAndConditions();
            terms.Show();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            //
        }

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "png files (* png)|*.png|jpg files (*.jpg)|*.jpg|All file(*.*)|*.*";
            if(dialog.ShowDialog() == DialogResult.OK)
            {
                imglocation = dialog.FileName.ToString();
                profilepic.ImageLocation= imglocation;
            }
        }

        private void bunifuThinButton23_MouseEnter(object sender, EventArgs e)
        {
            pictureBox4.BackColor = System.Drawing.Color.White;
            pictureBox4.Image = Image.FromFile(@"C:\Users\User\Documents\C# projects\Icons used\upload in orange.png");

        }

        private void bunifuThinButton23_MouseLeave(object sender, EventArgs e)
        {
            Color Mytheme = ColorTranslator.FromHtml("#F7971F");
            pictureBox4.BackColor = Mytheme;
            pictureBox4.Image = Image.FromFile(@"C:\Users\User\Documents\C# projects\Icons used\Enebla icon-01.png");


        }
    }
}
