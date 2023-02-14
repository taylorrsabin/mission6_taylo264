using System;
using Microsoft.EntityFrameworkCore;

namespace Mission6.Models
{
	public class MovieSubmissionContext : DbContext
	{
        public MovieSubmissionContext(DbContextOptions<MovieSubmissionContext> options) : base(options)
        {

        }

        public DbSet<ApplicationResponse> Responses { get; set; }

        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<ApplicationResponse>().HasData(

                new ApplicationResponse
                {
                    MovieId = 1,
                    Title = "The Dark Knight",
                    Year = 2008,
                    Director = "Christopher Nolan",
                    Rating = "PG-13",
                    Edited = false,
                    LentTo = "Bill Nye",
                    Notes = ""
                },

                new ApplicationResponse
                {
                    MovieId = 2,
                    Title = "Iron Man",
                    Year = 2008,
                    Director = "Jon Favreau",
                    Rating = "PG-13",
                    Edited = true,
                    LentTo = "",
                    Notes = "Super awesome movie"
                },

                new ApplicationResponse
                {
                    MovieId = 3,
                    Title = "Ocean's Eleven",
                    Year = 2001,
                    Director = "Steven Soderbergh",
                    Rating = "PG-13",
                    Edited = false,
                    LentTo = "",
                    Notes = ""
                }

            );
        }
    }
}

