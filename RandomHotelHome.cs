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
    public partial class RandomHotelHome : UserControl
    {
        public RandomHotelHome()
        {
            InitializeComponent();
        }

        private void clickForHotel(object sender, EventArgs e)
        {
            MessageBox.Show("shows other hotel");
        }
    }
}
