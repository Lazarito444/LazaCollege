using LazaCollege.Domain.Common.Pagination;
using LazaCollege.Domain.Common.Specifications;

namespace LazaCollege.Domain.Common.Repositories;

public interface IRepository<TEntity> where TEntity : class
{
    Task<DataPage<TResult>> GetPagedAsync<TResult>(ISpecification<TEntity, TResult> spec, CancellationToken cancellationToken = default);
    Task<List<TResult>> ListAsync<TResult>(ISpecification<TEntity, TResult> spec, CancellationToken cancellationToken = default);
    Task<TEntity?> GetByIdAsync(object id, CancellationToken cancellationToken = default);
    Task<TEntity?> GetByIdAsync(object[] composedKey, CancellationToken cancellationToken = default);
    void Add(TEntity entity, CancellationToken cancellationToken = default);   
    void Update(TEntity entity, CancellationToken cancellationToken = default);
    void Delete(TEntity entity, CancellationToken cancellationToken = default);
    void AddRange(IEnumerable<TEntity> entities,CancellationToken cancellationToken = default);
    void UpdateRange(IEnumerable<TEntity> entities, CancellationToken cancellationToken = default);
    void DeleteRange(IEnumerable<TEntity> entities, CancellationToken cancellationToken = default);
}   
