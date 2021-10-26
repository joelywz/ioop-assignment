﻿using System;
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

        public static User Save(string username, string fullName, string email, string password, string phoneNo, Roles role)
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
            cmd.Parameters["@role"].Value = role;

            cmd.ExecuteNonQuery();


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
            // Querying this way can prevent database injections
            // Docs: https://docs.microsoft.com/en-us/dotnet/api/system.data.sqlclient.sqlcommand.parameters?redirectedfrom=MSDN&view=dotnet-plat-ext-5.0#System_Data_SqlClient_SqlCommand_Parameters
            SqlConnection conn = Database.GetSqlConnection();
            conn.Open();

            BetterSqlCommand bsc = new BetterSqlCommand("SELECT * FROM [User] WHERE username=@username;", conn);
            bsc.addParameter<string>("@username", System.Data.SqlDbType.VarChar, username);

            SqlDataReader reader = bsc.Cmd.ExecuteReader();

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
        /// Get a user from database by id.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static User GetById(int id)
        {
            // Querying this way can prevent database injections
            // Docs: https://docs.microsoft.com/en-us/dotnet/api/system.data.sqlclient.sqlcommand.parameters?redirectedfrom=MSDN&view=dotnet-plat-ext-5.0#System_Data_SqlClient_SqlCommand_Parameters
            SqlConnection conn = Database.GetSqlConnection();
            conn.Open();

            BetterSqlCommand bsc = new BetterSqlCommand("SELECT * FROM [User] WHERE userId=@userId;", conn);
            bsc.addParameter<int>("@userId", System.Data.SqlDbType.Int, id);

            SqlDataReader reader = bsc.Cmd.ExecuteReader();

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
        /// Get a user from database by email.
        /// </summary>
        /// <param name="email"></param>
        /// <returns>null when no User found</returns>
        public static User GetByEmail(string email)
        {
            SqlConnection conn = Database.GetSqlConnection();
            conn.Open();

            BetterSqlCommand bsc = new BetterSqlCommand("SELECT * FROM [User] WHERE email=@email;", conn);
            bsc.addParameter<string>("@email", System.Data.SqlDbType.VarChar, email);

            SqlDataReader reader = bsc.Cmd.ExecuteReader();

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
        public static User[] GetByRole(Roles role)
        {
            SqlConnection conn = Database.GetSqlConnection();
            conn.Open();

            BetterSqlCommand bsc = new BetterSqlCommand("SELECT * FROM [User] WHERE [role]=@role ORDER BY[fullname] ASC;", conn);
            bsc.addParameter<int>("@role", System.Data.SqlDbType.Bit, (int)role);


            SqlDataReader reader = bsc.Cmd.ExecuteReader();

            List<User> users = new List<User>();

            while (reader.Read())
            {
                User user = Reader(reader);
                users.Add(user);
            }

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

            return user;
        }

        public void Update()
        {
            SqlConnection conn = Database.GetSqlConnection();
            conn.Open();

            string cmdText = "UPDATE [User] SET [username]=@username, [fullName]=@fullName, [password]=@password, [phoneNo]=@phoneNo, [role]=@role WHERE [userId]=@userId;";
            BetterSqlCommand bsc = new BetterSqlCommand(cmdText, conn);
            bsc
                .addParameter<string>("@username", System.Data.SqlDbType.VarChar, Username)
                .addParameter<string>("@fullname", System.Data.SqlDbType.VarChar, FullName)
                .addParameter<string>("@email", System.Data.SqlDbType.VarChar, Email)
                .addParameter<string>("@password", System.Data.SqlDbType.VarChar, Password)
                .addParameter<string>("@phoneNo", System.Data.SqlDbType.VarChar, PhoneNo)
                .addParameter<int>("@role", System.Data.SqlDbType.Bit, (int)Role);

            int rowsAffected = bsc.Cmd.ExecuteNonQuery();
            Console.WriteLine("rowsAffected: {0}", rowsAffected);

            conn.Close();
        }
    }
}
