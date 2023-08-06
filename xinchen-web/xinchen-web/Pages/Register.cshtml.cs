using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MongoDB.Driver;
using System.Security.Cryptography;
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
        public string Username { get; set; }

        [BindProperty]
        public string Password { get; set; }

        public IActionResult OnPost()
        {
            var valid = true;
            var errorMsg = string.Empty;
            string userNamePattern = "^[a-zA-Z0-9]*$";
            string passwordPattern = @"^(?=.*[a-zA-Z])(?=.*\d)(?=.*[@#$%^&+=!_-]).*$";

            // 使用 Regex.Match 方法來進行驗證
            //Match match = Regex.Match(input, pattern);
            if (Username.Length < 5 || !Regex.IsMatch(Username, userNamePattern))
            {
                valid = false;
                errorMsg += "不正確的帳號名稱" + Environment.NewLine;
            }

            if (Password.Length < 8 || !Regex.IsMatch(Password, passwordPattern))
            {
                valid = false;
                errorMsg += "不符規則的密碼" + Environment.NewLine;
            }

            var username = Username;
            if (_mongoSvc.Get<User>(Builders<User>.Filter.Eq(x => x.Account, username)).Any())
            {
                valid = false;
                errorMsg += "帳號已存在" + Environment.NewLine;
            }
            if (!valid)
            {
                TempData["ErrorMessage"] = errorMsg + "請重新輸入";
                return RedirectToPage("/Register");
            }
            else
            {
                _mongoSvc.Create<User>(new Models.User() { Account = Username, Password = MD5Helper.CalculateHash(Password) });
                return RedirectToPage("/Login?from=Register");
            }
        }
    }
}
