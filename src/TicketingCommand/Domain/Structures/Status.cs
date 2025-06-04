namespace TicketingCommand.Domain.Structures;

public struct Status
{
    public string Name { get; set; }

    public Status(string name)
    {
        string[] validStatus = ["Open", "Closed", "Cancelled", "Deleted"];
        if (!validStatus.Contains(name))
            throw new ArgumentException("Invalid status");
        Name = name;
    }
}