using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Assignment
{
    public class BetterSqlCommand
    {
        public SqlCommand Cmd { get; }

        public BetterSqlCommand(string cmdText, SqlConnection conn)
        {
            Cmd = new SqlCommand(cmdText, conn);
        }

        public BetterSqlCommand AddParameter<T>(string parameterName, System.Data.SqlDbType type, T value)
        {
 
            Cmd.Parameters.Add(parameterName, type);
            if (value != null)
                Cmd.Parameters[parameterName].Value = value;
            else
                Cmd.Parameters[parameterName].Value = DBNull.Value;

            return this;
        }

        public void Dispose()
        {
            this.Cmd.Dispose();
        }
    }
}
