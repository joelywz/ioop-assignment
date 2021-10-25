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
        public int? Id { get; }
        public string Username { get; set;}
        public string Password { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string PhoneNo { get; set; }
        public string Ic { get; set; }
        public Roles Role { get; set; }

        public enum Roles
        {
            Customer = 0,
            Administrator = 1,
            Receptionist = 2,
            Technician = 3,
        }

        private User(int id)
        {
            this.Id = id;
        }
            
        public User(string username, string password, string fullName, string email, string phoneNo, Roles role)
        {
            this.Id = null;
            this.Username = username;
            this.Password = password;
            this.FullName = fullName;
            this.Email = email;
            this.PhoneNo = phoneNo;
            this.Role = role;
        }

        /// <summary>
        /// Get a user from database by username.
        /// </summary>
        /// <param name="username"></param>
        /// <returns>User Object</returns>
        public static User FromDbByUsername(string username)
        {
            // Querying this way can prevent database injections
            // Docs: https://docs.microsoft.com/en-us/dotnet/api/system.data.sqlclient.sqlcommand.parameters?redirectedfrom=MSDN&view=dotnet-plat-ext-5.0#System_Data_SqlClient_SqlCommand_Parameters
            SqlConnection conn = Database.GetSqlConnection();
            conn.Open();

            SqlCommand cmd = new SqlCommand("SELECT * FROM [User] WHERE username=@username;", conn);
            cmd.Parameters.Add("@username", System.Data.SqlDbType.VarChar);
            cmd.Parameters["@username"].Value = username;

            SqlDataReader reader = cmd.ExecuteReader();

            User user = null;
            while (reader.Read())
            {
                // Sets user variables to their value
                user = Reader(reader);
                break;
            }
            reader.Close();
            conn.Close();
            return user;
        }

        /// <summary>
        /// Get a user from database by id.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static User FromDbById(int id)
        {
            // Querying this way can prevent database injections
            // Docs: https://docs.microsoft.com/en-us/dotnet/api/system.data.sqlclient.sqlcommand.parameters?redirectedfrom=MSDN&view=dotnet-plat-ext-5.0#System_Data_SqlClient_SqlCommand_Parameters
            SqlConnection conn = Database.GetSqlConnection();
            conn.Open();

            SqlCommand cmd = new SqlCommand("SELECT * FROM [User] WHERE userId=@userId;", conn);
            cmd.Parameters.Add("@userId", System.Data.SqlDbType.VarChar);
            cmd.Parameters["@userId"].Value = id;

            SqlDataReader reader = cmd.ExecuteReader();

            User user = null;
            while (reader.Read())
            {
                user = Reader(reader);
                break;
            }
            reader.Close();
            conn.Close();
            return user;
        }

        /// <summary>
        /// Get users from database by their role.
        /// </summary>
        /// <param name="role"></param>
        /// <returns></returns>
        public static User[] FromDbByRole(Roles role)
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
                User user = Reader(reader);

                Array.Resize(ref users, users.Length + 1);
                users[users.Length - 1] = (user);
            }

            return users;
        }

        /// <summary>
        /// Get a user from database by email.
        /// </summary>
        /// <param name="email"></param>
        /// <returns></returns>
        public static User FromDbByEmail(string email)
        {
            SqlConnection conn = Database.GetSqlConnection();
            conn.Open();

            SqlCommand cmd = new SqlCommand("SELECT * FROM [User] WHERE email=@email;", conn);
            cmd.Parameters.Add("@email", System.Data.SqlDbType.VarChar);
            cmd.Parameters["@email"].Value = email;

            SqlDataReader reader = cmd.ExecuteReader();

            User user = null;
            while (reader.Read())
            {
                // Sets user variables to their value
                user = Reader(reader);
                break;
            }
            reader.Close();
            conn.Close();
            return user;
        }

        /// <summary>
        /// To map items from SQL reader.
        /// </summary>
        /// <param name="reader"></param>
        /// <returns></returns>
        private static User Reader(SqlDataReader reader)
        {
            int id = (int)reader["userId"];
            User user = new User(id);
            user.Username = (string)reader["username"];
            user.Password = (string)reader["password"];
            user.Email = (string)reader["email"];
            user.FullName = (string)reader["fullName"];
            user.PhoneNo = (string)reader["phoneNo"];
            user.Ic = reader["ic"].ToString();
            user.Role = (Roles)(int)reader["role"];

            return user;
        }

        public User Save()
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
            cmd.Parameters["@username"].Value = Username;
            cmd.Parameters["@fullName"].Value = FullName;
            cmd.Parameters["@email"].Value = Email;
            cmd.Parameters["@password"].Value = Password;
            cmd.Parameters["@phoneNo"].Value = PhoneNo;
            cmd.Parameters["@role"].Value = Role;

            cmd.ExecuteNonQuery();

            Console.WriteLine(Id);
            conn.Close();
            return User.FromDbByUsername(Username);
        }

        public void Update()
        {
            SqlConnection conn = Database.GetSqlConnection();
            conn.Open();

            SqlCommand cmd = new SqlCommand("UPDATE [User] SET [username]=@username, [fullName]=@fullName, [password]=@password, [phoneNo]=@phoneNo, [role]=@role WHERE [userId]=@userId;", conn);
            cmd.Parameters.Add("@username", System.Data.SqlDbType.VarChar);
            cmd.Parameters.Add("@fullName", System.Data.SqlDbType.VarChar);
            cmd.Parameters.Add("@email", System.Data.SqlDbType.VarChar);
            cmd.Parameters.Add("@password", System.Data.SqlDbType.VarChar);
            cmd.Parameters.Add("@phoneNo", System.Data.SqlDbType.VarChar);
            cmd.Parameters.Add("@role", System.Data.SqlDbType.Int);
            cmd.Parameters["@username"].Value = Username;
            cmd.Parameters["@fullName"].Value = FullName;
            cmd.Parameters["@email"].Value = Email;
            cmd.Parameters["@password"].Value = Password;
            cmd.Parameters["@phoneNo"].Value = PhoneNo;
            cmd.Parameters["@role"].Value = Role;

            int rowsAffected = cmd.ExecuteNonQuery();

            Console.WriteLine("rowsAffected: {0}", rowsAffected);

            conn.Close();
        }
    }
}
