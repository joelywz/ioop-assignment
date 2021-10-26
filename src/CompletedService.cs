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
        public int Id {get;}
        public User User;
        public User CompletedBy;
        public Service Service;
        public bool Urgent;
        public string Description;
        public bool HasPaid;
        public DateTime DateTimeCreated;
        public DateTime DateTimeCompleted;

        private CompletedService(int id, User user, User completedBy, Service service, bool urgent, bool hasPaid, string description, DateTime created, DateTime completed)
        {
            this.Id = id;
            this.User = user;
            this.CompletedBy = completedBy;
            this.Service = service;
            this.Urgent = urgent;
            this.HasPaid = hasPaid;
            this.Description = description;
            this.DateTimeCreated = created;
            this.DateTimeCompleted = completed;
        }

        public static CompletedService Save(IncompleteService incompleteService, User completedBy, string description)
        {

            int userId = incompleteService.User.Id;
            int completedByUserId = completedBy.Id;
            int serviceId = incompleteService.Service.Id;
            bool urgent = incompleteService.Urgent;
            DateTime dateTimeCreated = incompleteService.DateTimeCreated;
            double price = urgent ? incompleteService.Service.UrgentPrice : incompleteService.Service.Price;

            // Delete incomplete service
            incompleteService.Delete();

            // Save to database
            SqlConnection conn = Database.GetSqlConnection();

            string cmdText =
                "INSERT INTO [CompletedService]([userId], [completedByUserId], [serviceId], [urgent], [price], [description], [dateTimeCreated]) " +
                "VALUES(@userId, @completedByUserId, @serviceId, @urgent, @price, @description, @dateTimeCreated);" +
                "SELECT SCOPE_IDENTITY();";
            BetterSqlCommand bsc = new BetterSqlCommand(cmdText, conn)
                .AddParameter<int>("@userId", System.Data.SqlDbType.Int, userId)
                .AddParameter<int>("@completedByUserId", System.Data.SqlDbType.Int, completedByUserId)
                .AddParameter<int>("@serviceId", System.Data.SqlDbType.Int, serviceId)
                .AddParameter<byte>("@urgent", System.Data.SqlDbType.Bit, Convert.ToByte(urgent))
                .AddParameter<double>("@price", System.Data.SqlDbType.Float, price)
                .AddParameter<string>("@description", System.Data.SqlDbType.Text, description)
                .AddParameter<DateTime>("@dateTimeCreated", System.Data.SqlDbType.DateTime, dateTimeCreated);

            conn.Open();
            int completedServiceId = Convert.ToInt32(bsc.Cmd.ExecuteScalar());
            conn.Close();
            return CompletedService.GetById(completedServiceId);
        }

        public static CompletedService GetById(int id)
        {
            SqlConnection conn = Database.GetSqlConnection();
            
            string cmdText = "SELECT * FROM [CompletedService] WHERE [completedServiceId]=@completedServiceId; ";
            BetterSqlCommand bsc = new BetterSqlCommand(cmdText, conn)
                .AddParameter<int>("@completedServiceId", System.Data.SqlDbType.Int, id);

            conn.Open();
            SqlDataReader reader = bsc.Cmd.ExecuteReader();

            CompletedService cs = null;
            while (reader.Read())
            {
                cs = Reader(reader);
                break;
            }

            reader.Close();
            conn.Close();

            return cs;

        }

        private static CompletedService Reader(SqlDataReader reader)
        {
            int completedServiceId = Convert.ToInt32(reader["completedServiceId"]);
            User user = User.GetById(Convert.ToInt32(reader["userId"]));
            User completedBy = User.GetById(Convert.ToInt32(reader["completedByUserId"]));
            Service service = Service.GetService(Convert.ToInt32(reader["serviceId"]));
            bool urgent = (bool)reader["urgent"];
            bool hasPaid = (bool)reader["hasPaid"];
            string description = reader["description"].ToString();
            DateTime created = (DateTime)reader["dateTimeCreated"];
            DateTime completed = (DateTime)reader["dateTimeCompleted"];

            return new CompletedService(completedServiceId, user, completedBy, service, urgent, hasPaid, description, created, completed);
            

        }
    }
}
