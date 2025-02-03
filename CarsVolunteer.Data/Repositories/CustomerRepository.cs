using CarsVolunteer.core.Repositories;
using CarsVolunteer.Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace CarsVolunteer.Data.Repositories
{
    public class CustomerRepository:ICustomerRepository
    {
        private readonly DataContext _dataContext;

        public CustomerRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }
        //שליפת רשימת לקוחות
        public async Task<IEnumerable<Customer>> GetListOfCustomerAsync()
        {
            return await _dataContext.customers.Include(c=>c.Volun).ToListAsync();
        }
        //שליפת לקוח לפי ID
        public async Task<Customer> GetCustomerByIdAsync(int id)
        {
            var customer= await _dataContext.customers.FirstOrDefaultAsync(x=> x.castId == id);
            if (customer == null)
            {
                throw new ArgumentException($"Application with id {id} was not found.");
            }
            return customer;
        }
        //הוספת לקוח
        public async Task<Customer> AddCustomerAsync(Customer customer)
        {
            
            _dataContext.customers.Add(customer);
            await _dataContext.SaveChangesAsync();
            return customer;
        }


        public async Task<Customer> DeleteCustomerAsync(int id)
        {
          var customer= await _dataContext.customers.FirstOrDefaultAsync(x => x.castId == id);
            if (customer == null)
            {
                throw new ArgumentException($"Application with id {id} was not found.");
            }
            _dataContext.customers.Remove(customer);
            await _dataContext.SaveChangesAsync();
            return customer;
        }

        //עדכון לקוח
        public async Task<Customer> UpdateCustomerAsync(int id, Customer customer)
        {
          await  DeleteCustomerAsync(id);
          await  AddCustomerAsync(customer);
          await _dataContext.SaveChangesAsync();
            return customer;
        }
    }
}

