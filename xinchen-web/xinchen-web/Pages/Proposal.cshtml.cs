using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using xinchen_web.Models;

namespace xinchen_web.Pages
{
    public class ProposalModel : PageModel
    {
        
        public readonly MarketSetting _marketSetting;
        private SelectListItem _defaultSelection;
        public List<SelectListItem> SelectLocation { get; set; }
        public List<SelectListItem> SelectMarketScale { get; set; }
        public List<SelectListItem> SelectTent { get; set; }
        public List<SelectListItem> SelectElectricity { get; set; }
        public List<SelectListItem> SelectWaterFacility { get; set; }
        public List<SelectListItem> SelectCharingMode { get; set; }
        public List<SelectListItem> SelectBudgetLevel { get; set; }
        public List<AddonService> Addons { get; set; }

        public ProposalModel(MarketSetting marketSetting)
        {
            _marketSetting = marketSetting;
            _defaultSelection = new SelectListItem { Value = "0", Text = "-- ½Ð¿ï¾Ü --" };
        }
        public void OnGet()
        {
            SelectLocation = new List<SelectListItem>();
            SelectLocation.Add(_defaultSelection);
            foreach (var item in _marketSetting.MarketDetail)
            {
                SelectLocation.Add(new SelectListItem { Value = item.Id.ToString(), Text = item.Location });
            }

            SelectMarketScale = new List<SelectListItem>();
            SelectMarketScale.Add(_defaultSelection);
            SelectTent = new List<SelectListItem>();
            SelectTent.Add(_defaultSelection);
            SelectElectricity = new List<SelectListItem>();
            SelectElectricity.Add(_defaultSelection);
            SelectWaterFacility = new List<SelectListItem>();
            SelectWaterFacility.Add(_defaultSelection);
            SelectCharingMode = new List<SelectListItem>();
            SelectCharingMode.Add(_defaultSelection);
            SelectBudgetLevel = new List<SelectListItem>();
            SelectBudgetLevel.Add(_defaultSelection);

            Addons = _marketSetting.AddonService.ToList();
            
        }
        
        public void OnPost()
        {

        }

        public JsonResult OnGetSubItems(int locationId)
        {
            var itemsByLocation = _marketSetting.MarketDetail.Where(x => x.Id == locationId).FirstOrDefault();
            if (itemsByLocation != null)
            {
                return new JsonResult(
                    new
                    {
                        defaultSelection = _defaultSelection,
                        marketScale = itemsByLocation.MarketScale,
                        tent = itemsByLocation.Tent,
                        electricity = itemsByLocation.Electricity,
                        waterFacility = itemsByLocation.WaterFacility,
                        charingMode = itemsByLocation.CharingMode,
                        budgetLevel = itemsByLocation.BudgetLevel
                    });
            }
            return null;

        }
    }
}
