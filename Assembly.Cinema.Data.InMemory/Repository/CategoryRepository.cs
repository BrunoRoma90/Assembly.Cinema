using Cinema.Domain.Models;

public class CategoryRepository : Repository<Category, int>, ICategoryRepository
{
    public override void Add(Category category)
    {
        throw new NotImplementedException();
    }

    public override void Delete(Category category)
    {
        throw new NotImplementedException();
    }

    public override List<Category> GetAll()
    {
        throw new NotImplementedException();
    }

    public override Category GetById(int id)
    {
        throw new NotImplementedException();
    }

    public override void Update(Category category)
    {
        throw new NotImplementedException();
    }

    public Category GetCategoryByName(string name)
    {
        throw new NotImplementedException();
    }
}
