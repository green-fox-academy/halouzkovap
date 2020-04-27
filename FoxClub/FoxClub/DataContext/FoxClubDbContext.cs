using FoxClub.Models;

using Microsoft.EntityFrameworkCore;

namespace FoxClub.DataContext
{
    public class FoxClubDbContext : DbContext
    {
        public FoxClubDbContext(DbContextOptions<FoxClubDbContext> options) : base(options)
        {

        }
        public DbSet<Fox> Foxes { get; set; }
        public DbSet<Trick> Tricks { get; set; }
        public DbSet<Nutrition> Nutritions { get; set; }
    }
}
