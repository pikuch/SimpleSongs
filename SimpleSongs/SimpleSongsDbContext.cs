using Microsoft.EntityFrameworkCore;
using SimpleSongs.Model;
using SimpleSongs.Resources;
using System;

namespace SimpleSongs
{
    /// <inheritdoc/>
    class SimpleSongsDbContext : DbContext
    {
        DbSet<Song> Songs { get; set; }

        /// <summary>
        /// Configures the database relationships and seeds some data
        /// </summary>
        /// <param name="modelBuilder">ModelBuilder used to setup the model</param>
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Song>().HasData(
                new Song {
                    Id = 1,
                    Title = "Ciągnik",
                    Author = "Blenders",
                    AlbumName = "Fankomat",
                    Length = new TimeSpan(0, 3, 40).TotalSeconds
                },
                new Song {
                    Id = 2,
                    Title = "Hydrogen",
                    Author = "M.O.O.N.",
                    AlbumName = "MOON EP",
                    Length = new TimeSpan(0, 4, 31).TotalSeconds
                },
                new Song {
                    Id = 3,
                    Title = "...Baby One More Time",
                    Author = "Britney Spears",
                    AlbumName = "...Baby One More Time",
                    Length = new TimeSpan(0, 3, 30).TotalSeconds
                }
                );
        }

        /// <summary>
        /// Configures the database connection
        /// </summary>
        /// <param name="optionsBuilder">DbContextOptionsBuilder used for database context configuration</param>
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(SimpleStringResource.ConnectionString);
        }
    }
}
