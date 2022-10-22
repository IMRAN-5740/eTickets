using eTickets.Models;

namespace eTickets.Data.Services
{
    public interface IMoviesService
    {
        Task<IEnumerable<Movie>> GetAllAsync();
        Task<Movie> GetByIdAsync(int id);
        Task AddAsync(Movie movie);
        Task<Movie> UpdateAsync(int id, Movie newmovie);
        Task DeleteAsync(int id);
    }
}
