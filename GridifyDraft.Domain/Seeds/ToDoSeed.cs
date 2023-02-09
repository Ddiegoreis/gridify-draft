using GridifyDraft.Domain.Models;

namespace GridifyDraft.Domain.Seeds
{
    public class ToDoSeed
    {
        public static IEnumerable<ToDo> ReturnToDos()
        {
            var todos = new List<ToDo>
            {
                new() { Title = "Study english", Done = false },
                new() { Title = "Study asp.net", Done = true },
                new() { Title = "Drink water", Done = false },
                new() { Title = "Work", Done = true },
                new() { Title = "Take a shower", Done = true }
            };

            return todos;
        }
    }
}
