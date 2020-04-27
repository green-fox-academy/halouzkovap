using Microsoft.EntityFrameworkCore;

namespace BankOfSimba.Models
{
    public class BankOfSimbaDbContext : DbContext
    {
        public BankOfSimbaDbContext(DbContextOptions<BankOfSimbaDbContext> options) : base(options)
        {

        }

        public DbSet<BankAccount> BankAccounts { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //seed categories
            modelBuilder.Entity<BankAccount>().HasData(new BankAccount { Id = 1, Name = "Simba", Balance = 2000, AnimalType = "lion" });
            modelBuilder.Entity<BankAccount>().HasData(new BankAccount { Id = 2, Name = "Hathi", Balance = 5000, AnimalType = "elephant" });
            modelBuilder.Entity<BankAccount>().HasData(new BankAccount { Id = 3, Name = "Akela", Balance = 6000, AnimalType = "wolf" });
            modelBuilder.Entity<BankAccount>().HasData(new BankAccount { Id = 4, Name = "Balu", Balance = 1000, AnimalType = "bear" });
            modelBuilder.Entity<BankAccount>().HasData(new BankAccount { Id = 5, Name = "Ka", Balance = 500, AnimalType = "snike" });
            modelBuilder.Entity<BankAccount>().HasData(new BankAccount { Id = 6, Name = "King", Balance = 500, AnimalType = "person" });
            modelBuilder.Entity<BankAccount>().HasData(new BankAccount { Id = 7, Name = "Bad Guy", Balance = 500, AnimalType = "person" });
            modelBuilder.Entity<BankAccount>().HasData(new BankAccount { Id = 8, Name = "Good Guy", Balance = 500, AnimalType = "person" });
        }
    }
}
