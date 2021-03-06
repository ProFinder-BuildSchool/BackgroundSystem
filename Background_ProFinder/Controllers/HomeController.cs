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
using Background_ProFinder.Models.DBModel;
using Background_ProFinder.Models.ViewModel;
using Background_ProFinder.Repositories;
using Background_ProFinder.Service;

namespace Background_ProFinder.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ThirdGroupContext _ctx;
     

        public HomeController(ILogger<HomeController> logger,ThirdGroupContext context)
        {
            _logger = logger;
            _ctx = context;
        }

        [Authorize]
        public IActionResult Index()
        {
            ClaimsPrincipal principal = HttpContext.User;
            if (null != principal)
            {
                foreach (Claim claim in principal.Claims)
                {
                    if (claim.Type == ClaimTypes.Role)
                    {
                        ViewData["Role"] = claim.Value;
                    }
                }
            }
            return View();
        }

        public IActionResult Privacy()
        {

            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        public IActionResult Button()
        {
            return View();
        }

        [Authorize]
        public IActionResult HomePage()
        {
            ClaimsPrincipal principal = HttpContext.User;
            if (null != principal)
            {
                foreach (Claim claim in principal.Claims)
                {
                    if (claim.Type == ClaimTypes.Role)
                    {
                        ViewData["Role"] = claim.Value;
                    }
                }
            }
            return View();
        }

        [Authorize]
        public IActionResult AdminiAccountManagement()
        {
            ClaimsPrincipal principal = HttpContext.User;
            if (null != principal)
            {
                foreach (Claim claim in principal.Claims)
                {
                    if (claim.Type == ClaimTypes.Role)
                    {
                        ViewData["Role"] = claim.Value;
                    }
                }
            }
            return View();
        }

        [Authorize]
        public IActionResult OrderManagement()
        {
            ClaimsPrincipal principal = HttpContext.User;
            if (null != principal)
            {
                foreach (Claim claim in principal.Claims)
                {
                    if (claim.Type == ClaimTypes.Role)
                    {
                        ViewData["Role"] = claim.Value;
                    }
                }
            }
            return View();
        }

        [Authorize]
        public IActionResult MemManagement()
        {
            ClaimsPrincipal principal = HttpContext.User;
            if (null != principal)
            {
                foreach (Claim claim in principal.Claims)
                {
                    if (claim.Type == ClaimTypes.Role)
                    {
                        ViewData["Role"] = claim.Value;
                    }
                }
            }
            return View();
        }

        [Authorize]
        public IActionResult Dashboard()
        {
            ClaimsPrincipal principal = HttpContext.User;
            if (null != principal)
            {
                foreach (Claim claim in principal.Claims)
                {
                    if (claim.Type == ClaimTypes.Role)
                    {
                        ViewData["Role"] = claim.Value;
                    }
                }
            }
            return View();
        }
     
    }
}
