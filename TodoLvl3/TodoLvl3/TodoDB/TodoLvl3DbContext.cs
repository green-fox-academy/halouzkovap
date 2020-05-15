using Microsoft.EntityFrameworkCore;
using TodoLvl3.Entity;

namespace TodoLvl3.TodoDB
{
    public class TodoLvl3DbContext : DbContext
    {
        public TodoLvl3DbContext(DbContextOptions<TodoLvl3DbContext> options) : base(options)
        {

        }
        public DbSet<Assignee> Assignees { get; set; }
        public DbSet<Mentor> Mentors { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<Entity.Task> Tasks { get; set; }
        public DbSet<SubTask> SubTasks { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Entity.Task>()
                .Property(t => t.CreateAt)
                .HasDefaultValueSql("getdate()");
            modelBuilder.Entity<SubTask>()
             .Property(t => t.CreateAt)
             .HasDefaultValueSql("getdate()");

        }
    }
}
