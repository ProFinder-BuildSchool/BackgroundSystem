﻿using Background_ProFinder.Models.APIModel;
using Background_ProFinder.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;


namespace Background_ProFinder.APIControllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {

        private readonly IOrderService _orderService;
        public OrderController(IOrderService orderService)
        {
            _orderService = orderService;
        }
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
    }
}
