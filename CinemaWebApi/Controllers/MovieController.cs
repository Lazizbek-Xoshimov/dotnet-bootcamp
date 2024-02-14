using CinemaWebApi.Context;
using CinemaWebApi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CinemaWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MovieController : ControllerBase
    {
        private readonly MoviesDbContext _dbContext;
        public MovieController(MoviesDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Movies>>> GetUsers()
        {
            if (_dbContext.Movies == null)
            {
                return NotFound();
            }
            return await _dbContext.Movies.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Movies>> GetMovie(int id)
        {
            if(_dbContext.Movies == null)
            {
                return NotFound();
            }
            var movie = await _dbContext.Movies.FindAsync(id);
            if(movie == null)
            {
                return NotFound();
            }
            return movie;
        }

        [HttpPost]
        public async Task<IActionResult> CreateMovie(Movies movies)
        {
            _dbContext.Movies.Add(movies);
            await _dbContext.SaveChangesAsync();
            return NoContent();
        }
        private bool UserExists(int id)
        {
            return _dbContext.Movies.Any(x => x.Id == id);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateUser(int id, Movies movies)
        {
            if (id != movies.Id)
            {
                return BadRequest();
            }
            _dbContext.Entry(movies).State = EntityState.Modified;

            try
            {
                await _dbContext.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!UserExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }
            return NoContent();
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteMovie(int id)
        {
            var movie = await _dbContext.Movies.FindAsync(id);
            if(movie != null)
            {
                return NotFound();
            }
            _dbContext.Movies.Remove(movie);
            await _dbContext.SaveChangesAsync();
            return NoContent();
        }
    }
}
