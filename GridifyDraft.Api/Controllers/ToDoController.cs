using Gridify;
using GridifyDraft.Api.Context;
using GridifyDraft.Domain.Seeds;
using Microsoft.AspNetCore.Mvc;

namespace GridifyDraft.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ToDoController : ControllerBase
    {
        private readonly ToDoContext  _context;

        public ToDoController(ToDoContext context)
        {
            _context = context;
        }

        [HttpGet("todos")]
        public IActionResult GetToDos([FromQuery]GridifyQuery modelQuery)
        {
            if (!_context.ToDos.Any())
            {
                _context.ToDos.AddRange(ToDoSeed.ReturnToDos());
                _context.SaveChanges();
            }

            var result = _context.ToDos.GridifyQueryable(modelQuery);

            return Ok(result);
        }
    }
}
