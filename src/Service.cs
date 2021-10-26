using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Assignment
{
    public class Service
    {
        private static Service[] services = { };
        public int Id { get; }
        public string Name { get; }
        public double Price { get; }
        public double UrgentPrice { get; }

        private Service(int id, string name, double price, double urgentPrice)
        {
            Id = id;
        }
       
        private static Service[] FromDb()
        {
            // Create SQL connection
            SqlConnection conn = Database.GetSqlConnection();
            conn.Open();

            // Create SQL command
            SqlCommand cmd = new SqlCommand("SELECT * FROM [Service];", conn);

            // Create SQL reader
            SqlDataReader reader = cmd.ExecuteReader();

            List<Service> services = new List<Service>();
            services.Clear();

            while (reader.Read())
            {
 
                int id = (int)reader["serviceId"];
                string name = (string)reader["name"];
                double  price = (double)reader["price"];
                double urgentPrice = (double)reader["urgentPrice"];

                Service service = new Service(id, name, price, urgentPrice);

                services.Add(service);              
            }

            return services.ToArray();
        }

        /// <summary>
        /// Get service from database.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static Service GetService(int id)
        {
            if (services == null)
                services = FromDb();
            return services[id - 1];
        }
        
    }
}
