using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;

namespace Assignment
{
    class Database
    {

        public static SqlConnection GetSqlConnection()
        {
            string value = System.Configuration.ConfigurationManager.AppSettings.Get("connectionString");
            return new SqlConnection(value);
        }

        public static string TestConnection()
        {
            try
            {
                SqlConnection conn = GetSqlConnection();
                conn.Open();
                conn.Close();
                return "OK";
            } catch(Exception e)
            {
                return e.Message;
            }
        }

    }
}
