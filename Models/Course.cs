using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace MongoDbExample.Models
{
    public class Course
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public string Code { get; set; } = string.Empty;
    }
}