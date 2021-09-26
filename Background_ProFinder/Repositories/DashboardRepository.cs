using Background_ProFinder.Controllers;
using Background_ProFinder.Models.DBModel;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Background_ProFinder.Repositories
{
    public class DashboardRepository : GeneralRepository
    {
        public DashboardRepository(ThirdGroupContext context, ILogger<HomeController> logger) : base(context, logger)
        {

        }
    }
}
