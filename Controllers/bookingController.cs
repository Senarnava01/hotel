using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HotelManagement.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HotelManagement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class bookingController : ControllerBase
    {

        private readonly hoteldbContext _context;
        public bookingController(hoteldbContext context)
        { _context = context; }

        // GET: api/<bookingController>
        [HttpGet]
        public IEnumerable<booking> Get()
        {
            return _context.booking.ToList();
        }

        // GET api/<bookingController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<bookingController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<bookingController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<bookingController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
