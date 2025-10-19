using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StorageManagementProject
{
    public class Product
    {
        public string Sku { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set; }
        public string Category { get; set; }
        public DateTime DateAdded { get; set; }
        public string Supplier { get; set; }
        public double VatRate { get; set; }
        public string Note { get; set; }
    }

}
