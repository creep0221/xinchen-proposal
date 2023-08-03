using System.ComponentModel;

namespace xinchen_web.Enumerables
{
    public enum MarketLocation
    {
        None = 0,
        /// <summary>
        /// 華山1914文化創意產業園區室內
        /// </summary>
        [Description("華山1914文化創意產業園區室內")]
        HuaShanIndoor = 1,
        /// <summary>
        /// 華山1914文化創意產業園區室外
        /// </summary>
        [Description("華山1914文化創意產業園區室外")]
        HuaShaOutdoor = 2,
        /// <summary>
        /// 松山文創園區室內
        /// </summary>
        [Description("松山文創園區室內")]
        SongShanIndoor = 3,
        /// <summary>
        /// 松山文創園區室外
        /// </summary>
        [Description("松山文創園區室外")]
        SongShanOurdoor = 4,
        /// <summary>
        /// 圓山花博
        /// </summary>
        [Description("圓山花博")]
        YuanShanExhibition = 5,
        /// <summary>
        /// 瓶蓋工廠室內
        /// </summary>
        [Description("瓶蓋工廠室內")]
        BottleCapFactoryIndoor = 6,
        /// <summary>
        /// 瓶蓋工廠室外
        /// </summary>
        [Description("瓶蓋工廠室外")]
        BottleCapFactoryOutdoor = 7,
        /// <summary>
        /// 紀州庵文學森林
        /// </summary>
        [Description("紀州庵文學森林")]
        KishuAn = 8
    }
}
