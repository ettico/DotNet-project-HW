using CarsVolunteer.core.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using שב_4.Controllers.properties;

namespace CarsVolunteer.Data.Repositories
{
    public class ApplicationRepository: IApplicationRepository
    {
        private readonly DataContext _dataContext;

        public ApplicationRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }
        public bool AddApplication(Application Application)
        {
            _dataContext.Applications.Add(Application);
            _dataContext.SaveChanges();
            return true;
        }

        public bool DeleteApplication(int id)
        {
            var application = GetApplicationById(id);
            if (application == null)
            {
                throw new ArgumentException($"Application with id {id} was not found.");
            }
            _dataContext.Applications.Remove(GetApplicationById(id));
            _dataContext.SaveChanges();
            return true;
        }

        public List<Application> GetListOfApplication()
        {
            return _dataContext.Applications.ToList();//.Include(u => u.customer)
        }

        public Application GetApplicationById(int id)
        {
            return _dataContext.Applications.ToList().Find(x => x.appId == id);
        }

        public bool UpdateApplication(int id, Application travel)
        {
            DeleteApplication(id);
            AddApplication(travel);
            _dataContext.SaveChanges();
            return true;
        }
    }
}
