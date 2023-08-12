using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace xinchen_web.Models
{
    public class User
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        public string Account { get; set; }
        public string Password { get; set; }
        public string FullName { get; set; }
        public string? Email { get; set; }
        public string PhoneNumber { get; set; }

        public string UpperAccount { get; set; }
    }
}
