using Background_ProFinder.Models.DBModel;
using Background_ProFinder.Models.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Background_ProFinder.Service.Interfaces
{
    public interface ILoginService
    {
        BackAccount CompareUserData(LoginViewModel LoginData);
        List<LoginViewModel> GetUserAccountData();
       
        bool AddUser(LoginViewModel UserData);
        bool UpdateUserInfo(int AdminId, UpdateUserInfo VMdata);
        bool UpdateUserDeactivated(int adminId, int deactivatedNumber);
        bool UpdatePassword(int adminId, string psw);
        bool IsAccountDeactivated(LoginViewModel LoginData);

    }
}
