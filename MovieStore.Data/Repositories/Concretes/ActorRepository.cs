using MovieStore.Data.Context;
using MovieStore.Data.Entities;
using MovieStore.Data.Repositories.Concretes.Base;
using MovieStore.Data.Repositories.Interfaces;

namespace MovieStore.Data.Repositories.Concretes;

public class ActorRepository : GenericRepository<Actor, int>, IActorRepository
{
    public ActorRepository(MovieDbContext dbContext) : base(dbContext)
    {
    }
    
}