using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Security.Claims;
using System.Text.RegularExpressions;
using xinchen_web.Helpers;
using xinchen_web.Models;
using xinchen_web.Services;

namespace xinchen_web.Pages
{
    public class RegisterModel : PageModel
    {
        private readonly MongoSvc _mongoSvc;
        public RegisterModel(MongoSvc mongoSvc)
        {
            _mongoSvc = mongoSvc;
        }

        [BindProperty]
        public string Fullname { get; set; }

        [BindProperty]
        public string PhoneNumber { get; set; }
        
        [BindProperty]
        public string Email { get; set; }
        public void OnGet()
        {
        }

        public async Task OnPost()
        {
            var errorMsg = string.Empty;
            if (!TryValidateInput(out errorMsg))
            {
                TempData["ErrorMessage"] = errorMsg + "請重新輸入";
                return;
            }

            var account = HttpContext.Session.GetString("account");
            var password = HttpContext.Session.GetString("password");
            var user = new User()
            {
                Account = account,
                Email = Email,
                Password = password,
                FullName = Fullname,
                PhoneNumber = PhoneNumber,
                UpperAccount = account.ToUpper()
            };
            var savedUser = await _mongoSvc.Create(user);
            var isRemember = HttpContext.Session.GetInt32("isRemember").HasValue ?
                                (HttpContext.Session.GetInt32("isRemember").Value == 1 ? true : false) : false;
            await CreateAuthentication(account, savedUser.Id, isRemember);
            

            Response.Redirect("/Documents");
        }

        private bool TryValidateInput(out string errorMsg)
        {
            var valid = true;
            errorMsg = string.Empty;
            string phonenumberPattern = @"^[0-9]{8,}$";
            string mailPattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";

            // 使用 Regex.Match 方法來進行驗證
            if (PhoneNumber.Length < 7 || !Regex.IsMatch(PhoneNumber, phonenumberPattern))
            {
                valid = false;
                errorMsg += "電話錯誤" + Environment.NewLine;
            }
            if (!Regex.IsMatch(Email, mailPattern))
            {
                valid = false;
                errorMsg += "Email錯誤" + Environment.NewLine;
            }


            return valid;
        }

        private async Task CreateAuthentication(string username, string userID, bool isRemember)
        {
            ClaimsIdentity claimsIdentity = AuthenticateHelper.CreateClaims(username, userID, isRemember);

            //第3步，设置 cookie 属性，比如过期时间，是否持久化等
            string returnUrl = Request.Query["ReturnUrl"];
            AuthenticationProperties authProperties = new AuthenticationProperties
            {
                IsPersistent = isRemember,//是否持久化
                                          //如果用户点“登录“进来，登录成功后跳转到首页，否则跳转到上一个页面
                RedirectUri = string.IsNullOrWhiteSpace(returnUrl) ? "/Login" : returnUrl,
                ExpiresUtc = DateTime.UtcNow.AddMonths(1) //设置 cookie 过期时间：一个月后过期
            };

            //第4步，调用 HttpContext.SignInAsync() 方法生成一个加密的 cookie 并输出到浏览器。
            await HttpContext.SignInAsync(
                    CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(claimsIdentity), authProperties
            );
        }
    }
}
