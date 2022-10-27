using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Services.Description;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Enibla_project
{
    public partial class DeliverySignUp : Form
    {
        char Gen;
        string ImageFile;
        Image Pic = null;
        public DeliverySignUp()
        {
            InitializeComponent();
        }
        byte[] ConvertImageToBytes(Image img)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                img.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                return ms.ToArray();
            }
        }
        private void btnSignUp_Click(object sender, EventArgs e)
        {
            Delivery delivery = new Delivery();
            delivery.FullName = fName.Texts;
            delivery.Phonenumber = txtPhone.Texts;
            delivery.Email = txtEmail.Texts;
            delivery.Username = txtUName.Texts;
            delivery.Password =txtPassword.Texts;
            delivery.gender = Gen;
            delivery.Avatar = ConvertImageToBytes(Pic);
            delivery.PicFile = ImageFile;
            
            
            
            if (delivery.save())
            {
                loginPage login = new loginPage();
                login.Show();
                this.Hide();
            }

        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void guna2CircleButton2_Click(object sender, EventArgs e)
        {

        }

        private void guna2CircleButton3_Click(object sender, EventArgs e)
        {

        }

        private void btnBlackPerson_Click(object sender, EventArgs e)
        {
            


        }

        private void picGirl_Click(object sender, EventArgs e)
        {
           // picGirl.Image.Save(@"C:\Users\Desktop\test.jpg", System.Drawing.Imaging.ImageFormat.Jpeg);
        }

        private void blackPerson_Click(object sender, EventArgs e)
        {
            ImageFile = @"C:\Users\DELL\Desktop\GitHub\KidusEnibla\Icons\blackperson.png";
            ProPic.ImageLocation = ImageFile;
            Pic = Image.FromFile(ImageFile) ;
            ProPic.BorderColor = Color.LightSlateGray;
            ProPic.BorderColor2 = Color.White;
            Gen = 'M';

        }

        private void Girl_Click(object sender, EventArgs e)
        {
            ImageFile = @"C:\Users\DELL\Desktop\GitHub\KidusEnibla\Icons\girl.png";
            ProPic.ImageLocation = ImageFile;
            Pic = Image.FromFile(ImageFile);
            ProPic.BorderColor = Color.DarkOrchid;
            ProPic.BorderColor2 = Color.Yellow;
            Gen = 'F';
        }

        private void Ninja_Click(object sender, EventArgs e)
        {
            ImageFile = @"C:\Users\DELL\Desktop\GitHub\KidusEnibla\Icons\person3.png";
            ProPic.ImageLocation = ImageFile;
            Pic = Image.FromFile(ImageFile);
            ProPic.BorderColor = Color.LightSlateGray;
            ProPic.BorderColor2 = Color.White;
            Gen = 'F';

        }

        private void WhitePerson_Click(object sender, EventArgs e)
        {
            ImageFile = @"C:\Users\DELL\Desktop\GitHub\KidusEnibla\Icons\person2.png";
            ProPic.ImageLocation = ImageFile;
            Pic = Image.FromFile(ImageFile);
            ProPic.BorderColor = Color.LightSlateGray;
            ProPic.BorderColor2 = Color.Aqua;
            Gen = 'M';

        }
        public void SaveImage()
        {
            


        }

        private void blackPerson_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void LogIn_Click(object sender, EventArgs e)
        {
            DeliveryLogin form = new DeliveryLogin();
            form.Show();
            this.Hide();
        }

        private void lblLogIn_MouseEnter(object sender, EventArgs e)
        {
            lblLogIn.Font = new Font("Microsoft Sans Serif",16); 

        }

        private void lblLogIn_MouseLeave(object sender, EventArgs e)
        {
            lblLogIn.Font = new Font("Microsoft Sans Serif", 14); 

        }

        private void lblLogIn_Click(object sender, EventArgs e)
        {
            loginPage lp = new loginPage();
            lp.Show();
            this.Hide();
        }
    }
}
