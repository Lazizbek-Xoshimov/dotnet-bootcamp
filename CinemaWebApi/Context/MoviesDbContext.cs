using CinemaWebApi.Models;
using Microsoft.EntityFrameworkCore;

namespace CinemaWebApi.Context
{
    public class MoviesDbContext : DbContext
    {
        public MoviesDbContext(DbContextOptions<MoviesDbContext> options) : base(options)
        {
            
        }
        public DbSet<Movies> Movies { get; set; }
    }
}
