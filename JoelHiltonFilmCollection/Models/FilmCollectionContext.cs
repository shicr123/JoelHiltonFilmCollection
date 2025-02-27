using Microsoft.EntityFrameworkCore;
using Mission6_Cruz.Models;

public class FilmCollectionContext : DbContext
{
    public FilmCollectionContext(DbContextOptions<FilmCollectionContext> options) : base(options) { }

    public DbSet<Movie> Movies { get; set; }
    
    public DbSet<Category> Categories { get; set; }
 
}