using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GORIPBS.classes
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
        public string Bank { get; set; }
        public int ActivityCode { get; set; }
        public string Telephone { get; set; }
        public string MobileNumber { get; set; }
        public string Email { get; set; }
        public string Fax { get; set; }

        public Company() { }

        public Company(int companyId, string name, string pib, string address, string city, int postalCode, string owner, string bankAccount, string bank, int activityCode, string telephone, string mobileNumber, string email, string fax)
        {
            CompanyId = companyId;
            Name = name;
            PIB = pib;
            Address = address;
            City = city;
            PostalCode = postalCode;
            Owner = owner;
            BankAccount = bankAccount;
            Bank = bank;
            ActivityCode = activityCode;
            Telephone = telephone;
            MobileNumber = mobileNumber;
            Email = email;
            Fax = fax;
        }
    }
}
