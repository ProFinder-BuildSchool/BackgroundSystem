using Background_ProFinder.Repositories;
using Background_ProFinder.Models.DBModel;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Background_ProFinder.Repositories.Interfaces;

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
    }
}
