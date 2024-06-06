using FlickFlow.Models;
using Microsoft.EntityFrameworkCore;

namespace FlickFlow.Data.Services
{
    public class ActorsService : IActorsService
    {
        private readonly AppDbContext _appDbContext;

        public ActorsService(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public async Task AddActorAsync(Actor actor)
        {
            await _appDbContext.Actors.AddAsync(actor);
            await _appDbContext.SaveChangesAsync();
        }

        public void DeleteActor(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<Actor> GetActorByIdAsync(int id)
        {
            var result = await _appDbContext.Actors
                .FirstOrDefaultAsync(n => n.Id == id);
            return result;
        }

        public async Task<IEnumerable<Actor>> GetAllActors()
        {
           var result = await _appDbContext.Actors.ToListAsync();
            return result;
        }

        public Actor UpdateActor(int id, Actor newActor)
        {
            throw new NotImplementedException();
        }
    }
}
