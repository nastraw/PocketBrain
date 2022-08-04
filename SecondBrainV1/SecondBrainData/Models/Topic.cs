namespace SecondBrain.Data.Models;

public class Topic
{
    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public string? Id { get; set; }
    public string? Title { get; set; }
    public string? Description { get; set; }
    public DateTime DateCreated { get; set; } = DateTime.UtcNow;
    public BasicUserModel Author { get; set; }
    public Category Category { get; set; }
    public Status Status { get; set; }
    public int Rank { get; set; } = 0;
    public HashSet<Label> Labels { get; set; } = new();
    public bool HasLink { get; set; } = false;
    public bool Consumed { get; set; } = false;
    public bool Archived { get; set; } = false;
    public bool Ingored { get; set; } = false;
}

public class BasicUserModel
{
    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public string Id { get; set; }

    public string DisplayName { get; set; }
}
