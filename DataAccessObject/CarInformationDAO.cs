using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace DataAccessObject
{
    public class CarInformationDAO
    {
        private static CarInformationDAO instance = null;
        public static readonly object Lock = new object();
        private CarInformationDAO() { }
        public static CarInformationDAO Instance
        {
            get
            {
                lock (Lock)
                {
                    if (instance == null)
                    {
                        instance = new CarInformationDAO();
                    }
                    return instance;
                }
            }
        }
        public List<CarInformation> GetCarInformations()
        {
            using var db = new FUCarRentingManagementContext();
            return db.CarInformations
                    .Include(m => m.Manufacturer)
                    .Include(s => s.Supplier)
                    .ToList();
        }// Lấy ra danh sách các Car Information       
        public List<Manufacturer> GetManufacturerList()
        {
            using var db = new FUCarRentingManagementContext();
            return db.Manufacturers.ToList();
        }// Lấy danh sách các Manufacturers
        public List<Supplier> GetSupplierList()
        {
            using var db = new FUCarRentingManagementContext();
            return db.Suppliers.ToList();
        }// Lấy danh sách các Supplier

        public CarInformation GetCarInformationById(int id)
        {
            var tmp = GetCarInformations().SingleOrDefault(m => m.CarId == id);
            return tmp;
        }// Lấy Car Information theo Id
        public List<CarInformation> GetCarInformationByString(string value)
        {
            var tmp = GetCarInformations().FindAll(m => m.CarName.ToLower().Contains(value.ToLower()));
            return tmp;
        }// Lấy Car Information theo car name
        public List<CarInformation> GetCarInformationByCarRentingPricePerDay(decimal price)
        {
            var temp = GetCarInformations().FindAll(m => m.CarRentingPricePerDay <= price);
            return temp;
        }

        public void SaveCarInformation(CarInformation car)
        {
            using var db = new FUCarRentingManagementContext();
            db.CarInformations.Add(car);
            db.SaveChanges();
        }// Lưu Car Information
        public void UpdateCarInformation(CarInformation car)
        {
            using var db = new FUCarRentingManagementContext();
            db.CarInformations.Update(car);
            db.SaveChanges();
        }// Cập nhật Car Information
        public void RemoveCarInformation(CarInformation car)
        {
            using var db = new FUCarRentingManagementContext();
            var c1 = db.CarInformations.SingleOrDefault(m => m.CarId == car.CarId);
            db.CarInformations.Remove(c1);
            db.SaveChanges();
        }// Xóa Car Information
    }
}
