using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Background_ProFinder.Models.DBModel;
using Background_ProFinder.Models.ViewModel;
using Background_ProFinder.Repositories.Interfaces;
using Background_ProFinder.Service.Interfaces;

namespace Background_ProFinder.Service
{
    public class HomePageService : IHomePageService
    {
        private readonly IBannerRepository _bannerRepo;
        private readonly IWorkRepository _workRepo;
        
        public HomePageService(IBannerRepository bannerRepo, IWorkRepository workRepo)
        {
            _bannerRepo = bannerRepo;
            _workRepo = workRepo;
        }



        public void AddBannerData(BannerViewModel data)
        {

                _bannerRepo.GetAll<Banner>().FirstOrDefault(x => x.BannerId == data.BannerId).BannerImgUrl = data.BannerImgUrl;
                _bannerRepo.GetAll<Banner>().FirstOrDefault(x => x.BannerId == data.BannerId).BannerTitle = data.BannerTitle;
                _bannerRepo.SaveChanges();             
        }

        public void AddFeatureWorkMomo(WorkViewModel FeatureWorkList)
        {
            var temp = _workRepo.GetAll<Work>().FirstOrDefault(x => x.WorkId == FeatureWorkList.WorkID);
            temp.Memo = FeatureWorkList.Memo;
            _workRepo.SaveChanges();
        }

        public void SetFeatureWorkList(WorkViewModel FeatureWorkList)
        {
            var temp = _workRepo.GetAll<Work>().FirstOrDefault(x => x.WorkId == FeatureWorkList.WorkID);

            if (temp.Featured == 0)
            {
                temp.Featured = 1;
            }
            else
            {
                temp.Featured = 0;
            }
            _workRepo.SaveChanges();
        }

        public List<BannerViewModel> GetBannerData()
        {
            var result = (from b in _bannerRepo.GetAll<Banner>() select b).Select(x => new BannerViewModel
            {
                BannerTitle = x.BannerTitle,
                BannerImgUrl = x.BannerImgUrl

            }).ToList();

            return result;
        }

        public List<WorkViewModel> GetWorkList()
        {
           return (from W in _workRepo.GetAll<Work>()
                          join S in _workRepo.GetAll<SubCategory>() on W.SubCategoryId equals S.SubCategoryId
                          join workpic in _workRepo.GetAll<WorkPicture>() on W.WorkId equals workpic.WorkId

                          select new
                          {
                              WorkID = W.WorkId,
                              Picture = workpic.WorkPicture1,
                              SubCategoryName = S.SubCategoryName,
                              studio = W.Client,
                              MemberID = W.MemberId,
                              Featured = W.Featured,
                              Memo = W.Memo
                          }).ToList()
                              .GroupBy(x => x.WorkID)
                              .Select(x => new WorkViewModel
                              {
                                  WorkID = x.First().WorkID,
                                  WorkPicture = x.Select(p => p.Picture).ToList(),
                                  SubCategoryName = x.First().SubCategoryName,
                                  studio = x.First().studio,
                                  MemberID = (int)x.First().MemberID,
                                  Featured = (int)x.First().Featured,
                                  Memo = x.First().Memo,
                              }).Where(x => x.WorkPicture.Count() >= 3).OrderBy(x => x.WorkID).ToList();
        }

        
    }
}
