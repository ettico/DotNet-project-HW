using CarsVolunteer.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarsVolunteer.Core.Service
{
    public interface ICustomerServies
    {
        public Task<IEnumerable<Customer>> GetListOfCustomerAsync();
        public Task<Customer> GetCustomerByIdAsync(int id);
        public Task<Customer> AddCustomerAsync(Customer customer);
        public Task<Customer> DeleteCustomerAsync(int id);
        public Task<Customer> UpdateCustomerAsync(int id, Customer customer);
    }
}
