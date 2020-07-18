using GORIPBS.database;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GORIPBS.classes.entities
{
    class Company
    {
        public int CompanyId { get; set; }
        public string Name { get; set; }
        public string PIB { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public int PostalCode { get; set; }
        public string Owner { get; set; }
        public string BankAccount { get; set; }
        public string IdentificationNumber { get; set; }
        public string Bank { get; set; }
        public int ActivityCode { get; set; }
        public string Telephone { get; set; }
        public string MobileNumber { get; set; }
        public string Email { get; set; }
        public string Fax { get; set; }

        public Company() 
        {
            CompanyId = 0;
            Name = "";
            PIB = "";
            Address = "";
            City = "";
            PostalCode = 0;
            Owner = "";
            BankAccount = "";
            IdentificationNumber = "";
            Bank = "";
            ActivityCode = 0;
            Telephone = "";
            MobileNumber = "";
            Email = "";
            Fax = "";
        }

        public Company(int companyId, string name, string pib, string address, string city, int postalCode, string owner, string bankAccount, string identificationNumber, string bank, int activityCode, string telephone, string mobileNumber, string email, string fax)
        {
            CompanyId = companyId;
            Name = name;
            PIB = pib;
            Address = address;
            City = city;
            PostalCode = postalCode;
            Owner = owner;
            BankAccount = bankAccount;
            IdentificationNumber = identificationNumber;
            Bank = bank;
            ActivityCode = activityCode;
            Telephone = telephone;
            MobileNumber = mobileNumber;
            Email = email;
            Fax = fax;
        }

        public SqlParameter[] generateSqlParametersFromObjectFields() 
        {
            return new SqlParameter[] {
                new SqlParameter("CompanyId", CompanyId.ToString(), DbType.Int32),
                new SqlParameter("Name", Name, DbType.String),
                new SqlParameter("PIB", PIB, DbType.String),
                new SqlParameter("Address", Address, DbType.String),
                new SqlParameter("City", City, DbType.String),
                new SqlParameter("PostalCode", PostalCode.ToString(), DbType.Int32),
                new SqlParameter("Owner", Owner, DbType.String),
                new SqlParameter("BankAccount", BankAccount, DbType.String),
                new SqlParameter("IdentificationNumber", IdentificationNumber, DbType.String),
                new SqlParameter("Bank", Bank, DbType.String),
                new SqlParameter("ActivityCode", ActivityCode.ToString(), DbType.Int32),
                new SqlParameter("Telephone", Telephone, DbType.String),
                new SqlParameter("MobileNumber", MobileNumber, DbType.String),
                new SqlParameter("Email", Email, DbType.String),
                new SqlParameter("Fax", Fax, DbType.String)
            };
        }
    }
}
