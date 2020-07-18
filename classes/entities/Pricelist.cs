using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GORIPBS.classes.entities
{
    class Pricelist
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public int Discount { get; set; }

        public Pricelist() { }

        public Pricelist(string name, string type, int discount)
        {
            Name = name;
            Type = type;
            Discount = discount;
        }
    }
}
