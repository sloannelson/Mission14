using Microsoft.EntityFrameworkCore;

namespace Mission14NoScaffold.Models
{
    public class MoviesDBContext : DbContext 
    {
        public MoviesDBContext(DbContextOptions<MoviesDBContext> options) : base(options)
        {

        }

        public DbSet<Movie> Movies { get; set;}
    }
}
