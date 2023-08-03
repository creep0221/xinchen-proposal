using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc.RazorPages;


namespace xinchen_web.Pages
{
    public class RegisterModel : PageModel
    {
        [BindProperty]
        public string Username { get; set; }

        [BindProperty]
        public string Password { get; set; }

        public IActionResult OnPost()
        {
            if (Username == "admin" && Password == "password")
            {
                // 验证通过，可以执行注册逻辑，例如保存用户信息到数据库
                return RedirectToPage("/Index");
            }
            else
            {
                // 验证失败，显示错误消息
                TempData["ErrorMessage"] = "Invalid username or password.";
                return RedirectToPage("/Register");
            }
            // 注册成功后，可以跳转到其他页面，例如登录页面。
            //return RedirectToPage("/Login");
        }
    }
}
