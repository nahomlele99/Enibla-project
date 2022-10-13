using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Services.Description;
using System.Windows.Forms;

namespace Enibla_project
{
    class ServiceProvider
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Location { get; set; }
        public string Filename { get; set; }

        public Byte[] Images { get; set; }


        // Products products = new Products();
        // List<Products> products = new List<Products>();
        public bool save(SqlConnection c)
        {
            try
            {
                using ( c = new SqlConnection("Data Source =DESKTOP-8I5JD62\\SQLEXPRESS;Initial Catalog = EniblaDBs; Integrated Security = True;"))
                {
                    if (c.State == System.Data.ConnectionState.Closed)
                        c.Open();
                    string query = "Insert into ServiceProviders values (@Id,@Name,@UserName,@Password,@PhoneNumber,@Email,@Location,@Filename,@Images)";
                    using (SqlCommand cmd = new SqlCommand(query, c))
                    {
                        cmd.CommandType = System.Data.CommandType.Text;
                        cmd.Parameters.AddWithValue("@Id", this.Id);
                        cmd.Parameters.AddWithValue("@Name", this.Name);
                        cmd.Parameters.AddWithValue("@Username", this.UserName);
                        cmd.Parameters.AddWithValue("@Password", this.Password);
                        cmd.Parameters.AddWithValue("@PhoneNumber", this.PhoneNumber);
                        cmd.Parameters.AddWithValue("@Email", this.Email);
                        cmd.Parameters.AddWithValue("@Location", this.Location);
                        cmd.Parameters.AddWithValue("@Filename", this.Location);
                        cmd.Parameters.AddWithValue("@Images", this.Images);
                        if (cmd.ExecuteNonQuery() == 1)
                        {
                            return true;
                        }

                    }
                }
                return true;
            }
            catch(SqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;

            }


        }
    }
}
