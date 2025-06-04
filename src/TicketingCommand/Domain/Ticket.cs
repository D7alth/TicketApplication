using SharedKernel.Domain;
using SharedKernel.Events;
using TicketingCommand.Domain.Events;

namespace TicketingCommand.Domain;

public class Ticket(Guid id) : Entity<Guid>(id)
{
    public Event<CreateTicketEvent> CreateTicket(string title, string description, Guid createdBy, string status)
    {
        if (string.IsNullOrEmpty(title))
            throw new ArgumentException("Title is required");
        var @event = new CreateTicketEvent(title, description, createdBy, status);
        var metadata = new EventMetadata
        {
            Version = 1,
            AggregateId = id,
            AggregateName = nameof(Ticket),
            EventType = nameof(CreateTicketEvent)
        };
        return new Event<CreateTicketEvent>(nameof(CreateTicketEvent), metadata, @event);
    }
}