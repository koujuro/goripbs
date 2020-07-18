using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GORIPBS.classes.entities
{
    class Invoice
    {
        public int Id { get; set; }
        public Company Company { get; set; }
        public List<InvoiceItem> Items { get; set; }
        public string DateOfIssue { get; set; }
        public string PlaceOfIssue { get; set; }
        public string DateOfSupply { get; set; }
        public string DateOfPayment { get; set; }
        public string Status { get; set; }
        public double TotalBilling { get; set; }

        public Invoice() { }

        public Invoice(int id, Company company, List<InvoiceItem> items, string dateOfIssue, string placeOfIssue, string dateOfSupply, string dateOfPayment, string status, double totalBilling)
        {
            Id = id;
            Company = company;
            Items = items;
            DateOfIssue = dateOfIssue;
            PlaceOfIssue = placeOfIssue;
            DateOfSupply = dateOfSupply;
            DateOfPayment = dateOfPayment;
            Status = status;
            TotalBilling = totalBilling;
        }
    }
}
