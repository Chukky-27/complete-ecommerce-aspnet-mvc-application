using FlickFlow.Models;

namespace FlickFlow.Data.Services
{
    public interface IActorsService
    {
        Task<IEnumerable<Actor>> GetAllActors();
        Actor GetActorById(int id);
        void AddActor(Actor actor);
        Actor UpdateActor(int id, Actor newActor);
        void DeleteActor(int id);
    }
}
