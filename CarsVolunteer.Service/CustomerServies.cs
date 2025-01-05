using CarsVolunteer.core.servies;
using CarsVolunteer.core.Repositories;
using שב_4.Controllers.properties;

namespace Project.Servies
{
    public class CustomerServies : ICustomerServies
    {
        private readonly ICustomerRepository _CustomerRepository;
        public CustomerServies(ICustomerRepository CustomerRepository)
        {
            _CustomerRepository = CustomerRepository;
        }
        public List<Customer> GetListOfCustomer()
        {
            return _CustomerRepository.GetListOfCustomer();
        }
        public Customer GetCustomerById(int id)
        {
            return _CustomerRepository.GetCustomerById(id);
        }
        public bool AddCustomer(Customer customer)
        {
            return _CustomerRepository.AddCustomer(customer);
        }
        public bool DeleteCustomer(int id)
        {
            return _CustomerRepository.DeleteCustomer(id);
        }
        public bool UpdateCustomer(int id, Customer customer)
        {
            return _CustomerRepository.UpdateCustomer(id, customer);
        }
    }
}

