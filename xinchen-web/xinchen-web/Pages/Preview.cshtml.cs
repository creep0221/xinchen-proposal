using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MongoDB.Driver;
using System.Security.Claims;
using xinchen_web.Enumerables;
using xinchen_web.Models;
using xinchen_web.Services;

namespace xinchen_web.Pages
{
    public class PreviewModel : PageModel
    {
        private readonly MongoSvc _mongoSvc;
        private readonly MarketDescription _desc;
        private Proposal Proposal { get; set; }
        public string MarketStyleTitle { get; set; }
        public string StyleImagePath { get; set; }
        public string MarketStyleGoal { get; set; }
        public string MarketStyleFactor { get;set; }
        public string MarketStyleFeature { get; set; }

        public PreviewModel(MongoSvc mongoSvc, MarketDescription desc)
        {
            _mongoSvc = mongoSvc;
            _desc = desc;
        }
        public void OnGet(string Id, string tempId)
        {
            var style = _desc.StyleDescription[MarketStyle.AnimalForest];
            MarketStyleTitle= style.MarketStyleTitle;
            StyleImagePath = style.StyleImagePath;
            MarketStyleGoal =style.MarketStyleGoal;
            MarketStyleFactor= style.MarketStyleFactor;
            MarketStyleFeature= style.MarketStyleFeature;
            //ClaimsPrincipal cp = HttpContext.User;
            //if (!cp.Identity.IsAuthenticated)
            //    Response.Redirect("/Login");

            //List<Claim> claims = cp.Claims.ToList<Claim>();
            //string userId = claims.Single<Claim>(option => option.Type == "UserId").Value;
            //var user = _mongoSvc.Get(Builders<User>.Filter.Eq(x => x.Id, userId)).FirstOrDefault();

            //if (user == null)
            //    Response.Redirect("/Login");

            //if (!string.IsNullOrEmpty(Id))
            //{
            //    Proposal = _mongoSvc.Get<Proposal>(Builders<Proposal>.Filter.Eq(x => x.Id, Id)).FirstOrDefault();
            //}
            //else if(!string.IsNullOrEmpty(tempId))
            //{
            //    var tempProposal = _mongoSvc.Get(Builders<UserTempProposal>.Filter.Eq(x => x.Id, tempId)).FirstOrDefault();
            //    Proposal = tempProposal.Proposal;
            //}

            //if(Proposal == null)
            //{
            //    TempData["ErrorMessage"] = "企劃書不存在，請返回企劃書列表";
            //}
        }

        private void GetMarketStyleTitle(short marketStyle)
        {
            MarketStyle style = (MarketStyle)marketStyle;
            switch (style)
            {
                case MarketStyle.AnimalForest:
                    MarketStyleTitle = "動物森林手作市集";
                    MarketStyleGoal = "";
                    MarketStyleFactor = "";
                    MarketStyleFeature = "";
                    break;
                case MarketStyle.LuxuryParty:
                    MarketStyleTitle = "";
                    MarketStyleGoal = "";
                    MarketStyleFactor = "";
                    MarketStyleFeature = "";
                    break;
                case MarketStyle.ArtisticFresh:
                    MarketStyleTitle = "";
                    MarketStyleGoal = "";
                    MarketStyleFactor = "";
                    MarketStyleFeature = "";
                    break;
                case MarketStyle.CrossCulture:
                    MarketStyleTitle = "";
                    MarketStyleGoal = "";
                    MarketStyleFactor = "";
                    MarketStyleFeature = "";
                    break;
                case MarketStyle.Outdoor:
                    MarketStyleTitle = "";
                    MarketStyleGoal = "";
                    MarketStyleFactor = "";
                    MarketStyleFeature = "";
                    break;
                case MarketStyle.Taiwanese:
                    MarketStyleTitle = "";
                    MarketStyleGoal = "";
                    MarketStyleFactor = "";
                    MarketStyleFeature = "";
                    break;
                default:
                    MarketStyleTitle = "";
                    MarketStyleGoal = "";
                    MarketStyleFactor = "";
                    MarketStyleFeature = "";
                    break;
            }
        }
    }
}
