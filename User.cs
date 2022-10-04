using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enibla_project
{
    class User
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string Fullname { get; set; }
        public string Phonenumber { get; set; }
        public string Email { get; set; }
        public bool gender { get; set; }
        public string Filename { get; set; }
        public byte[] Images { get; set; }

        public static List<User> users = new List<User>();
        
        public void save()
        {
            //its used to save on the list and on the database as well
        }
        public  void getAll()
        {
            //its used to getAll the lists from the database
        }
        public void load()
        {
            // used for loading the database to the list or to the class instance (object)
        }

        


    }
}
