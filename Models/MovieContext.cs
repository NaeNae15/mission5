using System;
using Microsoft.EntityFrameworkCore;

namespace JoelHilton.Models
{
    public class MovieContext : DbContext
    {
        //constructor
        public MovieContext (DbContextOptions<MovieContext> options) : base(options)
        {
            //stuff 
        }

        public DbSet<MovieResponses> Responses { get; set; }
    }
}
