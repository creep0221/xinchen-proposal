using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MongoDB.Driver;
using System.Security.Claims;
using xinchen_web.Enumerables;
using xinchen_web.Helpers;
using xinchen_web.Models;
using xinchen_web.Services;
using static System.Formats.Asn1.AsnWriter;

namespace xinchen_web.Pages
{
    public class PreviewModel : PageModel
    {
        private readonly MongoSvc _mongoSvc;
        private readonly MarketDescription _desc;
        #region Properties
        private Proposal Proposal { get; set; }
        public string MarketStyleTitle { get; set; }
        public string StyleImagePath { get; set; }
        public string MarketStyleGoal { get; set; }
        public string MarketStyleFactor { get;set; }
        public string MarketStyleFeature { get; set; }
        public string MarketTypeDesc { get; set; }
        public string Location { get; set; }
        public string LocationDesc { get; set; }
        public string Scale { get; set; }
        public string ScaleDesc { get; set; }
        public string Tent { get; set; }
        public string TentDesc { get; set; }
        public string Electricity { get; set; }
        public string ElectricityDesc { get; set; }
        public string WaterFacility { get; set; }
        public string WaterFacilityDesc { get; set; }
        public string CharingMode { get; set; }
        public string CharingModeDesc { get; set; }
        public string BudgetLevel { get; set; }
        public string BudgetLevelDesc { get; set; }
        #endregion

        public PreviewModel(MongoSvc mongoSvc, MarketDescription desc)
        {
            _mongoSvc = mongoSvc;
            _desc = desc;
        }
        public void OnGet(string Id, string tempId)
        {
            ClaimsPrincipal cp = HttpContext.User;
            if (!cp.Identity.IsAuthenticated)
                Response.Redirect("/Login");

            List<Claim> claims = cp.Claims.ToList<Claim>();
            string userId = claims.Single<Claim>(option => option.Type == "UserId").Value;
            var user = _mongoSvc.Get(Builders<User>.Filter.Eq(x => x.Id, userId)).FirstOrDefault();

            if (user == null)
                Response.Redirect("/Login");

            if (!string.IsNullOrEmpty(Id))
            {
                Proposal = _mongoSvc.Get<Proposal>(Builders<Proposal>.Filter.Eq(x => x.Id, Id)).FirstOrDefault();
            }
            else if (!string.IsNullOrEmpty(tempId))
            {
                var tempProposal = _mongoSvc.Get(Builders<UserTempProposal>.Filter.Eq(x => x.Id, tempId)).FirstOrDefault();
                Proposal = tempProposal.Proposal;
            }

            if (Proposal == null)
            {
                TempData["ErrorMessage"] = "企劃書不存在，請返回企劃書列表";
            }
            else
            {
                var style = _desc.StyleDesc[Proposal.MarketStyle];
                MarketStyleTitle = style.MarketStyleTitle;
                StyleImagePath = style.StyleImagePath;
                MarketStyleGoal = style.MarketStyleGoal;
                MarketStyleFactor = style.MarketStyleFactor;
                MarketStyleFeature = style.MarketStyleFeature;
                
                MarketTypeDesc = _desc.TypeDesc[Proposal.MarketType].Description;
                
                Location = ((MarketLocation)Proposal.Location).GetDescriptionText();
                LocationDesc = _desc.LocationDesc[Proposal.Location].Description;
                
                Scale = ((Enumerables.MarketScale)Proposal.MarketScale).GetDescriptionText();
                ScaleDesc = _desc.ScaleDesc[Proposal.MarketScale].Description;

                Tent = ((Enumerables.Tent)Proposal.Tent).GetDescriptionText();
                TentDesc = _desc.TentDesc[Proposal.Tent].Description;

                Electricity = ((Enumerables.Electricity)Proposal.Electricity).GetDescriptionText();
                ElectricityDesc = _desc.ElectricityDesc[Proposal.Electricity].Description;

                WaterFacility = ((Enumerables.WaterFacility)Proposal.WaterFacility).GetDescriptionText();
                WaterFacilityDesc = _desc.WaterFacilityDesc[Proposal.WaterFacility].Description;
                
                CharingMode = ((Enumerables.CharingMode)Proposal.CharingMode).GetDescriptionText();
                CharingModeDesc = _desc.CharingModeDesc[Proposal.CharingMode].Description;

                BudgetLevel = ((Enumerables.BudgetLevel)Proposal.BudgetLevel).GetDescriptionText();
                BudgetLevelDesc = _desc.BudgetLevelDesc[Proposal.BudgetLevel].Description;
            }
        }

    }
}
