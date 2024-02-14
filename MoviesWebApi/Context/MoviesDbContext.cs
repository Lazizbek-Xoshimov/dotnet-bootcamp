using Microsoft.EntityFrameworkCore;
using MoviesWebApi.Models;

namespace MoviesWebApi.Context
{
    public class MoviesDbContext : DbContext
    {
        public MoviesDbContext(DbContextOptions<MoviesDbContext> options) : base(options)
        {
            
        }
        public DbSet<Movies> Movies { get; set; }
    }
}
