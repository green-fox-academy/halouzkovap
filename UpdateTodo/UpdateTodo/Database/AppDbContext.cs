using Microsoft.EntityFrameworkCore;
using UpdateTodo.Entitiy;

namespace UpdateTodo.Database
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Todo> Todos { get; set; }
        public DbSet<Assignee> Assignees { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<SubTodo> SubTodos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Todo>()
                .Property(t => t.CreateAt)
                .HasDefaultValueSql("getdate()");
            modelBuilder.Entity<SubTodo>()
             .Property(t => t.CreateAt)
             .HasDefaultValueSql("getdate()");

        }


    }
}
