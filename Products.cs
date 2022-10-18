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
    public class Products
    {
        public string ProductID { get; set; }
        public string ServiceProviderId { get; set; }
        public string ProductName { get; set; }
        public string Ingredients { get; set; }
        public double Price { get; set; }
        public int Amount { get; set; }
        public bool status { get; set; }    
        public string categorie { get; set; }
        public Image productPicture { get; set; }
        public string picFileName { get; set; }


        public static List<Products> products = new List<Products>();


        public bool save()
        {
            using (SqlConnection c = new SqlConnection(ConfigurationManager.ConnectionStrings["EniblaDBs"].ConnectionString))
            {
                if (c.State == System.Data.ConnectionState.Closed)
                    c.Open();
                string query = "Insert into Users values (@ProductID, @ServiceProviderId, @ProductName, @Ingredients, @Price, @Amount, @Status,@Categorie,@ProductPicture,@ProFileName)";
                using (SqlCommand cmd = new SqlCommand(query, c))
                {
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.Parameters.AddWithValue("@ProductID", this.ProductID);
                    cmd.Parameters.AddWithValue("@ServiceProviderId", this.ServiceProviderId);
                    cmd.Parameters.AddWithValue("@ProductName", this.ProductName);
                    cmd.Parameters.AddWithValue("@Ingredients", this.Ingredients);
                    cmd.Parameters.AddWithValue("@Price", this.Price);
                    cmd.Parameters.AddWithValue("@Amount", this.Amount);
                    cmd.Parameters.AddWithValue("@Status", this.status);
                    cmd.Parameters.AddWithValue("@Categorie", this.categorie);
                    cmd.Parameters.AddWithValue("@ProductPicture", this.productPicture);
                    cmd.Parameters.AddWithValue("@ProFileName", this.picFileName);

                    if (cmd.ExecuteNonQuery() == 1)
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
            //featch data from a database
        }
        public void LoadToList()
        {
            //this method is called by getAll method which helps to load the data recived to copy to the list
        }

    }
}
