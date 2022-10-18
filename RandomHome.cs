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
        Products p;
        public RandomHome()
        {
            InitializeComponent();
            p =Dashboard.LoadToPage(0);

            ProductName.Text = p.ProductName;
            ProductPic.Image = p.productPicture;
            ProductPic.ImageLocation = p.picFileName;
            Ingredients.Text = p.Ingredients;
            Price.Text = p.Price.ToString();

        }
    }
}
