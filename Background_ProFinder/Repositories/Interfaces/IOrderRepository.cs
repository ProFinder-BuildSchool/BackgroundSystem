using Background_ProFinder.Models.DBModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Background_ProFinder.Repositories.Interfaces
{
    public interface IOrderRepository : IGeneralRepository
    {
        bool GiveMoneyToProposer(int orderId);
    }
}
