using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Background_ProFinder.Models.ViewModel;
using Background_ProFinder.Service;
using System.Web;

namespace Background_ProFinder.APIControllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]


    public class LoginApiController : ControllerBase
    {
        private readonly LoginService _loginService;
        public LoginApiController(LoginService LoginService)
        {
            _loginService = LoginService;
        }

        [HttpGet]
        //[HttpGet("{apiname}", Name = "GetUserAccountData")]
        public APIResult GetUserAccountData()
        {
            try
            {
               var result = _loginService.GetUserAccountData();
                return new APIResult(APIStatus.Success, string.Empty, result);
            }
            catch (Exception ex)
            {
                return new APIResult(APIStatus.Fail, ex.Message, "");
            }
        }

        [HttpPost]
        public APIResult AddUser(LoginViewModel UserData)
        {
            bool result;
            try
            {
                result = _loginService.AddUser(UserData);
                return new APIResult(APIStatus.Success, string.Empty, result);
            }
            catch (Exception ex)
            {
                result = false;
                return new APIResult(APIStatus.Fail, ex.Message, result);
            }

            
        }

        public class APIResult
        {
            public APIResult(int status, string errMsg, object result)
            {
                Status = status;
                ErrMsg = errMsg;
                Result = result;
            }
            public int Status { get; set; }
            public string ErrMsg { get; set; }
            public object Result { get; set; }

        }

        public static class APIStatus
        {
            public const int Success = 0;
            public const int Fail = 1;
            public const int DataBaseBreak = 101;

        }

    }
}
