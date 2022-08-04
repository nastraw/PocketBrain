using System.Security.Cryptography.X509Certificates;

namespace SecondBrain.Data.Models;

public class BasicTopicModel
{
    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public string? Id { get; set; }
    public string? Title { get; set; }

    public BasicTopicModel()
    {
        
    }

    public BasicTopicModel(Topic topic)
    {
        Id = topic.Id;
        Title = topic.Title;
    }
}
