using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DatingApp.API.Data;
using DatingApp.API.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DatingApp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class valueController : ControllerBase
    {
        private readonly ApplicationDbContext _applicationDbContext;

        public valueController(ApplicationDbContext applicationDbContext)
        {
            this._applicationDbContext = applicationDbContext;
        }

        // GET: api/value
        [HttpGet]
        public async Task<IEnumerable<Value>> Get()
        {
            return await _applicationDbContext.Values.ToListAsync();
        }

        // GET: api/value/5
        [HttpGet("{id}", Name = "Get")]
        public async Task<IActionResult> Get(int id)
        {
            var value = await _applicationDbContext.Values.FindAsync(id);
            if (value == null) return NotFound();
            return Ok(value);
        }

        // POST: api/value
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/value/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
