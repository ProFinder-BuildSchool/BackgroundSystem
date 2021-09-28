using Background_ProFinder.Models.APIModel;
using Background_ProFinder.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;

namespace Background_ProFinder.APIControllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MemberController : Controller
    {
        private readonly IMemService _memService;
        public MemberController(IMemService memService)
        {
            _memService = memService;
        }
        [HttpGet]
        public APIResult GetMemList()
        {
            string result = "";
            try
            {
                result = _memService.GetAllMems();
                return new APIResult(APIStatus.Success, string.Empty, result);
            }
            catch (Exception ex)
            {
                return new APIResult(APIStatus.Fail, ex.Message, result);
            }
        }
    }
}
