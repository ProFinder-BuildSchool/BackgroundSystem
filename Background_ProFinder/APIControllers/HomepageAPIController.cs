using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Background_ProFinder.Models.DBModel;
using Background_ProFinder.Models.ViewModel;
using Background_ProFinder.Service;
using Background_ProFinder.Service.Interfaces;

namespace Background_ProFinder.APIControllers
{

    [Route("api/[controller]/[action]")]
    [ApiController]
    public class HomepageAPIController : ControllerBase
    {

        public readonly IHomePageService _homePageService;

        public HomepageAPIController(IHomePageService homePageService)
        {
            _homePageService = homePageService;
        }

        [HttpPut]
        public APIResult AddBannerData(BannerViewModel data)
        {
            try
            {
                _homePageService.AddBannerData(data);
                return new APIResult(APIStatus.Success, string.Empty, "儲存成功");
            }
            catch (Exception ex)
            {
                return new APIResult(APIStatus.Fail, ex.Message, "儲存失敗");
            }
        }




        [HttpPut]
        public APIResult AddFeatureWorkMomo(WorkViewModel FeatureWorkList)
        {
            try
            {

                _homePageService.AddFeatureWorkMomo(FeatureWorkList);

                return new APIResult(APIStatus.Success, string.Empty, "儲存成功");
            }
            catch (Exception ex)
            {
                return new APIResult(APIStatus.Fail, ex.Message, "儲存失敗");
            }
        }








        [HttpPut]
        public APIResult SetFeatureWorkList(WorkViewModel FeatureWorkList)
        {
            try
            {
                _homePageService.SetFeatureWorkList(FeatureWorkList);


                return new APIResult(APIStatus.Success, string.Empty, "儲存成功");
            }
            catch (Exception ex)
            {
                return new APIResult(APIStatus.Fail, ex.Message, "儲存失敗");
            }
        }

        [HttpGet]
        public APIResult GetBannerData()
        {
            try
            {
                return new APIResult(APIStatus.Success, string.Empty, _homePageService.GetBannerData());
            }
            catch (Exception ex)
            {
                return new APIResult(APIStatus.Fail, ex.Message, "儲存失敗");
            }
        }


        [HttpGet]
        public APIResult GetWorkList()
        {
            try
            {



                return new APIResult(APIStatus.Success, string.Empty, _homePageService.GetWorkList());
            }
            catch (Exception ex)
            {
                return new APIResult(APIStatus.Fail, ex.Message, "儲存失敗");
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
