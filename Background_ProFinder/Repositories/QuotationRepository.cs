using Background_ProFinder.Models.DBModel;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Background_ProFinder.Repositories
{
    public class QuotationRepository:GeneralRepository<Quotation>
    {
        public QuotationRepository(ThirdGroupContext context, ILogger<Quotation> logger):base(context,logger)
        {

        }

    }
}
