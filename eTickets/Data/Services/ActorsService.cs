using eTickets.Models;
using javax.swing.text;
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

        

        public async Task AddAsync(Actor actor)
        {
            await _context.Actors.AddAsync(actor);
            await _context.SaveChangesAsync();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }


        public async Task<IEnumerable<Actor>> GetAllAsync()
        {
            var actorsResult = await _context.Actors.ToListAsync();
            return actorsResult;
        }



        public async Task<Actor> GetByIdAsync(int id)
        {
            var result =await _context.Actors.FirstOrDefaultAsync(c=>c.Id==id);
            return result;
        }

        public Actor Update(int id, Actor newActor)
        {
            throw new NotImplementedException();
        }

       
    }
}
