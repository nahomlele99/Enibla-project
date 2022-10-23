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
        public DeactivateAccount()
        {
            InitializeComponent();
        }

        private void btnSureYes_Click(object sender, EventArgs e)
        {
            try
            {


                {
                    Delivery del = new Delivery();
                    String connectionString = ConfigurationManager.ConnectionStrings["EniblaDbs"].ConnectionString;
                    SqlConnection con = new SqlConnection(connectionString);
                    del.LogedUserInfo();
                    SqlCommand cmd = new SqlCommand("DELETE  from Delivery where Email IN ('" + del.LogedUserEmail + "')", con);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    if (cmd.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show(" Deactivated SUCCESFULLY");
                        SqlCommand cmd2= new SqlCommand("DELETE  from LogedIn where Email IN ('" + del.LogedUserEmail + "')", con);
                        cmd2.ExecuteNonQuery();
                        if (cmd2.ExecuteNonQuery() == 1)
                        {
                            DeliveryLogin login = new DeliveryLogin();
                            login.Show();
                            this.Hide();

                        }  
                    }
                    con.Close();
                }
            }
            catch (SqlException)
            {

            }

        }


        private void btnYes_Click(object sender, EventArgs e)
        {
            lblConformation.Visible = true;
        }
    }
}
