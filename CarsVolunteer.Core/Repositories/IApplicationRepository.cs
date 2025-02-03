using CarsVolunteer.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarsVolunteer.core.Repositories
{
    public interface IApplicationRepository
    {
        public Task<IEnumerable<Application>> GetListOfApplicationAsync();
        public Task<Application> GetApplicationByIdAsync(int id);
        public Task<Application> AddApplicationAsync(Application application);
        public Task<Application> DeleteApplicationAsync(int id);
        public Task<Application> UpdateApplicationAsync(int id, Application application);
    }
}
