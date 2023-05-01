using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace CinemaCoursework.Data
{
    public class Session
    {
        [BsonId]
        [BsonIgnoreIfDefault]
        public ObjectId Id { get; set; }
        [BsonIgnoreIfDefault]
        [BsonIgnoreIfNull]
        public string? SessionNumber { get; set; }
        [BsonIgnoreIfDefault]
        [BsonIgnoreIfNull]
        public DateTime Time { get; set; }

        [BsonIgnoreIfDefault]
        [BsonIgnoreIfNull]
        public Movie Movie { get; set; } = new();

        [BsonIgnoreIfDefault]
        [BsonIgnoreIfNull]
        public Hall Hall { get; set; } = new();
    }
}
