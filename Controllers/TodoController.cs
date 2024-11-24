using Microsoft.AspNetCore.Mvc;
using Todo_API.Entities;
using Todo_API.Services;

namespace Todo_API.Controllers
{
    [Route("/todos")]
    [ApiController]
    public class TodoController : ControllerBase
    {
        private readonly ITodoService _todoService;

        public TodoController(ITodoService todoService)
        {
            _todoService = todoService;
        }

        [HttpGet]
        public IActionResult GetAllTodos()
        {
            return Ok(_todoService.GetAllTodos());
        }

        [HttpGet]
        [Route("{id}")]
        public IActionResult GetTodo(int id)
        {
            return Ok(_todoService.GetTodoById(id));
        }

        [HttpPost]
        public IActionResult CreateTodo(TodoEntity newTodoEntity)
        {
            return Ok(_todoService.AddTodo(newTodoEntity));
        }

        [HttpPost]
        [Route("{id}")]
        public IActionResult UpdateTodo(int id, TodoEntity updateTodoEntity)
        {
            return Ok(_todoService.UpdateTodo(id, updateTodoEntity));
        }

        [HttpDelete]
        [Route("{id}")]
        public IActionResult DeleteTodo(int id)
        {
            return Ok(_todoService.DeleteTodo(id));
        }
    }
}