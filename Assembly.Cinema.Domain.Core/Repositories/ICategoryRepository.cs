using Assembly.Cinema.Domain.Core.Repositories;
using Cinema.Domain.Models;

public interface ICategoryRepository : IRepository<Category, int>
{
    public Category GetCategoryByName(string name);
}
