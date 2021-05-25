using System;
using System.Collections.Generic;

#nullable disable

namespace Pharmacy_Store.Models
{
    public partial class ProductPharmacy
    {
        public int IdProduct { get; set; }
        public int IdPharmacy { get; set; }

        public virtual Pharmacy IdPharmacyNavigation { get; set; }
        public virtual Product IdProductNavigation { get; set; }
    }
}
