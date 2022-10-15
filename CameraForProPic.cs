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
        
        public CameraForProPic() 
        {
            InitializeComponent();

            getInfo();
            
            myCamera.OnFrameArrived += myCamera_OnFrameArrived;
        }

        private void myCamera_OnFrameArrived(object source, FrameArrivedEventArgs e)
        {
            Image img = e.GetFrame();
            pictureBox1.Image= img;

        }
        private void getInfo()
        {
            var cameraDevices = myCamera.GetCameraSources();
            var cameraResolution =myCamera.GetSupportedResolutions();

            foreach (var d in cameraDevices)
            {
                comboBox1.Items.Add(d);
            }
            foreach (var r in cameraResolution)
            {
                comboBox2.Items.Add(r);
            }
            comboBox1.SelectedIndex= 0;
            comboBox2.SelectedIndex= 0;

        }

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
            myCamera.Stop();
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
                    string path = @"C:\Users\User\Documents\C# projects\Images";
                    pictureBox1.Image.Save(path + @"\" + NameText.Texts + ".jpg", ImageFormat.Jpeg);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            myCamera.ChangeCamera(comboBox1.SelectedIndex);
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            myCamera.Start(comboBox2.SelectedIndex);
        }
        public string photo()
        {
                string path = @"C:\Users\User\Documents\C# projects\Images\" + NameText;
            return path;
        }
    }
}
