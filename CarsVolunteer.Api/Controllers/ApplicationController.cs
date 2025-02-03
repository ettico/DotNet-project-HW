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
    public class ApplicationController : ControllerBase
    {
        readonly private IApplicationServies _ApplicationServies;
        private readonly IMapper _mapper;
        public ApplicationController(IApplicationServies ApplicationServies,IMapper mapper)
        {
            _ApplicationServies = ApplicationServies;
            _mapper = mapper;
        }
        // GET: api/<TravelControllerr>
        [HttpGet]
        public async Task<ActionResult> Get()
        {
            var list=await _ApplicationServies.GetListOfApplicationAsync();
            var appDTO=_mapper.Map<IEnumerable<ApplicationDTO>>(list);
            return Ok(appDTO);
        }

        // GET api/<TravelControllerr>/5
        [HttpGet("{id}")]
        public async Task<ActionResult> Get(int id)
        {
            var app=await _ApplicationServies.GetApplicationByIdAsync(id);
            var appDTO=_mapper.Map<ApplicationDTO>(app);
            return Ok(appDTO);
        }

        // POST api/<TravelControllerr>
        [HttpPost]
        public async Task<Application> Post([FromBody] ApplicationPostModel Application)
        {
            var app=new Application { CustomerId=Application.CustomerId ,dateTime=Application.dateTime,Domain=Application.Domain,Location=Application.Location};
            return await _ApplicationServies.AddApplicationAsync(app);
            
        }

        // PUT api/<TravelControllerr>/5
        [HttpPut("{id}")]
        public async Task<ActionResult<Application>> Put(int id, [FromBody] ApplicationPostModel application)
        {
            var app = new Application { CustomerId = application.CustomerId, dateTime = application.dateTime, Domain = application.Domain, Location = application.Location };
            return await _ApplicationServies.UpdateApplicationAsync(id, app);
        }

        // DELETE api/<TravelControllerr>/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Application>> Delete(int id)
        {
            return await _ApplicationServies.DeleteApplicationAsync(id);
        }
    }
}
