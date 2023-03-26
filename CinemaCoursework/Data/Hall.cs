using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace CinemaCoursework.Data
{
    public class Hall
    {
        [BsonId]
        [BsonIgnoreIfDefault]
        public ObjectId Id { get; set; }
        [BsonIgnoreIfDefault]
        [BsonIgnoreIfNull]
        public string? Name { get; set; }
        [BsonIgnoreIfDefault]
        [BsonIgnoreIfNull]
        public List<Place>? Places { get; set; }
    }
}
