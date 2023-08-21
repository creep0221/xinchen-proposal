using MongoDB.Bson.Serialization.Attributes;

namespace xinchen_web.Models
{
    public class UserProposal
    {
        [BsonId]
        public string Id { get; set; }
        public string UserId { get; set; }
        public List<string> ProposalId { get; set; }
    }
}
