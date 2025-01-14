using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using Optimiza_RepositoryBase.API.Abstractions;
using Optimiza_RepositoryBase.API.Infrastructure;

namespace Optimiza_RepositoryBase.API.Repositories;

public class RepositoryBaseGood<TEntity, TKey> : IRepositoryBaseGood<TEntity, TKey>, IDisposable where TEntity : DomainEntity<TKey>
{
    
    private readonly ApplicationDbContext _context;
    
    public IQueryable<TEntity> FindAll(params Expression<Func<TEntity, object>>[] includeProperties)
    {
        IQueryable<TEntity> items = _context.Set<TEntity>().AsNoTracking();
        if (includeProperties.Length == 0) return items;
        return includeProperties.Aggregate(items, (current, includeProperty) => current.Include(includeProperty));
    }

    public IQueryable<TEntity> FindAll(Expression<Func<TEntity, bool>> predicate, params Expression<Func<TEntity, object>>[] includeProperties)
    {
        IQueryable<TEntity> items = _context.Set<TEntity>().AsNoTracking();
        if (includeProperties.Length == 0) return items.Where(predicate);
        items = includeProperties.Aggregate(items, (current, includeProperty) => current.Include(includeProperty));
        return items.Where(predicate);
    }

    public async Task<TEntity> FindByIdAsync(TKey id, CancellationToken cancellationToken = default, params Expression<Func<TEntity, object>>[] includeProperties)
    {
        return await FindAll(includeProperties).SingleOrDefaultAsync(x => x.Id.Equals(id), cancellationToken);
    }

    public async Task<TEntity> FindSingleAsync(Expression<Func<TEntity, bool>> predicate, CancellationToken cancellationToken = default,
        params Expression<Func<TEntity, object>>[] includeProperties)
    {
        return await FindAll(includeProperties).SingleOrDefaultAsync(predicate, cancellationToken);
    }

    public void Add(TEntity entity)
    {
        _context.Add(entity);
    }

    public void Update(TEntity entity)
    {
        _context.Set<TEntity>().Update(entity);
    }

    public void Remove(TEntity entity)
    {
        _context.Set<TEntity>().Remove(entity);
    }

    public async Task RemoveAsync(TKey id, CancellationToken cancellationToken = default)
    {
        var entity = await FindByIdAsync(id, cancellationToken);
        Remove(entity);
    }

    public void RemoveMultiple(List<TEntity> entities)
    {
        _context.Set<TEntity>().RemoveRange(entities);
    }

    public void Dispose()
    {
        _context?.Dispose();
    }
}