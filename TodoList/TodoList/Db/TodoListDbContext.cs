using Microsoft.EntityFrameworkCore;
using TodoList.Models;

namespace TodoList.Db
{
    public class TodoListDbContext : DbContext
    {
        public TodoListDbContext(DbContextOptions<TodoListDbContext> options) : base(options)
        {
        }
        public DbSet<Todo> Todos { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Todo>()
                .Property(t => t.Inserted)
                .HasDefaultValueSql("getdate()");
        }
    }
}
