using eTickets.Models;
using Microsoft.EntityFrameworkCore;

namespace eTickets.Data.Services
{
    public class ActorsService : IActorsService
    {
        private readonly ApplicationDbContext _context;
        public ActorsService(ApplicationDbContext context)
        {
            _context = context;
        }

        public void Add(Actor actor)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Actor>> GetAll()
        {
            var actorsResult = await _context.Actors.ToListAsync();
            return actorsResult;
        }

        public Actor GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Actor Update(int id, Actor newActor)
        {
            throw new NotImplementedException();
        }
    }
}
