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

        public void save()
        {
            //insert it to the data base
        }
        public void getAll()
        {
            //featch data from a data base and convert it to alist of objects
        }
        public static void load()
        {
            //loads the data initaly to the list in order to do search and other staff from it
            //it is also helpfull for auto suggestion part
        }

    }
}
