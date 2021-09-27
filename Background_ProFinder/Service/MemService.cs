using Background_ProFinder.Models.DBModel;
using Background_ProFinder.Models.ViewModel;
using Background_ProFinder.Repositories;
using Background_ProFinder.Repositories.Interfaces;
using Background_ProFinder.Service.Interfaces;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Background_ProFinder.Service
{
    public class MemService : IMemService
    {
        private readonly IMemberRepository _memberInfoRepo;
        private readonly ILocationsRepository _locationsRepo;

        //Location
        public MemService(IMemberRepository memberRepo, ILocationsRepository locationsRepo)
        {
            _memberInfoRepo = memberRepo;
            _locationsRepo = locationsRepo;

        }

        public string GetAllMems()
        {
            var allMems = _memberInfoRepo.GetAll<MemberInfo>().ToList();
            List<MemViewModel> memList = new List<MemViewModel>();
            foreach (var m in allMems)
            {
                var NickName = m.NickName != null ? m.NickName : "NoRecord";
                var Cellphone = m.Cellphone != null ? m.Cellphone : "-";
                var UserId = m.UserId != null ? m.UserId : "-";
                var Email = m.Email != null ? m.Email : "-";


                var identity = m.Identity != null ? (Enum.Enum.Identity)m.Identity : 0;
                var identityString = m.Identity != null ? ((Enum.Enum.Identity)m.Identity).ToString("g") : "-";

                //var location = _locationsRepo.GetAll<Location>().FirstOrDefault(l=>l.LocationId==m.LocationId);
                var location = m.LocationId != null ? _locationsRepo.GetAll<Location>().FirstOrDefault(x => x.LocationId == m.LocationId) : null;

                var locationString = m.LocationId != null ? location.LocationName : "-";


                memList.Add(new MemViewModel
                {
                    MemberId = m.MemberId,
                    NickName = NickName,
                    Cellphone = Cellphone,
                    Email = Email,
                    UserId = UserId,
                    Identity = identity,
                    IdentityString = identityString,
                    LocationId = m.LocationId,
                    LocationString = locationString
                });
            }
            return JsonConvert.SerializeObject(memList);
        }
    }
}
