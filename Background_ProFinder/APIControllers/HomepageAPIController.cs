using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Background_ProFinder.Models.DBModel;
using Background_ProFinder.Models.ViewModel;

namespace Background_ProFinder.APIControllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomepageAPIController : ControllerBase
    {

        public readonly ThirdGroupContext _ctx;

        public HomepageAPIController(ThirdGroupContext ctx)
        {
            _ctx = ctx;
        }

        [HttpPut("api/[controller]/AddBannerData", Name = "AddBannerData")]
        public APIResult AddBannerData(BannerViewModel data)
        {
            try
            {

                _ctx.Banners.FirstOrDefault(x => x.BannerId == data.BannerId).BannerImgUrl = data.BannerImgUrl;
                _ctx.Banners.FirstOrDefault(x => x.BannerId == data.BannerId).BannerTitle = data.BannerTitle;
                _ctx.SaveChanges();

                return new APIResult(APIStatus.Success, string.Empty, "儲存成功");
            }
            catch (Exception ex)
            {
                return new APIResult(APIStatus.Fail, ex.Message, "儲存失敗");
            }
        }


        [HttpGet("api/[controller]/GetBannerData", Name = "GetBannerData")]
        public APIResult GetBannerData()
        {
            try
            {
                var result = (from b in _ctx.Banners select b).Select(x => new BannerViewModel
                {
                    BannerTitle = x.BannerTitle,
                    BannerImgUrl = x.BannerImgUrl

                }).ToList();


                return new APIResult(APIStatus.Success, string.Empty, result);
            }
            catch (Exception ex)
            {
                return new APIResult(APIStatus.Fail, ex.Message, "儲存失敗");
            }
        }


        [HttpGet("{apiname}", Name = "GetWorkList")]
        public APIResult GetWorkList()
        {
            try
            {
                var result = (from W in _ctx.Works
                              join S in _ctx.SubCategories on W.SubCategoryId equals S.SubCategoryId
                              join workpic in _ctx.WorkPictures on W.WorkId equals workpic.WorkId
                              
                              select new
                              {
                                  WorkID = W.WorkId,
                                  Picture = workpic.WorkPicture1,
                                  SubCategoryName = S.SubCategoryName,
                                  studio = W.Client,
                                  MemberID = W.MemberId
                              }).ToList()
                              .GroupBy(x =>x.WorkID)
                              .Select(x=> new WorkViewModel
                              {
                                  WorkID = x.First().WorkID,
                                  WorkPicture = x.Select(p => p.Picture).ToList(),
                                  SubCategoryName = x.First().SubCategoryName,
                                  studio = x.First().studio,
                                  MemberID = (int)x.First().MemberID
                              }).Where(x=>x.WorkPicture.Count()>=3).OrderBy(x => x.WorkID).ToList();







                return new APIResult(APIStatus.Success, string.Empty, result);
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
