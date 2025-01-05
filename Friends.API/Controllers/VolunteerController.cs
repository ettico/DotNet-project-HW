using Microsoft.AspNetCore.Mvc;
using שב_4.Controllers.properties;
using שב_4.Properties;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace שב_4.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VolunteerController : ControllerBase
    {
        // GET: api/<VolunteerController>
        [HttpGet]
        public IEnumerable<DataManager> Get()
        {
            return (IEnumerable<DataManager>)DataManager.dataContect.volunteers;
        }

        // GET api/<VolunteerController>/5
        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            var vol= DataManager.dataContect.volunteers.FirstOrDefault(x => x.volId == id);
            if (vol == null)
                return NotFound();
            return Ok(vol);
        }

        // POST api/<VolunteerController>
        [HttpPost]
        public void Post([FromBody] Volunteer volunteer)
        {
            DataManager.dataContect.volunteers.Add(volunteer);
        }

        // PUT api/<VolunteerController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Volunteer volunteer)
        {
            DataManager.dataContect.volunteers[id] = volunteer;
        }

        // DELETE api/<VolunteerController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            foreach (Volunteer item in DataManager.dataContect.volunteers)
            {
                if (item.volId == id)
                    DataManager.dataContect.volunteers.Remove(item);
            }
        }
    }
}
