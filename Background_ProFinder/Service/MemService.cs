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
        //Location
        public MemService(IMemberRepository memberRepo)
        {
            _memberInfoRepo = memberRepo;

        }

        public string GetAllMems()
        {
            var allMems = _memberInfoRepo.GetAll<MemberInfo>().ToList();
            List<MemViewModel> memList = new List<MemViewModel>();
            foreach (var m in allMems)
            {
                var NickName = m.NickName != null ? m.NickName : "NoRecord";
                var Cellphone = m.Cellphone != null ? m.Cellphone : "NoRecord";
                var UserId = m.UserId != null ? m.UserId : "NoRecord";
                var Email = m.Email != null ? m.Email : "NoRecord";


                var identity = m.Identity != null ? (Enum.Enum.Identity)m.Identity : 0;
                var identityString = m.Identity != null ? ((Enum.Enum.Identity)m.Identity).ToString("g") : "NoRecord";
                
                memList.Add(new MemViewModel
                {
                    MemberId = m.MemberId,
                    NickName = NickName,
                    Cellphone = Cellphone,
                    Email = Email,
                    UserId = UserId,
                    Identity = identity,
                    IdentityString = identityString
                });
            }
            return JsonConvert.SerializeObject(memList);
        }
    }
}
