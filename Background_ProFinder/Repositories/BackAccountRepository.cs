using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Background_ProFinder.Repositories.Interfaces;
using Background_ProFinder.Models.DBModel;
using Microsoft.Extensions.Logging;

namespace Background_ProFinder.Repositories
{
    public class BackAccountRepository : GeneralRepository, IBackAccountRepository
    {
        public BackAccountRepository(ThirdGroupContext context, ILogger<MemberInfo> logger) : base(context, logger)
        {

        }
    }
}
