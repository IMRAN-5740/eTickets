using eTickets.Models;
using Microsoft.EntityFrameworkCore;

namespace eTickets.Data.Services
{
    public class MoviesService : IMoviesService
    {

        private readonly ApplicationDbContext _context;
        public MoviesService(ApplicationDbContext context)
        {
            _context = context;
        }


        public async Task AddAsync(Movie movie)
        {
            await _context.Movies.AddAsync(movie);
            await _context.SaveChangesAsync();
        }


        public async Task DeleteAsync(int id)
        {
            var result = await _context.Actors.FirstOrDefaultAsync(c => c.Id == id);
            _context.Actors.Remove(result);
            await _context.SaveChangesAsync();

        }
        public async Task<IEnumerable<Movie>> GetAllAsync()
        {
            var result = await _context.Movies.Include(c => c.Cinema).OrderBy(n => n.Name).ToListAsync();
            return result;
        }


        public async Task<Movie> GetByIdAsync(int id)
        {
            var result = await _context.Movies.FirstOrDefaultAsync(c => c.Id == id);
            return result;
        }

        public async Task<Movie> UpdateAsync(int id, Movie newMovie)
        {
            _context.Update(newMovie);
            await _context.SaveChangesAsync();
            return newMovie;

        }
    }
}
