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
        private static Service[] services = null;
        public int id;
        public string name;
        public double price;
        public double urgentPrice;
       
        private static Service[] FromDb()
        {
            // Create SQL connection
            SqlConnection conn = Database.GetSqlConnection();
            conn.Open();

            // Create SQL command
            SqlCommand cmd = new SqlCommand("SELECT * FROM [Service];", conn);

            // Create SQL reader
            SqlDataReader reader = cmd.ExecuteReader();

            Service[] services = { };

            while (reader.Read())
            {
                Service service = new Service();
                service.id = (int)reader["serviceId"];
                service.name = reader["name"].ToString();
                service.price = (double)reader["price"];
                service.urgentPrice = (double)reader["urgentPrice"];

                Array.Resize(ref services, services.Length + 1);
                services[services.Length - 1] = service;
              
            }

            return services;
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
