using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using שב_4.Controllers.properties;

namespace CarsVolunteer.core.Repositories
{
    public interface ICustomerRepository
    {
        public List<Customer> GetListOfCustomer();
        public Customer GetCustomerById(int id);
        public bool AddCustomer(Customer customer);
        public bool DeleteCustomer(int id);
        public bool UpdateCustomer(int id, Customer customer);
    }
}
