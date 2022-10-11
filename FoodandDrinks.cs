using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Enibla_project
{
    public class FoodandDrinks
    {
        public  int HotelID { get; set; }
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public string Ingridents { get; set; }
        public decimal Price { get; set; }
        public string GoodType{ get; set; }
        public string Filename { get; set; }
        public byte[] Images { get; set; }
        public int bread { get; set; }
        public int egg { get; set; }
        public string cheese { get; set; }
        public string redwine { get; set; }
        public string coca { get; set; }
        public int pasta{ get; set; }

        private static List<FoodandDrinks> list = new List<FoodandDrinks>();

        public FoodandDrinks SearchProductsByName(string ProductsName, List<FoodandDrinks> products)

        {

            FoodandDrinks pd = products.SingleOrDefault(p => p.ProductName == ProductsName);


            return pd;
        }

        public List<FoodandDrinks> DisplayAll()
        {

            return list;
        }
        public List<FoodandDrinks> findOne(string ProductsName)
        {
            return DisplayAll().FindAll(p => p.ProductName == ProductsName);

        }
        public void AddProducts()
        {
            string path = "Data Source= DESKTOP-8I5JD62\\SQLEXPRESS;Initial Catalog= AvailableProducts;Integrated security=true;";
            string query2 = "insert into AvailableProducts([PrCode],[PrName],[Pr.Quantity]) values(112,'Milk',200),(113,'Sugar',30)";
            string query1 = "SET IDENTITY_INSERT AvailableProducts ON";
            SqlConnection conn;
            conn = new SqlConnection(path);
            conn.Open();
            SqlCommand cmd;
            cmd = new SqlCommand(query1, conn);
            cmd.ExecuteNonQuery();
            cmd = new SqlCommand(query2, conn);
            cmd.ExecuteNonQuery();



        }

        public List<FoodandDrinks> Displayy()
        {
                
                string path = "Data Source= DESKTOP-8I5JD62\\SQLEXPRESS;Initial Catalog= FoodandDrinks;Integrated security=true;";
                string query = "SELECT * FROM Ingridients";
                SqlConnection conn;
                conn = new SqlConnection(path);
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                var result = cmd.ExecuteReader();
                List<FoodandDrinks> temp = new List<FoodandDrinks>();
                while (result.Read())
                {
                    FoodandDrinks fd = new FoodandDrinks();
                    fd.bread = Convert.ToInt32(result["Bread"]);

                    fd.egg = Convert.ToInt32(result["Egg"]);
                    fd.cheese = result["Cheese"].ToString();
                    fd.redwine = result["RedWine"].ToString();
                    fd.coca = result["Coca"].ToString();
                    fd.pasta = Convert.ToInt32(result["Pasta"]);


                    temp.Add(fd);
                


            }
                return temp;
           
            
        }
        // private void card_click(object o ,)
    

}
}
