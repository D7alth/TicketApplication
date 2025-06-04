using MongoDB.Bson.Serialization.Attributes;

namespace SharedKernel.Events;

public sealed record EventMetadata
{
    private static int _version;

    [BsonElement("Version")] public double Version { get; set; } = _version++;

    [BsonElement("timestamp")] public DateTime TimeStamp { get; private set; } = DateTime.UtcNow;

    [BsonElement("aggregateId")] public Guid AggregateId { get; set; } = Guid.Empty;

    [BsonElement("aggregateName")] public string AggregateName { get; set; } = string.Empty;

    [BsonElement("eventType")] public string EventType { get; set; } = string.Empty;
}