using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObject;

namespace Repositories
{
    public interface ICustomerRepository
    {
        List<Customer> GetCustomers();
        Customer CheckLogin(string username, string password);
        Customer GetCustomerById(int id);
        void Register(Customer cus);
        void DeleteCus(Customer cus);
    }
}
