using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GORIPBS.classes.entities
{
    class Item
    {
        public string ItemCode { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }

        public Item() { }

        public Item(string itemCode, string name, int price) 
        {
            this.ItemCode = itemCode;
            this.Name = name;
            this.Price = price;
        }
    }
}
