using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Enibla_project
{
    public class Delivery
    {
        public string FullName { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Phonenumber { get; set; }
        public char gender { get; set; }
        public bool AcceptOrder { get; set; }
        

        public Byte[] Avatar { get; set; }
        public string Email { get; set; }

        public static List<User> users = new List<User>();
        public bool save()
        {
            try
            {
                using (SqlConnection c = new SqlConnection(ConfigurationManager.ConnectionStrings["EniblaDBs"].ConnectionString))
                {
                    if (c.State == System.Data.ConnectionState.Closed)
                        c.Open();
                    string query = "Insert into Delivery values (@Username, @Password, @Fullname, @Phonenumber, @Email )";
                    using (SqlCommand cmd = new SqlCommand(query, c))
                    {
                        cmd.CommandType = System.Data.CommandType.Text;
                        cmd.Parameters.AddWithValue("@Username", this.Username);
                        cmd.Parameters.AddWithValue("@Password", this.Password);
                        cmd.Parameters.AddWithValue("@Fullname", this.FullName);
                        cmd.Parameters.AddWithValue("@Phonenumber", this.Phonenumber);
                        cmd.Parameters.AddWithValue("@Email", this.Email);
                       

                        if (cmd.ExecuteNonQuery() == 1)
                        {
                            return true;
                        }
                        
                    }
                    return true;
                }
            }catch(SqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
                
            }

        }

        public void getAll()
        {
            
            
        }
        public void load()
        {
            // load it from the data base to the list
        }
    }
}
