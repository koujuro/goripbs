using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GORIPBS.database
{
    class SqlParameter
    {
        public string Key { get; set; }
        public string Value { get; set; }
        public DbType SqlDbType { get; set; }

        public SqlParameter() { }

        public SqlParameter(string key, string value, DbType dbType) 
        {
            Key = key;
            Value = value;
            SqlDbType = dbType;
        }

        public bool checkIfValueIsInt() 
        {
            int value;
            return Int32.TryParse(Value, out value);
        }
    }
}
