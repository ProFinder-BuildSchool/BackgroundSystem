using Background_ProFinder.Models.DBModel;
using Background_ProFinder.Models.ViewModel;
using Background_ProFinder.Repositories;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Background_ProFinder.Service
{
    public class DashBoardService
    {
        private readonly IGeneralRepository _dashboardRepo;
        public DashBoardService(IGeneralRepository dashboardRepo)
        {
            _dashboardRepo = dashboardRepo;
        }
        public string GetAllDashboard()
        {

            var allOrders = _dashboardRepo.GetAll<Order>().ToList();
            var allQuotations = _dashboardRepo.GetAll<Quotation>().ToList();
            var allSubcategory = _dashboardRepo.GetAll<SubCategory>().ToList();
            var allMemberInfos = _dashboardRepo.GetAll<MemberInfo>().ToList();
            int sum = 0;
            DashboardViewModel dashboardDetails = new DashboardViewModel();
            dashboardDetails.MemberCount = allMemberInfos.Count();
            dashboardDetails.QuotationCount = allQuotations.Count();
            dashboardDetails.OrderCount = allOrders.Count();
            foreach(var o in allOrders) {

                sum += (int)o.Price * (int)o.Count;
            }
            dashboardDetails.OrderRevenue = sum;
            var subcategorysummary = (from q in allQuotations
                                      join s in allSubcategory on q.SubCategoryId equals s.SubCategoryId
                                      //group q by q.SubCategoryId
                                      select new 
                                      {
                                          Subcategory = s.SubCategoryName
                                      });

            var subcategory = from g in
                                  from c in subcategorysummary
                                  group c by c.Subcategory
                              orderby g.Count() descending
                              select new PieChartViewModel { Subcategory = g.Key, Subcategorycnt = g.Count() };
            var subcategoryTop3 = subcategory.Take(3);
            dashboardDetails.PieChartName = from s in subcategoryTop3
                                            select s.Subcategory;
            dashboardDetails.PieChartCnt = from s in subcategoryTop3
                                           select s.Subcategorycnt;
            var today = DateTime.Today;
            var last1day = DateTime.Today.AddDays(-1);
            var last2day = DateTime.Today.AddDays(-2);
            var last3day = DateTime.Today.AddDays(-3);
            var last4day = DateTime.Today.AddDays(-4);
            var last5day = DateTime.Today.AddDays(-5);
            var last6day = DateTime.Today.AddDays(-6);
            var last7day = DateTime.Today.AddDays(-7);
            var last8day = DateTime.Today.AddDays(-8);
            var last9day = DateTime.Today.AddDays(-9);

            int todaycnt = (from q in allQuotations
                      where DateTime.Equals(q.UpdateDate.Date, today.Date)
                      select q.UpdateDate).Count();
            int last1daycnt = (from q in allQuotations
                           where DateTime.Equals(q.UpdateDate.Date, last1day.Date)
                               select q.UpdateDate).Count();
            int last2daycnt = (from q in allQuotations
                              where DateTime.Equals(q.UpdateDate.Date, last2day.Date)
                               select q.UpdateDate).Count();
            int last3daycnt = (from q in allQuotations
                              where DateTime.Equals(q.UpdateDate.Date, last3day.Date)
                               select q.UpdateDate).Count();
            int last4daycnt = (from q in allQuotations
                              where DateTime.Equals(q.UpdateDate.Date, last4day.Date)
                               select q.UpdateDate).Count();
            int[] launchcnt = {todaycnt,last1daycnt, last2daycnt , last3daycnt , last4daycnt };
            string[] launchday = {today.ToShortDateString(), last1day.ToShortDateString(), last2day.ToShortDateString(), last3day.ToShortDateString(), last4day.ToShortDateString() };
            dashboardDetails.LaunchCnt = launchcnt;
            dashboardDetails.LaunchDay = launchday;
            return JsonConvert.SerializeObject(dashboardDetails);

        }
    }
}
