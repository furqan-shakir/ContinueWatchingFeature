using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MoviesApis.Models;
using Microsoft.EntityFrameworkCore;
using Faker;
using Bogus;
using Bogus.Hollywood;


namespace MoviesApis.DBContexts
{
    public class MySqlDbContext : DbContext
    {
        //public DbSet<Series> Serieses { get; set; }
        //public DbSet<User> Users { get; set; }
        //public DbSet<Season> Seasons { get; set; }
        public DbSet<Video> Videos { get; set; }
        public DbSet<WatchList> WatchLists { get; set; }
        public MySqlDbContext(DbContextOptions<MySqlDbContext> options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var ids = 1;
            //var usersData = new Faker<User>()
            //                .RuleFor(m => m.Id, f => ids++)
            //                .RuleFor(m => m.FirstName, f => f.Name.FirstName())
            //                .RuleFor(m => m.LastName, f => f.Name.LastName())
            //                .RuleFor(m => m.CreationDateTime, f => f.Date.Past(1));

            //modelBuilder.Entity<User>().HasData(usersData.Generate(100)); //Generate 100 user


            //ids = 1;
            //var seriesData = new Faker<Series>()
            //                .RuleFor(m => m.Id, f => ids++)
            //                .RuleFor(m => m.Title, f => f.Random.Words(4))
            //                .RuleFor(m => m.CreationDateTime, f => f.Date.Past(1));

            //modelBuilder.Entity<Series>().HasData(seriesData.Generate(1000)); //Generate 1000 series

            //ids = 1;
            //var seasonsData = new Faker<Season>()
            //               .RuleFor(m => m.Id, f => ids++)
            //               .RuleFor(m => m.Title, f => f.Random.Words(4))
            //               .RuleFor(m => m.SeriesId, f => f.Random.Number(1, 1000))
            //               .RuleFor(m => m.CreationDateTime, f => f.Date.Past(1));
            //modelBuilder.Entity<Season>().HasData(seasonsData.Generate(50)); //Generate 50 season
            //ids = 1;
            var seriesVideosData = new Faker<Video>()
                           .RuleFor(m => m.Id, f => ids++)
                           .RuleFor(m => m.Title, f => f.Random.Words(4))
                           .RuleFor(m => m.SeasonId, f => f.Random.Number(1, 50))
                           .RuleFor(m => m.Duration, f => f.Random.Float(1, 2))
                           .RuleFor(m => m.StoragePath, f => f.System.FilePath())
                           .RuleFor(m => m.Type, VideoType.Series)
                           .RuleFor(m => m.CreationDateTime, f => f.Date.Past(1));
            modelBuilder.Entity<Video>().HasData(seriesVideosData.Generate(2000)); //Generate 1 eposide
            //// Continue seeding from the last id:
            var moviesVideosData = new Faker<Video>()
                           .RuleFor(m => m.Id, f => ids++)
                           .RuleFor(m => m.Title, f => f.Random.Words(4))
                           .RuleFor(m => m.Duration, f => f.Random.Float(1, 2))
                           .RuleFor(m => m.StoragePath, f => f.System.FilePath())
                           .RuleFor(m => m.Type, VideoType.Movie)
                           .RuleFor(m => m.CreationDateTime, f => f.Date.Past(1));
            modelBuilder.Entity<Video>().HasData(moviesVideosData.Generate(2000)); //Generate 50000 movies


        }
    }
}
