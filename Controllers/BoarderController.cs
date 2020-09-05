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
    public class BoarderController : ControllerBase
    {
        private readonly hoteldbContext _context;
        public BoarderController(hoteldbContext context)
        { _context = context; }
           
        // GET: api/<BoarderController>
        [HttpGet]
        public IEnumerable<Boarder> Get()
        {
            return _context.Boarders.ToList();
        }

        // GET api/<BoarderController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<BoarderController>
        [HttpPost]
        public string Post([FromBody] Boarder value)
        {
            _context.Boarders.Add(value);
            _context.SaveChanges();
            return "sucess";

        }

        // PUT api/<BoarderController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<BoarderController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
