using CarsVolunteer.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarsVolunteer.Core.Service
{
    public interface IVolunteerServies
    {
        public Task<IEnumerable<Volunteer>> GetListOfVolunteerAsync();
        public Task<Volunteer> GetVolunteerByIdAsync(int id);
        public Task<Volunteer> AddVolunteerAsync(Volunteer volunteer);
        public Task<Volunteer> DeleteVolunteerAsync(int id);
        public Task<Volunteer> UpdateVolunteerAsync(int id, Volunteer volunteer);
    }
}
