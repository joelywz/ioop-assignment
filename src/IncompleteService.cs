using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


// PK - userId
// PK - serviceId
// urgent
// dateTimeCreated 

namespace Assignment
{
    public class IncompleteService
    {
        private User user;
        public Service service;
        public bool urgent;
        public DateTime dateTimeCreated;

        public IncompleteService(User user, Service service, bool urgent)
        {
            this.user = user;
            this.service = service;
            this.urgent = urgent;
            this.dateTimeCreated = new DateTime();
        }

        private IncompleteService() { }

        /// <summary>
        /// Gets ALL incomplete services from database
        /// </summary>
        /// <returns>An array of IncompleteService</returns>
        public static IncompleteService[] FromDb()
        {
            // Create SQL connection
            SqlConnection conn = Database.GetSqlConnection();
            conn.Open();

            // Create SQL command
            SqlCommand cmd = new SqlCommand("SELECT * FROM [IncompleteService];", conn);

            // Create SQL reader
            SqlDataReader reader = cmd.ExecuteReader();

            // Store all incomplete services in array
            IncompleteService[] incompleteServices = { };

            while (reader.Read())
            {
                IncompleteService s = Reader(reader);

                Array.Resize(ref incompleteServices, incompleteServices.Length + 1);
                incompleteServices[incompleteServices.Length - 1] = s;
            }

            reader.Close();
            conn.Close();

            return incompleteServices;
        }

        /// <summary>
        /// Gets THE incomplete service from database from a user
        /// </summary>
        /// <param name="user"></param>
        /// <returns>NULL when not found</returns>
        public static IncompleteService FromDbByUser(User user)
        {
            // Create cconnection
            SqlConnection conn = Database.GetSqlConnection();
            conn.Open();

            // Create command
            SqlCommand cmd = new SqlCommand("SELECT * FROM [IncompleteService] WHERE [userId]=@userId;", conn);
            cmd.Parameters.Add("@userId", System.Data.SqlDbType.Int);
            cmd.Parameters["@userId"].Value = user.Id;

            // Create sql reader
            SqlDataReader reader = cmd.ExecuteReader();

            // Create incomplete service
            IncompleteService incompleteService = null;

            while (reader.Read())
            {
                incompleteService = Reader(reader);
                break;
            }

            reader.Close();
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
            IncompleteService incompleteService = new IncompleteService();

            incompleteService.user = User.FromDbById((int)reader["userId"]);
            incompleteService.service = Service.GetService((int)reader["serviceId"] - 1);
            incompleteService.urgent = (bool)reader["urgent"];
            incompleteService.dateTimeCreated = (DateTime)reader["dateTimeCreated"];

            return incompleteService;
        }

        public void Save()
        {

            SqlConnection conn = Database.GetSqlConnection();

            SqlCommand cmd = new SqlCommand("INSERT INTO [IncompleteService]([userId], [serviceId], [urgent]) " +
                "VALUES (@userId, @serviceId, @urgent)", conn);

            cmd.Parameters.Add("@userId", System.Data.SqlDbType.Int);
            cmd.Parameters.Add("@serviceId", System.Data.SqlDbType.Int);
            cmd.Parameters.Add("@urgent", System.Data.SqlDbType.Bit);

            cmd.Parameters["@userId"].Value = user.Id;
            cmd.Parameters["@serviceId"].Value = service.id;
            cmd.Parameters["@urgent"].Value = Convert.ToByte(urgent);

            conn.Open();
            int rowAffected = cmd.ExecuteNonQuery();
            Console.WriteLine("Row Affected: {0}", rowAffected);
            conn.Close();
        }

        public void Update()
        {
            SqlConnection conn = Database.GetSqlConnection();

            SqlCommand cmd = new SqlCommand("UPDATE [IncompleteService] " +
                "SET [userId]=@userId, [serviceId]=@serviceId, [urgent]=@urgent " +
                "WHERE [userId]=@userId", conn);

            cmd.Parameters.Add("@userId", System.Data.SqlDbType.Int);
            cmd.Parameters.Add("@serviceId", System.Data.SqlDbType.Int);
            cmd.Parameters.Add("@urgent", System.Data.SqlDbType.Bit);

            cmd.Parameters["@userId"].Value = user.Id;
            cmd.Parameters["@serviceId"].Value = service.id;
            cmd.Parameters["@urgent"].Value = Convert.ToByte(urgent);

            conn.Open();
            int rowAffected = cmd.ExecuteNonQuery();
            Console.WriteLine("Row Affected: {0}", rowAffected);
            conn.Close();
        }

    }
}
