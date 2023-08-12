using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using System.Security.Claims;

namespace xinchen_web.Helpers
{
    public class AuthenticateHelper
    {
        public static ClaimsIdentity CreateClaims(string username, string userID, bool isRemember)
        {
            List<Claim> claims = new List<Claim>
                    {
                        //特别注意这一行，如果不设置那么 HttpContext.User.Identity.Name 将为 null 
                        new Claim(ClaimTypes.Name, username),
                        new Claim("UserId", userID)
                    };
            ClaimsIdentity claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);

            return claimsIdentity;
        }
    }
}
