using Cinema.Domain.Interfaces;
using System.Security.Cryptography;

namespace Cinema.Domain.Common
{
    public class Entity<TId> : IEntity<TId>
    {
        public TId Id { get; private set; } = default;
    }
}
