using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enibla_project
{
    public class Dashboard
    {

        public static List<Products> CurrentHotelPro = new List<Products>();
        
        static Products inital = new Products();


        static ServiceProvider initalSP = new ServiceProvider();
        
        static bool HomeProductDash(string hotelid)
        {
            using (SqlConnection c = new SqlConnection(ConfigurationManager.ConnectionStrings["EniblaDBs"].ConnectionString))
            {
                if (c.State == System.Data.ConnectionState.Closed)
                    c.Open();
                string query = "select * from Products where ServiceProviderId =" + hotelid;
                using (SqlCommand cmd = new SqlCommand(query, c))
                {
                    SqlDataReader sdr = cmd.ExecuteReader();
                    if (sdr.Read())
                    {
                        foreach (Products i in sdr)
                        {
                            CurrentHotelPro.Add(i);
                        }
                        return true;
                    }
                    else
                        return false;
                }

            }
        }
        static bool HomeHotelDash()
        {
            using (SqlConnection c = new SqlConnection(ConfigurationManager.ConnectionStrings["EniblaDBs"].ConnectionString))
            {
                if (c.State == System.Data.ConnectionState.Closed)
                    c.Open();
                string query = "select * from ServiceProvider";
                using (SqlCommand cmd = new SqlCommand(query, c))
                {
                    SqlDataReader sdr = cmd.ExecuteReader();
                    if (sdr.Read())
                    {
                        foreach (ServiceProvider i in sdr)
                        {
                            ServiceProvider.services.Add(i);
                        }
                        return true;
                    }
                    else
                        return false;
                }
            }
        }
        static int RandomHotel()
        {
            Random rand = new Random();
            return rand.Next(0,ServiceProvider.services.Count);

        }
        public static bool both()
        {
            if (HomeHotelDash())
            {
                string randHotel = ServiceProvider.services[0].ServiceProviderName;//.ElementAt(RandomHotel()).ServiceProviderId;  //;
                if (HomeProductDash(randHotel))
                return true;
                else return false;
            }
            else return false;
        }
        public static Products LoadToPage(int i)
        {
            inital.ProductName = "Beyanet";
            inital.picFileName = @"C:\Users\User\Pictures\tegabino ena beyaynet.jpg";
            inital.Ingredients = "dinich be alicha ena bekey tekekilo zeyit wst yinekerina keza tetebso keweta buhal kundu berbere, kororima, chaw ena rosmerin tedergo be mitmita tashto yemibela";
            inital.Price = 110.00;

            CurrentHotelPro.Add(inital);

            if (i < CurrentHotelPro.Count)
            {
                return CurrentHotelPro.ElementAtOrDefault(i);
                
            }
            return null;
        }
        public static ServiceProvider SelectedProduct()
        {
            initalSP.ServiceProviderName = "Sheraton Addis";
            initalSP.ServiceProviderId = "Blabal";
            initalSP.LogoFile = @"C:\Users\User\Pictures\tegabino ena beyaynet.jpg";
            initalSP.Email = "Blablablabla@BABA.com";
            initalSP.Address = "Its okay Addis Ababa";
            ServiceProvider.services.Add(initalSP);

            return ServiceProvider.services[0];
        }
    }
}
