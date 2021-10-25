using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Assignment
{
    

    class User
    {
        public int id;
        public string username;
        public string password;
        public string fullName;
        public string email;
        public string phoneNo;
        public string role;

        public enum Roles
        {
            Customer = 0,
            Receptionist = 1,
            Technician = 2,
            Administrator = 3,
        }
        User()
        {

        }

        public static User FromDb(string username)
        {
            SqlConnection conn = Database.GetSqlConnection();
            conn.Open();
            // Querying this way can prevent database injections
            // Docs: https://docs.microsoft.com/en-us/dotnet/api/system.data.sqlclient.sqlcommand.parameters?redirectedfrom=MSDN&view=dotnet-plat-ext-5.0#System_Data_SqlClient_SqlCommand_Parameters
            SqlCommand cmd = new SqlCommand("SELECT * FROM [User] WHERE username = @username", conn);
            cmd.Parameters.Add("@username", System.Data.SqlDbType.VarChar);
            cmd.Parameters["@username"].Value = username;
            SqlDataReader reader = cmd.ExecuteReader();

            // Returns null if there's no entries
            if (!reader.HasRows)
            {
                reader.Close();
                conn.Close();
                return null;
            }

            // Creates a user object
            User user = new User();

            while (reader.Read())
            {
                // Sets user variables to their value
                user.username = reader["username"].ToString();
                user.password = reader["password"].ToString();
                user.email = reader["email"].ToString();
                user.fullName = reader["fullName"].ToString();
                user.phoneNo = reader["phoneNo"].ToString();
                user.role = reader["role"].ToString();
            }

            reader.Close();
            conn.Close();

            return user;
        }
    }
}
