using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using שב_4.Controllers.properties;

namespace CarsVolunteer.core.Repositories
{
    public interface IApplicationRepository
    {
        public List<Application> GetListOfApplication();
        public Application GetApplicationById(int id);
        public bool AddApplication(Application travel);
        public bool DeleteApplication(int id);
        public bool UpdateApplication(int id, Application travel);
    }
}
