using System.ComponentModel;
using xinchen_web.Enumerables;

namespace xinchen_web.Models
{
    public class MarketDescription
    {
        public Dictionary<short, MarketStyleDescription> StyleDesc { get; private set; }
        public Dictionary<short, MarketTypeDescription> TypeDesc { get; private set; }
        public Dictionary<short, MarketLocationDescription> LocationDesc { get; private set; }
        public Dictionary<short, MarketScaleDescription> ScaleDesc { get; private set; }
        public Dictionary<short, TentDescription> TentDesc { get; private set; }
        public Dictionary<short, ElectricityDescription> ElectricityDesc { get; private set; }
        public Dictionary<short, WaterFacilityDescription> WaterFacilityDesc { get; private set; }
        public Dictionary<short, CharingModeDescription> CharingModeDesc { get; private set; }
        public Dictionary<short, BudgetLevelDescription> BudgetLevelDesc { get; private set; }


        public MarketDescription()
        {
            InitStyleDescription();
            InitTypeDescription();
            InitLocationDescription();
            InitScaleDescription();
            InitTentDescription();
            InitElectricityDescription();
            InitWaterFacilityDescription();
            InitCharingModeDescription();
            InitBudgetLevelDescription();
        }
        private void InitStyleDescription()
        {
            StyleDesc = new Dictionary<short, MarketStyleDescription>();

            var animalForestStyle = new MarketStyleDescription();
            animalForestStyle.MarketStyleTitle = @"動物森林手作市集";
            animalForestStyle.StyleImagePath = "~/images/marketstyle/01animalforest.jpg";
            animalForestStyle.MarketStyleGoal = @"
<p>
在於以一個愉悅、充滿童趣的方式，凝聚社區中對於大自然和動物的關注與愛護，透過創意手作藝術的表現，
喚起人們對於生態平衡的重要性的認識，同時鼓勵參與者以自己的創作去探索動植物、森林環境所帶來的美妙與奧秘，
進而促進可持續環保思維和保護大自然的行動。我們期待透過這個市集，串聯起一個關愛、尊重及和諧共處於動物和綠意之間的社區，
並為我們的子孫締造一個更美好的環境。 
</p>
";
            animalForestStyle.MarketStyleFactor = @"
<p>
透過「動物森林手作市集」的設計繪製，我們將以豐富的圖像和色彩，呈現一個充滿活力、自然與童趣的場景，引領參與者進入一個歡樂的大自然世界。
以下是設計繪製方向的詳細描述： 
</p>
<p>主視覺元素： </p>
<p>
動物角色： 在市集的主視覺中，將呈現各種動物角色，如可愛的小松鼠、兔子、鳥兒、狐狸等，它們將成為市集的吉祥物，代表著動物森林的環境。
這些動物角色應具有極富表情的特點，能夠觸動人心，讓人對大自然的愛護感產生共鳴。 
</p>
<p>綠地和森林： 主視覺的背景將是一片廣袤的綠地和茂密的森林，透過繽紛的樹木、草地和花朵，呈現出一個豐富多樣的生態環境。
森林的深綠色和自然光影的變化，營造出寧靜而充滿生氣的氛圍。 
</p>
<p>色彩概念：</p>
<p>
自然色調： 整個設計將以大自然的色調為主，如深綠、天藍、柔和的棕色和土色，以及鮮豔的花朵顏色。這些色彩能夠喚起人們對於大自然的記憶和情感，
同時也傳達出清新和和諧的感覺。 
</p>
<p>
動物色彩： 動物角色的色彩將參考真實動物的外觀，同時也加入一些帶有童趣的彩虹色調，突顯市集的歡樂和藝術氛圍。 
</p>
<p>場景元素：</p>
<p>
攤位區域： 在設計中，可以將市集攤位的概念圖描繪出來，每個攤位的背景都可以有不同的動物和自然元素，彰顯著每個參展者的獨特特色。 
</p>
<p>
動物互動場景： 在主視覺中可以加入一些動物的互動場景，如小松鼠攀爬在樹上，兔子在草地上奔跑，這些場景可以增加活潑感，
讓人們感受到動物森林的生動性。 
</p>
<p>整體風格： </p>
<p>
整體風格將以手繪、插畫風格為主，帶有輕鬆、自然、童趣的元素。繪製的線條可以有一些筆觸的質感，讓整個設計更具人情味和溫度。 
</p>
<p>
這個設計繪製方向將以豐富的視覺元素和色彩，將「動物森林手作市集」的主題生動呈現，勾勒出一個令人心馳神往的自然世界，
引導參與者穿越大自然的美麗和神奇。 
</p>

";
            animalForestStyle.MarketStyleFeature = @"
<p>
自然靈感手作攤位： 數十位藝術家將呈現以動物、綠地和森林為靈感的手工創作，包括繪畫、雕塑、陶瓷、紡織品等多種媒材，讓您感受大自然的美妙。
</p>
<p>
大自然手作工作坊： 我們將舉辦一系列有趣的手作工作坊，讓您親自體驗創作過程，例如製作葉子手工飾品、森林生態畫等，
專業導師將引導您創造出獨特的作品。 
</p>
<p>
動物主題展演： 主舞台將呈現各式各樣的動物主題表演，包括寵物秀、鳥類翱翔表演，以及有趣的動物趣聞分享。
</p>
<p>
自然美味美食區： 現場提供以新鮮食材為主的自然美食，讓您在品味美味的同時，也能感受到食物與自然的緊密聯繫。
</p>
<p>
生態保育分享： 我們特別邀請生態專家進行講座，分享有關保護動植物、森林環境等議題，以提高大眾對自然保育的認識。
</p>
";
            StyleDesc.Add(1, animalForestStyle);

            var luxuryPartyStyle = new MarketStyleDescription();
            luxuryPartyStyle.MarketStyleTitle = "奢華派對藝品市集";
            luxuryPartyStyle.StyleImagePath = "~/images/marketstyle/02luxuryParty.jpg";
            luxuryPartyStyle.MarketStyleGoal = @"
<p>
在於打造一個極具華麗、高尚的藝品市集，透過藝術的輝煌和手工藝的精湛工藝，展現藝術的獨特魅力與價值。
我們致力於匯集來自國際和本地的頂尖藝術家和創作者，為參與者呈現一場優雅、精緻的藝術盛宴，同時透過這個奢華的活動平台，
提倡藝術的尊貴、創作的無限可能，以及對人文藝術的長久支持。我們希望透過這個市集，啟發人們對於美的欣賞、藝術的尊嚴，
並在高雅的氛圍中共同分享創意和情感。這是一場藝術和美學的盛會，融合奢華和創意，呈現藝術在人們生活中的深遠影響和價值。
我們期望參與者能夠在這個奢華派對中，感受藝術的魅力、展現自己的獨特品味，並在華麗的背後找到情感共鳴和美的共享。
這個宗旨將引領我們共同創造一個高尚、精緻的藝品交流平台，讓藝術的光芒繼續綻放在人們的生活之中。 
</p>
";
            luxuryPartyStyle.MarketStyleFactor = @"
<p>
透過「奢華派對藝品市集」的設計繪製，我們將展現一個夢幻、典雅的夜晚場景，以金色和亮片為主要元素，創造出一個奢華、璀璨的藝術空間。
以下是設計繪製方向的詳細描述： 
</p>
<p>
主視覺元素： 
</p>
<p>
夜晚場景： 在市集的主視覺中，描繪出一個寧靜的夜晚場景，有著深藍色的天空和星光點點。這將營造出一個神秘而浪漫的氛圍，
使參與者彷彿置身於夜晚的奢華派對中。 
</p> 
<p>
金色和亮片： 主視覺中的藝品、裝飾和文字將充滿金色和亮片的元素，這些光芒四射的細節將為設計增添奢華感和高貴感。金色代表著尊貴和璀璨，
而亮片則為整個場景注入動感和閃爍效果。 
</p> 
<p>
色彩概念： 
</p> 
<p>
金色調： 金色將是整個設計的主要色調，從深沉的酒紅金到明亮的黃金色調，都能夠帶來奢華的感覺。金色的光澤和光影變化將為整個設計增添層次感。 
</p> 
<p>
深藍和黑色： 作為夜晚場景的背景，深藍和黑色將用來表現夜空的神秘感。這些色調將與金色形成鮮明對比，使金色元素更加顯眼。 
</p> 
<p>
場景元素： 
</p> 
<p>
藝品展示區： 在設計中可以描繪出華麗的藝品展示區，展示高品質的手工藝品和藝術品。這些展示區可以有金色和亮片的裝飾，
使每一個藝品都顯得尊貴而獨特。 
</p> 
<p>
星光點點： 在夜空中描繪出星光點點，為整個設計增添夢幻感和浪漫氛圍，同時也呼應著夜晚派對的場景。 
</p> 
<p>
整體風格： 
</p> 
<p>
整體風格將以華麗、夢幻和典雅為主，融合了金色、亮片和夜晚的元素，呈現出一種光芒四射、璀璨奪目的感覺。設計將強調細節，
讓觀眾在視覺上感受到豐富的層次和質感。 
</p> 
<p>
這個設計繪製方向將在光芒和夜晚的環境中，呈現出「奢華派對藝品市集」的主題。透過金色、亮片和夜空的元素，打造出一個典雅、
浪漫的場景，使參與者能夠在光影之中感受到藝術的高貴和價值。 
</p>
";
            luxuryPartyStyle.MarketStyleFeature = @"
<p>
華麗手工藝攤位： 來自國際和本地的頂尖手工藝藝術家將在市集上展示精心製作的高品質手工藝品，包括珠寶、時尚配飾、皮革製品等，以奢華材質和精湛工藝展現藝術的獨特價值。 
</p> 
<p>
奢華工作坊： 活動期間將舉辦一系列尊貴的工作坊，讓參與者親自體驗製作過程，學習高級手工技巧，如珠寶設計、刺繡藝術等，創作出充滿品味的個人作品。 
</p> 
<p>
音樂與藝術表演： 主舞台將呈現古典音樂演奏、歌唱表演，以及藝術家的創作分享，為市集注入一絲高雅的藝術氛圍。 
</p> 
<p>
奢華美食體驗： 在市集周邊設置美食區，提供精緻美味的奢華料理，讓參與者在品味美食的同時，也能感受宴會的浪漫氛圍。 
</p> 
<p>
慈善拍賣： 活動最後一天舉辦慈善拍賣，所得收入將捐贈給當地藝術教育機構，支持藝術的培育和發展。 
</p>
";
            StyleDesc.Add(2, luxuryPartyStyle);

            var artisticFreshStyle = new MarketStyleDescription();
            artisticFreshStyle.MarketStyleTitle = "藝文清新風市集";
            artisticFreshStyle.StyleImagePath = "~/images/marketstyle/03artisticFresh.jpg";
            artisticFreshStyle.MarketStyleGoal = @"
<p>
在於打造一個融合藝術、文化和自然的活動平台，透過輕盈、愉悅的氛圍，啟發參與者對於創意表達、知識分享和自然互動的興趣。
我們致力於營造一個溫暖、充滿想像力的環境，促進藝文的交流和文化的傳承，同時鼓勵人們透過親身參與和體驗，
重新發現對於藝術、文化和自然的愛與熱情。我們相信藝術和自然有著相互滋養的關係，能夠為人們的生活帶來美好和啟發。
這個宗旨將引領我們一同創造一個充滿活力、激發創造力的藝文聚會，使藝術、文化和自然成為我們生活中不可或缺的一部分。 
</p>
";
            artisticFreshStyle.MarketStyleFactor = @"
<p>
透過「藝文清新風市集」的設計繪製，我們將以大地色系、不規則圓形和色塊的元素，呈現一個自然、輕盈的藝術氛圍。以下是設計繪製方向的詳細描述： 
</p> 
<p>
主視覺元素： 
</p> 
<p>
大地色系： 在市集的主視覺中，主要使用大地色系，如淺棕色、柔和的綠色、淡黃色等，以營造出自然、溫暖的感覺。這些色彩能夠引起人們對自然的聯想，使參與者在視覺上感受到平靜和寧靜。 
</p> 
<p>
不規則圓形： 不規則圓形將是整個設計的主要幾何形狀，這些圓形可以代表藝術的無限可能性和流動感，同時也呼應自然中的曲線和變化。 
</p> 
<p>
色彩概念： 
</p> 
<p>
大地色調： 大地色系將主導整個設計的色彩概念，通過柔和的色調，呈現出清新和舒適的感覺。淡淡的綠色、棕色和灰色相互結合，營造出和諧的色彩配搭。 
</p> 
<p>
色塊： 在設計中加入色塊的元素，使用不同深淺的色彩塊，營造層次感和視覺重點。這些色塊可以呈現出不同的藝術風格和表現形式。 
</p> 
<p>
場景元素： 
</p> 
<p>
藝文展示空間： 描繪出藝文展示區域，展示不同類型的藝術品和文化作品，這些展示區可以根據不同主題劃分，同時也可以以不規則圓形的形式呈現，使展示更有趣味性。 
</p> 
<p>
不規則圓形裝飾： 在場景中加入不規則圓形的裝飾元素，可以是標誌、標題、攤位牌等，這些圓形元素不僅能夠增加視覺吸引力，還能夠營造出輕鬆的氛圍。 
</p> 
<p>
整體風格： 
</p> 
<p>
整體風格將以自然、輕盈、和諧為主，通過大地色系、不規則圓形和色塊的結合，創造出一個溫暖、愉悅的藝文聚會場景。設計將強調簡約、有機的風格，讓觀眾在輕鬆的氛圍中感受藝文的魅力和深層的情感。 
</p> 
<p>
這個設計繪製方向將在大地色調、不規則圓形和色塊的呈現下，打造出「藝文清新風市集」的主題。透過這些元素的結合，我們將營造出一個自然、輕盈的藝文場景，讓參與者能夠在其中感受到藝術的滋養和自然的和諧。 
</p>
";
            artisticFreshStyle.MarketStyleFeature = @"
<p>
藝文展示攤位： 來自各地的藝術家和文化團體將展示他們的作品，包括繪畫、攝影、手工藝品等，呈現出多元的藝術風貌，讓人們在欣賞作品的同時，也能了解不同的藝術表現形式。 
</p>  
<p>
清新手工藝坊： 在現場設置多個手工藝坊，讓參與者可以親身參與創作，製作自己的手工藝品，體驗創意的樂趣，同時也能了解手工藝的價值和技巧。 
</p>  
<p>
音樂舞台演出： 主舞台將舉行音樂演出、舞蹈表演、詩歌朗讀等，為現場注入輕快的節奏和藝術氛圍，讓參與者在音樂的陪伴下感受藝文的情感。 
</p>  
<p>
文化分享講座： 我們特別邀請文化學者和藝術家進行講座，分享有關藝術、文化、創作的思考和經驗，鼓勵大眾參與文化討論和思考。 
</p>  
<p>
美食與自然體驗： 市集周邊將設有美食區，提供健康、清新的美食選擇，同時也可以結合自然體驗，如植物種植、自然導覽等，使活動更加與自然環境融合。 
</p> 
";
            StyleDesc.Add(3, artisticFreshStyle);

            var crossCultureStyle = new MarketStyleDescription();
            crossCultureStyle.MarketStyleTitle = "異國文化風市集";
            crossCultureStyle.StyleImagePath = "~/images/marketstyle/04crossCulture.jpg";
            crossCultureStyle.MarketStyleGoal = @"
<p>
在於打造一個融合異國文化風情的多元交流平台，透過彙聚日系和美系的藝術、美食、音樂、時尚和傳統文化，鼓勵文化多樣性的尊重和理解。
我們以文化為紐帶，旨在促進人與人之間的連結，啟發對於異國文化的興趣，並強調共存與共融的價值。
透過藝術的交流、美食的分享、音樂的合奏、時尚的展示以及傳統文化的傳承，我們希望在這個異國風市集中，打破界限、促進友誼，
並共同創造一個充滿包容和和諧的文化交流盛會，讓參與者能夠在交流中發現共通點，並尊重不同文化的獨特之處，讓異國風情成為我們的寶貴財富。 
</p>
";
            crossCultureStyle.MarketStyleFactor = @"
<p>
透過「異國文化風市集」的設計繪製，我們將以和服、韓服、國旗和國際元素為主要特色，呈現一個充滿多元、包容的文化交流場景。以下是設計繪製方向的詳細描述： 
</p> 
<p>
主視覺元素： 
</p> 
<p>
和服與韓服： 主視覺中可以描繪出穿著和服和韓服的人物，這兩種異國服飾將成為視覺的焦點，代表著日系和韓系文化的特色。這些服飾的色彩和圖案能夠呈現出不同的文化特色，同時也體現了多元的美麗。 
</p> 
<p>
國旗： 在主視覺中加入來自不同國家的國旗元素，象徵著國際交流和多元文化的融合。這些國旗可以以色彩鮮豔的方式呈現，突顯出市集的多元性和包容性。 
</p> 
<p>
色彩概念： 
</p> 
<p>
多彩色調： 色彩將以多彩的元素為主，每個異國文化的色彩將在設計中得到體現。這些鮮豔的色調將代表不同文化的活力和豐富性。 
</p> 
<p>
和諧色彩配搭： 在多彩的基礎上，通過色彩的搭配和平衡，使整個設計保持和諧。不同文化的色彩能夠在設計中和諧共存，呈現出包容性和共融感。 
</p> 
<p>
場景元素： 
</p> 
<p>
多國攤位區： 描繪出來自不同國家的攤位區域，每個攤位代表著一個國家的文化特色。攤位上可以展示該國的手工藝品、美食、藝術品等，讓參與者近距離感受不同文化的魅力。 
</p> 
<p>
文化交流區： 在場景中設置文化交流區，讓參與者可以參加文化工作坊、舞蹈表演、音樂演奏等，透過親身參與來體驗異國文化的樂趣。 
</p> 
<p>
整體風格： 
</p> 
<p>
整體風格將以多元、國際、包容為主，透過和服、韓服、國旗和國際元素的結合，打造出一個充滿多彩和歡樂的文化交流場景。設計將強調多元文化的共存，讓觀眾能夠在這個場景中感受到文化的豐富性和人與人之間的連結。 
</p>
<p>
這個設計繪製方向將在和服、韓服、國旗和國際元素的呈現下，打造出一個多元、包容的「異國文化風市集」。透過這些元素的交織，我們將營造出一個彩虹般的文化交流場景，讓參與者能夠在其中感受到文化的美麗和多元的魅力。 
</p>
";
            crossCultureStyle.MarketStyleFeature = @"
<p>
異國文化攤位： 市集將邀請來自日本和美國的特色攤位，展示當地的手工藝品、飾品、服飾等，讓參與者近距離感受異國風情，並了解不同文化的獨特之處。 
</p> 
<p>
美食美味體驗： 現場將設置日式和美式美食攤位，呈現經典的美國漢堡和日本壽司，以及其他特色小吃，讓參與者在品味美食的同時，感受不同國度的味覺享受。 
</p> 
<p>
音樂舞台演出： 主舞台將上演多元風格的音樂表演，包括日本傳統音樂、美國流行曲目，以及交流合作的跨文化音樂，營造歡樂的節奏和音樂氛圍。 
</p> 
<p>
文化工作坊： 活動期間將舉辦日本茶道、美國插花等文化工作坊，讓參與者親身體驗不同國度的傳統文化，並且學習其獨特的手藝和技巧。 
</p> 
<p>
時尚服飾秀： 舉辦主題服飾秀，將展示日系和美系的時尚風格，呈現兩種異國風文化在服飾方面的美麗融合。 
</p>
";
            StyleDesc.Add(4, crossCultureStyle);

            var outdoorStyle = new MarketStyleDescription();
            outdoorStyle.MarketStyleTitle = "Outdoor野營風";
            outdoorStyle.StyleImagePath = "~/images/marketstyle/05outdoor.jpg";
            outdoorStyle.MarketStyleGoal = @"
<p>
在於鼓勵參與者遠離城市的喧囂，重新與大自然建立深刻聯繫，透過自然環境的親身體驗，探索大自然的奧秘和魅力。
我們深信自然能夠療癒心靈、豐富思維，同時透過戶外活動、環保教育和文化交流，引導人們尊重自然、愛護環境，以及培養永續生活的價值觀。
這場活動旨在營造一個充滿活力、富有探險精神的戶外環境，讓參與者在自然的懷抱中找回平衡、靈感和幸福，
同時也將自然的美好和可持續的生活方式傳遞給更多人，共同守護這片美麗的地球
</p>
";
            outdoorStyle.MarketStyleFactor = @"
<p>
透過「Outdoor野營風市集」的設計繪製，我們將以戶外、草地、營火和野餐的元素，呈現一個充滿自然、放鬆的環境。以下是設計繪製方向的詳細描述： 
</p> 
<p>
主視覺元素： 
</p> 
<p>
戶外場景： 主視覺中描繪出廣闊的戶外場景，包括草地、樹木和天空。這些元素代表著大自然的美麗和寬廣，營造出自然環境中的寧靜和寧和感。 
</p> 
<p>
營火： 在主視覺中加入營火的元素，象徵著野營的氛圍和溫暖。營火的火焰能夠營造出溫馨的光照，也代表著夜晚在戶外的活動。 
</p> 
<p>
色彩概念： 
</p> 
<p>
大自然色調： 以大自然的色彩為基調，使用綠色、褐色、淺藍色等自然色調，呈現戶外環境的真實感和和諧。 
</p>
<p>
溫暖色調： 在色彩中加入溫暖的橘色和紅色，代表營火的溫度和能量，同時也能為整個設計增添視覺焦點。 
</p>
<p>
場景元素： 
</p>
<p>
草地休憩區： 在場景中設置草地休憩區，可以是野餐墊、躺椅等，讓參與者能夠在草地上放鬆休息，感受自然的氛圍。 
</p> 
<p>
營火篝火區： 描繪出篝火區域，可以是一個圓圈的火堆，周圍圍繞著參與者圍坐，享受營火的溫暖和社交。 
</p> 
<p>
活動元素： 
</p> 
<p>
野餐設置： 在場景中安排野餐區，展示戶外野餐的場景，可以是擺放食物、野餐桌椅，讓參與者感受野外用餐的愜意。 
</p>
<p>
自然探索區： 在場景中加入自然探索的元素，如指南針、放大鏡、植物標本等，讓參與者能夠在戶外環境中進行自然觀察和學習。 
</p> 
<p>
整體風格： 
</p> 
<p>
整體風格將以戶外、自然、放鬆為主，通過草地、營火和野餐的元素，打造出一個自然、舒適的戶外環境。設計將強調簡單、寧靜的風格，讓觀眾能夠在其中感受到戶外活動的愜意和舒適。 
</p> 
<p>
這個設計繪製方向將在大自然色調、溫暖色彩和戶外元素的呈現下，營造出「Outdoor野營風市集」的主題。透過這些元素的結合，我們將呈現出一個充滿自然和放鬆感的戶外市集場景，讓參與者能夠在其中感受到自然的美好和愜意。 
</p>
";
            outdoorStyle.MarketStyleFeature = @"
<p>
野營體驗區： 在郊區自然公園設置野營區域，提供帳篷、營火和露天用餐區，讓參與者能夠親身體驗戶外野營的樂趣，感受大自然的靜謐和寧靜。 
</p> 
<p>
自然探險活動： 舉辦自然探險活動，如尋找野生動植物、導覽生態環境等，讓參與者在戶外的過程中學習、觀察和探索，增強對自然的認識。 
</p> 
<p>
環保教育工作坊： 舉辦環保教育工作坊，教導參與者如何在戶外環境中保持環保意識，減少對環境的影響，同時鼓勵垃圾分類和資源回收。 
</p> 
<p>
戶外音樂演出： 舉辦戶外音樂演出，呈現原汁原味的戶外音樂風格，營造舒適的音樂氛圍，讓參與者在自然中享受音樂的愉悅。 
</p> 
<p>
美食與自然體驗： 在戶外營地周邊設置美食區，提供營火烤肉、野外烹飪等自然體驗，讓參與者在享受美食的同時，感受自然的生活方式。 
</p>
";
            StyleDesc.Add(5, outdoorStyle);

            var taiwaneseStyle = new MarketStyleDescription();
            taiwaneseStyle.MarketStyleTitle = "台派風市集";
            taiwaneseStyle.StyleImagePath = "~/images/marketstyle/06taiwanese.jpg";
            taiwaneseStyle.MarketStyleGoal = @"
<p>
在於強化台灣文化的連結，喚起對台灣的情感與歸屬，同時也藉由市集的融合和創新，將傳統台灣的風貌融入現代生活。
我們致力於重新點燃對台灣傳統的尊重和關愛，並透過市集的平台，將傳統工藝、美食、音樂、語言和價值觀傳承給新一代。
這場市集不僅是對台灣文化的慶祝，更是一個凝聚社區情感，彰顯文化特色，以及為台灣人民帶來歸屬感和自豪感的場所。
我們希望透過這個市集，將台灣的美好價值傳遞給更多人，讓台灣文化成為我們的共同驕傲，凝聚力量，共同守護台灣的傳承。 
</p>
";
            taiwaneseStyle.MarketStyleFactor = @"
<p>
透過「台派風市集」的設計繪製，我們將以台灣、復古和霓虹的元素，呈現一個兼具懷舊情感和現代活力的市集場景。以下是設計繪製方向的詳細描述： 
</p> 
<p>
主視覺元素： 
</p>
<p>
台灣地景： 主視覺中以台灣的地理輪廓為基礎，描繪出台灣的山川、河流，以及代表性的地標，如高山、海岸線等，突顯台灣的美麗和多元風貌。 
</p> 
<p>
復古元素： 在主視覺中加入復古的元素，如老式街燈、腳踏車、老屋等，呼應台灣的過去，喚起人們對過去時光的回憶和情感。 
</p> 
<p>
霓虹燈光： 在主視覺中融入霓虹燈光的效果，代表現代活力和時尚感。這些霓虹燈光可以呈現市集的名稱、主題，為整個設計增添動感。 
</p> 
<p>
色彩概念： 
</p>
<p>
台灣自然色彩： 使用大自然的色彩，如綠色、藍色、土色等，呈現出台灣的自然風景，突顯台灣的美麗和多樣性。 
</p> 
<p>
復古色調： 在色彩中加入復古的色調，如淺棕色、淡黃色，讓整個設計散發懷舊的情感，回味過去的台灣風景。 
</p> 
<p>
霓虹色彩： 在霓虹元素中使用鮮豔的霓虹色彩，如紅色、藍色、綠色，為整個設計注入現代感和活力。 
</p> 
<p>
場景元素： 
</p> 
<p>
復古攤位區： 在場景中設置復古風格的攤位區，展示傳統台灣商品、古董、手工藝品等，讓參與者感受台灣的復古魅力。 
</p> 
<p>
霓虹燈牆： 在場景中打造霓虹燈牆，可以是市集名稱、標語等，營造出現代感十足的環境，吸引參與者拍照留念。 
</p> 
<p>
活動元素： 
</p> 
<p>
表演舞台： 設置舞台進行表演，包括台語歌曲演唱、傳統音樂演奏、舞蹈等，展現台灣文化的多樣性。 
</p> 
<p>
霓虹美食區： 在美食區域加入霓虹燈光的裝飾，營造現代與傳統的結合，展示台灣美食的豐富。 
</p> 
<p>
整體風格： 
</p> 
<p>
整體風格將以台灣、復古和霓虹為主，通過這些元素的結合，打造出一個兼具傳統情感和現代活力的市集場景。設計將展現台灣的美麗風景、懷舊情感和現代創意的結合，讓觀眾能夠在其中感受到台灣的多元魅力。 
</p> 
<p>
這個設計繪製方向將在台灣自然色彩、復古元素和霓虹燈光的呈現下，營造出「台派風市集」的主題。透過這些元素的交織，我們將展現出台灣的過去與現在，以及台灣文化的多元性和活力。 
</p>
";
            taiwaneseStyle.MarketStyleFeature = @"
<p>
傳統工藝展示： 邀請傳統工藝師傅展示台灣傳統工藝，如剪紙、竹編、布袋戲布偶等，讓參與者近距離觀賞並參與製作，感受台灣傳統藝術的美妙。 
</p>
<p>
台派美食品味： 設置台灣傳統小吃攤位，呈現台派美食，如蚵仔煎、滷肉飯、擔仔麵等，讓參與者品味台灣的地方美食。 
</p> 
<p>
台灣音樂表演： 舉辦台灣音樂表演，呈現台灣的音樂風格，包括台語歌曲、民謠演奏，讓參與者在音樂中感受台灣的情感和節奏。 
</p> 
<p>
文化工作坊： 舉辦台灣文化工作坊，如台灣茶道、台語學習、創意書法等，讓參與者親身體驗台灣的文化特色。 
</p> 
<p>
傳統市集氛圍： 在市集中重現傳統台灣市集的氛圍，設置攤位攤販，展示傳統商品，讓參與者回味舊時的台灣市集風光。 
</p>
";
            StyleDesc.Add(6, taiwaneseStyle);

        }
        private void InitTypeDescription()
        {
            TypeDesc = new Dictionary<short, MarketTypeDescription>();
            var handmadeCreativityType = new MarketTypeDescription();
            handmadeCreativityType.Description = @"
<p>
這個市集是一個由100%手作類攤位所組成的繽紛世界，每個攤位都展現了創作者的獨特才華和精湛技藝。
走進這個市集，彷彿進入了一個純粹的手作藝術殿堂，每一件展品都是創作者用心灌注的作品，每一處攤位都是一個獨立的創意小宇宙。 
</p>
<p>
舉例來說可能會出現的品牌有 
</p>
<p>
1. JIEGEM 姊的珠寶盒 
</p>
<div>
    <img src=""/images/markettype/handmade/01.jpg"" title=""JIEGEM 姊的珠寶盒"" >
</div>
<br />
<p>
2. Kotori 小鳥日本飾品專門店
</p>
<div>
    <img src=""/images/markettype/handmade/02.jpg"" title=""Kotori 小鳥日本飾品專門店"" >
</div>
<br />
<p>
3. °○敲級口愛chaogikoi°○串珠珠 
</p>
<div>
    <img src=""/images/markettype/handmade/03.jpg"" title=""°○敲級口愛chaogikoi°○串珠珠 "" />
</div>
<br />
<p>
4. 織妍CHIYEN 
</p>
<div>
    <img src=""/images/markettype/handmade/04.jpg"" title=""織妍CHIYEN"" />
</div>
<p>
5. 奧羅拉商行
</p>
<br />
<div>
    <img src=""/images/markettype/handmade/05.jpg"" title=""奧羅拉商行"" />
</div>
<p>
※品牌圖示皆為示意圖，實際依招收品牌為主，圖示版權方為品牌本身非主辦單位所有 
</p>
";
            TypeDesc.Add(1, handmadeCreativityType);

            var artistPerformType = new MarketTypeDescription();
            artistPerformType.Description = @"
<p>
這個市集呈現出一種多元而平衡的藝術氛圍，其中40%的手作類攤位、30%的繪畫類攤位和30%的陶藝類攤位，組合成了一個充滿創意和多樣性的藝術世界。每個攤位都散發著獨特的魅力，呈現出各種不同的藝術風格和技巧。 
</p>
<p>
在手作類攤位中，你可以發現各種手工製品，從編織品到紙藝，從皮革工藝到飾品，每一件作品都是創作者用心創作的結晶。這些手作品展現了創作者的巧思和技藝，呈現出獨特的細節和質感。 
</p> 
<p>
30%的繪畫類攤位帶來了視覺的享受，展示著畫家們豐富的想像力和表達能力。從寫實風格到抽象風格，每個繪畫攤位都帶來了一個不同的世界，讓觀眾可以在畫作中流連忘返，感受藝術的力量。 
</p> 
<p>
陶藝類攤位佔30%，將你帶入了陶瓷的世界。這裡展示著陶藝家的創作，從精緻的陶器到獨特的陶瓷藝術品，每個作品都散發著古樸的氣息和藝術家的靈感。你可以欣賞到陶藝的多樣性，從粗獷的手感到精緻的雕刻，每個作品都是對土地和生活的獨特詮釋。 
</p>
<p>
舉例來說可能會出現的品牌有 
</p>
<p>
1. JIEGEM 姊的珠寶盒 
</p>
<br />
<div>
    <img src=""/images/markettype/artist/01.jpg"" title=""JIEGEM 姊的珠寶盒 "" />
</div>
<p>
<br />
2. Kotori 小鳥日本飾品專門店
</p>
<div>
    <img src=""/images/markettype/artist/02.jpg"" title=""Kotori 小鳥日本飾品專門店"" />
</div>
<p>
<br />
3. 陶炑
</p>
<div>
    <img src=""/images/markettype/artist/03.jpg"" title=""陶炑"" />
</div>
<p>
<br />
4. Soul Irrigation靈魂灌溉所
</p>
<div>
    <img src=""/images/markettype/artist/04.jpeg"" title=""Soul Irrigation靈魂灌溉所"" />
</div>
<p>
<br />
5. 墨染一色
</p>
<div>
    <img src=""/images/markettype/artist/05.jpeg"" title=""墨染一色"" />
</div>
<p>
<br />
6. 人中人株式會社
</p>
<div>
    <img src=""/images/markettype/artist/06.jpeg"" title=""人中人株式會社"" />
</div>
<p>
※品牌圖示皆為示意圖，實際依招收品牌為主，圖示版權方為品牌本身非主辦單位所有 
</p>

";
            TypeDesc.Add(2, artistPerformType);

            var streetFoodType = new MarketTypeDescription();
            streetFoodType.Description = @"
<p>
這個市集為你帶來一場匠心獨具的體驗，由40%的手作類攤位和60%的餐飲類攤位所組成。在這個充滿創意和美味的環境中，你可以同時感受到藝術的觸摸和味蕾的享受。 
</p>
<p>
手作類攤位帶來了獨特的藝術風景，每個攤位都散發著創作者的熱情和巧思。從手工製品到文創商品，每一件作品都是創作者的心血結晶，展現了多種不同的風格和技藝。你可以找到各種驚喜，從細緻的手繪明信片到別具特色的手工藝品，每個攤位都是一個獨特的藝術展示。 
</p> 
<p>
而在餐飲類攤位中，你將迎接一場美食的盛宴。從道地的本土美食到創意十足的國際料理，每個攤位都帶來了獨特的口味和風味。你可以品嚐到來自各地的美味佳餚，從街頭小吃到精緻料理，每一口都是一次味覺的探險。 
</p> 
<p>
市集的氛圍充滿了生活的情趣和藝術的氛圍。手作攤位上的作品展現了創作者的個性和創意，讓你感受到藝術的溫度；餐飲攤位則呈現了廚師的烹飪技藝和對美食的熱愛，讓你品味到味蕾的享受。無論是尋找獨特的禮物、欣賞藝術，還是享受美食的滋味，這個市集都能夠滿足你多方面的期待。舉例來說可能會出現的品牌有 
</p>
<p>
1. °○敲級口愛chaogikoi°○串珠珠
</p>
<div>
    <img src=""/images/markettype/streetfood/01.jpg"" title=""°○敲級口愛chaogikoi°○串珠珠"" />
</div>
<br />
<p>
2. 織妍CHIYEN
</p>
<div>
    <img src=""/images/markettype/streetfood/02.jpg"" title=""織妍CHIYEN"" />
</div>
<p>
<br />
3. 綺楽燒
</p>
<div>
    <img src=""/images/markettype/streetfood/03.jpeg"" title=""綺楽燒"" />
</div>
<p>
<br />
4. 犬首燒
</p>
<div>
    <img src=""/images/markettype/streetfood/04.jpg"" title=""犬首燒"" />
</div>
<p>
<br />
5. J主廚特製軟法三明治
</p>
<div>
    <img src=""/images/markettype/streetfood/05.jpeg"" title=""J主廚特製軟法三明治"" />
</div>
<p>
※品牌圖示皆為示意圖，實際依招收品牌為主，圖示版權方為品牌本身非主辦 
</p>
";
            TypeDesc.Add(3, streetFoodType);
        }
        private void InitLocationDescription()
        {
            LocationDesc = new Dictionary<short, MarketLocationDescription>();
            var huaShanIndoor = new MarketLocationDescription();
            huaShanIndoor.Description = @"
<div>
    <img src=""/images/location/01huashan.jpg"" title=""華山1914文化創意產業園區"" />
</div>
<p>
地址: 台北市中正區八德路一段1號 
</p>
<p>
特色: 是位於臺灣臺北市中正區的複合式文化展演園區。前身為「台北酒廠」，為臺北市市定古蹟；
經多年閒置，在1999年起成為提供給藝文界、非營利組織及個人使用的藝術展覽、音樂表演等文化活動場地，成為臺北市西區重要的藝文展演場所。 
</p>
<p>
※照片為示意圖，版權方為場地所有非主辦單位 
</p>
";
            LocationDesc.Add(1, huaShanIndoor);

            var huaShaOutdoor = new MarketLocationDescription();
            huaShaOutdoor.Description = @"
<div>
    <img src=""/images/location/01huashan.jpg"" title=""華山1914文化創意產業園區"" />
</div>
<p>
地址: 台北市中正區八德路一段1號 
</p>
<p>
特色: 是位於臺灣臺北市中正區的複合式文化展演園區。前身為「台北酒廠」，為臺北市市定古蹟；經多年閒置，在1999年起成為提供給藝文界、非營利組織及個人使用的藝術展覽、音樂表演等文化活動場地，成為臺北市西區重要的藝文展演場所。 
</p>
<p>
※照片為示意圖，版權方為場地所有非主辦單位 
</p>
";
            LocationDesc.Add(2, huaShaOutdoor);

            var songShanIndoor = new MarketLocationDescription();
            songShanIndoor.Description = @"
<div>
    <img src=""/images/location/02shonshan.jpg"" title=""松山文創園區"" />
</div>
<p>
地址: 台北市信義區光復南路133號 
</p>
<p>
特色: 做為一個國際型的文創聚落，從扶植原創的精神出發，鼓勵創新性與實驗性。從創業育成到建立品牌，從核心創作到商業運用，從產業進駐到資源連結，提供創作者群聚，實現從實驗創新、設計發想、測試製作到面對群眾與國際鏈結的歷程，松山文創園區成為台灣重要的創意樞紐，更是國際性的文創聚落，民眾可在此平台參與藝術與原創，體驗無限創意。 
</p>
<p>
※照片為示意圖，版權方為場地所有非主辦單位 
</p>
";
            LocationDesc.Add(3, songShanIndoor);

            var songShanOurdoor = new MarketLocationDescription();
            songShanOurdoor.Description = @"
<div>
    <img src=""/images/location/02shonshan.jpg"" title=""松山文創園區"" />
</div>
<p>
地址: 台北市信義區光復南路133號 
</p>
<p>
特色: 做為一個國際型的文創聚落，從扶植原創的精神出發，鼓勵創新性與實驗性。從創業育成到建立品牌，從核心創作到商業運用，從產業進駐到資源連結，提供創作者群聚，實現從實驗創新、設計發想、測試製作到面對群眾與國際鏈結的歷程，松山文創園區成為台灣重要的創意樞紐，更是國際性的文創聚落，民眾可在此平台參與藝術與原創，體驗無限創意。 
</p>
<p>
※照片為示意圖，版權方為場地所有非主辦單位 
</p>
";
            LocationDesc.Add(4, songShanOurdoor);

            var yuanShanExhibition = new MarketLocationDescription();
            yuanShanExhibition.Description = @"
<div>
    <img src=""/images/location/03yuanshan.jpg"" title=""圓山花博"" />
</div>
<p>
地址: 臺北市中山區玉門街1號 
</p>
<p>
特色: 位於台灣台北市中山區，捷運圓山站與美術公園之間，在2010年臺北國際花卉博覽會期間劃入展區，目前為花博公園的一部分，場地富有異國風情，廣場腹地大、草皮多，為北台北休閒重鎮。 
</p>
<p>
※照片為示意圖，版權方為場地所有非主辦單位 
</p>
";
            LocationDesc.Add(5, yuanShanExhibition);

            var bottleCapFactoryIndoor = new MarketLocationDescription();
            bottleCapFactoryIndoor.Description = @"
<div>
    <img src=""/images/location/04bottlecap.png"" title=""瓶蓋工廠"" />
</div>
<p>
地址: 台北市南港區南港路二段13號 
</p>
<p>
特色: 歷史建築內的創意中心，提供共享辦公室、在地新創園區及展覽空間。 
</p>
<p>
※照片為示意圖，版權方為場地所有非主辦單位 
</p>
";
            LocationDesc.Add(6, bottleCapFactoryIndoor);

            var bottleCapFactoryOutdoor = new MarketLocationDescription();
            bottleCapFactoryOutdoor.Description = @"
<div>
    <img src=""/images/location/04bottlecap.png"" title=""瓶蓋工廠"" />
</div>
<p>
地址: 台北市南港區南港路二段13號 
</p>
<p>
特色: 歷史建築內的創意中心，提供共享辦公室、在地新創園區及展覽空間。 
</p>
<p>
※照片為示意圖，版權方為場地所有非主辦單位 
</p>
";
            LocationDesc.Add(7, bottleCapFactoryOutdoor);

            var kishuAn = new MarketLocationDescription();
            kishuAn.Description = @"
<div>
    <img src=""/images/location/05kishuan.jpg"" title=""紀州庵文學森林"" />
</div>
<p>
地址: 台北市中正區同安街 107 號 
</p>
<p>
特色: 「紀州庵」初建於1917年，原為平松家族經營的日式料亭，因緊鄰新店溪畔，景色宜人，成為城南居民的生活重心。1950 年代，二戰後的紀州庵轉為公務人員眷舍，小說家王文興曾居於此，《家變》的部分場景便源於此地。1970 年代起，純文學、爾雅、洪範、遠流等出版社也不約而同的在城南建立。 
</p>
<p>
※照片為示意圖，版權方為場地所有非主辦單位 
</p>
";
            LocationDesc.Add(8, kishuAn);

        }
        private void InitScaleDescription()
        {
            ScaleDesc = new Dictionary<short, MarketScaleDescription>();
            var large = new MarketScaleDescription();
            large.Description = @"
<div>
    <img src=""/images/scale/01large.jpg"" />
</div>
<p>
這場市集是一場規模龐大、熱鬧非凡的盛會，超過100個攤位匯聚在一起，帶來了多元的體驗和無盡的驚喜。
漫步在市集中，你將穿梭於五光十色的攤位之間，感受著來自不同領域的創意和活力。
無論是手工藝品、美食饗宴、藝術表演，還是各種特色商品，這裡都是一個集合了多種文化、風格和味道的精彩世界。
無論你是探索者、美食家還是藝術愛好者，這場大型市集將成為一個無限可能的探索之地，讓你在每個攤位背後，都發現一個新奇的故事和驚艷的驚喜。 
</p>
";
            ScaleDesc.Add(1, large);
            
            var medium = new MarketScaleDescription();
            medium.Description = @"
<div>
    <img src=""/images/scale/02medium.jpg"" />
</div>
<p>
這場市集以中型規模展現了獨特的魅力，匯聚了30到100個多樣性的攤位。這個市集充滿了活力，你可以在其中尋找到各種類型的商品和體驗。
從手工藝品到美食、從文創設計到藝術表演，這個中型市集將為你帶來一場多元且充滿驚喜的探索之旅。
無論你是在尋找獨特的禮物，品味美味的美食，還是欣賞藝術的表現，這場市集都能夠滿足你的各種需求，帶來一個充滿活力和多彩的體驗。
</p>
";
            ScaleDesc.Add(2, medium);
            
            var small = new MarketScaleDescription();
            small.Description = @"
<div>
    <img src=""/images/scale/03small.jpg"" />
</div>
<p>
這場小型市集雖然攤位數量不多，卻充滿了溫馨和親密感。
在這個精心策劃的市集中，你可以輕鬆地漫步，一邊欣賞著手工藝品、文創商品，一邊品味著精緻的小吃和特色美食。
儘管規模較小，這場市集卻讓你更能深入感受每個攤位的特色和創意，彷彿是與創作者和商家進行一次親切的互動。
這個小型市集將為你帶來一份溫暖的社區氛圍和舒適的購物體驗，讓你在細微之處感受到愉悅和滿足。 
</p>
";
            ScaleDesc.Add(3, small);
        }
        private void InitTentDescription()
        {
            TentDesc = new Dictionary<short, TentDescription>();
            var regular = new TentDescription();
            regular.Description = @"
<div>
    <img src=""/images/tent/01regular.jpg"" />
</div>
<p>
此市集以一般帳篷為主要攤位呈現，防水度佳，市集中的一般帳篷為整個活動場地帶來了舒適和實用性。
這些帳篷被巧妙地佈置在攤位之間，為參與者提供了遮陽、遮雨和休息的地方。 
</p>
";
            TentDesc.Add(1, regular);

            var wood = new TentDescription();
            wood.Description = @"
<div>
    <img src=""/images/tent/02wood.jpg"" />
</div>
<p>
此市集以木架為主要攤位呈現，美觀且藝文感強烈市集中的藝文木架為整個場景注入了藝術的氛圍和風采。
這些木架被巧妙地設置在市集的特定區域，
用來展示各種文創作品、藝術品、手工藝品和繪畫作品。
木架可能具有不同的高度和尺寸，以展示不同種類和尺寸的作品。 
</p>
";
            TentDesc.Add(2, wood);

            var others = new TentDescription();
            others.Description = @"
<div>
    <img src=""/images/tent/03others.jpg"" />
</div>
<p>
此市集需另外討論攤位呈現，特色感強烈，無論你是藝術愛好者還是只是尋找獨特禮物的參與者，
這些特色布置都能夠讓你深入了解當地藝術家的才華和創意，並且在市集的氛圍中感受到藝術的力量和情感。
這些布置為市集增添了一份獨特的文化韻味，成為市集不可或缺的一部分 
</p>
";
            TentDesc.Add(3, others);
        }
        private void InitElectricityDescription()
        {
            ElectricityDesc = new Dictionary<short, ElectricityDescription>();
            var regular = new ElectricityDescription();
            regular.Description = @"
<p>
在這個市集中，電力供應是為每攤位提供了一般的電力資源。
每攤位都能夠獲得2A的電力供應，這足以支持攤位的燈光、音響和其他基本的電器設備運作。
這種供電方式確保了每個攤位都有足夠的能量來展示他們的商品、進行互動和提供服務，同時也確保市集整體的電力分配均衡和穩定。
這樣的電力配置使得每個攤位都能夠在營運中保持正常運作，讓參與者能夠在舒適的環境中欣賞、購物和互動。 
</p>
";
            ElectricityDesc.Add(1, regular);

            var heavy= new ElectricityDescription();
            heavy.Description = @"
<p>
這場市集為特定領域（餐飲或表演）的攤位提供了強大的供電支援，以應對更多的電器需求。每個擁有重型電力的攤位都能夠獲得更大的電力資源，以確保他們的活動和需求得以順利進行。 
</p>
<p>
對於餐飲攤位而言，這意味著他們可以運行更多的廚房設備，如電磁爐、烤箱、攪拌機等，以提供更多種類的美食。這種重型電力供應使得廚房操作更加順暢，可以在忙碌的環境中輕鬆應對烹飪需求，為參觀者帶來更多美味的選擇。 
</p>
<p>
對於表演攤位，這種電力供應則能夠支持更多的音響和燈光設備，以創造出更震撼的演出效果。樂隊、歌手、舞者和其他表演者可以更自由地運用技術，打造出引人入勝的演出現場，讓觀眾沉浸在音樂和表演的世界中。 
</p>
<p>
這樣的供電方式為特定領域的攤位提供了更多的彈性和能量，確保了他們能夠在市集中充分展現他們的才華和創意。同時，也為參與者帶來了更豐富的體驗，讓他們可以享受到更多種類的美食和表演，共同創造出一場難忘的活動。 
</p>
";
            ElectricityDesc.Add(2, heavy);
        }
        private void InitWaterFacilityDescription()
        {
            WaterFacilityDesc = new Dictionary<short, WaterFacilityDescription>();
            var withWater = new WaterFacilityDescription();
            withWater.Description = @"
<p>
此市集有供應洗滌用水，供各攤友使用 
</p>
";
            WaterFacilityDesc.Add(1, withWater);

            var withoutWater = new WaterFacilityDescription();
            withoutWater.Description = @"
<p>
此市集無供應洗滌用水，供各攤友使用 
</p>
";
            WaterFacilityDesc.Add(2, withoutWater);
        }
        private void InitCharingModeDescription()
        {
            CharingModeDesc = new Dictionary<short, CharingModeDescription>();
            var free = new CharingModeDescription();
            free.Description = @"
<p>
此市集無收取費用為攤友免費擺攤，可能提供車馬費。 
</p>
";
            CharingModeDesc.Add(1, free);

            var charged= new CharingModeDescription();
            charged.Description = @"
<p>
此市集收取費用為攤友付費擺攤，於活動開始前收取費用。 
</p>
";
            CharingModeDesc.Add(2, charged);
        }
        private void InitBudgetLevelDescription()
        {
            BudgetLevelDesc = new Dictionary<short, BudgetLevelDescription>();
            var lt30 = new BudgetLevelDescription();
            lt30.Description = @"
<p>
小於30萬 
</p>
";
            BudgetLevelDesc.Add(1, lt30);

            var gt31lt50 = new BudgetLevelDescription();
            gt31lt50.Description = @"
<p>
31~50萬 
</p>
";
            BudgetLevelDesc.Add(2, gt31lt50);

            var gt51lt80 = new BudgetLevelDescription();
            gt51lt80.Description = @"
<p>
51~80萬 
</p>
";
            BudgetLevelDesc.Add(3, gt51lt80);

            var gt81lt100 = new BudgetLevelDescription();
            gt81lt100.Description = @"
<p>
81~100萬 
</p>
";
            BudgetLevelDesc.Add(4, gt81lt100);

            var gt100 = new BudgetLevelDescription();
            gt100.Description = @"
<p>
>100萬。 
</p>
";
            BudgetLevelDesc.Add(5, gt100);


        }
    }

    public class MarketStyleDescription
    {
        public string MarketStyleTitle { get; set; }
        public string StyleImagePath { get; set; }
        public string MarketStyleGoal { get; set; }
        public string MarketStyleFactor { get; set; }
        public string MarketStyleFeature { get; set; }
    }
    public class MarketTypeDescription
    {
        public string Description { get; set; }
    }
    public class MarketLocationDescription
    {
        public string Description { get; set; }
    }
    public class MarketScaleDescription
    {
        public string Description { get; set; }
    }
    public class TentDescription
    {
        public string Description { get; set; }
    }

    public class ElectricityDescription
    {
        public string Description { get; set; }
    }
    public class WaterFacilityDescription
    {
        public string Description { get; set; }
    }
    public class CharingModeDescription
    {
        public string Description { get; set; }
    }
    public class BudgetLevelDescription
    {
        public string Description { get; set; }
    }
}
