using Frontend.Entities;
using Microsoft.EntityFrameworkCore;

namespace Frontend.DatabaseContext
{
    public class FrontendDbContext : DbContext
    {
        public FrontendDbContext(DbContextOptions<FrontendDbContext> options) : base(options)
        {
        }
        public DbSet<LogObject> Logs { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<LogObject>()
                .Property(t => t.CreatedAt)
                .HasDefaultValueSql("getdate()");
        }
    }
}
