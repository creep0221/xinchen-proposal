using System.ComponentModel;

namespace xinchen_web.Enumerables
{
    /// <summary>
    /// 市集類型
    /// </summary>
    public enum MarketType
    {
        None = 0,
        /// <summary>
        /// 1.手作文創類
        /// </summary>
        [Description("手作文創類")]
        HandmadeCreativity = 1,
        /// <summary>
        /// 2.藝術展演類
        /// </summary>
        [Description("藝術展演類")]
        ArtistPerform = 2,
        /// <summary>
        /// 3.街頭餐飲
        /// </summary>
        [Description("街頭餐飲")]
        StreetFood = 3


    }
}
