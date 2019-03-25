using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ChildController : ControllerBase

    {
        private readonly ChildContext _context;

        public ChildContext context { get; }

        public  ChildController(ChildContext _context)
        {
            _context = context;
            
            if (_context.Children.Count() == 0)
            {
                _context.Children.Add(new Child { FirstName = "Item1" });
                _context.SaveChanges();

            }

        }
        public async Task <ActionResult<IEnumerable<Child>>> GetChildren()
        {
            return await _context.Children.ToListAsync();
        }

        [HttpGet("{id}")]
        public  async Task<ActionResult<Child>>GetChild (long id)
        {
            var Child = await _context.Children.FindAsync(id);
            if(Child ==null)
            {
                return NotFound();
            }
            return Child;
        }


        // GET: api/<controller>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<controller>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<controller>
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/<controller>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
