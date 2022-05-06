using Microsoft.AspNetCore.Mvc;
using TO_DO.Context;
using TO_DO.Models;
using TO_DO.Seed;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TO_DO.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly SqlContext _context;
        public ValuesController(SqlContext context)
        {
            _context = context;
        }
        // GET: api/<ValuesController>
        [HttpGet]
        public IEnumerable<ToDo> Get()
        {
            return new List<ToDo>();
        }

        // GET api/<ValuesController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ToDo>> GetAddress(int id)
        {
            var todo = await _context.ToDos.FindAsync(id);

            if (todo == null)
            {
                return NotFound();
            }

            return todo;
        }

        // POST api/<ValuesController>
        [HttpPost]
        public async Task<CreatedAtActionResult> Post([FromBody] ToDo todos)
        {
            _context.ToDos.Add(todos);
            await _context.SaveChangesAsync();

            return CreatedAtAction("", new { id = todos.Id }, todos);
        }
    }
}
