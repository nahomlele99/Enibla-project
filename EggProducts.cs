using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Enibla_project
{
    public partial class EggProducts : Form
    {
        //SqlConnection conn = new SqlConnection("Data Source= DESKTOP-8I5JD62\\SQLEXPRESS;Initial Catalog= AvailableProducts;Integrated security=true;");
        const int eggid = 100;
        const int milkid = 101;
        public EggProducts()
        {
            InitializeComponent();
        }

        private void producttypes1_Load(object sender, EventArgs e)
        {

        }

        private void EggProducts_Load(object sender, EventArgs e)
        {

        }
        private void  btnSave_Click(object sender, EventArgs e)
        {/*
            try
            {
                conn.Open();
                string query1 = "SET IDENTITY_INSERT AvailableProducts ON";
              
                SqlCommand cmd;
                cmd = new SqlCommand(query1, conn);
                cmd.ExecuteNonQuery();
                cmd = new SqlCommand("INSERT INTO AvailableProducts([PrCode],[PrName],[PrQuantity]) VALUES(@PrCode,@PrName,@PrQuantity)", conn);
                cmd.Parameters.AddWithValue("@PrCode", eggid);
               cmd.Parameters.AddWithValue("@PrName", lblegg.Text);
                cmd.Parameters.AddWithValue("@PrQuantity", cbegg.SelectedIndex);
               
                cmd.Parameters.AddWithValue("@PrCode", milkid);
                cmd.Parameters.AddWithValue("@PrName", lblmilk.Text);
                cmd.Parameters.AddWithValue("@PrQuantity", cbmilk.SelectedIndex);
               cmd.ExecuteNonQuery();
                MessageBox.Show("      Added Successfully ");
                conn.Close();



            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            */
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void lblegg_Click(object sender, EventArgs e)
        {

        }

        private void lblegg_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Chicken eggs provide high-quality and easily usable protein. Besides, they contain Vitamin A, K and B2, minerals and fat. The largest amount is found in egg yolks and consists of unsaturated fatty acids. Eggs also contain cholesterol which can have an adverse effect on the blood lipid levels. For a healthy and balanced diet, you need not worry about too high consumption of egg. It ultimately always depends on the quantity", lblegg);
        }

        private void lblmilk_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Milk and milk products form part of a mixed, balanced diet. They provide high-quality protein and are a good source of Vitamin D and calcium. This trio is necessary for building and maintaining bone mass. Be it for muesli, tasty desserts or cooking and baking, milk can be used in diverse ways. Milk should be stored in the refrigerator to ensure optimal shelf life", lblmilk);
        }
    }
}
