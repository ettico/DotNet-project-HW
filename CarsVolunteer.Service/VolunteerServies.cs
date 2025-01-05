
using CarsVolunteer.core.Repositories;
using CarsVolunteer.core.servies;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using שב_4.Controllers.properties;

namespace Project.Servies
{
    public class VolunteerServies : IVolunteerServies
    {
        private readonly IVolunteerRepository _volunteerRepository;
        public VolunteerServies(IVolunteerRepository volunteerRepository)
        {
            _volunteerRepository=volunteerRepository;
        }
        public bool AddVolunteer(Volunteer volunteer)
        {
            _volunteerRepository.AddVolunteer(volunteer);
            return true;
        }

        public bool DeleteVolunteer(int id)
        {
            _volunteerRepository.DeleteVolunteer(id);
            return true;
        }

        public List<Volunteer> GetListOfVolunteer()
        {
            return _volunteerRepository.GetListOfVolunteer();
        }

        public Volunteer GetVolunteerById(int id)
        {
            return _volunteerRepository.GetVolunteerById(id);
        }

        public bool UpdateVolunteer(int id, Volunteer volunteer)
        {
            return _volunteerRepository.UpdateVolunteer(id, volunteer);
        }
    }
}
