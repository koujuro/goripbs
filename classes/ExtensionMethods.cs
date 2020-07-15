using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace GORIPBS.classes
{
    static class ExtensionMethods
    {
        public static string SafeGetString(this SQLiteDataReader reader, int colIndex)
        {
            if (!reader.IsDBNull(colIndex))
                return reader.GetString(colIndex);
            return string.Empty;
        }

        public static int SafeGetInt(this SQLiteDataReader reader, int colIndex)
        {
            if (!reader.IsDBNull(colIndex))
                return reader.GetInt32(colIndex);
            return 0;
        }

        public static DbType GetTypeAsDbTypeStringOrInt(this FieldInfo fieldInfo) 
        {
            if (fieldInfo.FieldType == typeof(string))
                return DbType.String;
            else
                return DbType.Int32;
        }
    }
}
