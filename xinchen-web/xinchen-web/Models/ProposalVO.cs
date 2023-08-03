using xinchen_web.Enumerables;

namespace xinchen_web.Models
{
    public class ProposalVO
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public MarketStyle MarketStyle { get; set; }
        public MarketType MarketType { get; set; }
        public MarketLocation Location { get; set; }
        public MarketScale MarketScale { get; set; }
        public int Tent { get; set; }
        public int Electricity { get; set; }
        public int WaterFacility { get; set; }
        public int CharingMode { get; set; }
        public int BudgetLevel { get; set; }
        public int Status { get; set; }

    }

}
