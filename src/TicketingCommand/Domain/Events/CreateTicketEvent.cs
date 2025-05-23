using SharedKernel.Events;

namespace TicketingCommand.Domain.Events;

public class CreateTicketEvent(string title, string description, Guid createdBy, string status) : IEventPayload
{
    public Guid TicketId { get; private set; } = Guid.Empty;
    public string Title { get; set; } = title;
    public string Description { get; set; } = description;
    public Guid CreateBy { get; set; } = createdBy;
    public Status Status { get; set; } = new(status);
}