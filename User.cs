using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Enibla_project
{
    public class User
    {
        public string FullName { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Phonenumber { get; set; }
        public char Gender { get; set; }

        public string Filename { get; set; }

        public Byte[] Images { get; set; }
        public string Email { get; set; }

        public static List<User> users = new List<User>();
        public bool save(SqlConnection c)
        {
            try
            {
                //ConfigurationManager.ConnectionStrings["EniblaDBs"].ConnectionString
                using (c = new SqlConnection("Data Source =DESKTOP-8I5JD62\\SQLEXPRESS;Initial Catalog = EniblaDBs; Integrated Security = True;"))
                {
                    if (c.State == System.Data.ConnectionState.Closed)
                        c.Open();
                    string query = "Insert into Users(Username,Password,Fullname,Phonenumber,Email,Gender,Filename,Images) values (@Username, @Password, @Fullname, @Phonenumber, @Email, @Gender, @Filename,@Images)";
                    using (SqlCommand cmd = new SqlCommand(query, c))
                    {
                        cmd.CommandType = System.Data.CommandType.Text;
                        cmd.Parameters.AddWithValue("@Username", this.Username);
                        cmd.Parameters.AddWithValue("@Password", this.Password);
                        cmd.Parameters.AddWithValue("@Fullname", this.FullName);
                        cmd.Parameters.AddWithValue("@Phonenumber", this.Phonenumber);
                        cmd.Parameters.AddWithValue("@Email", this.Email);
                        cmd.Parameters.AddWithValue("@Gender", this.Gender);
                        cmd.Parameters.AddWithValue("@Filename", this.Filename);
                        cmd.Parameters.AddWithValue("@Images", this.Images);

                        if (cmd.ExecuteNonQuery() == 1)
                        {
                            return true;
                        }
                      
                    }
                }
                return true;
            }

            catch (SqlException ex)
            {
                
                MessageBox.Show(ex.Message);
                return false;


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
