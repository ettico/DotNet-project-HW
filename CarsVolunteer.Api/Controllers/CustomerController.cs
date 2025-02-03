using Microsoft.AspNetCore.Mvc;
using CarsVolunteer.Api.Models;
using CarsVolunteer.Core.Entities;
using CarsVolunteer.Core.Service;
using AutoMapper;
using CarsVolunteer.Core.DTOs;
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CarsVolunteer.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerServies _customerService;
        private readonly IMapper _mapper;
        public CustomerController(ICustomerServies customerService,IMapper mapper)
        {
            _customerService = customerService;
            _mapper = mapper;
        }
        // GET: api/<CustomerController>
        [HttpGet]
        public async Task<ActionResult> Get()
        {
            var list =await _customerService.GetListOfCustomerAsync();
            var custDTO = _mapper.Map<IEnumerable<CustomerDTO>>(list);
            return Ok(custDTO);
        }

        // GET api/<CustomerController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Customer>> Get(int id)
        {
            var cust =await _customerService.GetCustomerByIdAsync(id);
            var custDTO = _mapper.Map<CustomerDTO>(cust);
            return Ok(custDTO);
        }

        // POST api/<CustomerController>
        [HttpPost]
        public async Task<ActionResult<Customer>> Post([FromBody] CustomerPostModel c)
        {
            var customer=new Customer { castName=c.castName,castAddress=c.castAddress, castPhone=c.castPhone,castEmail=c.castEmail,VolunteerId=c.VolunteerId};
            return await _customerService.AddCustomerAsync(customer);
        }

        // PUT api/<CustomerController>/5
        [HttpPut("{id}")]
        public async Task<ActionResult<Customer>> Put(int id, [FromBody] CustomerPostModel c)
        {
            var customer = new Customer { castName = c.castName, castAddress = c.castAddress, castPhone = c.castPhone, castEmail = c.castEmail, VolunteerId = c.VolunteerId };

            return await _customerService.UpdateCustomerAsync(id, customer);
        }

        // DELETE api/<CustomerController>/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Customer>> Delete(int id)
        {
            return await _customerService.DeleteCustomerAsync(id);
        }
    }
}
