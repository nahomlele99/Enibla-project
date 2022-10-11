using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Enibla_project
{
    public partial class Shopping : Form
    {
        public Shopping()
        {
            InitializeComponent();
        }
       
        private void timer1_Tick(object sender, EventArgs e)
        {
            
        }

        private void productsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void utilitiesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void hireDeliveryToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void availablefoodsanddrinksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(ActiveMdiChild != null)
            {
                ActiveMdiChild.Close();

            }
            AvailableProduct form = new AvailableProduct();
            form.MdiParent = this;
            form.Show();
           
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
            {
                ActiveMdiChild.Close();

            }
            AddFoodProduct form = new AddFoodProduct();
            form.MdiParent = this;
            form.Show();

        }

        private void viaEmailToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
