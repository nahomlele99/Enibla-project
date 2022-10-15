using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enibla_project
{
    class Products
    {
        public String ProductID { get; set; }
        public string HotelID { get; set; }
        public string ProductName { get; set; }
        public string Ingredients { get; set; }
        public double Price { get; set; }
        public int Amount { get; set; }
        public bool status { get; set; }    
        public string categorie { get; set; }
        public Image productPicture { get; set; }
        public string picFileName { get; set; }

        public static List<Products> products = new List<Products>();
        static Products inital = new Products();

        public void save()
        {
            

        }
        public void getAll()
        {
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

    }
}
