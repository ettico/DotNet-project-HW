using AutoMapper;
using CarsVolunteer.Core.DTOs;
using CarsVolunteer.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarsVolunteer.Core
{
    public class MappingProfile:Profile
    {
        public MappingProfile()
        {
            CreateMap<Application, ApplicationDTO>().ReverseMap();
            CreateMap<Customer, CustomerDTO>().ReverseMap();
            CreateMap<Volunteer, VolunteerDTO>().ReverseMap();
        }
    }
}
