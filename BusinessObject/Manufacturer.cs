using System;
using System.Collections.Generic;

#nullable disable

namespace BusinessObject
{
    public partial class Manufacturer
    {
        public Manufacturer()
        {
            CarInformations = new HashSet<CarInformation>();
        }

        public int ManufacturerId { get; set; }
        public string ManufacturerName { get; set; }
        public string Description { get; set; }
        public string ManufacturerCountry { get; set; }

        public virtual ICollection<CarInformation> CarInformations { get; set; }
    }
}
