using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace xinchen_web.Models
{
    public class UserTempProposal
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        public string UserId { get; set; }
        public Proposal Proposal { get; set; }
    }
}
