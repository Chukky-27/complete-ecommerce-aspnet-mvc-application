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

        public void AddActor(Actor actor)
        {
            _appDbContext.Actors.Add(actor);
            _appDbContext.SaveChanges();
        }

        public void DeleteActor(int id)
        {
            throw new NotImplementedException();
        }

        public Actor GetActorById(int id)
        {
            throw new NotImplementedException();
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
