using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using MovieStore.Data.Context;
using MovieStore.Data.Entities.Base;
using MovieStore.Data.Repositories.Interfaces.Base;

namespace MovieStore.Data.Repositories.Concretes.Base;

public abstract class GenericRepository<TEntity, TKey> : IGenericRepository<TEntity, TKey> where TEntity : class, IEntity<TKey>
{
    private readonly MovieDbContext _dbContext;
    private readonly DbSet<TEntity> _entities;

    protected GenericRepository(MovieDbContext dbContext)
    {
        _dbContext = dbContext;
        _entities = _dbContext.Set<TEntity>();
    }
    public async Task CreateAsync(TEntity entity) => await _entities.AddAsync(entity);
    
    public async Task DeleteAsync(TKey id)
    {
        var entity = await _entities.FindAsync(id);

        if(entity is null)  throw new InvalidOperationException("Entity not found");

        _entities.Remove(entity);
    }
    
    public async Task<TEntity?> GetByIdAsync(TKey id) => await _entities.FindAsync(id);
    public async Task<TEntity> GetOrThrowNotFoundByIdAsync(TKey id)
    {
        var entity = await GetByIdAsync(id);
        if (entity == null)
        {
            throw new InvalidOperationException($"{typeof(TEntity).Name} not found");
        }
        return entity;
    }

    public async Task<List<TEntity>> GetAllAsync(Expression<Func<TEntity, bool>> predicate) => await _entities.Where(predicate).ToListAsync();
    public async Task<List<TEntity>> GetAllAsync() => await _entities.ToListAsync();
    
    public async Task UpdateAsync(TKey id, TEntity entity)
    {
        var current = await _entities.FindAsync(id);

        if(current is null)  throw new InvalidOperationException("Entity not found");

        _dbContext.Entry(current).CurrentValues.SetValues(entity);
    }
    
}