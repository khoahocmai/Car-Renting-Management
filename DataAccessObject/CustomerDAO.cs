using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObject;

namespace DataAccessObject
{
    public class CustomerDAO
    {
        private static CustomerDAO instance = null;
        public static readonly object Lock = new object();
        private CustomerDAO() { }
        public static CustomerDAO Instance
        {
            get
            {
                lock (Lock)
                {
                    if (instance == null)
                    {
                        instance = new CustomerDAO();
                    }
                    return instance;
                }
            }
        }
        public List<Customer> GetCustomers()
        {
            using var db = new FUCarRentingManagementContext();
            return db.Customers.ToList();
        }
        public Customer CheckLogin(string username, string password)
        {
            using var db = new FUCarRentingManagementContext();
            return db.Customers.SingleOrDefault(m => m.Email.Equals(username) && m.Password.Equals(password));
        }
        public Customer GetCustomerById(int id)
        {
            var tmp = GetCustomers().SingleOrDefault(m => m.CustomerId == id);
            return tmp;
        }
        public void Register(Customer cus)
        {
            using var db = new FUCarRentingManagementContext();
            db.Customers.Add(cus);
            db.SaveChanges();
        }
        public void RemoveCustomer(Customer cus)
        {
            using var db = new FUCarRentingManagementContext();
            var c1 = db.Customers.SingleOrDefault(m => m.CustomerId == cus.CustomerId);
            db.Customers.Remove(c1);
            db.SaveChanges();
        }
    }
}
