using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mission5.Models
{
    public class MovieContext : DbContext
    {
        public MovieContext (DbContextOptions<MovieContext> options) : base(options)
        {

        }

        public DbSet<Movie> Movies { get; set; }

        // Seed database
        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<Movie>().HasData(
                new Movie
                {
                    MovieId = 1,
                    Category = "Comedy/Drama",
                    Title = "The Intern",
                    Year = 2015,
                    Director = "Nancy Meyers",
                    Rating = "PG13"
                },

                new Movie
                {
                    MovieId = 2,
                    Category = "Fantasy",
                    Title = "Harry Potter and the Deathly Hallows: Part 2",
                    Year = 2011,
                    Director = "David Yates",
                    Rating = "PG13"
                },

                new Movie
                {
                    MovieId = 3,
                    Category = "Family/Comedy",
                    Title = "The Santa Clause",
                    Year = 1994,
                    Director = "John Pasquin",
                    Rating = "PG"
                }

            );
        }
    }
}
