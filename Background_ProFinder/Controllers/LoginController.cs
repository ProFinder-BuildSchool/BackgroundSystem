using Background_ProFinder.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Background_ProFinder.Models.ViewModel;
using Background_ProFinder.Service;
using Background_ProFinder.Models.DBModel;

namespace Background_ProFinder.Controllers
{
    public class LoginController : Controller
    {
        private readonly LoginService _loginService;
        public LoginController(LoginService LoginService)
        {
            _loginService = LoginService;
        }
        public IActionResult Index()
        {
            return View();
        }


        public IActionResult Login()
        {
            return View();

        }

        public async Task<IActionResult> Logout()
        {
            //清除cookie
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);

            //return View();
            //return RedirectToPage("/Login/Login");   // 登出，跳去另一頁。
            return RedirectToAction("Login", "Login");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]

        public ActionResult Login(LoginViewModel LoginData)
        {
            if (ModelState.IsValid)
            {
                var result = _loginService.CompareUserData(LoginData);
                var accountstatus = _loginService.IsAccountDeactivated(LoginData);
                if (!accountstatus)
                {
                    ViewData["ErrorMessage"] = "此帳號已停用";
                    return View();
                }

                if (result == null)
                {
                    ViewData["ErrorMessage"] = "帳號與密碼有錯";
                    return View();
                }

                else
                {
                    #region ***** 不使用ASP.NET Core Identity的 cookie 驗證 *****

                    //創建cookie 保存用户訊息，使用claim將用户訊息序列化並儲存在cookie中
                    var claims = new List<Claim>
                    {
                        new Claim(ClaimTypes.Name,result.Name),

                        new Claim(ClaimTypes.Role,result.Authority.ToString()), //如果要有「群組、角色、權限」，可以加入這一段 

                        new Claim("AdminId",result.AdminId.ToString())
                    };

                    // 底下的 ** 登入 Login ** 需要下面兩個參數 (1) claimsIdentity  (2) authProperties

                    //創建聲明主题，指定認證方式，這裡使用cookie
                    var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);

                    //配置認證属性 比如過期時間，是否持續存在...等
                    var authProperties = new AuthenticationProperties
                    {
                        //AllowRefresh = <bool>,
                        // Refreshing the authentication session should be allowed.


                        // 從現在算起，Cookie何時過期
                        ExpiresUtc = DateTimeOffset.UtcNow.AddMinutes(40),   
                        // The time at which the authentication ticket expires. A 
                        // value set here overrides the ExpireTimeSpan option of 
                        // CookieAuthenticationOptions set with AddCookie.

                        //是否持續存在，EX:登入的時候，勾選記住我
                        IsPersistent = true,
                        // Whether the authentication session is persisted across 
                        // multiple requests. When used with cookies, controls
                        // whether the cookie's lifetime is absolute (matching the
                        // lifetime of the authentication ticket) or session-based.

                        //發身分驗證的時間
                        //IssuedUtc = <DateTimeOffset>,
                        // The time at which the authentication ticket was issued.

                        //RedirectUri = <string>
                        // The full path or absolute URI to be used as an http 
                        // redirect response value.
                    };

                    //登入
                    HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(claimsIdentity), authProperties);
                    #endregion
                }

            }

            return RedirectToAction("Index", "Home");
        }

        [Authorize]
        public IActionResult ResetPassword()
        {
            ClaimsPrincipal principal = HttpContext.User;
            if(null != principal)
            {
                foreach(Claim claim in principal.Claims)
                {
                    if(claim.Type == "AdminId")
                    {
                        ViewData["AdminId"] = claim.Value;
                    }
                    if (claim.Type == ClaimTypes.Role)
                    {
                        ViewData["Role"] = claim.Value;
                    }
                }
            }
            return View();

        }

        //[Authorize(Roles = "0")]
        //public IActionResult Index3()
        //{
        //    return View();    // 登入成功（會員）才可以看見
        //}
    }
}
