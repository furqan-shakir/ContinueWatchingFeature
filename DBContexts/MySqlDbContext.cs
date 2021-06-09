using MoviesApis.Models;
using Microsoft.EntityFrameworkCore;
using MoviesApis.Extensions;

namespace MoviesApis.DBContexts
{
    public class MySqlDbContext : DbContext
    {
        public DbSet<Series> Serieses { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Season> Seasons { get; set; }
        public DbSet<Video> Videos { get; set; }
        public MySqlDbContext(DbContextOptions<MySqlDbContext> options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Use seed extension to move the logic of seeding the db outside of this class.
            // So we can have a clean code here.
            modelBuilder.Seed();
        }
    }
}
