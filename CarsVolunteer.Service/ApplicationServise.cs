using CarsVolunteer.core.Repositories;
using CarsVolunteer.Core.Entities;
using CarsVolunteer.Core.Service;

namespace Project.Servies
{
    public class ApplicationServies : IApplicationServies
    {
        readonly private IApplicationRepository _ApplicationRepository;

        public ApplicationServies(IApplicationRepository applicationRepository)
        {
            _ApplicationRepository = applicationRepository ?? throw new ArgumentNullException(nameof(applicationRepository));
        }
        public async Task<Application> AddApplicationAsync(Application application)
        {
           await _ApplicationRepository.AddApplicationAsync(application);
            return application;
        }

        public async Task<Application> DeleteApplicationAsync(int id)
        {
           return  await _ApplicationRepository.DeleteApplicationAsync(id);
        }

       
        public async Task<IEnumerable<Application>> GetListOfApplicationAsync()
        {
          return await _ApplicationRepository.GetListOfApplicationAsync();
             
        }

        public async Task<Application> GetApplicationByIdAsync(int id)
        {
           return await _ApplicationRepository.GetApplicationByIdAsync(id);
           //var application = _dataContext.Applications.FirstOrDefault(a => a.Id == id);
           //if (application == null)
           //{
           //   throw new ArgumentException($"Application with id {id} was not found.");
           //}
           //return application;
        }

      

        public async Task<Application> UpdateApplicationAsync(int id, Application application)
        {
            return await _ApplicationRepository.UpdateApplicationAsync(id, application);

        }
    }
}

