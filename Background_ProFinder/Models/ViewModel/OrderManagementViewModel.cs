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
        public int OrderID { get; set; } //ok
        public int Price { get; set; } //ok
        public string PriceString { get; set; } //ok
        public int Count { get; set; } //ok
        public int Total { get; set; } //ok
        public string TotalString { get; set; } //ok
        public string DealedDate { get; set; } //ok
        public int PredictDays { get; set; } //ok
        public string CompleteDate { get; set; } //ok
        public bool IsClientComfirmed { get; set; } //ok
        public OrderStatus OrderStatus { get; set; } //ok
        public string OrderStatusString { get; set; } //ok

        //接案者資料
        public int ProposerID { get; set; }//ok
        public string StudioName { get; set; } //ok
        public string ProposerPhone { get; set; }
        public string ProposerEmail { get; set; }
        public string BankCode { get; set; }
        public string BankAccount { get; set; }
        public int Balance { get; set; } //帳戶餘額
        public string BalanceString { get; set; }

        //案主資料
        public string ClientName { get; set; }//ok
        public string ClientTel { get; set; }//ok
        public string ClientEmail { get; set; }//ok
        public string ClientMemo { get; set; }//ok
        

    }
}
