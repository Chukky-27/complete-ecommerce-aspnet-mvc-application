using FlickFlow.Models;

namespace FlickFlow.Data.Services
{
    public interface IActorsService
    {
        Task<IEnumerable<Actor>> GetAllActors();
        Task<Actor> GetActorByIdAsync(int id);
        Task AddActorAsync(Actor actor);
        Actor UpdateActor(int id, Actor newActor);
        void DeleteActor(int id);
    }
}
