﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pharmacy_Store.Models;

namespace Pharmacy_Store.CommandDataBase
{
    interface IDeleteProductFromPharmacy
    {
        void DeleteProductFromPharmacy(ProductPharmacy productPharmacy);
    }
}
