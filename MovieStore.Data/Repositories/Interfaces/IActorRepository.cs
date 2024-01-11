using MovieStore.Data.Entities;
using MovieStore.Data.Repositories.Interfaces.Base;

namespace MovieStore.Data.Repositories.Interfaces;

public interface IActorRepository : IGenericRepository<Actor, int>
{
    
}