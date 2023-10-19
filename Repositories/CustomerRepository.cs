using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObject;
using DataAccessObject;

namespace Repositories
{
    public class CustomerRepository : ICustomerRepository
    {
        public List<Customer> GetCustomers() => CustomerDAO.Instance.GetCustomers();
        public Customer CheckLogin(string username, string password)
            => CustomerDAO.Instance.CheckLogin(username, password);
        public Customer GetCustomerById(int id) => CustomerDAO.Instance.GetCustomerById(id);
        public void Register(Customer cus) => CustomerDAO.Instance.Register(cus);
        public void DeleteCus(Customer cus) => CustomerDAO.Instance.RemoveCustomer(cus);
    }
}
