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
        private SQLiteConnection

        public static DataBase DataBaseSingleton() 
        {
            if (instance == null)
                instance = new DataBase();
            return instance;
        }


    }
}
