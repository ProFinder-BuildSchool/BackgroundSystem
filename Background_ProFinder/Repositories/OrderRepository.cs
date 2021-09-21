using Background_ProFinder.Repositories;
using Background_ProFinder.Models.DBModel;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Background_ProFinder.Repositories
{
    public class OrderRepository :GeneralRepository<Order>
    {
        public OrderRepository(ThirdGroupContext context, ILogger<Order> logger): base(context, logger)
        {

        }
        
        
    }
}
