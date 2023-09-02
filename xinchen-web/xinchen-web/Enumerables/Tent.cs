using System.ComponentModel;

namespace xinchen_web.Enumerables
{
    public enum Tent
    {
        [Description("無")]
        None = 0,
        [Description("一般帳篷")]
        Regular = 1,
        [Description("木作棚架")]
        Wood = 2,
        [Description("其他需求")]
        Others = 3
    }
}
