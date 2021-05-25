using System;
using System.Collections.Generic;

#nullable disable

namespace Pharmacy_Store.Models
{
    public partial class Product
    {
        public Product()
        {
            ProductPharmacies = new HashSet<ProductPharmacy>();
        }

        public int IdProduct { get; set; }
        public string NameProduct { get; set; }
        public int CountProduct { get; set; }
        public decimal PriceProduct { get; set; }

        public virtual ICollection<ProductPharmacy> ProductPharmacies { get; set; }
    }
}
