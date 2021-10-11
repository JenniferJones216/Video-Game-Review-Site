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
                new Platform() {Id = 1, Name = "PC"},
                new Platform() {Id = 2, Name = "Xbox"},
                new Platform() {Id = 3, Name = "PS4"},
                new Platform() {Id = 4, Name = "Switch"}
                );

            //Video Game Seed Data; DOES NOT INCLUDE platforms or reviews
            modelBuilder.Entity<VideoGame>().HasData(
                new VideoGame() { Id = 1, Name = "Disco Elysium: The Final Cut", ReleaseDate = "30 March 2021", Description = "A non-traditional roleplaying game set in Revachol, a large city still recovering from a war decades prior to the game's start, with players taking the role of an amnesiac detective who has been tasked with solving a murder mystery.", PictureURL = "https://upload.wikimedia.org/wikipedia/en/thumb/0/0d/Disco_Elysium_Poster.jpeg/220px-Disco_Elysium_Poster.jpeg", VideoURL = "https://www.youtube.com/watch?v=YV2lp6p_gXw" },
                new VideoGame() { Id = 2, Name = "Dishonored", ReleaseDate = "9 October 2012", Description = "A first-person immersive stealth sim set in the fictional, plague-ridden industrial city of Dunwall, Dishonored follows the story of Corvo Attano, bodyguard to the Empress of the Isles. He is framed for her murder and forced to become an assassin, seeking revenge on those who conspired against him.", PictureURL = "https://upload.wikimedia.org/wikipedia/en/thumb/6/65/Dishonored_box_art_Bethesda.jpg/220px-Dishonored_box_art_Bethesda.jpg", VideoURL = "https://www.youtube.com/watch?v=-XbQgdSlsd0" },
            new VideoGame() { Id = 3, Name = "Portal", ReleaseDate = "10 October, 2007", Description = "A critically acclaimed, unique first-person puzzle platformer Portal consists primarily of a series of puzzles that must be solved by teleporting the player's character and simple objects using \"the Aperture Science Handheld Portal Device\", a device that can create inter-spatial portals between two flat planes. The player-character, Chell, is challenged and taunted by an artificial intelligence named GLaDOS (Genetic Lifeform and Disk Operating System) to complete each puzzle in the Aperture Science Enrichment Center using the portal gun with the promise of receiving cake when all the puzzles are completed.", PictureURL = "https://upload.wikimedia.org/wikipedia/en/thumb/9/9f/Portal_standalonebox.jpg/220px-Portal_standalonebox.jpg", VideoURL = "https://www.youtube.com/watch?v=TluRVBhmf8w" },
            new VideoGame() { Id = 4, Name = "The Talos Principle", ReleaseDate = "11 December 2014", Description = "The Talos Principle is a narrative-based puzzle game, played from a first- or third-person perspective. The player takes the role of a robot with a seemingly human consciousness as they explore a number of environments that include over 120 puzzles. These environments interlock greenery, desert, and stone ruins with futuristic technology.", PictureURL = "https://upload.wikimedia.org/wikipedia/en/thumb/a/ac/The_Talos_Principle.jpg/220px-The_Talos_Principle.jpg", VideoURL = "https://www.youtube.com/watch?v=iAVh4_wnOIw" },
            new VideoGame() { Id = 5, Name = "The Elder Scrolls V: Skyrim", ReleaseDate = "11 November 2011", Description = "This famed open-world action role-playing game takes place in the titular Skyrim province of Tamriel. The game's main story revolves around the player's character, the Dragonborn, on their quest to defeat Alduin the World-Eater, a dragon who is prophesied to destroy the world.", PictureURL = "https://upload.wikimedia.org/wikipedia/en/thumb/1/15/The_Elder_Scrolls_V_Skyrim_cover.png/220px-The_Elder_Scrolls_V_Skyrim_cover.png", VideoURL = "https://www.youtube.com/watch?v=JSRtYpNRoN0" }
                );

        }

    }
}
