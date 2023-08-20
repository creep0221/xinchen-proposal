using System.ComponentModel;

namespace xinchen_web.Enumerables
{
    /// <summary>
    /// 市集風格
    /// </summary>
    public enum MarketStyle
    {
        None = 0,
        /// <summary>
        /// 1.動物森林風
        /// </summary>
        [Description("動物森林風")]
        AnimalForest = 1,
        /// <summary>
        /// 2.奢華派對風
        /// </summary>
        [Description("奢華派對風")]
        LuxuryParty = 2,
        /// <summary>
        /// 3.藝文清新風
        /// </summary>
        [Description("藝文清新風")]
        ArtisticFresh = 3,
        /// <summary>
        /// 4.異國文化風(日系/美系)
        /// </summary>
        [Description("異國文化風(日系/美系)")]
        CrossCulture = 4,
        /// <summary>
        /// 5. Outdoor野營風
        /// </summary>
        [Description("Outdoor野營風")]
        Outdoor = 5,
        /// <summary>
        /// 6.台派風格
        /// </summary>
        [Description("台派風格")]
        Taiwanese = 6
    }
}
