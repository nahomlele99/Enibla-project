using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Enibla_project
{
    public partial class LogOut : Form
    {
        Delivery dm;
        public LogOut(Delivery del)
        {
            dm = del;
            InitializeComponent();
          
        }
       
        private void btnYes_Click(object sender, EventArgs e)
        {
            panelConformation.Visible = true;
            
        }

        private void btnNo_Click(object sender, EventArgs e)
        {

        }

        private void btnSureYes_Click(object sender, EventArgs e)
        {
            loginPage LP = new loginPage();
            HomeDelievry.form.Hide();
            LP.Show();
            this.Close();


         

        }

        private void btnSureNo_Click(object sender, EventArgs e)
        {
            panelConformation.Visible = false;
        }
    }
}
