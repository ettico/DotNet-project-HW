
using CarsVolunteer.core.Repositories;
using CarsVolunteer.Core.Entities;
using CarsVolunteer.Core.Service;
using System.Linq;
using System.Reflection.Metadata.Ecma335;

namespace Project.Servies
{
    public class VolunteerServies : IVolunteerServies
    {
        private readonly IVolunteerRepository _volunteerRepository;
        public VolunteerServies(IVolunteerRepository volunteerRepository)
        {
            _volunteerRepository=volunteerRepository;
        }
        public async Task<Volunteer> AddVolunteerAsync(Volunteer volunteer)
        {
           return await _volunteerRepository.AddVolunteerAsync(volunteer);
        }

        public async Task<Volunteer> DeleteVolunteerAsync(int id)
        {
          return  await _volunteerRepository.DeleteVolunteerAsync(id);
        }

        public async Task<IEnumerable<Volunteer>> GetListOfVolunteerAsync()
        {
            return await _volunteerRepository.GetListOfVolunteerAsync();
        }

        public async Task<Volunteer> GetVolunteerByIdAsync(int id)
        {
            return await _volunteerRepository.GetVolunteerByIdAsync(id);
        }

        public async Task<Volunteer> UpdateVolunteerAsync(int id, Volunteer volunteer)
        {
            return await _volunteerRepository.UpdateVolunteerAsync(id, volunteer);
        }
    }
}
