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
using System.Xml.Linq;

namespace Enibla_project
{
    public partial class PersonalInfo : Form
    {
        public PersonalInfo()
        {
            InitializeComponent();
        }
        public static string imglocation = "";
        Image imgimage = null;
        private void PersonalInfo_Load(object sender, EventArgs e)
        {

        }

        private void EditMode_Click(object sender, EventArgs e)
        {
            
        }
        private void ReadingMode()
        {
            txtName.ReadOnly = false;
            txtPhone.ReadOnly = false;
            txtEmail.ReadOnly = false;
        }

        private void UploadPic_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "png files (* png)|*.png|jpg files (*.jpg)|*.jpg|All file(*.*)|*.*";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                imgimage = Image.FromFile(dialog.FileName);
                imglocation = dialog.FileName.ToString();
                profilepic.ImageLocation = imglocation;
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
        private void btnTakePhoto_Click(object sender, EventArgs e)
        {
            CameraForProPic Takepic = new CameraForProPic(txtName.Text);
            Takepic.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            profilepic.ImageLocation = imglocation;
            imgimage = Image.FromFile(imglocation);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //Deliver deliver = new Deliver();
        }
    }
}
