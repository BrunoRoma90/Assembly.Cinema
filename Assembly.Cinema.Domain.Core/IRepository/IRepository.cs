using Cinema.Domain.Interfaces;

namespace Assembly.Cinema.Domain.Core.IRepository
{
    public interface IRepository<TEntity, TId> where TEntity : IEntity<TId>
    {
        List<TEntity> GetAll();
        TEntity GetById(TId id);
        TEntity Add(TEntity obj);
        TEntity Update(TEntity obj);
        TEntity Delete(TEntity id);
    }
}