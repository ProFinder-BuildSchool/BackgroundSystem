using Background_ProFinder.Models.APIModel;
using Background_ProFinder.Service.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;


namespace Background_ProFinder.APIControllers
{
    [Route("api/[controller]")]
    [ApiController]
    //[Authorize]
    public class OrderController : ControllerBase
    {

        private readonly IOrderService _orderService;

        public OrderController(IOrderService orderService)
        {
            _orderService = orderService;
        }
        /// <summary>
        /// 取得所有訂單資訊
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public APIResult GetAllOrders()
        {
            string result = "";
            try
            {

                result = _orderService.GetAllOrders();
                return new APIResult(APIStatus.Success, string.Empty, result);
            }
            catch (Exception ex)
            {
                return new APIResult(APIStatus.Fail, ex.Message, result);
            }
        }

        /// <summary>
        /// 接收訂單ID，訂單status改爲【已撥款】，並撥款至接案者帳戶
        /// </summary>
        /// <param name="id">訂單ID</param>
        /// <returns></returns>
        //[HttpPut("GiveMoney/{id}")]
        [HttpPut("{id}")]
        public APIResult GiveMoney(int id)
        {

            bool result = false;
            try
            {
                
                result = _orderService.ChangeOrderStatus(id);
                return new APIResult(APIStatus.Fail, "", result);
            }
            catch (Exception ex)
            {

                return new APIResult(APIStatus.Fail, ex.Message, result);
            }

        }
        [HttpGet("Dapper")]
        public APIResult DapperGetAllOrder()
        {
            string result = "";
            try
            {

                result = JsonConvert.SerializeObject(_orderService.DapperGetAllOrders());
                return new APIResult(APIStatus.Fail, "", result);
            }
            catch (Exception ex)
            {

                return new APIResult(APIStatus.Fail, ex.Message, result);
            }
        }
    }
}
