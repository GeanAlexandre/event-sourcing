using EventSourcing.Domain.Events;
using System.Collections.Generic;

namespace EventSourcing.Domain.Models
{
    public abstract class Entity
    {
        protected ICollection<IDomainEvent> Events => new List<IDomainEvent>();
    }
}
