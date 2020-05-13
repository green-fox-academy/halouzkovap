using Microsoft.EntityFrameworkCore;
using TrainToTest.Enity;

namespace TrainToTest.DbTTT
{
    public class TrainToTestDbContext : DbContext
    {
        public TrainToTestDbContext(DbContextOptions<TrainToTestDbContext> options) : base(options)
        {

        }

        public DbSet<UrlAliaser> UrlAliasers { get; set; }
    }
}
