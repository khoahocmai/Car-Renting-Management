using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObject;
using DataAccessObject;

namespace Repositories
{
    public class ManufacturerSupplierRepository : IManufacturerSupplierRepository
    {
        public List<Manufacturer> GetManufacturers()=> ManufacturerSupplierDAO.Instance.GetManufacturers();
        public List<Supplier> GetSuppliers() => ManufacturerSupplierDAO.Instance.GetSuppliers();
    }
}
