using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObject;

namespace DataAccessObject
{
    public class ManufacturerSupplierDAO
    {
        private static ManufacturerSupplierDAO instance = null;
        public static readonly object Lock = new object();
        private ManufacturerSupplierDAO() { }
        public static ManufacturerSupplierDAO Instance
        {
            get
            {
                lock (Lock)
                {
                    if (instance == null)
                    {
                        instance = new ManufacturerSupplierDAO();
                    }
                    return instance;
                }
            }
        }
        public List<Manufacturer> GetManufacturers()
        {
            using var db = new FUCarRentingManagementContext();
            return db.Manufacturers.ToList();
        }
        public List<Supplier> GetSuppliers()
        {
            using var db = new FUCarRentingManagementContext();
            return db.Suppliers.ToList();
        }
    }
}
