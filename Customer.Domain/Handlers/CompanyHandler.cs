using System;
using Customer.Domain.Aggregates;
using Customer.Domain.Events;
using Customer.Domain.Messages;
using EventSource.Framework;

namespace Customer.Domain.Handlers
{
    public class CompanyHandler : IMessageHandler<CreateCompanyMessage, Company>
    {
        private IEventPublisher _eventPublisher;
        private IEventStore _eventStore;

        public CompanyHandler(
            IEventStore eventStore,
            IEventPublisher eventPublisher)
        {
            _eventStore = eventStore;
            _eventPublisher = eventPublisher;
        }

        public Company Handle(CreateCompanyMessage message)
        {
            var id = Guid.NewGuid();

            var companyCreatedEvent = new CompanyCreatedEvent(id, message.Name);
            var events = _eventStore.AddEvent<CompanyEvents>(id, companyCreatedEvent);

//            _eventPublisher.Publish(new CompanyCreated());

            return new Company(id, events);
        }
    }
}