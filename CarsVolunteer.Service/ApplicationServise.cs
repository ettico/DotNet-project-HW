using CarsVolunteer.core.Repositories;
using CarsVolunteer.core.servies;
using שב_4.Controllers.properties;

namespace Project.Servies
{
    public class ApplicationServies : IApplicationServies
    {
        readonly private IApplicationRepository _ApplicationRepository;

        public bool AddApplication(Application application)
        {
            _ApplicationRepository.AddApplication(application);
            return true;
        }

        public bool DeleteApplication(int id)
        {
            _ApplicationRepository.DeleteApplication(id);
            return true;
        }

        public ApplicationServies(IApplicationRepository applicationRepository)
        {
            _ApplicationRepository = applicationRepository ?? throw new ArgumentNullException(nameof(applicationRepository));
        }
        public List<Application> GetListOfApplication()
        {
          return _ApplicationRepository.GetListOfApplication();
             
        }

        public Application GetApplicationById(int id)
        {
           return _ApplicationRepository.GetApplicationById(id);
           //var application = _dataContext.Applications.FirstOrDefault(a => a.Id == id);
           //if (application == null)
           //{
           //   throw new ArgumentException($"Application with id {id} was not found.");
           //}
           //return application;
        }

        public bool UpdateApplication(int id, Application application)
        {
            return _ApplicationRepository.UpdateApplication(id, application);  
        }
    }
}

