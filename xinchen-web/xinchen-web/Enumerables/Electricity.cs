using System.ComponentModel;

namespace xinchen_web.Enumerables
{
    public enum Electricity
    {
        [Description("無")]
        None = 0,
        [Description("一般電力-一攤2A")]
        Regular = 1,
        [Description("重型電力-餐飲或表演")]
        Heavy = 2
    }
}
