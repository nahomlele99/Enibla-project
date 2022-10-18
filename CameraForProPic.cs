using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DarrenLee.Media;
using System.IO;
using System.Drawing.Imaging;


namespace Enibla_project
{
    public partial class CameraForProPic : Form
    {
        Camera myCamera = new Camera();
        string path;
        public CameraForProPic(string Name) 
            
        {
            InitializeComponent();
            myCamera.OnFrameArrived += myCamera_OnFrameArrived;
            path = @"C:\Users\User\Documents\C# projects\Images\" + Name + ".Jpg";
        }

        private void myCamera_OnFrameArrived(object source, FrameArrivedEventArgs e)
        {
            Image img = e.GetFrame();
            pictureBox1.Image= img;

        }

        private void Save_Click(object sender, EventArgs e)
        {
           
            try
            {
                if (!Directory.Exists(@"C:\Users\User\Documents\C# projects\Images")) {
                    Directory.CreateDirectory(@"C: \Users\User\Documents\C# projects\Images");
                    MessageBox.Show("Images folder created....");
                }
                else
                {
                    
                    pictureBox1.Image.Save(path, ImageFormat.Jpeg);
                    myCamera.Stop();
                    MessageBox.Show(path);
                    SignupPage.imglocation = path;
                    this.Hide();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
       public string photo()
       {
                return path = path + Name + ".jpg";
                
        }
        private void CameraForProPic_Load(object sender, EventArgs e)
        {
            myCamera.Start();
        }
    }
}
