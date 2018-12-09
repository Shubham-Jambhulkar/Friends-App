using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Friends.Api.Data;
using Microsoft.AspNetCore.Mvc;

namespace FriendsApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {

        // GET api/values
        [HttpGet]
        public IActionResult GetValues()
        {
            return Ok(_context.Values.ToList());
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }

        public ValuesController(DataContext context)
        {
            _context = context;
        }

        private readonly DataContext _context;
    }
}
