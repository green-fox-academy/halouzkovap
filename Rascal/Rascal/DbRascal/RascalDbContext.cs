using Microsoft.EntityFrameworkCore;
using Rascal.Entity;

namespace Rascal.DbRascal
{
    public class RascalDbContext : DbContext
    {
        public RascalDbContext(DbContextOptions<RascalDbContext> options) : base(options)
        {

        }

        public DbSet<User> Users { get; set; }
        public DbSet<UserApiKey> UserApiKeys { get; set; }
        public DbSet<MyChannel> Channels { get; set; }
    }
}
