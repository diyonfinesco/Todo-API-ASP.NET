using Todo_API.Entities;

namespace Todo_API.Services
{
    public interface ITodoService
    {
        List<TodoEntity> GetAllTodos();
        TodoEntity? GetTodoById(int id);
        TodoEntity AddTodo(TodoEntity todoEntity);
        TodoEntity UpdateTodo(int id, TodoEntity updateEntity);
        bool DeleteTodo(int id);
    }
}