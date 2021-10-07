    using Microsoft.EntityFrameworkCore;
using ReviewsSite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReviewsSite
{
    public class VideoGameContext : DbContext
    {
        public DbSet<VideoGame> VideoGames { get; set; }
        public DbSet<Platform> Platforms { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<VideoGamePlatform> VideoGamePlatforms { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = "Server=(localdb)\\mssqllocaldb;Database = VideoGameDB_100621;Trusted_Connection=true";
            optionsBuilder.UseSqlServer(connectionString).UseLazyLoadingProxies();
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // the platform table HAS this data already in it
            modelBuilder.Entity<Platform>().HasData(
                new Platform() {Id = 1, Name = "PC"} //,
                );
        }
    }
}
