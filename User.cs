using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enibla_project
{
    public class User
    {
        public string FullName { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Phonenumber { get; set; } 
        public bool gender { get; set; }

        public string Filename  { get; set; }  
        
        public Byte [] Images { get; set; }
        public string Email { get; set; }

        public List<User> users = new List<User>();
        public void save()
        {
            // to save on the list and as well as to load it on data base
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
