using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Background_ProFinder.Models.DBModel;


namespace Background_ProFinder.Service
{
    public class LoginService
    {
        private readonly ThirdGroupContext _ctx;
        public LoginService(ThirdGroupContext context)
        {
            _ctx = context;
        }

        public BackAccount CompareUserData(BackAccount LoginData)
        {
            var dataList = (from b in _ctx.BackAccounts
                           where b.Account == LoginData.Account && b.Password == LoginData.Password
                           select b).FirstOrDefault();

            return dataList;
        }
    }
}
