using CarsVolunteer.core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using שב_4.Controllers.properties;

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
        public List<Customer> GetListOfCustomer()
        {
            return _dataContext.customers.ToList();
        }
        //שליפת לקוח לפי ID
        public Customer GetCustomerById(int id)
        {
            return _dataContext.customers.ToList().Find(x=> x.castId == id);    
        }
        //הוספת לקוח
        public bool AddCustomer(Customer customer)
        {
            //for (int i = 0; i < dataContext.customers.Count(); i++)
            //{
            //    if (GetCustomerById(customer.Id) == null)
            //        return false;
            //}
            _dataContext.customers.Add(customer);
            _dataContext.SaveChanges();
            return true;
        }


        public bool DeleteCustomer(int id)
        {
            _dataContext.customers.Remove(GetCustomerById(id));
            _dataContext.SaveChanges();
            return true;
        }

        //עדכון לקוח
        public bool UpdateCustomer(int id, Customer customer)
        {
            DeleteCustomer(id);
            AddCustomer(customer);
            _dataContext.SaveChanges();
            return true;
            /*if (_dataContext.customers == null)
                return false;
            for (int i = 0; i < _dataContext.customers.Count(); i++)
            {
                if (_dataContext.customers.ToList()[i].Id == id)
                {
                    _dataContext.customers.ToList()[i].Id = customer.Id;
                    _dataContext.customers.ToList()[i].Name = customer.Name;
                    _dataContext.customers.ToList()[i].Address = customer.Address;
                    _dataContext.customers.ToList()[i].Email = customer.Email;
                    _dataContext.customers.ToList()[i].Phone = customer.Phone;
                    _dataContext.customers.ToList()[i].Destination = customer.Destination;
                    return true;
                }
            }
            return false;*/
        }
    }
}

