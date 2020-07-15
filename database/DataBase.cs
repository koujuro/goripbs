using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Data;

namespace GORIPBS.database
{
    class DataBase
    {
        public static DataBase instance;
        public string connectionString;
        private SQLiteConnection connection;

        public static DataBase DataBaseSingleton() 
        {
            if (instance == null)
                instance = new DataBase();
            return instance;
        }

        private DataBase() 
        {
            connectionString = @"Data Source=" + generatePathForConnectionString() + ";Version=3;";
            connection = new SQLiteConnection(connectionString);
        }

        private string generatePathForConnectionString() 
        {
            string path = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location);
            string newPath = System.IO.Path.GetFullPath(System.IO.Path.Combine(path, "..", ".."));
            return newPath + "\\assets\\database.db";
        }

        public SQLiteDataReader selectionQuery(SQLiteCommand command) 
        {
            openConnection();
            command.Connection = connection;
            SQLiteDataReader reader = command.ExecuteReader();
            //closeConnection();

            return reader;
        }

        public int executionQuery(SQLiteCommand command)
        {
            openConnection();
            command.Connection = connection;
            int rowsAffected = command.ExecuteNonQuery();
            //closeConnection();

            return rowsAffected;
        }

        public void openConnection() 
        {
            if (connection.State != ConnectionState.Open)
                connection.Open();
        }

        public void closeConnection()
        {
            if (connection.State != ConnectionState.Closed)
                connection.Close();
        }
    }
}
