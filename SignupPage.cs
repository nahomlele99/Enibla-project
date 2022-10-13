using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Enibla_project
{
    public partial class SignupPage : Form
    {
        public SignupPage()
        {
            
            InitializeComponent();
        }
        string imglocation= "";
        Image imgimage = null;
        SqlConnection c = new SqlConnection();
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
            
            User user = new User();
            user.FullName = fName.Texts;
            user.Phonenumber = Pnumber.Texts;
            user.Email = Email.Texts;
            user.Gender = 'M';
            user.Username=Uname.Texts;
            user.Password = Pword.Texts;
            user.Filename = imglocation;
            user.Images=ConvertImageToBytes(imgimage);
            if(user.save(c))
            {
                loginPage login = new loginPage();
                login.Show();
                this.Hide();
            }
            

        }

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "png files (* png)|*.png|jpg files (*.jpg)|*.jpg|All file(*.*)|*.*";
            if(dialog.ShowDialog() == DialogResult.OK)
            {
                imgimage= Image.FromFile(dialog.FileName);
                imglocation = dialog.FileName.ToString();
                profilepic.ImageLocation= imglocation;
            }
        }
        byte[] ConvertImageToBytes(Image img)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                img.Save(ms,System.Drawing.Imaging.ImageFormat.Png);
                return ms.ToArray();
            }    
        }
        public Image ConvertByteToImage(byte[] data)
        {
            using(MemoryStream ms = new MemoryStream())
            {
                return Image.FromStream(ms);
            }
        }

        private void bunifuThinButton23_MouseEnter(object sender, EventArgs e)
        {
            pictureBox4.BackColor = System.Drawing.Color.White;
            pictureBox4.Image = Image.FromFile(@"C:\Users\Dell\Documents\orange.png");

        }

        private void bunifuThinButton23_MouseLeave(object sender, EventArgs e)
        {
            Color Mytheme = ColorTranslator.FromHtml("#F7971F");
            pictureBox4.BackColor = Mytheme;
            pictureBox4.Image = Image.FromFile(@"C:\Users\Dell\Documents\icon 1.png");


        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {

        }

        private void profilepic_Click(object sender, EventArgs e)
        {

        }

        private void Pword__TextChanged(object sender, EventArgs e)
        {

        }

        private void Uname__TextChanged(object sender, EventArgs e)
        {

        }

        private void Email__TextChanged(object sender, EventArgs e)
        {

        }

        private void Pnumber__TextChanged(object sender, EventArgs e)
        {

        }

        private void fName__TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
