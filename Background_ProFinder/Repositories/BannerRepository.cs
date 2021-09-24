using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Background_ProFinder.Models.DBModel;
using Background_ProFinder.Repositories.Interfaces;
using Microsoft.Extensions.Logging;

namespace Background_ProFinder.Repositories
{
    public class BannerRepository:GeneralRepository ,IBannerRepository
    {
        public BannerRepository(ThirdGroupContext context, ILogger<MemberInfo> logger) : base(context, logger)
        {

        }
    }
}
