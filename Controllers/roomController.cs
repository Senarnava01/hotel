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
    public class roomController : ControllerBase
    {
        private readonly hoteldbContext _context;
        public roomController(hoteldbContext context)
        { _context = context; }

        // GET: api/<roomController>
        [HttpGet]
        public IEnumerable<room> Get()
        {
            return _context.booking.ToList();
        }

        // GET api/<roomController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<roomController>
        [HttpPost]
        public string Post([FromBody] room value)
        {
            _context.booking.Add(value);
            _context.SaveChanges();
            return "sucess";
        }

        // PUT api/<roomController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<roomController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
