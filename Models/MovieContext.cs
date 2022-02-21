using System;
using Microsoft.EntityFrameworkCore;

namespace JoelHilton.Models
{
    public class MovieContext : DbContext
    {
        //constructor
        public MovieContext(DbContextOptions<MovieContext> options) : base(options)
        {
            //stuff 
        }

        public DbSet<MovieResponses> Responses { get; set; }
        public DbSet<Category> Categories { get; set; }

        //seeding the data
        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<Category>().HasData(
                new Category
                {
                    CategoryId = 1,
                    CategoryName = "Action/Adeventure",
                },
                new Category
                {
                    CategoryId = 2,
                    CategoryName = "Comedy"
                },
                new Category
                {
                    CategoryId = 3,
                    CategoryName = "Drama"
                },
                new Category
                {
                    CategoryId = 4,
                    CategoryName = "Family"
                },
                new Category
                {
                    CategoryId = 5,
                    CategoryName = "Horror/Suspense"
                },
                new Category
                {
                    CategoryId = 6,
                    CategoryName = "Miscellaneous"
                },
                new Category
                {
                    CategoryId = 7,
                    CategoryName = "Television"
                },
                new Category
                {
                    CategoryId = 8,
                    CategoryName = "VHS"
                },
                new Category
                {
                    CategoryId = 9,
                    CategoryName = "Other"
                }
                );

            mb.Entity<MovieResponses>().HasData(

                new MovieResponses
                {
                    MovieId = 1,
                    CategoryId = 1,
                    Title = "Avengers, The",
                    Year = 2012,
                    Director = "Joss Whedon",
                    Rating = "PG-13",
                    Edited = false,
                    LentTo = null,
                    Notes = null,
                },

                new MovieResponses
                {
                    MovieId = 2,
                    CategoryId = 2,
                    Title = "Maverick",
                    Year = 1994,
                    Director = "Richard Donner",
                    Rating = "PG",
                    Edited = false,
                    LentTo = null,
                    Notes = null,
                },
                
                new MovieResponses
                {
                    MovieId = 3,
                    CategoryId = 4,
                    Title = "Mrs. Doubtfire",
                    Year = 1993,
                    Director = "Chris Columbus",
                    Rating = "PG-13",
                    Edited = false,
                    LentTo = null,
                    Notes = null,
                },


                new MovieResponses
                {
                    MovieId = 4,
                    CategoryId = 1,
                    Title = "Ladyhawke",
                    Year = 1985,
                    Director = "Richard Donner",
                    Rating = "PG-13",
                    Edited = false,
                    LentTo = null,
                    Notes = "Most Quotable",
                }
            );
        }
    }
}