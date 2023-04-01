using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace CinemaCoursework.Data
{
    public class Place
    {
        [BsonId]
        [BsonIgnoreIfDefault]
        public ObjectId Id { get; set; }
        [BsonIgnoreIfDefault]
        [BsonIgnoreIfNull]
        public int PlaceNumber { get; set; }
        [BsonIgnoreIfDefault]
        [BsonIgnoreIfNull]
        public int Row { get; set; }
        [BsonIgnoreIfDefault]
        [BsonIgnoreIfNull]
        public bool IsOccupied { get; set; }
    }
}
