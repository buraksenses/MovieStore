using MovieStore.Data.Context;
using MovieStore.Data.Entities;
using MovieStore.Data.Repositories.Concretes.Base;
using MovieStore.Data.Repositories.Interfaces;

namespace MovieStore.Data.Repositories.Concretes;

public class DirectorRepository : GenericRepository<Director, int>, IDirectorRepository
{
    public DirectorRepository(MovieDbContext dbContext) : base(dbContext)
    {
    }

}