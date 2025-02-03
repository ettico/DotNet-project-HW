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
    public class VolunteerRepository : IVolunteerRepository
    {
        private readonly DataContext _dataContext;
        public VolunteerRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }
        public async Task<IEnumerable<Volunteer>> GetListOfVolunteerAsync()
        {
            return await _dataContext.volunteers.ToListAsync();
        }

        public async Task<Volunteer> GetVolunteerByIdAsync(int id)
        {
            var vol = await _dataContext.volunteers.FirstOrDefaultAsync(x => x.volId == id);
            if (vol == null)
            {
                throw new ArgumentException($"Application with id {id} was not found.");
            }
            return vol;
        }

        public async Task<Volunteer> DeleteVolunteerAsync(int id)
        {
            var vol = await _dataContext.volunteers.FirstOrDefaultAsync(x => x.volId == id);
            if (vol == null)
            {
                throw new ArgumentException($"Application with id {id} was not found.");
            }
            _dataContext.volunteers.Remove(vol);
            await _dataContext.SaveChangesAsync();
            return vol;
        }

        //הוספת לקוח
        public async Task<Volunteer> AddVolunteerAsync(Volunteer volunteer)
        {
            _dataContext.volunteers.Add(volunteer);
            await _dataContext.SaveChangesAsync();
            return volunteer;
        }
        public async Task<Volunteer> UpdateVolunteerAsync(int id, Volunteer volunteer)
        {
           await DeleteVolunteerAsync(id);
           await AddVolunteerAsync(volunteer);
           await _dataContext.SaveChangesAsync();
            return volunteer;
        }
    }
}
