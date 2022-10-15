using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Enibla_project
{
    class Products
    {
        public string ProductID { get; set; }
        public string RestaurantID { get; set; }
        public string ProductName { get; set; }
        public string Ingredients { get; set; }
        public double Price { get; set; }
        public int Amount { get; set; }
        public string ExpiryDate{ get; set; }    
        public string categorie { get; set; }
        public Image productPicture { get; set; }
        public string picFileName { get; set; }

        public static List<Products> products = new List<Products>();
<<<<<<< HEAD
        static Products inital = new Products();

        public void save()
        {
            

=======
        public static bool saveFood(Products product)
        {
            SqlConnection c;
            try
            {
                //ConfigurationManager.ConnectionStrings["EniblaDBs"].ConnectionString
                using (c = new SqlConnection("Data Source =DESKTOP-8I5JD62\\SQLEXPRESS;Initial Catalog = EniblaDBs; Integrated Security = True;"))
                {
                    if (c.State == System.Data.ConnectionState.Closed)
                        c.Open();
                    string query = "Insert into Food values (@FoodID, @FoodName, @Ingridient,@Price,@Amount,@Categorie,@RestID)";
                    using (SqlCommand cmd = new SqlCommand(query, c))
                    {
                        cmd.CommandType = System.Data.CommandType.Text;
                        cmd.Parameters.AddWithValue("@FoodID", product.ProductID);
                        cmd.Parameters.AddWithValue("@FoodName", product.ProductName);
                        cmd.Parameters.AddWithValue("@Ingridient", product.Ingredients);
                        cmd.Parameters.AddWithValue("@Price", product.Price);
                        cmd.Parameters.AddWithValue("@Amount", product.Amount);
                        cmd.Parameters.AddWithValue("@Categorie", product.categorie);
                        cmd.Parameters.AddWithValue("@RestID", product.RestaurantID);
                        

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
            //insert it to the data base
>>>>>>> 5647f5a765c9a35d5a0e7946f030ebdf1cfc53a8
        }
        public static bool saveDrink(Products product)
        {
<<<<<<< HEAD
            //featch data from a database
        }
        public void LoadToList()
        {
            //this method is called by getAll method which helps to load the data recived to copy to the list
        }
        public static Products LoadToPage(int i)
        {
            inital.ProductName = "Ertib";
            inital.picFileName = @"C:\Users\User\Pictures\tegabino ena beyaynet.jpg";
            inital.Ingredients = "dinich be alicha ena bekey tekekilo zeyit wst yinekerina keza tetebso keweta buhal kundu berbere, kororima, chaw ena rosmerin tedergo be mitmita tashto yemibela";
            inital.Price = 110.00;
            products.Add(inital);
            if (i < products.Count) {
                Products p = products.ElementAtOrDefault(i);
                return p;
            }
            return null;
        }
=======
            SqlConnection c;
            try
            {
                //ConfigurationManager.ConnectionStrings["EniblaDBs"].ConnectionString
                using (c = new SqlConnection("Data Source =DESKTOP-8I5JD62\\SQLEXPRESS;Initial Catalog = EniblaDBs; Integrated Security = True;"))
                {
                    if (c.State == System.Data.ConnectionState.Closed)
                        c.Open();
                    string query = "Insert into Drink values (@DrinkID, @DrinkName,@Categorie,@Amount, @ExpiryDate, @RestID)";
                    using (SqlCommand cmd = new SqlCommand(query, c))
                    {
                        cmd.CommandType = System.Data.CommandType.Text;
                        cmd.Parameters.AddWithValue("@DrinkID", product.ProductID);
                        cmd.Parameters.AddWithValue("@DrinkName", product.ProductName);
                        cmd.Parameters.AddWithValue("@Categorie", product.categorie);
                        cmd.Parameters.AddWithValue("@Amount", product.Amount);
                        cmd.Parameters.AddWithValue("@ExpiryDate", product.Ingredients);
                        cmd.Parameters.AddWithValue("@RestID", product.RestaurantID);


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
            //insert it to the data base
        }

        public static bool getOneDrink(SqlConnection c)
        {
            try
            {
                using (c = new SqlConnection("Data Source =DESKTOP-8I5JD62\\SQLEXPRESS;Initial Catalog = EniblaDBs; Integrated Security = True;"))
                {
                    if (c.State == System.Data.ConnectionState.Closed)
                        c.Open();
                    string query = "SELECT * FROM Drink WHERE DrinkID=@DrinkID";
                    SqlCommand command = new SqlCommand(query);
                    int result = command.ExecuteNonQuery();

                    
                    using (SqlDataReader reader = command.ExecuteReader())
                    {



                    }
                }
                return true;
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            //featch data from a data base and convert it to alist of objects
        }
        public static bool getOneFood(SqlConnection c)
        {
            try
            {
                using (c = new SqlConnection("Data Source =DESKTOP-8I5JD62\\SQLEXPRESS;Initial Catalog = EniblaDBs; Integrated Security = True;"))
                {
                    if (c.State == System.Data.ConnectionState.Closed)
                        c.Open();
                    string query = "SELECT * FROM Food WHERE FoodID=@FoodID";
                    SqlCommand command = new SqlCommand(query);
                    int result = command.ExecuteNonQuery();


                    using (SqlDataReader reader = command.ExecuteReader())
                    {



                    }
                }
                return true;
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
                
            }
            //featch data from a data base and convert it to alist of objects
        }
        public static bool DeleteFood(Products product)
        {
            SqlConnection c;
            try
            {
                using (c = new SqlConnection("Data Source =DESKTOP-8I5JD62\\SQLEXPRESS;Initial Catalog = EniblaDBs; Integrated Security = True;"))
                {
                    if (c.State == System.Data.ConnectionState.Closed)
                        c.Open();
                    SqlCommand cmd = new SqlCommand("DELETE  from  Food where FoodID IN ('" + product.ProductID + "')");
                    cmd.ExecuteNonQuery();
                    return true;




                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }

        }
        public static bool saveIngridient(Products product)
        {
            SqlConnection c;
            try
            {
                //ConfigurationManager.ConnectionStrings["EniblaDBs"].ConnectionString
                using (c = new SqlConnection("Data Source =DESKTOP-8I5JD62\\SQLEXPRESS;Initial Catalog = EniblaDBs; Integrated Security = True;"))
                {
                    if (c.State == System.Data.ConnectionState.Closed)
                        c.Open();
                    string query = "Insert into Ingridients values (@IngID, @Ingridient,@FoodID)";
                    using (SqlCommand cmd = new SqlCommand(query, c))
                    {
                        cmd.CommandType = System.Data.CommandType.Text;
                        cmd.Parameters.AddWithValue("@IngID", product.ProductID);
                        cmd.Parameters.AddWithValue("@Ingridient", product.ProductName);
                        cmd.Parameters.AddWithValue("@Ingridient", product.Ingredients);
                        cmd.Parameters.AddWithValue("@Price", product.Price);
                        cmd.Parameters.AddWithValue("@Amount", product.Amount);
                        cmd.Parameters.AddWithValue("@Categorie", product.categorie);
                        cmd.Parameters.AddWithValue("@RestID", product.RestaurantID);


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
            //insert it to the data base
        }
        //public static IEnumerable<Products> Load()
        //{
        //     foreach(Products i in products){
        //yield return i;
        //}

        //loads the data initaly to the list in order to do search and other staff from it
        //it is also helpfull for auto suggestion part
        //}
>>>>>>> 5647f5a765c9a35d5a0e7946f030ebdf1cfc53a8

    }
}
