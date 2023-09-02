using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using MongoDB.Driver;
using System.Security.Claims;
using xinchen_web.Enumerables;
using xinchen_web.Helpers;
using xinchen_web.Models;
using xinchen_web.Services;
using static System.Net.Mime.MediaTypeNames;
using static xinchen_web.Pages.DocumentsModel;

namespace xinchen_web.Pages
{
    public class DocumentsModel : PageModel
    {
        private readonly MongoSvc _mongoSvc;
        public List<SelectListItem> SelectProposalStatus { get; set; }
        public DocumentsModel(MongoSvc mongoSvc)
        {
            _mongoSvc = mongoSvc;
        }
        public void OnGet()
        {
            ClaimsPrincipal cp = HttpContext.User;
            if (cp.Identity.IsAuthenticated) //如果用户已经登录
            {
                //取出用户帐号信息
                //***注：如果我们登录时写入 Cookie 中的是 UserId 如: new Claim(ClaimTypes.Name, user.UserId), 
                //***那么这里取出来的将是 UserId , 即 Identity.Name 对应的是 ClaimTypes.Name 的值。 
                string userAcc = cp.Identity.Name;

                //取出登录时设置到 cookie 中的所有用户信息
                List<Claim> claims = cp.Claims.ToList<Claim>();
                //通过传入 Lambda 表达式找出登录时设置的 UserId 值
                string userId = claims.Single<Claim>(option => option.Type == "UserId").Value;
                var userProposal = _mongoSvc.Get<UserProposal>(Builders<UserProposal>.Filter.Eq(x => x.UserId, userId)).FirstOrDefault();
                var proposalList = new List<Proposal>();
                if(userProposal != null)
                {
                    foreach(var proposalId in userProposal.ProposalId)
                    {
                        var proposal = _mongoSvc.Get<Proposal>(Builders<Proposal>.Filter.Eq(x => x.Id, proposalId)).FirstOrDefault();
                        if (proposal != null) { proposalList.Add(proposal); }
                    }

                    if(proposalList.Count > 0)
                    {
                        ViewData["ProposalList"] = proposalList;
                    }

                    if (proposalList.Count == 10)
                    {
                        ViewData["AllowCreateNew"] = false;
                    }
                }


                SelectProposalStatus = new List<SelectListItem>();
                foreach (Enum item in Enum.GetValues(typeof(ProposalStatus)))
                {
                    SelectProposalStatus.Add(new SelectListItem() { Value = (Convert.ToInt32(item)).ToString(), Text = item.GetDescriptionText() });
                }
            }
        }

        public IActionResult OnPostSaveStatus([FromBody] StatusUpdate statusUpdate)
        {
            ClaimsPrincipal cp = HttpContext.User;
            if (!cp.Identity.IsAuthenticated)
                return new JsonResult(new ResponseMessage() { Code = "error", Message = "請重新登入" });
            else
            {
                var proposal = _mongoSvc.Get(Builders<Proposal>.Filter.Eq(x => x.Id, statusUpdate.ProposalId)).FirstOrDefault();
                if (proposal == null)
                {
                    return new JsonResult(new ResponseMessage() { Code = "error", Message = "企劃書發生錯誤，請重新登入" });
                }
                proposal.Status = Int16.Parse(statusUpdate.Status);
                _mongoSvc.ReplaceOne(Builders<Proposal>.Filter.Eq(x => x.Id, statusUpdate.ProposalId), proposal);

                return new JsonResult(new ResponseMessage() { Code = "success", Message = "" });
            }
        }

        public IActionResult OnDelete([FromQuery] string proposalId)
        {
            ClaimsPrincipal cp = HttpContext.User;
            if (!cp.Identity.IsAuthenticated)
                return new JsonResult(new ResponseMessage() { Code = "error", Message = "請重新登入" });
            else
            {
                var proposal = _mongoSvc.Get(Builders<Proposal>.Filter.Eq(x => x.Id, proposalId)).FirstOrDefault();
                if (proposal == null)
                {
                    return new JsonResult(new ResponseMessage() { Code = "error", Message = "企劃書發生錯誤，請重新登入" });
                }
                _mongoSvc.Remove(Builders<Proposal>.Filter.Eq(x => x.Id, proposalId));

                return new JsonResult(new ResponseMessage() { Code = "success", Message = "" });
            }
        }

        public class StatusUpdate
        {
            public string ProposalId { get; set; }
            public string Status { get; set; }
        }
    }
}
