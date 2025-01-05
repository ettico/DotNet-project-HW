using CarsVolunteer.core.servies;
using Microsoft.AspNetCore.Mvc;
using שב_4.Controllers.properties;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ApplicationController : ControllerBase
    {
        readonly private IApplicationServies _ApplicationServies;
        public ApplicationController(IApplicationServies ApplicationServies)
        {
            _ApplicationServies = ApplicationServies;
        }
        // GET: api/<TravelControllerr>
        [HttpGet]
        public IEnumerable<Application> Get()
        {
            return _ApplicationServies.GetListOfApplication();
        }

        // GET api/<TravelControllerr>/5
        [HttpGet("{id}")]
        public Application Get(int id)
        {
            return _ApplicationServies.GetApplicationById(id);
        }

        // POST api/<TravelControllerr>
        [HttpPost]
        public ActionResult<bool> Post([FromBody] Application travel)
        {
            return _ApplicationServies.AddApplication(travel);
            
        }

        // PUT api/<TravelControllerr>/5
        [HttpPut("{id}")]
        public ActionResult<bool> Put(int id, [FromBody] Application travel)
        {
            return _ApplicationServies.UpdateApplication(id, travel);
        }

        // DELETE api/<TravelControllerr>/5
        [HttpDelete("{id}")]
        public ActionResult<bool> Delete(int id)
        {
            return _ApplicationServies.DeleteApplication(id);
        }
    }
}
