using SharedKernel.Events;
using TicketingCommand.Domain.Structures;

namespace TicketingCommand.Domain.Events;

public class DeleteTicketEvent(Guid ticketId, Guid deletedBy) : IEventPayload
{
    public Guid TicketId { get; set; } = ticketId;
    public Guid CreateBy { get; set; } = deletedBy;
    public Status Status { get; set; } = new("Deleted");
}