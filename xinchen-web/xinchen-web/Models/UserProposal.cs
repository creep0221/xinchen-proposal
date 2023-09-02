using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace xinchen_web.Models
{
    public class UserProposal
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        public string UserId { get; set; }
        public List<string> ProposalId { get; set; }
    }
}
