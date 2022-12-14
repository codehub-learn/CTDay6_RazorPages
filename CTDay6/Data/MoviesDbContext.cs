using Microsoft.EntityFrameworkCore;
using CTDay6.Domain;

namespace CTDay6.Data
{
    public class MoviesDbContext : DbContext
    {
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Actor> Actors { get; set; }

        public MoviesDbContext(DbContextOptions<MoviesDbContext> options) : base(options) { }
    }
}
