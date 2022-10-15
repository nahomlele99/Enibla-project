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
    public partial class RandomHome : UserControl
    {
        #region properties
        

        

        [Category("KG Code - Appearance")]
        public  String ProductNames {
            get
            {
               return ProductNames;
            }
            set
            {
                ProductName.Text = ProductNames;
            } 
        }
        [Category("KG Code - Appearance")]
        public Image ProductPics
        {
            get
            {
                return ProductPics;
            }
            set
            {
                ProductPic.Image = ProductPics;
            }
        }
        [Category("KG Code - Appearance")]
        public string FileName
        {
            get
            {
                return FileName;
            }
            set
            {
                
               ProductPic.ImageLocation = FileName;

            }
        }
        [Category("KG Code - Appearance")]
        public String Ingredient
        {
            get
            {
                return Ingredient;
            }
            set
            {
                Ingredients.Text = Ingredient;
            }
        }
        [Category("KG Code - Appearance")]
        public double Prices
        {
            get
            {
                return Prices;
            }
            set
            {

                Price.Text = Prices.ToString();
            }
        }

        #endregion


        public RandomHome()
        {
            InitializeComponent();
            
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {

        }
    }
}
