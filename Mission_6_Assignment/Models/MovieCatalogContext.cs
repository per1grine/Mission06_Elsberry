using Microsoft.EntityFrameworkCore;

namespace Mission_6_Assignment.Models
{
    public class MovieCatalogContext : DbContext
    {
        public MovieCatalogContext(DbContextOptions<MovieCatalogContext> options) : base(options) //constructor
        {

        }
        public DbSet<Movie> MovieCatalog { get; set; }
    }
}
