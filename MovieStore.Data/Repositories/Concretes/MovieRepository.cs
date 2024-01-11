using MovieStore.Data.Context;
using MovieStore.Data.Entities;
using MovieStore.Data.Repositories.Concretes.Base;
using MovieStore.Data.Repositories.Interfaces;

namespace MovieStore.Data.Repositories.Concretes;

public class MovieRepository : GenericRepository<Movie, int>, IMovieRepository
{
    public MovieRepository(MovieDbContext dbContext) : base(dbContext)
    {
    }
    
}