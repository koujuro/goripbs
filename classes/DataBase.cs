using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace GORIPBS.classes
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
            return newPath + "\\database\\database.db";
        }

        public SQLiteDataReader selectionQuery(string sql) 
        {
            openConnection();
            string result = "";
            SQLiteCommand command = new SQLiteCommand(sql, connection);
            SQLiteDataReader reader = command.ExecuteReader();
            //closeConnection();

            return reader;
        }

        public int executionQuery(string sql)
        {
            openConnection();
            SQLiteCommand command = new SQLiteCommand(sql, connection);
            int rowsAffected = command.ExecuteNonQuery();
            closeConnection();

            return rowsAffected;
        }

        public void openConnection() 
        {
            connection.Open();
        }

        public void closeConnection()
        {
            connection.Close();
        }
    }
}
