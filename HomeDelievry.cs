using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Services.Description;
using System.Windows.Forms;

namespace Enibla_project
{

    public partial class HomeDelievry : Form
    {
        public static DeliverySetting form;
        Delivery deliveryMan = new Delivery();
        public HomeDelievry(string name)
        {
            InitializeComponent();
            getInfo(name);
            UserPic.ImageLocation = deliveryMan.PicFile;

        }

        private void guna2Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void HomeDelievry_Load(object sender, EventArgs e)
        {



        }

        private void btnDeliverySetting_Click(object sender, EventArgs e)
        {
            
            // ShowSubMenu(settingpanel);

        }

        private void guna2CircleButton3_Click(object sender, EventArgs e)
        {
            
            label1.BringToFront();
            label2.BringToFront();
            DeliveryFlowlayOut.Visible = true;
           
        }

        private void btnPersonType_Click(object sender, EventArgs e)
        {

        }

        private void btnNo(object sender, EventArgs e)
        {

        }
        public void getInfo(string User)
        {
            using (SqlConnection c = new SqlConnection(ConfigurationManager.ConnectionStrings["EniblaDBs"].ConnectionString))
            {
                if (c.State == System.Data.ConnectionState.Closed)
                    c.Open();
                string query = "select * from Delivery where Username = '" + User + "' ";
                using (SqlCommand cmd = new SqlCommand(query, c))
                {

                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {

                        deliveryMan.FullName = reader["Fullname"].ToString();
                        deliveryMan.Username = reader["Username"].ToString();
                        deliveryMan.Password = reader["Password"].ToString();
                        deliveryMan.Phonenumber= reader["Phonenumber"].ToString();
                        deliveryMan.Email= reader["Email"].ToString();
                        deliveryMan.gender =Convert.ToChar(reader["Gender"]);
                        deliveryMan.Avatar = (Byte[])reader["Picture"];
                        deliveryMan.PicFile = reader["PicFile"].ToString();





                    }
                }

            }
        }

        private void UserPic_Click(object sender, EventArgs e)
        {
            
            form = new DeliverySetting(deliveryMan);
            form.Show();
            this.Hide();

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void lblHistory_Click(object sender, EventArgs e)
        {
            DeliveryFlowlayOut.Controls.Clear();
            foreach(Delivery i in Delivery.deliveryMan)
            {
                DeliveryFlowlayOut.Controls.Add(new DeliveryOrder()
                {
                    //FoodName = i.ProductName, 
                    //Destination = "Addis Ababa",
                    //Starting = i.ServiceProviderId,
                    //Status = true,

                }) ;
            }

           // pnlHistoryDelivery.Visible = true;
        }

        private void acceptanceDelivery1_Load(object sender, EventArgs e)
        {

        }
    }
}
