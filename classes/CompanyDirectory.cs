using GORIPBS.database;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity.SqlServer;
using System.Data.SQLite;
using System.Linq;
using System.Reflection;
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
            SQLiteDataReader sQLiteDataReader = SqlHandler.selectionQuery(sql);
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

        public Company getCompanyByCompanyId(int companyId) 
        {
            foreach (Company company in ListOfCompanies) 
            {
                if (company.CompanyId == companyId)
                    return company;
            }

            return null;
        }

        public void insertEmptyCompanyIntoList() 
        {
            ListOfCompanies.Add(new Company());
        }

        public bool saveCompany(Company editedCompany) 
        {
            int rowsAffected = 0;
            if (editedCompany.CompanyId == 0)
            {
                rowsAffected = insertCompanyIntoDB(editedCompany);
            }
            else 
            {
                rowsAffected = updateCompanyInDB(editedCompany);
            }

            return (rowsAffected != 0) ? true : false;
        }

        private int insertCompanyIntoDB(Company newCompany) 
        {
            string sql = "INSERT INTO COMPANY ('Name', 'PIB', 'Address', 'City', 'PostalCode', 'Owner', 'BankAccount', 'IdentificationNumber', 'Bank', 'ActivityCode', 'Telephone', 'MobileNumber', 'Email', 'Fax', 'Deleted')" +
                "VALUES(@name, @pib, @address, @city, @postalCode, @owner, @bankAccount, @idNumber, @bank, @activityCode, @telephone, @mobileNumber, @email, @fax, 0)";
            SqlParameter[] sqlParameters = newCompany.generateSqlParametersFromObjectFields();
            return SqlHandler.executionQuery(sql, sqlParameters);
        }  

        private int updateCompanyInDB(Company editedCompany) 
        {
            StringBuilder sql = new StringBuilder("UPDATE COMPANY SET ");
            Company companyToBeUpdated = getCompanyByCompanyId(editedCompany.CompanyId);
            List<SqlParameter> listOfSqlParameters = new List<SqlParameter>();
            FieldInfo[] companyObjectFields = typeof(Company).GetFields();

            foreach (FieldInfo companyObjectField in companyObjectFields) 
            {
                PropertyInfo propertyInfo = typeof(Company).GetProperty(companyObjectField.Name);
                string valueOfOriginalCompanyField = propertyInfo.GetValue(companyToBeUpdated).ToString();
                string valueOfEditedCompanyField = propertyInfo.GetValue(editedCompany).ToString();
                DbType dbTypeOfCompanyField = companyObjectField.GetTypeAsDbTypeStringOrInt();

                if (!valueOfOriginalCompanyField.Equals(valueOfEditedCompanyField)) 
                {
                    sql.Append(companyObjectField.Name).Append("=@").Append(companyObjectField.Name).Append(", ");
                    listOfSqlParameters.Add(new SqlParameter(companyObjectField.Name, valueOfEditedCompanyField, dbTypeOfCompanyField));
                }
            }

            if (listOfSqlParameters.Count() != 0) 
            {
                string finalSql = sql.ToString();
                finalSql = finalSql.Substring(0, sql.Length - 1) + " WHERE CompanyId=" + editedCompany.CompanyId;
                return SqlHandler.executionQuery(finalSql, listOfSqlParameters.ToArray());
            }

            return -1;
        }

        public void updateCompanyInListOfCompanies(Company newCompany) 
        {
            ListOfCompanies[ListOfCompanies.FindIndex(ind => ind.CompanyId.Equals(newCompany.CompanyId))] = newCompany;
        }

        public bool deleteCompany(int indexInListOfCompanies) 
        {
            if (ListOfCompanies[indexInListOfCompanies].CompanyId == 0)
            {
                ListOfCompanies.RemoveAt(indexInListOfCompanies);
                return true;
            }
            else
            {
                if (deleteCompanyFromDB(ListOfCompanies[indexInListOfCompanies].CompanyId) == 1)
                {
                    ListOfCompanies.RemoveAt(indexInListOfCompanies);
                    return true;
                }
                else
                    return false;
            }
        }

        private int deleteCompanyFromDB(int companyId) 
        {
            string sql = "UPDATE COMPANY SET Deleted=1 WHERE CompanyId=@companyId";
            SqlParameter[] sqlParameters = new SqlParameter[] { 
                new SqlParameter("companyId", companyId.ToString(), DbType.Int32) 
            };

            return SqlHandler.executionQuery(sql, sqlParameters);
        }
    }
}
