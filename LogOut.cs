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
        public LogOut()
        {
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
            Delivery del = new Delivery();
            panelLogOut.Visible = false;
            MessageBox.Show(del.LogedUserEmail);
            try
            {
                
                using (SqlConnection c = new SqlConnection(ConfigurationManager.ConnectionStrings["EniblaDBs"].ConnectionString))
                {
                    if (c.State == System.Data.ConnectionState.Closed)
                        c.Open();
                    string query = "SELECT * FROM LogedIn";
                    using (SqlCommand cmd = new SqlCommand(query, c))
                    {
                        SqlDataReader reader = cmd.ExecuteReader();
                        if (reader.Read())
                        {
                            del.LogedUserEmail = reader.GetValue(0).ToString();

                        }
                       SqlCommand cmd2 = new SqlCommand("DELETE  from LogedIn where Email IN ('" + del.LogedUserEmail + "')", c);
                        cmd2.ExecuteNonQuery();
                       
                            MessageBox.Show("  LOGGED OUT SUCCESFULLY");
                            DeliveryLogin login = new DeliveryLogin();
                            login.Show();
                            this.Hide();
                        
                        
                    }
                    c.Close();
                }
               
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }



           

        }

        private void btnSureNo_Click(object sender, EventArgs e)
        {
            panelConformation.Visible = false;
        }
    }
}
