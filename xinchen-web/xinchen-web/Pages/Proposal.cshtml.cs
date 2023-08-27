using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using MongoDB.Driver;
using System;
using System.Security.Claims;
using xinchen_web.Models;
using xinchen_web.Services;

namespace xinchen_web.Pages
{
    public class ProposalModel : PageModel
    {
        
        public readonly MarketSetting _marketSetting;
        private readonly MongoSvc _mongoSvc;

        private SelectListItem _defaultSelection;
        public List<SelectListItem> SelectLocation { get; set; }
        public List<SelectListItem> SelectMarketScale { get; set; }
        public List<SelectListItem> SelectTent { get; set; }
        public List<SelectListItem> SelectElectricity { get; set; }
        public List<SelectListItem> SelectWaterFacility { get; set; }
        public List<SelectListItem> SelectCharingMode { get; set; }
        public List<SelectListItem> SelectBudgetLevel { get; set; }
        public List<AddonService> Addons { get; set; }

        public ProposalModel(MarketSetting marketSetting, MongoSvc mongoSvc)
        {
            _marketSetting = marketSetting;
            _mongoSvc = mongoSvc;
            _defaultSelection = new SelectListItem { Value = "0", Text = "-- 請選擇 --" };
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
        
        public void OnPostSubmit()
        {
            var a = Request.Form["chk1"];
            var b = Request.Form["ddlLocation"];
        }

        public IActionResult OnPostSaveProposal([FromBody] Proposal proposal)
        {
            ClaimsPrincipal cp = HttpContext.User;
            if (!cp.Identity.IsAuthenticated)
                return new JsonResult("請重新登入");

            List<Claim> claims = cp.Claims.ToList<Claim>();
            string userId = claims.Single<Claim>(option => option.Type == "UserId").Value;
            var user = _mongoSvc.Get(Builders<User>.Filter.Eq(x => x.Id, userId)).FirstOrDefault();

            if (user == null)
                return new JsonResult("請重新登入");

            if (!IsProposalValid(proposal))
            {
                return new JsonResult("企劃書內容不正確");
            }
            else
            {
                _mongoSvc.Create(proposal);
                UserProposal userProposal = null;
                userProposal = _mongoSvc.Get<UserProposal>(Builders<UserProposal>.Filter.Eq(x => x.UserId, userId)).FirstOrDefault();
                if (userProposal == null)
                {
                    userProposal = new UserProposal()
                    {
                        UserId = userId,
                        ProposalId = new List<string>() { proposal.Id }
                    };
                    _mongoSvc.Create(userProposal);
                }
                else
                {
                    userProposal.ProposalId.Add(proposal.Id);
                    _mongoSvc.ReplaceOneAsync(Builders<UserProposal>.Filter.Eq(x => x.UserId, userId), userProposal);
                }
            }

            return Redirect("/Documents");
            
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

        private bool IsProposalValid(Proposal proposal)
        {
            if (proposal == null) { return false; }
            else if (proposal.MarketStyle == 0 ||
                proposal.MarketType == 0 ||
                proposal.Location == 0 ||
                proposal.MarketScale == 0 ||
                proposal.Tent == 0 ||
                proposal.Electricity == 0 ||
                proposal.WaterFacility == 0 ||
                proposal.CharingMode == 0 ||
                proposal.BudgetLevel == 0)
                return false;
            else return true;
        }
    }
}
