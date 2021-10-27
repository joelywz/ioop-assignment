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
        public int Id { get; }
        public string Name { get; }
        public double Price { get; }
        public double UrgentPrice { get; }

        private Service(int id, string name, double price, double urgentPrice)
        {
            Id = id;
            Name = name;
            Price = price;
            UrgentPrice = urgentPrice;
        }
       
        private static Service[] FromDb()
        {
            // Preperation
            SqlConnection conn = Database.GetSqlConnection();
            BetterSqlCommand bsc = new BetterSqlCommand("SELECT * FROM [Service];", conn);

            // Execution
            conn.Open();
            SqlDataReader reader = bsc.Cmd.ExecuteReader();
            List<Service> services = new List<Service>();
            while (reader.Read())
            {
 
                int id = (int)reader["serviceId"];
                string name = reader["name"].ToString();
                double  price = (double)reader["price"];
                double urgentPrice = (double)reader["urgentPrice"];

                Service service = new Service(id, name, price, urgentPrice);

                services.Add(service);              
            }

            Service.services = services.ToArray();

            // Clean up
            reader.Close();
            bsc.Cmd.Dispose();
            conn.Close();

            return Service.services;
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
