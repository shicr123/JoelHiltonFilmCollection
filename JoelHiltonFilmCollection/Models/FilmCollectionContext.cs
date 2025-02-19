using JoeHiltonFilmCollection.Models;
using Mission6_Cruz.Models;
using Microsoft.EntityFrameworkCore;

namespace JoeHiltonFilmCollection.Models
{
    public class FilmCollectionContext : DbContext
    {
        public FilmCollectionContext(DbContextOptions<FilmCollectionContext> options) : base(options) { }

        public DbSet<Movie> Movies { get; set; }
    }
}
