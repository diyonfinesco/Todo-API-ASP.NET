using Todo_API.Entities;

namespace Todo_API.Services
{
    public class TodoService : ITodoService
    {
        private readonly List<TodoEntity> _todos;

        public TodoService()
        {
            _todos = new List<TodoEntity>()
        {
            new TodoEntity()
            {
                Id = 1,
                Title = "Wash clothes"
            }
        };
        }

        public List<TodoEntity> GetAllTodos()
        {
            return _todos;
        }

        public TodoEntity? GetTodoById(int id)
        {
            return _todos.Find(entity => entity.Id == id);
        }

        public TodoEntity AddTodo(TodoEntity todoEntity)
        {
            _todos.Add(todoEntity);
            return todoEntity;
        }

        public TodoEntity UpdateTodo(int id, TodoEntity updateEntity)
        {
            throw new NotImplementedException();
        }

        public bool DeleteTodo(int id)
        {
            throw new NotImplementedException();
        }
    }
}