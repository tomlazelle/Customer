using System;
using EventSource.Framework;

namespace Customer.Domain.Events
{
    public class CompanyCreatedEvent : VersionedEvent<Guid>
    {
        public CompanyCreatedEvent(Guid id, string name)
        {
            SourceId = id;
            Name = name;
        }

        public string Name { get; }
    }
}