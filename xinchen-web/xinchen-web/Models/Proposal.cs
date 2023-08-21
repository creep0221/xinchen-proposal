using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using xinchen_web.Enumerables;

namespace xinchen_web.Models
{
    public class Proposal
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        public string Name { get; set; }

        public short MarketStyle { get; set; }
        public short MarketType { get; set; }
        public short Location { get; set; }
        public short MarketScale { get; set; }
        public short Tent { get; set; }
        public short Electricity { get; set; }
        public short WaterFacility { get; set; }
        public short CharingMode { get; set; }
        public short BudgetLevel { get; set; }
        public short[] AddonService { get; set; }
        public short Status { get; set; }

    }

}
