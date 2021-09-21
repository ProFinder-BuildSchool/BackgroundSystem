using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Background_ProFinder.Services.Interfaces
{
    public interface IOrderService
    {
        string GetAllOrders();
        bool ChangeOrderStatus(int orderId);
    }
}
