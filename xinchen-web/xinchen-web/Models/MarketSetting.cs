namespace xinchen_web.Models
{
    public class MarketSetting
    {
        public MarketDetail[] MarketDetail { get; set; }
        public AddonService[] AddonService { get; set; }
    }
    public class MarketDetail
    {
        public int Id { get;set; }
        public string Location { get; set; }
        public MarketScale[] MarketScale { get; set; }
        public Tent[] Tent { get; set; }
        public Electricity[] Electricity { get; set; }
        public WaterFacility[] WaterFacility { get; set; }
        public CharingMode[] CharingMode { get; set; }
        public BudgetLevel[] BudgetLevel { get; set; }

    }

    public class AddonService 
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
    public class MarketScale
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
    public class Tent
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
    public class Electricity
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
    public class WaterFacility
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
    public class CharingMode
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
    public class BudgetLevel
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
