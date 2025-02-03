using CarsVolunteer.core.Repositories;
using CarsVolunteer.Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarsVolunteer.Data.Repositories
{
    public class ApplicationRepository: IApplicationRepository
    {
        private readonly DataContext _dataContext;

        public ApplicationRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }
        public async Task<Application> AddApplicationAsync(Application Application)
        {
            _dataContext.Applications.Add(Application);
           await _dataContext.SaveChangesAsync();
            return Application;
        }

        public async Task<Application> DeleteApplicationAsync(int id)
        {
            var application =await _dataContext.Applications.FirstOrDefaultAsync(x=>x.appId==id);
            if (application == null)
            {
                throw new ArgumentException($"Application with id {id} was not found.");
            }
            _dataContext.Applications.Remove(application);
            await _dataContext.SaveChangesAsync();
            return application;
        }

        public async Task<IEnumerable<Application>> GetListOfApplicationAsync()
        {
            return await _dataContext.Applications.Include(u => u.Customer).ToListAsync();
        }

        public async Task<Application> GetApplicationByIdAsync(int id)
        {
            var application = await _dataContext.Applications.FirstOrDefaultAsync(x => x.appId == id);
            if (application == null)
            {
                throw new ArgumentException($"Application with id {id} was not found.");
            }
            return application;
        }

       

        public async Task<Application> UpdateApplicationAsync(int id, Application application)
        {
            await DeleteApplicationAsync(id);
            await _dataContext.SaveChangesAsync();
            return  await AddApplicationAsync(application);


        }
    }
}
