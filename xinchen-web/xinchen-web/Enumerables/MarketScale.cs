using System.ComponentModel;

namespace xinchen_web.Enumerables
{
    public enum MarketScale
    {
        None = 0,
        /// <summary>
        /// (1)大型市集( >100攤)
        /// </summary>
        [Description("大型市集( >100攤)")]
        Large = 1,
        /// <summary>
        /// (2)中型市集(30~100攤)
        /// </summary>
        [Description("中型市集(30~100攤)")]
        Medium = 2,
        /// <summary>
        /// (3)小型市集( <30攤)
        /// </summary>
        [Description("小型市集( <30攤)")]
        Small = 3


    }
}
