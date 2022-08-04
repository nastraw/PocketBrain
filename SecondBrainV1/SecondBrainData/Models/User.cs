﻿namespace SecondBrain.Data.Models;

public class User
{
    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public string? Id { get; set; }
    public string? ObjectIdentifier { get; set; }
    public string? Email { get; set; }
    public string? DisplayName { get; set; }
    public string? SourceDevice { get; set; }
}