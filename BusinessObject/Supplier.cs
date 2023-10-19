using System;
using System.Collections.Generic;

#nullable disable

namespace BusinessObject
{
    public partial class Supplier
    {
        public Supplier()
        {
            CarInformations = new HashSet<CarInformation>();
        }

        public int SupplierId { get; set; }
        public string SupplierName { get; set; }
        public string SupplierDescription { get; set; }
        public string SupplierAddress { get; set; }

        public virtual ICollection<CarInformation> CarInformations { get; set; }
    }
}
