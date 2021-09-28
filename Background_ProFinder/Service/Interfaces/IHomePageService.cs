using Background_ProFinder.Models.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Background_ProFinder.Service.Interfaces
{
    public interface IHomePageService
    {

        void AddBannerData(BannerViewModel data);

        void AddFeatureWorkMomo(WorkViewModel FeatureWorkList);

        void SetFeatureWorkList(WorkViewModel FeatureWorkList);

        List<BannerViewModel> GetBannerData();

        List<WorkViewModel> GetWorkList();

    }
}
