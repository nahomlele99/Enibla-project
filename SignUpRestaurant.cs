using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using System.Globalization;

namespace Enibla_project
{
    public partial class SignUpRestaurant : Form
    {
        SqlConnection c = new SqlConnection();
        public SignUpRestaurant()
        {
            InitializeComponent();
        }
        string imglocation = "";
        Image imgimage = null;
        private void bunifuThinButton24_Click(object sender, EventArgs e)
        {
            ServiceProvider user = new ServiceProvider();
            user.Name = RName.Texts;
            user.Id = int.Parse(RId.Texts);
            user.PhoneNumber = phone.Texts;
            user.Email = Email.Texts;
            user.Location =cmboCountry.Text;
            user.UserName = UserName.Texts;
            user.Password = Password.Texts;
            user.Filename = imglocation;
            user.Images = ConvertImageToBytes(imgimage);
            if (user.save(c))
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

        private void bunifuThinButton23_MouseLeave(object sender, EventArgs e)
        {

            Color Mytheme = ColorTranslator.FromHtml("#F7971F");
            pictureBox4.BackColor = Mytheme;
            pictureBox4.Image = Image.FromFile(@"C:\Users\Dell\Documents\icon 1.png");
        }

        private void bunifuThinButton23_MouseEnter(object sender, EventArgs e)
        {
            pictureBox4.BackColor = System.Drawing.Color.White;
            pictureBox4.Image = Image.FromFile(@"C:\Users\Dell\Documents\orange.png");
        }

        private void SignUpRestaurant_Load(object sender, EventArgs e)
        {
            List<string> cultureList = new List<string>();

            CultureInfo[] cultures = CultureInfo.GetCultures(CultureTypes.SpecificCultures);

            foreach (CultureInfo culture in cultures)
            {
                RegionInfo region = new RegionInfo(culture.LCID);

                if (!(cultureList.Contains(region.EnglishName)))
                {
                    cultureList.Add(region.EnglishName);
                }
            }
            cultureList.Sort();
            cmboCountry.DataSource = cultureList;

        }
    }
}
