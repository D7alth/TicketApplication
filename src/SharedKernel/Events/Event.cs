using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace SharedKernel.Events;

[BsonCollection("Events")]
public sealed class Event<TPayload>(string eventName, EventMetadata eventMetadata, TPayload payload)
    where TPayload : IEventPayload
{
    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public ObjectId Id { get; private set; }

    [BsonElement("eventName")] public string EventName { get; set; } = eventName;

    [BsonElement("eventMetadata")] public EventMetadata EventMetadata { get; set; } = eventMetadata;

    [BsonElement("Payload")] public TPayload Payload { get; set; } = payload;
}