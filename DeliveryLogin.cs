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
using static System.ComponentModel.Design.ObjectSelectorEditor;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Enibla_project
{
    public partial class DeliveryLogin : Form
    {
        public DeliveryLogin()
        {
            InitializeComponent();
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            DeliverySignUp form = new DeliverySignUp();
            form.Show();
            this.Hide();
             
        }

        private void DelievryLogin_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection c = new SqlConnection(ConfigurationManager.ConnectionStrings["EniblaDBs"].ConnectionString))
                {
                    if (c.State == System.Data.ConnectionState.Closed)
                        c.Open();
                    string query = "select * from Delivery where Email = @Email And Password = @Password";
                    using (SqlCommand cmd = new SqlCommand(query, c))
                    {
                        cmd.CommandType = System.Data.CommandType.Text;
                        cmd.Parameters.AddWithValue("@Email",Email.Texts);
                        cmd.Parameters.AddWithValue("@Password", Pword.Texts);
                        Console.WriteLine(query);

                        if (cmd.ExecuteReader().Read())
                        {

                            
                            var mergeQuery = "INSERT INTO LogedIn(Username,Password,Fullname,Phonenumber,Email) SELECT * FROM Delivery WHERE Delivery.Email NOT IN(SELECT Email FROM LogedIn)";
                            using (var mergeCommand = new SqlCommand(mergeQuery, c))
                            {
                                mergeCommand.ExecuteNonQuery();
                            }
                            HomeDelievry form = new HomeDelievry();
                            form.Show();
                            this.Hide();
                                
                              
                        }                              
                    }
                }
            }catch(SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void label8_MouseHover(object sender, EventArgs e)
        {
           label8.Font = new Font(label8.Font.Name, 13, FontStyle.Regular);
        }

        private void label8_MouseLeave(object sender, EventArgs e)
        {
            label8.Font = new Font(label8.Font.Name, 12, FontStyle.Regular);
        }
    }
}
