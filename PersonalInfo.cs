using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
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
        public PersonalInfo()
        {
            InitializeComponent();

        }
        public static string imglocation = "";
        Image imgimage = null;
        private void PersonalInfo_Load(object sender, EventArgs e)
        {

            try
            {
                using (SqlConnection c = new SqlConnection(ConfigurationManager.ConnectionStrings["EniblaDBs"].ConnectionString))
                {
                    if (c.State == System.Data.ConnectionState.Closed)
                        c.Open();
                    string query = "SELECT * FROM LogedIn";
                    using (SqlCommand cmd = new SqlCommand(query, c))
                    {
                        SqlDataReader reader = cmd.ExecuteReader();
                        if (reader.Read())
                        {
                            
                            txtUsername.Text = reader.GetValue(0).ToString();
                            txtPassword.Text = reader.GetValue(1).ToString();
                            txtName.Text = reader.GetValue(2).ToString();
                            txtPhone.Text = reader.GetValue(3).ToString();
                            txtEmail.Text = reader.GetValue(4).ToString();



                        }
                    }
                }
            }
            catch(SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
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

            try
            {
                using (SqlConnection c = new SqlConnection(ConfigurationManager.ConnectionStrings["EniblaDBs"].ConnectionString))
                {
                    if (c.State == System.Data.ConnectionState.Closed)
                        c.Open();
                    string query = "UPDATE LogedIn SET Username='" + txtUsername.Text + "',Password= '" + txtPassword.Text + "',Fullname='" + txtName.Text + "',Phonenumber= '" + txtPhone.Text + "',Email='" + txtEmail.Text + "'";
                    using (SqlCommand cmd = new SqlCommand(query, c))
                    {
                        SqlDataReader reader = cmd.ExecuteReader();
                        MessageBox.Show("Successfully Updated");
                        DeliverySetting form = new DeliverySetting();
                        form.Show();
                        this.Hide();

                    }
                }
            }catch(SqlException ex)
            {
                MessageBox.Show(ex.Message);

            }
        }
        private void Password_Click(object sender, EventArgs e)
        {

        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            // image filters  
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {
                // display image in picture box  
                profilepic.Image = new Bitmap(open.FileName);
                // image file path  
               
            }
        }
    }
}
