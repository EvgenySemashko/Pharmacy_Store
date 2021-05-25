using System;
using System.Collections.Generic;

#nullable disable

namespace Pharmacy_Store.Models
{
    public partial class AdressesPharmacy
    {
        public int IdAdressPharmacy { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public string NumberBuilding { get; set; }
    }
}
