namespace SecondBrain.Data.Models;

public class AuditAction
{
    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public string? Id { get; set; }
    public User User { get; set; }
    public string? Action { get; set; }
}