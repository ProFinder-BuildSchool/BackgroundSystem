using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Background_ProFinder.Models.ViewModel
{
    public class DashboardViewModel
    {
        public int MemberCount {get;set;}
        public int QuotationCount { get; set; }
        public int OrderCount { get; set; }
        public int OrderRevenue{ get; set; }

        public IEnumerable<string> PieChartName { get; set; }
        public IEnumerable<int> PieChartCnt { get; set; }

        public IEnumerable<int> LaunchCnt { get; set;}
        public IEnumerable<string> LaunchDay { get; set; }


        //public IEnumerable <PieChartViewModel> PieChart { get; set; }




    }
}
