using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Background_ProFinder.Models.ViewModel;
using Background_ProFinder.Service;
using System.Web;
using Background_ProFinder.Models.APIModel;
using Background_ProFinder.Service.Interfaces;

namespace Background_ProFinder.APIControllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]


    public class LoginApiController : ControllerBase
    {
        private readonly ILoginService _loginService;
        public LoginApiController(ILoginService LoginService)
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
        [HttpPut]
        public APIResult UpdateUserInfo(int AdminId, UpdateUserInfo VMdata)
        {
            bool result;
            try
            {
                result = _loginService.UpdateUserInfo(AdminId, VMdata);
                return new APIResult(APIStatus.Success, string.Empty, result);
            }
            catch (Exception ex)
            {
                result = false;
                return new APIResult(APIStatus.Fail, ex.Message, result);
            }


        }


        [HttpPut]
        public APIResult UpdateUserDeactivated(int adminId, int deactivatedNumber)
        {
            bool result;
            try
            {
                result = _loginService.UpdateUserDeactivated(adminId, deactivatedNumber);
                return new APIResult(APIStatus.Success, string.Empty, result);
            }
            catch (Exception ex)
            {
                result = false;
                return new APIResult(APIStatus.Fail, ex.Message, result);
            }
        }

       [HttpPut]
        public APIResult UpdatePassword(int adminId, string psw)
        {
            bool result;
            try
            {
                result = _loginService.UpdatePassword(adminId, psw);
                return new APIResult(APIStatus.Success, string.Empty, result);
            }
            catch (Exception ex)
            {
                result = false;
                return new APIResult(APIStatus.Fail, ex.Message, result);
            }
        }
    }
}
