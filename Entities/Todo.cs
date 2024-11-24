namespace Todo_API.Entities
{
    public class TodoEntity
    {
        public int Id { get; set; }
        public required string Title { get; set; }
        public string Description { get; set; } = string.Empty;
    }
}