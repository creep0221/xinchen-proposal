using System.ComponentModel;

namespace xinchen_web.Enumerables
{
    public enum CharingMode
    {
        [Description("無")]
        None = 0,
        [Description("免費(有/無提供車馬費)")]
        Free = 1,
        [Description("收費(報名費)")]
        Charged = 2
    }
}
