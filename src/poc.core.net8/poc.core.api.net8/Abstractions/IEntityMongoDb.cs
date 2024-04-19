using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace poc.core.api.net8.Abstractions;

public interface IEntityMongoDb
{
    [BsonId]
    [BsonRepresentation(BsonType.String)]
    string Id { get; set; }
    [BsonElement("EventName")]
    public string EventName { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime? ExpiresAt { get; set; }
}