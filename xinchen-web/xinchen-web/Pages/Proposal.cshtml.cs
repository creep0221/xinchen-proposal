using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using xinchen_web.Models;

namespace xinchen_web.Pages
{
    public class ProposalModel : PageModel
    {
        public readonly MarketSetting _marketSetting;
        public List<SelectListItem> SelectLocation { get; set; }
        public List<SelectListItem> SelectTent { get; set; }

        public ProposalModel(MarketSetting marketSetting)
        {
            _marketSetting = marketSetting;
        }
        public void OnGet()
        {
            SelectLocation = new List<SelectListItem>();
            SelectLocation.Add(new SelectListItem { Value = "0", Text = "-- 請選擇 --" });
            foreach (var item in _marketSetting.MarketDetail)
            {
                SelectLocation.Add(new SelectListItem { Value = item.Id.ToString(), Text = item.Location });
            }

            SelectTent = new List<SelectListItem>();
            SelectTent.Add(new SelectListItem { Value = "0", Text = "-- 請選擇 --" });
            
        }

        public JsonResult OnGetTentByLocation(int locationId)
        {
            var tentByLocation = _marketSetting.MarketDetail.Where(x => x.Id == locationId).FirstOrDefault();
            if (tentByLocation != null)
            {
                var tentItems = new List<SelectListItem>();
                foreach (var tent in tentByLocation.Tent)
                {
                    tentItems.Add(new SelectListItem { Value = tent.Id.ToString(), Text = tent.Name });
                }
                return new JsonResult(tentItems);
            }
            return null;
            
            
        }
    }
}
