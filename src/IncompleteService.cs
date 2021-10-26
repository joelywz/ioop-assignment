using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Assignment
{
    public class IncompleteService
    {
        public User User { get; }
        public Service Service { get; set; }
        public bool Urgent { get; set; }
        public DateTime DateTimeCreated { get; set; }

        private IncompleteService(User user, Service service, bool urgent, DateTime dateTimeCreated)
        {
            this.User = user;
            this.Service = service;
            this.Urgent = urgent;
            this.DateTimeCreated = dateTimeCreated;
        }

        /// <summary>
        /// Gets ALL incomplete services from database
        /// </summary>
        /// <returns>An array of IncompleteService</returns>
        public static IncompleteService[] GetAll()
        {
            // Preparation
            SqlConnection conn = Database.GetSqlConnection();
            BetterSqlCommand bsc = new BetterSqlCommand("SELECT * FROM [IncompleteService];", conn);

            // Execution
            conn.Open();
            SqlDataReader reader = bsc.Cmd.ExecuteReader();

            List<IncompleteService> incompleteServices = new List<IncompleteService>();

            while (reader.Read())
            {
                IncompleteService s = Reader(reader);

                incompleteServices.Add(s);
            }

            // Clean up
            reader.Close();
            bsc.Dispose();
            conn.Close();

            return incompleteServices.ToArray();
        }

        /// <summary>
        /// Gets THE incomplete service from database from a user
        /// </summary>
        /// <param name="user"></param>
        /// <returns>NULL when not found</returns>
        public static IncompleteService GetByUser(User user)
        {
            // Preperation
            SqlConnection conn = Database.GetSqlConnection();
            BetterSqlCommand bsc = new BetterSqlCommand("SELECT * FROM [IncompleteService] WHERE [userId]=@userId;", conn)
                .AddParameter<int>("@userId", System.Data.SqlDbType.Int, user.Id);

            // Execution
            conn.Open();
            SqlDataReader reader = bsc.Cmd.ExecuteReader();
            IncompleteService incompleteService = null;
            while (reader.Read())
            {
                incompleteService = Reader(reader);
                break;
            }

            // Clean up
            reader.Close();
            bsc.Dispose();
            conn.Close();

            return incompleteService;
        }

        /// <summary>
        /// To map items from SQL reader.
        /// </summary>
        /// <param name="reader"></param>
        /// <returns></returns>
        private static IncompleteService Reader(SqlDataReader reader)
        {
            User user = User.GetById((int)reader["userId"]);
            Service service = Service.GetService((int)reader["serviceId"] - 1);
            bool urgent  = (bool)reader["urgent"];
            DateTime dateTimeCreated = (DateTime)reader["dateTimeCreated"];

            IncompleteService incompleteService = new IncompleteService(user, service, urgent, dateTimeCreated);

            return incompleteService;
        }

        /// <summary>
        /// Create a service for customer.
        /// </summary>
        /// <param name="user"></param>
        /// <param name="service"></param>
        /// <param name="urgent"></param>
        /// <returns></returns>
        public static IncompleteService Save(User user, Service service, bool urgent)
        {
            // Preperation
            SqlConnection conn = Database.GetSqlConnection();
            string cmdText = "INSERT INTO [IncompleteService]([userId], [serviceId], [urgent], [dateTimeCreated]) " +
                "VALUES (@userId, @serviceId, @urgent, @dateTimeCreated)";
            BetterSqlCommand bsc = new BetterSqlCommand(cmdText, conn)
                .AddParameter<int>("@userId", System.Data.SqlDbType.Int, user.Id)
                .AddParameter<int>("@serviceId", System.Data.SqlDbType.Int, service.Id)
                .AddParameter<byte>("@urgent", System.Data.SqlDbType.Bit, Convert.ToByte(urgent))
                .AddParameter<DateTime>("@dateTimeCreated", System.Data.SqlDbType.DateTime, DateTime.Now);

            // Execution
            conn.Open();
            int rowAffected = bsc.Cmd.ExecuteNonQuery();
            Console.WriteLine("Row Affected: {0}", rowAffected);

            // Clean up
            bsc.Dispose();
            conn.Close();
            
            return IncompleteService.GetByUser(user);
        }

        public void Update()
        {
            // Preperation
            SqlConnection conn = Database.GetSqlConnection();
            string cmdText = "UPDATE [IncompleteService] " +
                "SET [userId]=@userId, [serviceId]=@serviceId, [urgent]=@urgent [dateTimeCreated]=@dateTimeCreated" +
                "WHERE [userId]=@userId";
            BetterSqlCommand bsc = new BetterSqlCommand(cmdText, conn)
                .AddParameter<int>("@userId", System.Data.SqlDbType.Int, User.Id)
                .AddParameter<int>("@serviceId", System.Data.SqlDbType.Int, Service.Id)
                .AddParameter<byte>("@urgent", System.Data.SqlDbType.Bit, Convert.ToByte(Urgent))
                .AddParameter<DateTime>("@dateTimeCreated", System.Data.SqlDbType.DateTime, DateTimeCreated);

            // Execution
            conn.Open();
            int rowAffected = bsc.Cmd.ExecuteNonQuery();
            Console.WriteLine("Row Affected: {0}", rowAffected);

            // Clean up
            bsc.Dispose();
            conn.Close();
        }

        public void Delete()
        {
            // Preperation
            SqlConnection conn = Database.GetSqlConnection();
            string cmdText = "DELETE FROM [IncompleteService] WHERE [userId]=@userId";
            BetterSqlCommand bsc = new BetterSqlCommand(cmdText, conn)
                .AddParameter<int>("@userId", System.Data.SqlDbType.Int, User.Id);

            // Exection
            conn.Open();
            int rowsAffected = bsc.Cmd.ExecuteNonQuery();
            Console.WriteLine("Rows Affected: {0}", rowsAffected);

            // Clean up
            bsc.Dispose();
            conn.Close();
        }

    }
}
