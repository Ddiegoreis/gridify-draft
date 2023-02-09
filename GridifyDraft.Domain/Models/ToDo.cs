namespace GridifyDraft.Domain.Models
{
    public class ToDo
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Title { get; set; }
        public bool Done { get; set; }
    }
}
