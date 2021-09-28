using Background_ProFinder.Models.APIModel;
using Background_ProFinder.Service;
using Background_ProFinder.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;


namespace Background_ProFinder.APIControllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DashboardController : ControllerBase
    {

        private readonly DashBoardService _dashboardService;
        public DashboardController(DashBoardService dashboardService)
        {
            _dashboardService = dashboardService;
        }
        [HttpGet]
        public APIResult GetAllDashboards()
        {
            string result = "";
            try
            {

                result = _dashboardService.GetAllDashboard();
                return new APIResult(APIStatus.Success, string.Empty, result);
            }
            catch (Exception ex)
            {
                return new APIResult(APIStatus.Fail, ex.Message, result);
            }
        }

   
    }
}
