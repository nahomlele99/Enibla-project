using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
        public DeliverySignUp()
        {
            InitializeComponent();
        }
       
        private void btnSignUp_Click(object sender, EventArgs e)
        {
            Delivery delivery = new Delivery();
            delivery.FullName = fName.Texts;
            delivery.Phonenumber = txtPhone.Texts;
            
            delivery.Email = txtEmail.Texts;
            delivery.Username = txtUName.Texts;
            delivery.Password =txtPassword.Texts;
            
            if (delivery.save())
            {
                DeliveryLogin login = new DeliveryLogin();
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

        }

        private void Girl_Click(object sender, EventArgs e)
        {

        }

        private void Ninja_Click(object sender, EventArgs e)
        {

        }

        private void WhitePerson_Click(object sender, EventArgs e)
        {

        }
        public void SaveImage()
        {
            


        }

        private void blackPerson_MouseHover(object sender, EventArgs e)
        {
            
        }
    }
}
