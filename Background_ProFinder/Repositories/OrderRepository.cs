using Background_ProFinder.Repositories;
using Background_ProFinder.Models.DBModel;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Background_ProFinder.Repositories.Interfaces;
using Background_ProFinder.Models.ViewModel;
using Dapper;
using Microsoft.Data.SqlClient;

namespace Background_ProFinder.Repositories
{
    public class OrderRepository : GeneralRepository, IOrderRepository
    {
        public OrderRepository(ThirdGroupContext context, ILogger<Order> logger) : base(context, logger)
        {

        }

        public bool GiveMoneyToProposer(int orderId)
        {
            using (var transaction = _context.Database.BeginTransaction())
            {
                bool result = false;
                try
                {
                    var order = GetAll<Order>().FirstOrDefault(x => x.OrderId == orderId);
                    var proposer = GetAll<MemberInfo>().FirstOrDefault(x => x.MemberId == order.ProposerId);

                    //OrderStatus改成【4撥款完成】
                    order.OrderStatus = 4;
                    Update<Order>(order);

                    //撥款至Proposer Balance
                    var total = (int)order.Price * (int)order.Count;
                    var balance = proposer.Balance != null ? (int)proposer.Balance : 0;
                    proposer.Balance = balance + total;
                    Update<MemberInfo>(proposer);

                    //交易成功
                    transaction.Commit();
                    result = true;
                    return result;
                }
                catch (Exception ex)
                {
                    string exMag = ex.Message;
                    //交易失敗
                    transaction.Rollback();
                    return result;
                }
            }
        }
        
        public  IEnumerable<OrderManagementViewModel> DapperGetAllOrders()
        {
            IEnumerable<OrderManagementViewModel> result = new List<OrderManagementViewModel>();
            using(var conn = new SqlConnection(@"data source=bs-2021-hsz-summer.database.windows.net;initial catalog=ThirdGroup;user id=bs;password=3U7hzk5f8Bzm;"))
            {
                result = conn.Query<OrderManagementViewModel>("SET QUOTED_IDENTIFIER OFF;" + "SELECT o.OrderID, " +
                    "COALESCE(o.Price, 0) AS Price,CAST(CONVERT(int ,COALESCE(o.Price, 0), 2)AS nvarchar) AS PriceString," +
                    " o.[Count] AS [Count],(o.[Count] * COALESCE(o.Price, 0)) AS Total, " +
                    "CAST(CONVERT(int, o.[Count] * COALESCE(o.Price, 0), 2) AS nvarchar) AS TotalString, " +
                    "CONVERT(nvarchar, o.DealedDate, 111) AS DealedDate, COALESCE(q.ExecuteDate, o.PredictDays, 0) AS PredictDays, " +
                    "CAST(DATEADD(day,COALESCE(q.ExecuteDate, o.PredictDays, 0), o.DealedDate) AS nvarchar(50)) AS CompleteDate," +
                    "COALESCE(o.OrderStatus, 0) AS OrderStatus, " +
                    "OrderStatusString = CASE COALESCE(o.OrderStatus , 0) WHEN 0 THEN '待付款' WHEN 1 THEN '製作中' WHEN 2 THEN '待驗收' WHEN 3 THEN '已提出撥款需求' WHEN 4 THEN '撥款完成' END," +
                    "IIF(COALESCE(o.OrderStatus, 0) = 3, 1, 0) AS IsClientConfirmed, o.ProposerID AS ProposerID,m.Email AS ProposerEmail, COALESCE(o.StudioName, '無接案名稱') AS StudioName," +
                    "COALESCE(m.CellPhone, '無接案電話') AS ProposerPhone,COALESCE(m.BankCode, '無銀行行號資料') AS BankCode,COALESCE(m.BankAccount, '無銀行帳號資料') AS BankAccount," +
                    "COALESCE(m.Balance, 0) AS Balance,CAST(COALESCE(CONVERT(int,COALESCE(m.Balance, 0), 2), 0) AS nvarchar) AS BalanceString," +
                    "o.[Name] AS ClientName,  " +
                    "o.Tel AS ClientTel, o.Email AS ClientEmail, " +
                    "COALESCE(o.Memo, '無備註') AS ClientMemo " +
                    "FROM [Order] as o " +
                    "LEFT JOIN Quotation as q ON o.QuotationID = q.QuotationID " +
                    "LEFT JOIN MemberInfo as m ON o.ProposerID = m.MemberID").ToList();
                return result;
            }
        }
    }
}
