using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GORIPBS.classes.entities
{
    class InvoiceItem
    {
        public Item Item { get; set; }
        public int OrderingNumber { get; set; }
        public string UnitOfMeasure { get; set; }
        public int Quantity { get; set; }
        public double UnitPrice { get; set; }
        public double TaxBase { get; set; }

        public InvoiceItem() { }

        public InvoiceItem(Item item, int orderingNumber, string unitOfMeasure, int quantity, double unitPrice, double taxBase)
        {
            Item = item;
            OrderingNumber = orderingNumber;
            UnitOfMeasure = unitOfMeasure;
            Quantity = quantity;
            UnitPrice = unitPrice;
            TaxBase = taxBase;
        }
    }
}
