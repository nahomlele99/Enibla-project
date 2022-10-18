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
    public class ServiceProvider
    {
        public string ServiceProviderId { get; set; }
        public string ServiceProviderName { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Location { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string LogoFile { get; set; }
        public Byte[] Logo { get; set; }

        public static List<ServiceProvider> services = new List<ServiceProvider>();

        public bool save()
        {
            using (SqlConnection c = new SqlConnection(ConfigurationManager.ConnectionStrings["EniblaDBs"].ConnectionString))
            {
                if (c.State == System.Data.ConnectionState.Closed)
                    c.Open();
                string query = "Insert into SerciceProvider values (@ServiceProviderId, @ServiceProviderId, @Username, @Password, @Location, @Address, @PhoneNumber, @Email, @LogoFile, @Logo)";
                using (SqlCommand cmd = new SqlCommand(query, c))
                {
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.Parameters.AddWithValue("@ServiceProviderId", this.ServiceProviderId);
                    cmd.Parameters.AddWithValue("@ServiceProviderName", this.ServiceProviderName);
                    cmd.Parameters.AddWithValue("@Username", this.Username);
                    cmd.Parameters.AddWithValue("@Password", this.Password);
                    cmd.Parameters.AddWithValue("@Location", this.Location);
                    cmd.Parameters.AddWithValue("@Address", this.Address);
                    cmd.Parameters.AddWithValue("@PhoneNumber", this.PhoneNumber);
                    cmd.Parameters.AddWithValue("@Email", this.Email);
                    cmd.Parameters.AddWithValue("@LogoFile", this.LogoFile);
                    cmd.Parameters.AddWithValue("@Logo", this.Logo);

                    if (cmd.ExecuteNonQuery() == 1)
                    {
                        return true;
                    }
                    else
                        return false;
                }
            }
        }
    }

}
