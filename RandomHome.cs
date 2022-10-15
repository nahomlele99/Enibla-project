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
        
        private string _ProductName;
        private string _Ingredients;
        private Image _ProductPic;
        private double _Price;
        private string _filename;
        Products p;

        [Category("KG Code - Appearance")]
        public  String ProductNames {
            get
            {
               return _ProductName;
            }
            set
            {
                _ProductName = p.ProductName;
                ProductName.Text = p.ProductName;
            } 
        }
        [Category("KG Code - Appearance")]
        public Image ProductPics
        {
            get
            {
                return _ProductPic;
            }
            set
            {
                _ProductPic = p.productPicture;
                ProductPic.Image = p.productPicture;
            }
        }
        [Category("KG Code - Appearance")]
        public string FileName
        {
            get
            {
                return _filename;
            }
            set
            {
                _filename= p.picFileName;
                ProductPic.ImageLocation = p.picFileName;

            }
        }
        [Category("KG Code - Appearance")]
        public String Ingredient
        {
            get
            {
                return _Ingredients;
            }
            set
            {
                _Ingredients = p.Ingredients;
                Ingredients.Text = p.Ingredients;
            }
        }
        [Category("KG Code - Appearance")]
        public double Prices
        {
            get
            {
                return _Price;
            }
            set
            {
                _Price = p.Price;
                Price.Text = p.Price.ToString();
            }
        }

        #endregion
        public RandomHome()
        {
            InitializeComponent();
            p =Products.LoadToPage(0);
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            //order page is loaded with the drinks manuall
        }
    }
}
