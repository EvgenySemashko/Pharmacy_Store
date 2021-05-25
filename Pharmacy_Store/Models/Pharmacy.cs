using System;
using System.Collections.Generic;

#nullable disable

namespace Pharmacy_Store.Models
{
    public partial class Pharmacy
    {
        public Pharmacy()
        {
            ProductPharmacies = new HashSet<ProductPharmacy>();
        }

        public int IdPharmacy { get; set; }
        public string NamePharmacy { get; set; }

        public virtual ICollection<ProductPharmacy> ProductPharmacies { get; set; }
    }
}
