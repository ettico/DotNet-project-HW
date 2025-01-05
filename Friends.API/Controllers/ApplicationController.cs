using Microsoft.AspNetCore.Mvc;
using שב_4.Controllers.properties;
using שב_4.Properties;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace שב_4.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ApplicationController : ControllerBase
    {
        // GET: api/<ApplicationController>
        [HttpGet]
        public IEnumerable<DataManager> Get()
        {
            return (IEnumerable<DataManager>)DataManager.dataContect.applications;
        }


        // GET api/<ApplicationController>/5
        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
           var app= DataManager.dataContect.applications.FirstOrDefault(x => x.appId == id);
            if (app == null)
                return NotFound();
            return Ok(app);
        }

        // POST api/<ApplicationController>
        [HttpPost]
        public void Post([FromBody] Application application)
        {
            DataManager.dataContect.applications.Add(application);
        }

        // PUT api/<ApplicationController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Application application)
        {
            DataManager.dataContect.applications[id] = application;
        }

        // DELETE api/<ApplicationController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            foreach (Application item in DataManager.dataContect.applications)
            {
                if (item.appId == id)
                    DataManager.dataContect.applications.Remove(item);
            }
        }
    }
}
