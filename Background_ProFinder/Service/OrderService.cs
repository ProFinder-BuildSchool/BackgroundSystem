using Background_ProFinder.Models.DBModel;
using Background_ProFinder.Models.ViewModel;
using Background_ProFinder.Repositories;
using Background_ProFinder.Repositories.Interfaces;
using Background_ProFinder.Service.Interfaces;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace Background_ProFinder.Service
{
    public class OrderService : IOrderService
    {
        private readonly IOrderRepository _orderRepo;
        private readonly IQuotationRepository _quotationRepo;
        private readonly IMemberRepository _memberInfoRepo;
        public OrderService(IOrderRepository orderRepo, IQuotationRepository quotationRepo, IMemberRepository memberRepo)
        {
            _orderRepo = orderRepo;
            _quotationRepo = quotationRepo;
            _memberInfoRepo = memberRepo;
        }

        public bool ChangeOrderStatus(int orderId)
        {
            return _orderRepo.GiveMoneyToProposer(orderId);
        }

        public string GetAllOrders()
        {

            var allOrders = _orderRepo.GetAll<Order>().ToList();
            List<OrderManagementViewModel> orderDetails = new List<OrderManagementViewModel>();
            foreach (var o in allOrders) 
            {
                //Quotation可能null資料 - PredictDays
                var quotation = o.QuotationId != null ? _quotationRepo.GetAll<Quotation>().FirstOrDefault(x => x.QuotationId == o.QuotationId) : null;
                int predictDays = quotation != null ? quotation.ExecuteDate : o.PredictDays != null ? (int)o.PredictDays : 0;

                //Proposer可能null資料 - ProposerPhone, BankCode, BankAccount, Balance
                var proposer = _memberInfoRepo.GetAll<MemberInfo>().FirstOrDefault(x => x.MemberId == o.ProposerId);
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
                var count = o.Count != null ? (int)o.Count : 0;
                var total = count * price;
                var totalString = total.ToString("C", nfi);

                //訂單可能null資料 - Memo, OrderStatus 
                var memo = o.Memo != null ? o.Memo : "";
                var status = o.OrderStatus != null ? (Enum.Enum.OrderStatus)o.OrderStatus : 0;
                var statusString = o.OrderStatus != null ? ((Enum.Enum.OrderStatus)o.OrderStatus).ToString("g") : "待付款";

                //計算完成日期
                var dealedDate = (DateTime)o.DealedDate;
                var dealedDateString = dealedDate.ToString("yyyy/MM/dd");
                var completeDateString = dealedDate.AddDays(predictDays).Date.ToString("yyyy/MM/dd");
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
            return JsonConvert.SerializeObject(orderDetails);

        }
    }
}
