using Cinema.Domain.Interfaces;

namespace Cinema.Domain.Common
{
    public abstract class Entity : IEntity
    {
        public int Id { get; private set; }

        protected Entity(int id)
        {
            Id = id;
        }
    }
}
