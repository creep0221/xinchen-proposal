using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MongoDB.Driver;
using System.Security.Claims;
using xinchen_web.Models;
using xinchen_web.Services;

namespace xinchen_web.Pages
{
    public class DocumentsModel : PageModel
    {
        private readonly MongoSvc _mongoSvc;
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

            }
        }

        public void OnPost()
        {
            Response.Redirect("/Proposal");
        }
    }
}
