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
    public partial class DeliveryOrder : UserControl
    {
        public string FoodName{ get; set; }
        
        public string Destination{ get; set; }
        public string Starting{ get; set; }
        public bool Status { get; set; }
        public DeliveryOrder()
        {
            InitializeComponent();
        }

        private void DeliveryOrder_Load(object sender, EventArgs e)
        {


        }
    }
}
