using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Enibla_project
{
    public partial class DeactivateAccount : Form
    {
        Delivery dm;
        public DeactivateAccount(Delivery del)
        {
            dm = del;
            InitializeComponent();
        }

        


        private void btnYes_Click(object sender, EventArgs e)
        {
            string Title = "Delete";
            string msg = "Are you sure you want to delete";
            MessageBoxButtons btn = MessageBoxButtons.YesNo;
            MessageBoxIcon icon = MessageBoxIcon.Error;
            DialogResult result = MessageBox.Show(msg,Title,btn,icon);
            if (result == DialogResult.Yes)
            {
                dm.DeleteLogedUser();
                loginPage LP = new loginPage();
                HomeDelievry.form.Hide();
                LP.Show();
                this.Close();

            }
            
         
        }
    }
}
