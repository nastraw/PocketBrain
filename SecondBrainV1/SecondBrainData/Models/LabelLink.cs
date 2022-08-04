namespace SecondBrain.Data.Models;

public class LabelLink
{
    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public string? ParentId { get; set; }

    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public string? ChildId { get; set; }
}