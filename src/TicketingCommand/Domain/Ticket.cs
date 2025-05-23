using SharedKernel.Domain;
using SharedKernel.Events;
using TicketingCommand.Domain.Events;

namespace TicketingCommand.Domain;

public class Ticket(Guid id) : Entity<Guid>(id)
{
    public Event<CreateTicketEvent> CreateTicket(string title, string description, Guid createdBy, string status)
    {
        var ticket = new CreateTicketEvent(title, description, createdBy, status);
        var eventMetadata = new EventMetadata
        {
            Version = 1,
            AggregateId = "Ticket",
            AggregateName = "Ticket",
            EventType = "CreateTicketEvent"
        };
        var eventImplementation = new Event<CreateTicketEvent>(nameof(CreateTicketEvent), eventMetadata, ticket);
        return eventImplementation;
    }
}