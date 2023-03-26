using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace CinemaCoursework.Data
{
    public class Place
    {
        [BsonId]
        [BsonIgnoreIfDefault]
        public ObjectId Id { get; set; }
        [BsonIgnoreIfDefault]
        [BsonIgnoreIfNull]
        public int Number { get; set; }
        [BsonIgnoreIfDefault]
        [BsonIgnoreIfNull]
        public int Row { get; set; }
    }
}
