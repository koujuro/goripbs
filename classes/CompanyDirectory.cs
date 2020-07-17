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
            SqlHandler.closeConnectionToDataBase();
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
            int rowsAffected;
            if (editedCompany.CompanyId == 0)
            {
                rowsAffected = insertCompanyIntoDB(editedCompany);
            }
            else 
            {
                rowsAffected = updateCompanyInDB(editedCompany);
            }
            SqlHandler.closeConnectionToDataBase();

            return rowsAffected != 0;
        }

        private int insertCompanyIntoDB(Company newCompany) 
        {
            string sql = "INSERT INTO COMPANY ('Name', 'PIB', 'Address', 'City', 'PostalCode', 'Owner', 'BankAccount', 'IdentificationNumber', 'Bank', 'ActivityCode', 'Telephone', 'MobileNumber', 'Email', 'Fax', 'Deleted')" +
                "VALUES(@Name, @PIB, @Address, @City, @PostalCode, @Owner, @BankAccount, @IdentificationNumber, @Bank, @ActivityCode, @Telephone, @MobileNumber, @Email, @Fax, 0)";
            SqlParameter[] sqlParameters = newCompany.generateSqlParametersFromObjectFields();
            return SqlHandler.executionQuery(sql, sqlParameters);
        }  

        private int updateCompanyInDB(Company editedCompany) 
        {
            string sql = "UPDATE COMPANY SET Name=@Name, PIB=@PIB, Address=@Address, City=@City, PostalCode=@PostalCode, " +
                "Owner=@Owner, BankAccount=@BankAccount, IdentificationNumber=@IdentificationNumber, Bank=@Bank, ActivityCode=@ActivityCode," +
                "Telephone=@Telephone, MobileNumber=@MobileNumber, Email=@Email, Fax=@Fax WHERE CompanyId=" + editedCompany.CompanyId;
            SqlParameter[] sqlParameters = editedCompany.generateSqlParametersFromObjectFields();
            return SqlHandler.executionQuery(sql, sqlParameters);
        }

        public void updateCompanyInListOfCompanies(Company newCompany) 
        {
            ListOfCompanies[ListOfCompanies.FindIndex(ind => ind.CompanyId.Equals(newCompany.CompanyId))] = newCompany;
            ListOfCompanies[ListOfCompanies.IndexOf(newCompany)].CompanyId = getLastCompanyIdFromDB();
        }

        private int getLastCompanyIdFromDB() 
        {
            int id = 0;
            string sql = "SELECT CompanyID FROM COMPANY ORDER BY CompanyID desc LIMIT 1";
            SQLiteDataReader reader = SqlHandler.selectionQuery(sql);
            if (reader.Read()) 
            {
                id = reader.GetInt32(0);
            }
            return id;
        }

        public bool deleteCompany(int companyId) 
        {
            int indexOfCompany = ListOfCompanies.FindIndex(ind => ind.CompanyId.Equals(companyId));
            if (companyId == 0)
            {
                ListOfCompanies.RemoveAt(indexOfCompany);
                return true;
            }
            else
            {
                if (deleteCompanyFromDB(companyId) == 1)
                {
                    ListOfCompanies.RemoveAt(indexOfCompany);
                    SqlHandler.closeConnectionToDataBase();
                    return true;
                }
                else 
                {
                    SqlHandler.closeConnectionToDataBase();
                    return false;
                }
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
