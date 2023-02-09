using GridifyDraft.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace GridifyDraft.Api.Context
{
    public class ToDoContext : DbContext
    {
        protected ToDoContext(DbContextOptions options)
        : base(options) { }

        public ToDoContext(DbContextOptions<ToDoContext> options)
            : this((DbContextOptions)options)
        {
        }

        public DbSet<ToDo> ToDos { get; set; }
    }
}
