using JoeHiltonFilmCollection.Models;
using Microsoft.EntityFrameworkCore;

namespace JoelHiltonFilmCollection.Models
{
    public class FilmCollectionContext : DbContext
    {
        public FilmCollectionContext(DbContextOptions<FilmCollectionContext> options)
            : base(options)
        {
        }

        public DbSet<Movie> Movies { get; set; } // This must match the table name
    }
}