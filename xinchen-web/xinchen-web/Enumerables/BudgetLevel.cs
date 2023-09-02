using System.ComponentModel;

namespace xinchen_web.Enumerables
{
    public enum BudgetLevel
    {
        [Description("無")]
        None = 0,
        [Description("小於30萬")]
        lt30 = 1,
        [Description("31~50萬")]
        gt31lt50 = 2,
        [Description("51~80萬")]
        gt51lt80 =3,
        [Description("81~100萬")]
        gt81lt100 =4,
        [Description(">100萬")]
        gt100 = 5
    }
}
