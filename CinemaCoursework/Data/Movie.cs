using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace CinemaCoursework.Data
{
    public class Movie
    {
        [BsonId]
        [BsonIgnoreIfDefault]
        public ObjectId Id { get; set; }
        [BsonIgnoreIfDefault]
        [BsonIgnoreIfNull]
        public string? Name { get; set; }
        [BsonIgnoreIfDefault]
        [BsonIgnoreIfNull]
        public string? Genre { get; set; }
        [BsonIgnoreIfDefault]
        [BsonIgnoreIfNull]
        public string? Regisseur { get; set; }
        [BsonIgnoreIfDefault]
        [BsonIgnoreIfNull]
        public string? Roles { get; set; }
        [BsonIgnoreIfDefault]
        [BsonIgnoreIfNull]
        public string? Country { get; set; }
        [BsonIgnoreIfDefault]
        [BsonIgnoreIfNull]
        public string? Duration { get; set; }
        [BsonIgnoreIfDefault]
        [BsonIgnoreIfNull]
        public string? Description { get; set; }
    }
}
