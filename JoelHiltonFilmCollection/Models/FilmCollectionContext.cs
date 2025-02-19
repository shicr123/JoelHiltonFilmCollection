using Microsoft.EntityFrameworkCore;
using Mission6_Cruz.Models;

public class FilmCollectionContext : DbContext
{
    public FilmCollectionContext(DbContextOptions<FilmCollectionContext> options) : base(options) { }

    public DbSet<Movie> Movies { get; set; }
    
    // Seeding my database with my 3 favorite movies
    protected override void OnModelCreating(ModelBuilder mb)
    {
        mb.Entity<Movie>().HasData(
            new Movie
            {
                MovieId = 1,
                Title = "Insidious",
                Genre = "Horror",
                Director = "James Wan",
                ReleaseYear = 2010,
                Rating = "PG-13",
                Edited = false,
                LentTo = "Shir",
                Notes = "Best movie!"
            },
            new Movie
            {
                MovieId = 2,
                Title = "Annabelle",
                Genre = "Horror",
                Director = "John R. Leonetti",
                ReleaseYear = 2014,
                Rating = "PG-13",
                Edited = false,
                LentTo = "Shir",
                Notes = "Incredible movie!"
            },
            new Movie
            {
                MovieId = 3,
                Title = "The Conjuring",
                Genre = "Horror",
                Director = "Michael Chaves, James Wan",
                ReleaseYear = 2013,
                Rating = "PG-13",
                Edited = false,
                LentTo = "Shir",
                Notes = "Amazing movie!"
            });
    }
}