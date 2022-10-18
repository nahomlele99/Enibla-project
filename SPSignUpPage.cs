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

namespace Enibla_project
{
    public partial class SPSignUpPage : Form
    {
        public SPSignUpPage()
        {
            InitializeComponent();
        }
        public static string imglocation = "";
        Image imgimage = null;

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            ServiceProvider sp = new ServiceProvider();
            sp.ServiceProviderName = CompanyName.Texts;
            sp.PhoneNumber = PhoneNumber.Texts;
            sp.Location = Location.Texts;
            sp.Email = Email.Texts;
            sp.Username = UserName.Texts;
            sp.Password = Password.Texts;
            sp.Logo = ConvertImageToBytes(imgimage);
            sp.LogoFile = imglocation;
            sp.ServiceProviderId = "sheraton11";
            if (sp.save())
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
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                imgimage = Image.FromFile(dialog.FileName);
                imglocation = dialog.FileName.ToString();
                LogoPic.ImageLocation = imglocation;
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
    }
}
