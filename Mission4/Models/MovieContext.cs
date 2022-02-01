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
        public DbSet<Category> Categories { get; set; }

        // Seed database
        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<Category>().HasData(
                new Category
                {
                    CategoryId = 1,
                    CategoryName = "Comedy"
                },
                new Category
                {
                    CategoryId = 2,
                    CategoryName = "Action"
                },
                new Category
                {
                    CategoryId = 3,
                    CategoryName = "Drama"
                },
                new Category
                {
                    CategoryId = 4,
                    CategoryName = "Fantasy"
                },
                new Category
                {
                    CategoryId = 5,
                    CategoryName = "Romance"
                },
                new Category
                {
                    CategoryId = 6,
                    CategoryName = "Thriller"
                }
                );

            mb.Entity<Movie>().HasData(
                new Movie
                {
                    MovieId = 1,
                    CategoryId = 3,
                    Title = "The Intern",
                    Year = 2015,
                    Director = "Nancy Meyers",
                    Rating = "PG13"
                },

                new Movie
                {
                    MovieId = 2,
                    CategoryId = 4,
                    Title = "Harry Potter and the Deathly Hallows: Part 2",
                    Year = 2011,
                    Director = "David Yates",
                    Rating = "PG13"
                },

                new Movie
                {
                    MovieId = 3,
                    CategoryId = 1,
                    Title = "The Santa Clause",
                    Year = 1994,
                    Director = "John Pasquin",
                    Rating = "PG"
                }

            );
        }
    }
}
