namespace SharedKernel.Events;

[AttributeUsage(AttributeTargets.Class)]
public class BsonCollection(string documentName) : Attribute
{
    public string DocumentName { get; set; } = documentName;
}