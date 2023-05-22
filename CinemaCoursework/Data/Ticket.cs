using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace CinemaCoursework.Data
{
    public class Ticket
    {
        [BsonId]
        [BsonIgnoreIfDefault]
        public ObjectId Id { get; set; }

        [BsonIgnoreIfDefault]
        [BsonIgnoreIfNull]
        public string? MovieName { get; set; }

        [BsonIgnoreIfDefault]
        [BsonIgnoreIfNull]
        public string? Poster { get; set; }

        [BsonIgnoreIfDefault]
        [BsonIgnoreIfNull]
        public string? HallName { get; set; }

        [BsonIgnoreIfDefault]
        [BsonIgnoreIfNull]
        public string? PlaceNumber { get; set; }

        [BsonIgnoreIfDefault]
        [BsonIgnoreIfNull]
        public string? Date { get; set; }

        [BsonIgnoreIfDefault]
        [BsonIgnoreIfNull]
        public string? Time { get; set; }

        [BsonIgnoreIfDefault]
        [BsonIgnoreIfNull]
        public User? User { get; set; }
    }
}
