using Microsoft.AspNetCore.Mvc;
using שב_4.Controllers.properties;
using שב_4.Properties;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace שב_4.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        // GET: api/<CustomerController>
        [HttpGet]
        public IEnumerable<DataManager> Get()
        {
            return (IEnumerable<DataManager>)DataManager.dataContect.customers;
        }
        
        // GET api/<CustomerController>/5
        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
         var cast =DataManager.dataContect.customers.FirstOrDefault(x=>x.castId==id);
            if (cast == null)
                return NotFound();
            return Ok(cast);
        }

        // POST api/<CustomerController>
        [HttpPost]//הוספה
        public void Post([FromBody] Customer customer)
        {
            DataManager.dataContect.customers.Add(customer);
        }

        // PUT api/<CustomerController>/5
        [HttpPut("{id}")]//עדכון
        public void Put(int id, [FromBody] Customer customer)
        {
            DataManager.dataContect.customers[id] = customer;
        }

        // DELETE api/<CustomerController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            foreach (Customer item in DataManager.dataContect.customers)
            {
                if (item.castId==id)
                    DataManager.dataContect.customers.Remove(item);
            }
        }
    }
}
