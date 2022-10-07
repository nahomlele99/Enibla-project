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

namespace Enibla_project
{
    public partial class Availableproduct : Form
    {
        FoodandDrinks fd;
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
            try
            {

                fd = new FoodandDrinks();
                dataGridView1.DataSource = fd.Displayy();
                
                
               

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

