using CarsVolunteer.core.Repositories;
using CarsVolunteer.Core.Entities;
using CarsVolunteer.Core.Service;

namespace Project.Servies
{
    public class CustomerServies : ICustomerServies
    {
        private readonly ICustomerRepository _CustomerRepository;
        public CustomerServies(ICustomerRepository CustomerRepository)
        {
            _CustomerRepository = CustomerRepository;
        }
        public async Task<IEnumerable<Customer>> GetListOfCustomerAsync()
        {
            return await _CustomerRepository.GetListOfCustomerAsync();
        }
        public async Task<Customer> GetCustomerByIdAsync(int id)
        {
            return await _CustomerRepository.GetCustomerByIdAsync(id);
        }
        public async Task<Customer> AddCustomerAsync(Customer customer)
        {
            return await _CustomerRepository.AddCustomerAsync(customer);
        }
        public async Task<Customer> DeleteCustomerAsync(int id)
        {
            return await _CustomerRepository.DeleteCustomerAsync(id);
        }
        public async Task<Customer> UpdateCustomerAsync(int id, Customer customer)
        {
            return await _CustomerRepository.UpdateCustomerAsync(id, customer);
        }
    }
}

