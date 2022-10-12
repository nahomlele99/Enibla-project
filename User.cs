using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enibla_project
{
    public class User
    {
        public string FullName { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Phonenumber { get; set; }
        public char gender { get; set; }

        public string Filename { get; set; }

        public Byte[] Images { get; set; }
        public string Email { get; set; }

        public List<User> users = new List<User>();
        public bool save()
        {
            using (SqlConnection c = new SqlConnection(ConfigurationManager.ConnectionStrings["EniblaDBs"].ConnectionString))
            {
                if (c.State == System.Data.ConnectionState.Closed)
                    c.Open();
                string query = "Insert into Users values (@Username, @Password, @Fullname, @Phonenumber, @Email, @Gender, @Filename,@Image)";
                using (SqlCommand cmd = new SqlCommand(query, c))
                 {
                         cmd.CommandType = System.Data.CommandType.Text;
                         cmd.Parameters.AddWithValue("@Username", this.Username);
                         cmd.Parameters.AddWithValue("@Password", this.Password);
                         cmd.Parameters.AddWithValue("@Fullname", this.FullName);
                         cmd.Parameters.AddWithValue("@Phonenumber", this.Phonenumber);
                         cmd.Parameters.AddWithValue("@Email", this.Email);
                         cmd.Parameters.AddWithValue("@Gender", this.gender);
                         cmd.Parameters.AddWithValue("@Filename", this.Filename);
                         cmd.Parameters.AddWithValue("@Image", this.Images);
                         
                    if( cmd.ExecuteNonQuery() == 1)
                          {
                        return true;
                          }
                    else
                        return false;
                }
            }
        
        }

        public void getAll()
        {
           // to getAll from the database
        }
        public void load()
        {
            // load it from the data base to the list
        }
    }
}
