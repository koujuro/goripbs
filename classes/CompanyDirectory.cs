using System;
using System.Collections.Generic;
using System.Data.Entity.SqlServer;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GORIPBS.classes
{
    class CompanyDirectory
    {
        public List<Company> ListOfCompanies { get; set; }

        public CompanyDirectory() 
        {
            ListOfCompanies = new List<Company>();
            populateListOfCompanies();
        }

        private void populateListOfCompanies() 
        {
            SQLiteDataReader sQLiteDataReader = fetchCompaniesFromDB();
            while (sQLiteDataReader.Read() && sQLiteDataReader != null) 
            {
                ListOfCompanies.Add(createCompanyObjectFromRowInDB(sQLiteDataReader));
            }
            DataBase.DataBaseSingleton().closeConnection();
        }

        private SQLiteDataReader fetchCompaniesFromDB() 
        {
            string sql = "SELECT * FROM COMPANY WHERE CompanyID is not 1 AND Deleted is not 1";
            SQLiteDataReader sQLiteDataReader = DataBase.DataBaseSingleton().selectionQuery(sql);
            return sQLiteDataReader;
        }

        private Company createCompanyObjectFromRowInDB(SQLiteDataReader row) 
        {
            return new Company(row.SafeGetInt(0),
                row.SafeGetString(1),
                row.SafeGetString(2),
                row.SafeGetString(3),
                row.SafeGetString(4),
                row.SafeGetInt(5),
                row.SafeGetString(6),
                row.SafeGetString(7),
                row.SafeGetString(8),
                row.SafeGetString(9),
                row.SafeGetInt(10),
                row.SafeGetString(11),
                row.SafeGetString(12),
                row.SafeGetString(13),
                row.SafeGetString(14));
        }

        //private string[] parseValuesFromRowInDB(SQLiteDataReader row) 
        //{
        //    string[] values = new string[row.FieldCount];
        //    int id;
        //    for (int i = 0; i < values.Length-1; i++)
        //    {
        //        //values[i] = row.SafeGetString(i);
        //        id = row.SafeGetInt(i);
        //    }
        //    return values;
        //}
    }
}
