using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GORIPBS.database
{
    static class SqlHandler
    {
        public static SQLiteDataReader selectionQuery(string sql, SqlParameter[] sqlParameters = null) 
        {
            return DataBase.DataBaseSingleton().selectionQuery(prepareSqlCommand(sql, sqlParameters));
        }

        public static int executionQuery(string sql, SqlParameter[] sqlParameters = null) 
        {
            return DataBase.DataBaseSingleton().executionQuery(prepareSqlCommand(sql, sqlParameters));
        }

        private static SQLiteCommand prepareSqlCommand(string sql, SqlParameter[] sqlParameters) 
        {
            SQLiteCommand sqlCommand = new SQLiteCommand();
            sqlCommand.CommandText = sql;
            if (sqlParameters != null)
                sqlCommand = insertParametersIntoSqlCommand(sqlCommand, sqlParameters);

            return sqlCommand;
        }

        private static SQLiteCommand insertParametersIntoSqlCommand(SQLiteCommand sqlCommand, SqlParameter[] sqlParameters) 
        {
            sqlCommand.Parameters.Clear();
            foreach (SqlParameter parameter in sqlParameters) 
            {
                sqlCommand.Parameters.Add(parameter.Key, parameter.SqlDbType);
                sqlCommand.Parameters[parameter.Key].Value = parameter.Value;
            }

            return sqlCommand;
        }
    }
}
