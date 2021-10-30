using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Assignment
{
    public class CompletedService
    {
        public int Id { get; }
        public User User { get; }
        public User CompletedBy { get; }
        public Service Service { get; }
        public bool Urgent { get; }
        public double Price { get;  }
        public string Description { get; }
        public bool HasPaid { get; set; }
        public DateTime DateTimeCreated { get; }
        public DateTime DateTimeCompleted { get; }

        private CompletedService(int id, User user, User completedBy, Service service, bool urgent, double price, bool hasPaid, string description, DateTime created, DateTime completed)
        {
            this.Id = id;
            this.User = user;
            this.CompletedBy = completedBy;
            this.Service = service;
            this.Urgent = urgent;
            this.Price = price;
            this.HasPaid = hasPaid;
            this.Description = description;
            this.DateTimeCreated = created;
            this.DateTimeCompleted = completed;
        }

        /// <summary>
        /// Create a complete service from Incomplete service. It also deletes the entry of incomplete service in database.
        /// This is how you should create a CompleteService
        /// </summary>
        /// <param name="incompleteService"></param>
        /// <param name="completedBy"></param>
        /// <param name="description"></param>
        /// <param name="dateTimeCompleted"</param>
        /// <returns>CompletedService</returns>
        public static CompletedService Save(IncompleteService incompleteService, User completedBy, string description, DateTime dateTimeCompleted)
        {
            int userId = incompleteService.User.Id;
            int completedByUserId = completedBy.Id;
            int serviceId = incompleteService.Service.Id;
            bool urgent = incompleteService.Urgent;
            DateTime dateTimeCreated = incompleteService.DateTimeCreated;
            double price = urgent ? incompleteService.Service.UrgentPrice : incompleteService.Service.Price;

            // Delete incomplete service
            incompleteService.Delete();

            // Preperation
            SqlConnection conn = Database.GetSqlConnection();
            string cmdText =
                "INSERT INTO [CompletedService]([userId], [completedByUserId], [serviceId], [urgent], [price], [description], [dateTimeCreated], [dateTimeCompleted]) " +
                "VALUES(@userId, @completedByUserId, @serviceId, @urgent, @price, @description, @dateTimeCreated, @dateTimeCompleted);" +
                "SELECT SCOPE_IDENTITY();";
            BetterSqlCommand bsc = new BetterSqlCommand(cmdText, conn)
                .AddParameter<int>("@userId", System.Data.SqlDbType.Int, userId)
                .AddParameter<int>("@completedByUserId", System.Data.SqlDbType.Int, completedByUserId)
                .AddParameter<int>("@serviceId", System.Data.SqlDbType.Int, serviceId)
                .AddParameter<byte>("@urgent", System.Data.SqlDbType.Bit, Convert.ToByte(urgent))
                .AddParameter<double>("@price", System.Data.SqlDbType.Float, price)
                .AddParameter<string>("@description", System.Data.SqlDbType.Text, description)
                .AddParameter<DateTime>("@dateTimeCreated", System.Data.SqlDbType.DateTime, dateTimeCreated)
                .AddParameter<DateTime>("@dateTimeCompleted", System.Data.SqlDbType.DateTime, dateTimeCompleted);

            // Execution
            conn.Open();
            int completedServiceId = Convert.ToInt32(bsc.Cmd.ExecuteScalar());

            // Clean up
            bsc.Dispose();
            conn.Close();
            return CompletedService.GetById(completedServiceId);
        }


        /// <summary>
        /// Create a complete service from Incomplete service. It also deletes the entry of incomplete service in database.
        /// Automatically sets completed DateTime to current DateTime
        /// </summary>
        /// <param name="incompleteService"></param>
        /// <param name="completedBy"></param>
        /// <param name="description"></param>
        /// <returns>CompletedService</returns>
        public static CompletedService Save(IncompleteService incompleteService, User completedBy, string description)
        {
            return CompletedService.Save(incompleteService, completedBy, description, DateTime.Now);
        }

        /// <summary>
        /// Get a CompletedService by id
        /// </summary>
        /// <param name="id"></param>
        /// <returns>null when not found</returns>
        public static CompletedService GetById(int id)
        {
            // Preperation
            SqlConnection conn = Database.GetSqlConnection();
            string cmdText = "SELECT * FROM [CompletedService] WHERE [completedServiceId]=@completedServiceId; ";
            BetterSqlCommand bsc = new BetterSqlCommand(cmdText, conn)
                .AddParameter<int>("@completedServiceId", System.Data.SqlDbType.Int, id);

            // Execution
            conn.Open();
            SqlDataReader reader = bsc.Cmd.ExecuteReader();

            CompletedService cs = null;
            while (reader.Read())
            {
                cs = Reader(reader);
                break;
            }

            // Clean up
            reader.Close();
            bsc.Dispose();
            conn.Close();

            return cs;
        }

        /// <summary>
        /// Get an array of CompletedService by a user
        /// </summary>
        /// <param name="user"></param>
        /// <returns>An array of CompletedService</returns>
        public static CompletedService[] GetByUser(User user)
        {
            // Preperation
            SqlConnection conn = Database.GetSqlConnection();
            string cmdText = "SELECT * FROM [CompletedService] WHERE [userId]=@userId;";
            BetterSqlCommand bsc = new BetterSqlCommand(cmdText, conn)
                .AddParameter<int>("@userId", System.Data.SqlDbType.Int, user.Id);

            // Execution
            conn.Open();
            SqlDataReader reader = bsc.Cmd.ExecuteReader();

            List<CompletedService> cs = new List<CompletedService>();
            while (reader.Read())
            {
                cs.Add(Reader(reader));
            }

            // Clean up
            reader.Close();
            bsc.Dispose();
            conn.Close();

            return cs.ToArray();
        }

        public static CompletedService[] GetByDate(DateTime start, DateTime end)
        {
            // Preperation
            SqlConnection conn = Database.GetSqlConnection();
            string cmdText = "SELECT * FROM [CompletedService] WHERE [dateTimeCompleted] BETWEEN @start AND @end;";
            BetterSqlCommand bsc = new BetterSqlCommand(cmdText, conn)
                .AddParameter<DateTime>("@start", System.Data.SqlDbType.DateTime, start)
                .AddParameter<DateTime>("@end", System.Data.SqlDbType.DateTime, end);

            // Execution
            conn.Open();
            SqlDataReader reader = bsc.Cmd.ExecuteReader();

            List<CompletedService> cs = new List<CompletedService>();
            while (reader.Read())
            {
                cs.Add(Reader(reader));
            }

            // Clean up
            reader.Close();
            bsc.Dispose();
            conn.Close();

            return cs.ToArray();
        }

        /// <summary>
        /// Gets the number of unpaid service.
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public static int GetUnpaidCount(User user)
        {
            // Preperation
            SqlConnection conn = Database.GetSqlConnection();
            string cmdText = "SELECT COUNT([completedServiceId]) FROM [CompletedService] WHERE [userId]=@userId AND [hasPaid]=0;";
            BetterSqlCommand bsc = new BetterSqlCommand(cmdText, conn)
                .AddParameter<int>("@userId", System.Data.SqlDbType.Int, user.Id);

            // Execution
            conn.Open();
            int count = Convert.ToInt32(bsc.Cmd.ExecuteScalar());

            // Clean up
            bsc.Dispose();
            conn.Close();

            return count;
        }

        private static CompletedService Reader(SqlDataReader reader)
        {
            int completedServiceId = Convert.ToInt32(reader["completedServiceId"]);
            User user = User.GetById(Convert.ToInt32(reader["userId"]));
            User completedBy = User.GetById(Convert.ToInt32(reader["completedByUserId"]));
            Service service = Service.GetService(Convert.ToInt32(reader["serviceId"]));
            bool urgent = (bool)reader["urgent"];
            bool hasPaid = (bool)reader["hasPaid"];
            double price = Convert.ToDouble(reader["price"]);
            string description = reader["description"].ToString();
            DateTime created = (DateTime)reader["dateTimeCreated"];
            DateTime completed = (DateTime)reader["dateTimeCompleted"];

            return new CompletedService(completedServiceId, user, completedBy, service, urgent, price, hasPaid, description, created, completed);
            

        }

        public void Update()
        {
            // Since only "HasPaid" is changeable, only HasPaid will be updated to the database.

            // Preperation
            SqlConnection conn = Database.GetSqlConnection();
            string cmdText = "UPDATE [CompletedService] SET [hasPaid]=@hasPaid WHERE [completedServiceId]=@completedServiceId;";
            BetterSqlCommand bsc = new BetterSqlCommand(cmdText, conn)
                .AddParameter<byte>("@hasPaid", System.Data.SqlDbType.Bit, Convert.ToByte(HasPaid))
                .AddParameter<int>("@completedServiceId", System.Data.SqlDbType.Int, Id);

            // Execution
            conn.Open();
            int rowsAffected = bsc.Cmd.ExecuteNonQuery();
            Console.WriteLine("Rows Affected: {0}", rowsAffected);

            // Clean up
            bsc.Dispose();
            conn.Close();
        }
    }
}
