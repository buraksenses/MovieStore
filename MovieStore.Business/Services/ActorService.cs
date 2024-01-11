using MovieStore.Data.Entities;
using MovieStore.Data.Repositories.Interfaces;

namespace MovieStore.Business.Services;

public class ActorService : IActorService
{
    private readonly IActorRepository _actorRepository;

    public ActorService(IActorRepository actorRepository)
    {
        _actorRepository = actorRepository;
    }

    public async Task<Actor> CreateActorAsync(Actor actor)
    {
        await _actorRepository.CreateAsync(actor);
        return actor;
    }

    public async Task DeleteActorAsync(int actorId)
    {
        var actor = await _actorRepository.GetOrThrowNotFoundByIdAsync(actorId);

        await _actorRepository.DeleteAsync(actorId);
    }

    public async Task<IEnumerable<Actor>> GetAllActorsAsync()
    {
        return await _actorRepository.GetAllAsync();
    }

    public async Task<Actor> GetActorByIdAsync(int actorId)
    {
        return await _actorRepository.GetOrThrowNotFoundByIdAsync(actorId);
    }

    public async Task UpdateActorAsync(int actorId, Actor actor)
    {
        var existingActor = await _actorRepository.GetOrThrowNotFoundByIdAsync(actorId);

        await _actorRepository.UpdateAsync(actorId, existingActor);
    }
}