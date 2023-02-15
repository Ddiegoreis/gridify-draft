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

            _context.ToDos.AddRange(ToDoSeed.ReturnToDos());
            _context.SaveChanges();
        }

        [HttpGet("todos")]
        public IActionResult GetToDos([FromQuery]GridifyQuery modelQuery)
        {
            var result = _context.ToDos.GridifyQueryable(modelQuery);

            return Ok(result);
        }

        [HttpGet("todos/done")]
        public IActionResult GetDoneToDos()
        {
            GridifyQuery modelQuery = new GridifyQuery()
            {
                Filter = "Done=1"
            };

            var result = _context.ToDos.GridifyQueryable(modelQuery);

            return Ok(result);
        }
    }
}
