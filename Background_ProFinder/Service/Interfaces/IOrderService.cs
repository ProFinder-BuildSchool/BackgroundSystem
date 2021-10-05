using Background_ProFinder.Models.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Background_ProFinder.Service.Interfaces
{
    public interface IOrderService
    {
        bool ChangeOrderStatus(int orderId);
        string GetAllOrders();

        IEnumerable<OrderManagementViewModel> DapperGetAllOrders();
    }
}
