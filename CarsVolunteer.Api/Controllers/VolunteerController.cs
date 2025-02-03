using AutoMapper;
using CarsVolunteer.Api.Models;
using CarsVolunteer.Core.DTOs;
using CarsVolunteer.Core.Entities;
using CarsVolunteer.Core.Service;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VolunteerController : ControllerBase
    {
        private readonly IVolunteerServies _volunteerServies;
        private readonly IMapper _mapper;
        public VolunteerController(IVolunteerServies volunteerServies,IMapper mapper)
        {
            _volunteerServies=volunteerServies;
            _mapper=mapper;
        }
        // GET: api/<Volunteer>
        [HttpGet]
        public async Task<ActionResult> Get()
        {
            var list =await _volunteerServies.GetListOfVolunteerAsync();
            var volDTO = _mapper.Map<IEnumerable<VolunteerDTO>>(list);
            return Ok(volDTO);
        }

        // GET api/<Volunteer>/5
        [HttpGet("{id}")]
        public async Task<ActionResult> Get(int id)
        {
            var vol=await _volunteerServies.GetVolunteerByIdAsync(id);
            var volDTO = _mapper.Map<VolunteerDTO>(vol);

            return Ok(volDTO);
        }

        // POST api/<Volunteer>
        [HttpPost]
        public async Task<ActionResult<Volunteer>> Post([FromBody] VolunteerPostModel volunteer)
        {
            var vol=new Volunteer { volName=volunteer.volName,volDomain=volunteer.volDomain,volPhone=volunteer.volPhone,volStatus=volunteer.volStatus};
             return await _volunteerServies.AddVolunteerAsync(vol);
        }

        // PUT api/<Volunteer>/5
        [HttpPut("{id}")]
        public async Task<ActionResult<Volunteer>> Put(int id, [FromBody] VolunteerPostModel volunteer)
        {
            var vol = new Volunteer { volName = volunteer.volName, volDomain = volunteer.volDomain, volPhone = volunteer.volPhone, volStatus = volunteer.volStatus };

            return await _volunteerServies.UpdateVolunteerAsync(id,vol);
        }

        // DELETE api/<Volunteer>/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Volunteer>> Delete(int id)
        {
            return await _volunteerServies.DeleteVolunteerAsync(id);
        }
    }
}
