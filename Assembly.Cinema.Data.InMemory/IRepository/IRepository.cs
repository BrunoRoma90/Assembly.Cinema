public interface IRepository<TEntity, Tid> where TEntity : class
{
    List<TEntity> GetAll();
    TEntity GetById(Tid id);
    void Add(TEntity obj);
    void Update(TEntity obj);
    void Delete(TEntity obj);
}



