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
    }
}
