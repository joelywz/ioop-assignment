using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Assignment
{
    public class User
    {
        public int id;
        public string username;
        public string password;
        public string fullName;
        public string email;
        public string phoneNo;
        public string ic;
        public Role role;

        public enum Role
        {
            Customer = 0,
            Administrator = 1,
            Receptionist = 2,
            Technician = 3,
        }

        public User()
        {

        }

        public User(string username, string password, string fullName, string email, string phoneNo, Role role)
        {
            this.username = username;
            this.password = password;
            this.fullName = fullName;
            this.email = email;
            this.phoneNo = phoneNo;
            this.role = role;
        }

        public static User FromDb(string username)
        {
            // Querying this way can prevent database injections
            // Docs: https://docs.microsoft.com/en-us/dotnet/api/system.data.sqlclient.sqlcommand.parameters?redirectedfrom=MSDN&view=dotnet-plat-ext-5.0#System_Data_SqlClient_SqlCommand_Parameters
            SqlConnection conn = Database.GetSqlConnection();
            conn.Open();

            SqlCommand cmd = new SqlCommand("SELECT * FROM [User] WHERE username=@username;", conn);
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


            User user = new User();
            while (reader.Read())
            {
                // Sets user variables to their value
                user.id = Convert.ToInt32(reader["userId"]);
                user.username = reader["username"].ToString();
                user.password = reader["password"].ToString();
                user.email = reader["email"].ToString();
                user.fullName = reader["fullName"].ToString();
                user.phoneNo = reader["phoneNo"].ToString();
                user.ic = reader["ic"].ToString();
                user.role = (Role)Convert.ToInt32(reader["role"]);
                break;
            }
            reader.Close();
            conn.Close();
            return user;
        }

        public static User[] GetUsersByRole(Role role)
        {
            SqlConnection conn = Database.GetSqlConnection();
            conn.Open();

            SqlCommand cmd = new SqlCommand("SELECT * FROM [User] WHERE [role]=@role ORDER BY[fullname] ASC;", conn);

            cmd.Parameters.Add("@role", System.Data.SqlDbType.Int);
            cmd.Parameters["@role"].Value = (int)role;

            SqlDataReader reader = cmd.ExecuteReader();

            User[] users = { };

            while (reader.Read())
            {
                // Sets user variables to their value
                User user = new User();
                user.id = Convert.ToInt32(reader["userId"]);
                user.username = reader["username"].ToString();
                user.password = reader["password"].ToString();
                user.email = reader["email"].ToString();
                user.fullName = reader["fullName"].ToString();
                user.phoneNo = reader["phoneNo"].ToString();
                user.ic = reader["ic"].ToString();
                user.role = (Role)Convert.ToInt32(reader["role"]);

                Array.Resize(ref users, users.Length + 1);
                users[users.Length - 1] = (user);
            }

            return users;
        }

        public void Save()
        {
            SqlConnection conn = Database.GetSqlConnection();
            conn.Open();

            SqlCommand cmd = new SqlCommand("" +
                "INSERT INTO [User] ([username], [fullName], [email], [password], [phoneNo], [role]) " +
                "VALUES (@username, @fullName, @email, @password, @phoneNo, @role);", conn);
            cmd.Parameters.Add("@username", System.Data.SqlDbType.VarChar);
            cmd.Parameters.Add("@fullName", System.Data.SqlDbType.VarChar);
            cmd.Parameters.Add("@email", System.Data.SqlDbType.VarChar);
            cmd.Parameters.Add("@password", System.Data.SqlDbType.VarChar);
            cmd.Parameters.Add("@phoneNo", System.Data.SqlDbType.VarChar);
            cmd.Parameters.Add("@role", System.Data.SqlDbType.Int);
            cmd.Parameters["@username"].Value = username;
            cmd.Parameters["@fullName"].Value = fullName;
            cmd.Parameters["@email"].Value = email;
            cmd.Parameters["@password"].Value = password;
            cmd.Parameters["@phoneNo"].Value = phoneNo;
            cmd.Parameters["@role"].Value = 0;

            Int32 rowsAffected = cmd.ExecuteNonQuery();

            Console.WriteLine("rowsAffected: {0}", rowsAffected);

            conn.Close();
        }
    }
}
