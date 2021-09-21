using Background_ProFinder.Models.DBModel;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Background_ProFinder.Repositories
{
    public class MemberRepository:GeneralRepository<MemberInfo>
    {
        public MemberRepository(ThirdGroupContext context, ILogger<MemberInfo> logger) : base(context, logger)
        {

        }
    }
}
