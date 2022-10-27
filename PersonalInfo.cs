using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Enibla_project
{
    public partial class PersonalInfo : Form
    {
        Delivery dm;
        char Gen;
        string ImageFile;
        Image Pic = null;
        public PersonalInfo(Delivery del )
        {
            dm = del;
            DeliverySetting deliverySetting = new DeliverySetting(dm);
            InitializeComponent();
            
            

        }
        public static string imglocation = "";
        Image imgimage = null;
        private void PersonalInfo_Load(object sender, EventArgs e)
        {
          txtUsername.Text = dm.Username;
          txtPassword.Text = dm.Password;
          txtName.Text = dm.FullName;
          txtPhone.Text = dm.Phonenumber;
          txtEmail.Text = dm.Email;
          txtGender.Text = dm.gender.ToString();
          ProPic.ImageLocation = dm.PicFile;

        }
       
        private void EditMode_Click(object sender, EventArgs e)
        {
            ReadingMode();

        }
        private void ReadingMode()
        {
            txtName.ReadOnly = false;
            txtPhone.ReadOnly = false;
            txtEmail.ReadOnly = false;
            txtPassword.ReadOnly = false;
            txtGender.ReadOnly = false;
            txtUsername.ReadOnly = false;
        }

        private void UploadPic_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "png files (* png)|*.png|jpg files (*.jpg)|*.jpg|All file(*.*)|*.*";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                imgimage = Image.FromFile(dialog.FileName);
                imglocation = dialog.FileName.ToString();
                ProPic.ImageLocation = imglocation;
            }
        }
        byte[] ConvertImageToBytes(Image img)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                img.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                return ms.ToArray();
            }
        }
        public Image ConvertByteToImage(byte[] data)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                return Image.FromStream(ms);
            }
        }
       

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            ProPic.ImageLocation = imglocation;
            imgimage = Image.FromFile(imglocation);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            dm.Username = txtUsername.Text;
            dm.Password= txtPassword.Text;
            dm.FullName= txtName.Text;
            dm.Phonenumber= txtPhone.Text;
            dm.Email= txtEmail.Text;
            dm.gender= Convert.ToChar(txtGender.Text);
            dm.PicFile= ProPic.ImageLocation;
            dm.UpdateLogedUser();
        }
        private void blackPerson_Click(object sender, EventArgs e)
        {
            ImageFile = @"C:\Users\DELL\Desktop\GitHub\KidusEnibla\Icons\blackperson.png";
            ProPic.ImageLocation = ImageFile;
            Pic = Image.FromFile(ImageFile);
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
        private void Password_Click(object sender, EventArgs e)
        {

        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            try
            {
                string ImgLocation = "";
                OpenFileDialog open = new OpenFileDialog();
                // image filters  
                open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.png; *.bmp)|*.jpg; *.jpeg; *.gif; *.png; *.bmp";
                if (open.ShowDialog() == DialogResult.OK)
                {
                    // display image in picture box  
                    ImgLocation = open.FileName;
                    ProPic.ImageLocation = ImgLocation;
                    // image file path  

                }
            }catch(Exception)
            {
                MessageBox.Show("An Error Occured","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
    }
}
