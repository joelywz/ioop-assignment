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
        public int Id { get; }
        public string Username { get; set;}
        public string Password { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string PhoneNo { get; set; }
        public string Ic { get; set; }
        public Roles Role { get; set; }
        public DateTime? DateOfBirth { get; set; }

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

        public static User Save(string username, string fullName, string email, string password, string phoneNo, Roles role)
        {
            SqlConnection conn = Database.GetSqlConnection();
            conn.Open();

            string cmdText = "INSERT INTO [User] ([username], [fullName], [email], [password], [phoneNo], [role]) " +
                "VALUES (@username, @fullName, @email, @password, @phoneNo, @role);";

            BetterSqlCommand bsc = new BetterSqlCommand(cmdText, conn)
                .AddParameter<string>("@username", System.Data.SqlDbType.VarChar, username)
                .AddParameter<string>("@fullName", System.Data.SqlDbType.VarChar, fullName)
                .AddParameter<string>("@email", System.Data.SqlDbType.VarChar, email)
                .AddParameter<string>("@password", System.Data.SqlDbType.VarChar, password)
                .AddParameter<string>("@phoneNo", System.Data.SqlDbType.VarChar, phoneNo)
                .AddParameter<int>("@role", System.Data.SqlDbType.Int, (int)role);

            bsc.Cmd.ExecuteNonQuery();

            conn.Close();
            return User.GetByUsername(username);
        }

        /// <summary>
        /// Get a user from database by username.
        /// </summary>
        /// <param name="username"></param>
        /// <returns>User Object</returns>
        public static User GetByUsername(string username)
        {
            // Preperation
            SqlConnection conn = Database.GetSqlConnection();
            BetterSqlCommand bsc = new BetterSqlCommand("SELECT * FROM [User] WHERE username=@username;", conn);
            bsc.AddParameter<string>("@username", System.Data.SqlDbType.VarChar, username);

            // Execution
            conn.Open();
            SqlDataReader reader = bsc.Cmd.ExecuteReader();
            User user = null;
            while (reader.Read())
            {
                user = Reader(reader);
                break;
            }

            // Clean up
            reader.Close();
            bsc.Cmd.Dispose();
            conn.Close();
            return user;
        }

        /// <summary>
        /// Get a user from database by id.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static User GetById(int id)
        {
            // Preperation
            SqlConnection conn = Database.GetSqlConnection();
            BetterSqlCommand bsc = new BetterSqlCommand("SELECT * FROM [User] WHERE userId=@userId;", conn);
            bsc.AddParameter<int>("@userId", System.Data.SqlDbType.Int, id);
            
            // Execution
            conn.Open();
            SqlDataReader reader = bsc.Cmd.ExecuteReader();
            User user = null;
            while (reader.Read())
            {
                user = Reader(reader);
                break;
            }

            // Clean up
            reader.Close();
            bsc.Cmd.Dispose();
            conn.Close();
            return user;
        }

        /// <summary>
        /// Get a user from database by Ic.
        /// </summary>
        /// <param name="ic"></param>
        /// <returns></returns>
        public static User GetByIc(string ic)
        {
            // Preperation
            SqlConnection conn = Database.GetSqlConnection();
            BetterSqlCommand bsc = new BetterSqlCommand("SELECT * FROM [User] WHERE ic=@userIc;", conn);
            bsc.AddParameter<string>("@userIc", System.Data.SqlDbType.VarChar, ic);

            // Execution
            conn.Open();
            SqlDataReader reader = bsc.Cmd.ExecuteReader();
            User user = null;
            while (reader.Read())
            {
                user = Reader(reader);
                break;
            }

            // Clean up
            reader.Close();
            bsc.Cmd.Dispose();
            conn.Close();
            return user;
        }

        /// <summary>
        /// Get a user from database by phoneNo.
        /// </summary>
        /// <param name="phoneNo"></param>
        /// <returns></returns>
        public static User GetByPhoneNo(string phoneNo)
        {
            // Preperation
            SqlConnection conn = Database.GetSqlConnection();
            BetterSqlCommand bsc = new BetterSqlCommand("SELECT * FROM [User] WHERE PhoneNo=@phone;", conn);
            bsc.AddParameter<string>("@phone", System.Data.SqlDbType.VarChar, phoneNo);

            // Execution
            conn.Open();
            SqlDataReader reader = bsc.Cmd.ExecuteReader();
            User user = null;
            while (reader.Read())
            {
                user = Reader(reader);
                break;
            }

            // Clean up
            reader.Close();
            bsc.Cmd.Dispose();
            conn.Close();
            return user;
        }

        /// <summary>
        /// Get a user from database by email.
        /// </summary>
        /// <param name="email"></param>
        /// <returns>null when no User found</returns>
        public static User GetByEmail(string email)
        {
            // Preperation
            SqlConnection conn = Database.GetSqlConnection();
            BetterSqlCommand bsc = new BetterSqlCommand("SELECT * FROM [User] WHERE email=@email;", conn);
            bsc.AddParameter<string>("@email", System.Data.SqlDbType.VarChar, email);

            // Execution
            conn.Open();
            SqlDataReader reader = bsc.Cmd.ExecuteReader();
            User user = null;
            while (reader.Read())
            {
                user = Reader(reader);
                break;
            }

            // Clean up
            reader.Close();
            bsc.Cmd.Dispose();
            conn.Close();

            return user;
        }

        /// <summary>
        /// Get users from database by their role.
        /// </summary>
        /// <param name="role"></param>
        /// <returns></returns>
        public static User[] GetByRole(Roles role)
        {
            //  Preparation
            SqlConnection conn = Database.GetSqlConnection();
            BetterSqlCommand bsc = new BetterSqlCommand("SELECT * FROM [User] WHERE [role]=@role ORDER BY[fullname] ASC;", conn);
            bsc.AddParameter<int>("@role", System.Data.SqlDbType.Bit, (int)role);
            
            // Execution
            conn.Open();
            SqlDataReader reader = bsc.Cmd.ExecuteReader();
            List<User> users = new List<User>();

            while (reader.Read())
            {
                User user = Reader(reader);
                users.Add(user);
            }

            // Clean Up
            bsc.Cmd.Dispose();
            reader.Close();
            conn.Close();

            return users.ToArray();
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

            try
            {
                user.DateOfBirth = Convert.ToDateTime(reader["dateOfBirth"]);
            } catch (Exception)
            {
                user.DateOfBirth = null;
            }

            if (string.IsNullOrWhiteSpace(user.Ic))
            {
                user.Ic = null;
            }

            return user;
        }

        public void Update()
        {
            // Preperation
            SqlConnection conn = Database.GetSqlConnection();
            string cmdText = "UPDATE [User] SET [username]=@username, [fullName]=@fullName, [password]=@password, [email]=@email, [phoneNo]=@phoneNo, [role]=@role, [dateOfBirth]=@dateOfBirth, [ic]=@ic WHERE [userId]=@userId;";
            BetterSqlCommand bsc = new BetterSqlCommand(cmdText, conn);
            bsc
                .AddParameter<int>("@userId", System.Data.SqlDbType.VarChar, Id)
                .AddParameter<string>("@username", System.Data.SqlDbType.VarChar, Username)
                .AddParameter<string>("@fullname", System.Data.SqlDbType.VarChar, FullName)
                .AddParameter<string>("@email", System.Data.SqlDbType.VarChar, Email)
                .AddParameter<string>("@password", System.Data.SqlDbType.VarChar, Password)
                .AddParameter<string>("@phoneNo", System.Data.SqlDbType.VarChar, PhoneNo)
                .AddParameter<int>("@role", System.Data.SqlDbType.Int, RoleToInt(Role))
                .AddParameter<string>("@ic", System.Data.SqlDbType.VarChar, Ic)
                .AddParameter<DateTime?>("@dateOfBirth", System.Data.SqlDbType.Date, DateOfBirth);


            // Execution
            conn.Open();
            int rowsAffected = bsc.Cmd.ExecuteNonQuery();
            Console.WriteLine("rowsAffected: {0}", rowsAffected);
            conn.Close();
        }
        
        /// <summary>
        /// Convert User.Roles to int
        /// </summary>
        /// <param name="role"></param>
        /// <returns>integer of the role</returns>
        public static int RoleToInt(Roles role)
        {
            return (int)role;
        }
        
        /// <summary>
        /// Conver User.Roles to string
        /// </summary>
        /// <param name="role"></param>
        /// <returns>name of the role</returns>
        public static string RoleToString(Roles role)
        {
            switch (role)
            {
                case User.Roles.Customer:
                     return "Customer";
                case User.Roles.Administrator:
                    return "Administrator";
                case User.Roles.Receptionist:
                    return "Receptionist";
                case User.Roles.Technician:
                    return "Technician";
                default:
                    return "Unknown Role";
            }
        }
    }


}
