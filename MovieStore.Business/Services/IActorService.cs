using MovieStore.Data.Entities;

namespace MovieStore.Business.Services;

public interface IActorService
{
    Task<Actor> CreateActorAsync(Actor actor);
    Task DeleteActorAsync(int actorId);
    Task<IEnumerable<Actor>> GetAllActorsAsync();
    Task<Actor> GetActorByIdAsync(int actorId);
    Task UpdateActorAsync(int actorId, Actor actor);
}