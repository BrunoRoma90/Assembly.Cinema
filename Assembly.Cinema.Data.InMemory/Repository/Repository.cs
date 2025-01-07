//Classe abstract é necessário criar outras classe que herdem dela
using Assembly.Cinema.Domain.Core.IRepository;

public abstract class Repository<TEntity, Tid> : IRepository<TEntity, Tid> where TEntity : class
{
    //Método abstrato não possui implementação, possui apenas implementação na classe derivada
    public abstract List<TEntity> GetAll();

    public abstract TEntity GetById(Tid id);

    public abstract void Add(TEntity obj);

    public abstract void Update(TEntity obj);

    public abstract void Delete(TEntity obj);

}



