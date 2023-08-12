using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MongoDB.Driver;
using System.Security.Claims;
using System.Security.Principal;
using System.Text.RegularExpressions;
using xinchen_web.Helpers;
using xinchen_web.Models;
using xinchen_web.Services;
using static MongoDB.Driver.WriteConcern;

namespace xinchen_web.Pages
{
    public class LoginModel : PageModel
    {
        private readonly MongoSvc _mongoSvc;
        public LoginModel(MongoSvc mongoSvc)
        {
            _mongoSvc = mongoSvc;
        }
        [BindProperty]
        public string Username { get; set; }

        [BindProperty]
        public string Password { get; set; }
        public void OnGet()
        {
        }

        public async Task OnPost(string submitbutton)
        {
            var errorMsg = string.Empty;
            var upperUserName = Username.ToUpper();
            string rememberMe = Request.Form["rememberMe"];//如果勾选=1，否则=null
            bool isRemember = rememberMe == "1" ? true : false;
            
            await HttpContext.SignOutAsync();
            
            if (!TryValidateInput(out errorMsg))
            {
                TempData["ErrorMessage"] = errorMsg + "請重新輸入";
                return;
            }

            var user = _mongoSvc.Get<User>(Builders<User>.Filter.Eq(x => x.UpperAccount, upperUserName)).FirstOrDefault();
            var hashedPassword = MD5Helper.CalculateHash(Password);
            if (submitbutton == "login")
            {
                if (user != null && hashedPassword == user.Password)
                {
                    //login successful
                    await CreateAuthentication(user.Account, user.Id, isRemember);
                    Response.Redirect("/Documents");
                }
                else
                {
                    TempData["ErrorMessage"] += "帳號密碼錯誤" + Environment.NewLine;
                    return;
                }
            }
            else if (submitbutton == "register")
            {
                if (user != null)
                {
                    TempData["ErrorMessage"] += "帳號已存在" + Environment.NewLine;
                }
                else
                {
                    HttpContext.Session.SetString("account", Username);
                    HttpContext.Session.SetString("password", hashedPassword);
                    HttpContext.Session.SetInt32("isRemember", isRemember ? 1 : 0);
                    Response.Redirect("/Register");
                }
            }
        }

        private bool TryValidateInput(out string errorMsg)
        {
            var valid = true;
            errorMsg = string.Empty;
            string userNamePattern = "^[a-zA-Z0-9]*$";
            string passwordPattern = @"^[A-Za-z0-9.!@#$%^&*()_+=\-[\]{};:'""<>?,/|\\]+$";

            // 使用 Regex.Match 方法來進行驗證
            //Match match = Regex.Match(input, pattern);
            if (Username.Length < 5 || !Regex.IsMatch(Username, userNamePattern))
            {
                valid = false;
                errorMsg += "帳號錯誤" + Environment.NewLine;
            }

            if (Password.Length < 8 ||
                Password.IndexOf(' ') > 0 ||
                !Regex.IsMatch(Password, passwordPattern))
            {
                valid = false;
                errorMsg += "不符規則的密碼" + Environment.NewLine;
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
