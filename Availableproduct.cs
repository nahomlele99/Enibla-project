using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.ServiceModel.Configuration;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Drawing.Text;

namespace Enibla_project
{
    public partial class Availableproduct : Form
    {
        FoodandDrinks fd;
        SqlConnection conn = new SqlConnection("Data Source= DESKTOP-8I5JD62\\SQLEXPRESS;Initial Catalog= AvailableProducts;Integrated security=true;");
        public Availableproduct()
        {
            InitializeComponent();
        }

       
        private void searchPic_Click(object sender, EventArgs e)
        {

        }

        private void drinkdisplay_Click(object sender, EventArgs e)
        {

        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            
            //string name = txtsearch.Text;
           // dataGridView1.ReadOnly = true;
           // dataGridView1.DataSource = fd.Displayy();

        }

        private void Availableproduct_Load(object sender, EventArgs e)
        {
            fd = new FoodandDrinks();
            fd.AddProducts();

                




         
        }

        private void btnAvaialble_Click(object sender, EventArgs e)
        {
           // string path = "Data Source= DESKTOP-8I5JD62\\\\SQLEXPRESS;Initial Catalog= AvailableProducts;Integrated security=true;";
            string query = "SELECT * FROM AvailableProducts";

            conn.Open();
            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            conn.Close();


        }
    }
}

