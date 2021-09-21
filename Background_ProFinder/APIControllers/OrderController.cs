using Background_ProFinder.Models.APIModel;
using Background_ProFinder.Models.DBModel;
using Background_ProFinder.Models.ViewModel;
using Background_ProFinder.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace Background_ProFinder.APIControllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly IGeneralRepository<Order> _orderRepo;
        private readonly IGeneralRepository<Quotation> _quotationRepo;
        private readonly IGeneralRepository<MemberInfo> _memberInfoRepo;
        private readonly ThirdGroupContext _context;
        public OrderController(IGeneralRepository<Order> orderRepo, IGeneralRepository<Quotation> quotationRepo, IGeneralRepository<MemberInfo> memberInfo, ThirdGroupContext context)
        {
            _orderRepo = orderRepo;
            _quotationRepo = quotationRepo;
            _memberInfoRepo = memberInfo;
            _context = context;
        }
        [HttpGet]
        public APIResult GetAllOrders()
        {
            string result = "";
            try
            {
                var allOrders = _orderRepo.GetAll().ToList();
                List < OrderManagementViewModel > orderDetails = new List<OrderManagementViewModel>();
                foreach (var o in allOrders)
                {
                    //Quotation可能null資料 - PredictDays
                    var quotation = o.QuotationId != null ? _quotationRepo.GetAll().FirstOrDefault(x => x.QuotationId == o.QuotationId) : null;
                    int predictDays = quotation != null ? quotation.ExecuteDate : o.PredictDays != null ? (int)o.PredictDays : 0;
                    
                    //Proposer可能null資料 - ProposerPhone, BankCode, BankAccount, Balance
                    var proposer = _memberInfoRepo.GetAll().FirstOrDefault(x => x.MemberId == o.ProposerId);
                    var proposerPhone = proposer.Cellphone != null ? proposer.Cellphone : "無接案電話";
                    var bankCode = proposer.BankCode != null ? proposer.BankCode : "無銀行行號資料";
                    var bankAccount = proposer.BankAccount != null ? proposer.BankAccount : "無銀行帳號資料";
                    var balance = proposer.Balance != null ? (int)proposer.Balance : 0;
                    //balance 群組分隔字串
                    NumberFormatInfo nfi = new CultureInfo("en-US", false).NumberFormat;
                    var balanceString = balance.ToString("C", nfi);
                    var price = o.Price != null ? (int)o.Price : 0;
                    var priceString = price.ToString("C", nfi);

                    //計算total
                    var count = o.Count != null? (int)o.Count: 0;
                    var total = count * price;
                    var totalString = total.ToString("C", nfi);

                    //訂單可能null資料 - Memo, OrderStatus 
                    var memo = o.Memo != null ? o.Memo : "";
                    var status = o.OrderStatus != null ? (Enum.Enum.OrderStatus)o.OrderStatus : 0;
                    var statusString = o.OrderStatus != null ? ((Enum.Enum.OrderStatus)o.OrderStatus).ToString("g") : "待付款";

                    //計算完成日期
                    var dealedDate = (DateTime)o.DealedDate;
                    var dealedDateString = dealedDate.ToString("d");
                    var completeDateString = dealedDate.AddDays(predictDays).Date.ToString("d");
                    var isComplete = o.OrderStatus == 3 ? true : false;
                    orderDetails.Add(new OrderManagementViewModel
                    {
                        //訂單資訊
                        OrderID = o.OrderId,
                        Price = price,
                        PriceString = priceString,
                        Count = count,
                        Total = total,
                        TotalString = totalString,
                        DealedDate = dealedDateString,
                        PredictDays = predictDays,
                        CompleteDate = completeDateString,
                        IsClientComfirmed = isComplete,
                        OrderStatus = status,
                        OrderStatusString = statusString,

                        //接案者資料
                        ProposerID = (int)o.ProposerId,
                        StudioName = o.StudioName,
                        ProposerPhone = proposerPhone,
                        ProposerEmail = proposer.Email,
                        BankCode = bankCode,
                        BankAccount = bankAccount,
                        Balance = balance,
                        BalanceString = balanceString,

                        //案主資料
                        ClientName = o.Name,
                        ClientTel = o.Tel,
                        ClientEmail = o.Email,
                        ClientMemo = memo
                    }); 
                }
                return new APIResult(APIStatus.Success, string.Empty, JsonConvert.SerializeObject(orderDetails));
            }
            catch(Exception ex)
            {
                return new APIResult(APIStatus.Fail, ex.Message, result);
            }
        }
        
        //[HttpPut("GiveMoney/{id}")]
        [HttpPut("{id}")]
        public APIResult GiveMoney(int id)
        {
            using (var transaction = _context.Database.BeginTransaction())
            {
                bool result = false;
                try
                {
                    var order = _orderRepo.GetAll().FirstOrDefault(x => x.OrderId == id);
                    var proposer = _memberInfoRepo.GetAll().FirstOrDefault(x => x.MemberId == order.ProposerId);

                    //OrderStatus改成【4撥款完成】
                    order.OrderStatus = 4;
                    _orderRepo.Update(order);

                    //撥款至Proposer Balance
                    var total = (int)order.Price * (int)order.Count;
                    var balance = proposer.Balance != null ? (int)proposer.Balance : 0;
                    proposer.Balance = balance + total;
                    _memberInfoRepo.Update(proposer);

                    //交易成功
                    transaction.Commit();
                    result = true;
                    return new APIResult(APIStatus.Fail, "", result);
                }
                catch (Exception ex)
                {
                    //交易失敗
                    transaction.Rollback();
                    return new APIResult(APIStatus.Fail, ex.Message, result);
                }
            }
        }
    }
}
