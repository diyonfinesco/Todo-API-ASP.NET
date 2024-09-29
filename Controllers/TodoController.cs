using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Todo.Entities;

namespace Todo.Controller
{
    [Route("/todos")]
    [ApiController]
    public class TodoController : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> GetAllTodos()
        {
            var todos = new List<TodoEntity>{
                new TodoEntity
                {
                    Id=1,
                    Title = "todo 1",
                    Description =  ""
                }
            };

            return Ok(todos);
        }
    }
}