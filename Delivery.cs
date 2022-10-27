using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Services.Description;
using System.Windows.Forms;
using System.Xml.Linq;

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

        public string PicFile { get; set; }


        public static List<Delivery> deliveryMan = new List<Delivery>();
        
        public bool save()
        {
            try
            {
                using (SqlConnection c = new SqlConnection(ConfigurationManager.ConnectionStrings["EniblaDBs"].ConnectionString))
                {
                    if (c.State == System.Data.ConnectionState.Closed)
                        c.Open();
                    string query = "Insert into Delivery values (@Username, @Password, @Fullname, @Phonenumber, @Email, @PicFile, @Avatar,@Gender)";
                    using (SqlCommand cmd = new SqlCommand(query, c))
                    {
                        cmd.CommandType = System.Data.CommandType.Text;
                        cmd.Parameters.AddWithValue("@Username", this.Username);
                        cmd.Parameters.AddWithValue("@Password", this.Password);
                        cmd.Parameters.AddWithValue("@Fullname", this.FullName);
                        cmd.Parameters.AddWithValue("@Phonenumber", this.Phonenumber);
                        cmd.Parameters.AddWithValue("@Email", this.Email);
                        cmd.Parameters.AddWithValue("@PicFile", this.PicFile);
                        cmd.Parameters.AddWithValue("@Avatar", this.Avatar);
                        cmd.Parameters.AddWithValue("@Gender", this.gender);


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
        public bool UpdateLogedUser()
        {


            try
            {
                using (SqlConnection c = new SqlConnection(ConfigurationManager.ConnectionStrings["EniblaDBs"].ConnectionString))
                {
                    if (c.State == System.Data.ConnectionState.Closed)
                        c.Open();
                    string query = "UPDATE Delivery SET Password= '" + this.Password + "',Fullname='" + this.FullName + "',Phonenumber= '" + this.Phonenumber+ "',Email='" + this.Email + "',PicFile= '" + this.PicFile + "',Picture= '" +this.Avatar+ "',Gender= '"+ this.gender + "' WHERE Username= '" + this.Username + "'";
                    using (SqlCommand cmd = new SqlCommand(query, c))
                    {
                        SqlDataReader reader = cmd.ExecuteReader();
                        MessageBox.Show("Successfully Updated");

                        return true;
                    }
                }
                
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
        public bool DeleteLogedUser()
        {


            try
            {
                using (SqlConnection c = new SqlConnection(ConfigurationManager.ConnectionStrings["EniblaDBs"].ConnectionString))
                {
                    if (c.State == System.Data.ConnectionState.Closed)
                        c.Open();
                    string query = "delete from Delivery where Username='" + this.Username + "';";
                    using (SqlCommand cmd = new SqlCommand(query, c))
                    {
                        SqlDataReader reader = cmd.ExecuteReader();
                        MessageBox.Show("Successfully Deleted");

                        return true;
                    }
                }

            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
        public static void getAll()
        {

            try
            {
                using (SqlConnection c = new SqlConnection(ConfigurationManager.ConnectionStrings["EniblaDBs"].ConnectionString))
                {
                    if (c.State == System.Data.ConnectionState.Closed)
                        c.Open();
                    string query = "SELECT * FROM Delivery ";
                    using (SqlCommand cmd = new SqlCommand(query, c))
                    {
                        SqlDataReader reader = cmd.ExecuteReader();


                        while (reader.Read())
                        {
                            deliveryMan.Add(new Delivery()
                            {
                            FullName = reader["Fullname"].ToString(),
                            Username = reader["Username"].ToString(),
                            Password = reader["Password"].ToString(),
                            Phonenumber = reader["Phonenumber"].ToString(),
                            Email = reader["Email"].ToString(),
                            gender = Convert.ToChar(reader["Gender"]),
                            Avatar = (Byte[])reader["Picture"],
                            PicFile = reader["PicFile"].ToString(),

                        });
                            
                        }

                    }
                    
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
                

            }
        }
       
    }
}
