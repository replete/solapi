using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Sol.Models {

    public class User {

        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; } = default!;
        public string Name { get; set; } = default!;
        public string Email { get; set; } = default!;
        public string Password { get; set; } = default!;
    }
}