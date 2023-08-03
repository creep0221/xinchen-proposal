using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace xinchen_web.Models
{
    public class UserVO
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public int ID { get; set; }
        public string Account { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public string? Email { get; set; }
        public string PhoneNumber { get; set; }
    }
}
