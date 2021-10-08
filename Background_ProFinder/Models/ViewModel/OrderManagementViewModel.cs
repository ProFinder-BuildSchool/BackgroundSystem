using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static Background_ProFinder.Enum.Enum;

namespace Background_ProFinder.Models.ViewModel
{
    public class OrderManagementViewModel
    {
        //訂單資訊
        public int OrderID { get; set; } 
        public int Price { get; set; } 
        public string PriceString { get; set; } 
        public int Count { get; set; } 
        public int Total { get; set; } 
        public string TotalString { get; set; } 
        public string DealedDate { get; set; } 
        public int PredictDays { get; set; } 
        public string CompleteDate { get; set; } 
        public bool IsClientComfirmed { get; set; } 
        public OrderStatus OrderStatus { get; set; } 
        public string OrderStatusString { get; set; } 

        //接案者資料
        public int ProposerID { get; set; }
        public string StudioName { get; set; } 
        public string ProposerPhone { get; set; }
        public string ProposerEmail { get; set; }
        public string BankCode { get; set; }
        public string BankAccount { get; set; }
        public int Balance { get; set; } //帳戶餘額
        public string BalanceString { get; set; }

        //案主資料
        public string ClientName { get; set; }
        public string ClientTel { get; set; }
        public string ClientEmail { get; set; }
        public string ClientMemo { get; set; }
        

    }
}
