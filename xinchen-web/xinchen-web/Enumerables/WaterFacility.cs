using System.ComponentModel;

namespace xinchen_web.Enumerables
{
    public enum WaterFacility
    {
        [Description("無")]
        None = 0,
        [Description("有水")]
        WithWater = 1,
        [Description("無水")]
        WithourWater = 2
    }
}
