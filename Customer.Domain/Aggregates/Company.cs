using System;
using Customer.Domain.Events;
using Customer.Domain.Handlers;
using EventSource.Framework;

namespace Customer.Domain.Aggregates
{
    public class Company : BaseEntity<Guid>
    {
        public Company(Guid id) : base(id)
        {
            Handles<CompanyCreatedEvent>(CompanyCreated);
        }
        public Company(Guid id, CompanyEvents eventItems) : this(id)
        {           
            LoadEvents(eventItems.Events);
        }
        private void CompanyCreated(CompanyCreatedEvent companyCreatedEvent)
        {
            Name = companyCreatedEvent.Name;
        }

        public string Name { get; private set; }
    }
}