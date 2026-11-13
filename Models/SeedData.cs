using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MvcMovie.Data;
using System;
using System.Linq;

namespace MvcMovie.Models;

public static class SeedData
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using (var context = new MvcMovieContext(
            serviceProvider.GetRequiredService<
                DbContextOptions<MvcMovieContext>>()))
        {
            // Look for any movies.
            if (context.Movie.Any())
            {
                return;   // DB has been seeded
            }
            context.Movie.AddRange(
             new Movie
             {
                 Title = "When Harry Met Sally",
                 ReleaseDate = DateTime.Parse("1989-1-11"),
                 Genre = "Romantic Comedy",
                 Rating = "R",
                 Price = 7.99M
             },
                new Movie
                {
                    Title = "Ghostbusters ",
                    ReleaseDate = DateTime.Parse("1984-3-13"),
                    Genre = "Comedy",
                    Rating = "PG",
                    Price = 8.99M
                },
                new Movie
                {
                    Title = "Ghostbusters 2",
                    ReleaseDate = DateTime.Parse("1986-2-23"),
                    Genre = "Comedy",
                    Rating = "PG",
                    Price = 9.99M
                },
                new Movie
                {
                    Title = "Rio Bravo",
                    ReleaseDate = DateTime.Parse("1959-4-15"),
                    Genre = "Western",
                    Rating = "PG",
                    Price = 3.99M
                },
                new Movie
                {
                    Title = "Apocalypse Z",
                    ReleaseDate = DateTime.Parse("2026-10-09"),
                    Genre = "Action horror Thriller",
                    Rating = "PG",
                    Price = 9.99M
                },
                new Movie
                {
                    Title = "Heart of the Beast",
                    ReleaseDate = DateTime.Parse("2026-09-19"),
                    Genre = "Adventure Thriller",
                    Rating = "PG",
                    Price = 10.99M
                },
                new Movie
                {
                    Title = "Hope",
                    ReleaseDate = DateTime.Parse("2026-07-15"),
                    Genre = "Action Mystery science fiction",
                    Rating = "PG",
                    Price = 15.99M
                }
            );
            context.SaveChanges();
        }
    }
}