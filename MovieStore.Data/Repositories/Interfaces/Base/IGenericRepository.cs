using System.Linq.Expressions;
using MovieStore.Data.Entities.Base;

namespace MovieStore.Data.Repositories.Interfaces.Base;

public interface IGenericRepository<TEntity, TKey> where TEntity : class, IEntity<TKey>
{
    Task CreateAsync(TEntity entity);
    
    Task DeleteAsync(TKey id);
    
    Task<TEntity?> GetByIdAsync(TKey id);

    Task<TEntity> GetOrThrowNotFoundByIdAsync(TKey id);

    Task<List<TEntity>> GetAllAsync(Expression<Func<TEntity,bool>> predicate);

    Task<List<TEntity>> GetAllAsync();
    
    Task UpdateAsync(TKey id, TEntity entity);
}