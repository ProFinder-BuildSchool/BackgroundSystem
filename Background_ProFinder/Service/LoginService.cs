using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Background_ProFinder.Models.DBModel;
using Background_ProFinder.Models.ViewModel;
using System.Text;
using System.Security.Cryptography;
using System.Web;
using Background_ProFinder.Repositories.Interfaces;
using Background_ProFinder.Service.Interfaces;
using System.Text.RegularExpressions;

namespace Background_ProFinder.Service
{
    public class LoginService : ILoginService
    {
        private readonly ThirdGroupContext _ctx;
        private readonly IBackAccountRepository _backaccountRepo;
        public LoginService(IBackAccountRepository backaccountRepo, ThirdGroupContext context)
        {
            _ctx = context;
            _backaccountRepo = backaccountRepo;
        }



        /// <summary>
        /// 比對帳號密碼
        /// </summary>
        /// <param name="LoginData"></param>
        /// <returns></returns>
        public BackAccount CompareUserData(LoginViewModel LoginData)
        {
            string password = MD5Hash(HttpUtility.HtmlEncode(LoginData.Password));

            var dataList = (from b in _backaccountRepo.GetAll<BackAccount>()
                            where b.Account.ToUpper() == LoginData.AccountName.ToUpper() && b.Password == password
                            select b).FirstOrDefault();

            return dataList;
        }
        /// <summary>
        /// 確認帳號是否停用/0是正常；1是停用
        /// </summary>
        /// <param name="LoginData"></param>
        /// <returns></returns>
        public bool IsAccountDeactivated(LoginViewModel LoginData)
        {
            var UserInfo = _backaccountRepo.GetAll<BackAccount>().FirstOrDefault(x => x.Account.ToUpper() == LoginData.AccountName.ToUpper());
            if(UserInfo.Deactivated != 0)
            {
                return false;
            }

            return true;
        }

        /// <summary>
        /// 獲得帳戶資料
        /// </summary>
        /// <returns></returns>
        public List<LoginViewModel> GetUserAccountData()
        {
            var newAccountNumber = _backaccountRepo.GetAll<BackAccount>().OrderByDescending(x => x.Account).ToList()[0].Account;
            var newaccountNumber = (Convert.ToInt32(getStrInt(newAccountNumber))+1).ToString("D3");

            var dataList = _backaccountRepo.GetAll<BackAccount>()
                            .Select(x => new LoginViewModel
                            {
                                AccountName= x.Name,
                                Email = x.Email,
                                Account = x.Account,
                                AuthorityName = AuthorityToString((int)x.Authority),
                                Deactivated =(int)x.Deactivated,
                                newAccountNumber = "PF" + newaccountNumber,
                                AdminId = x.AdminId,
                                Authority = (int)x.Authority

                            }).ToList();


            return dataList;
        }
        
        /// <summary>
        /// 更新管理者資訊
        /// </summary>
        /// <param name="AdminId"></param>
        /// <returns></returns>
        public bool UpdateUserInfo(int AdminId,UpdateUserInfo VMdata)
        {
            var UserInfo = _backaccountRepo.GetAll<BackAccount>().FirstOrDefault(x => x.AdminId == AdminId);
            UserInfo.Email = VMdata.Email;
            UserInfo.Name = VMdata.AccountName;
            UserInfo.Authority = VMdata.Authority;

            _backaccountRepo.Update<BackAccount>(UserInfo);

            return true;
        }
        /// <summary>
        /// 更新帳號啟用/停用狀態
        /// </summary>
        /// <param name="adminId"></param>
        /// <param name="deactivatedNumber"></param>
        /// <returns></returns>
        public bool UpdateUserDeactivated(int adminId,int deactivatedNumber)
        {
            var UserInfo = _backaccountRepo.GetAll<BackAccount>().FirstOrDefault(x => x.AdminId == adminId);
            UserInfo.Deactivated = deactivatedNumber;
            _backaccountRepo.Update<BackAccount>(UserInfo);

            return true;
        }

        public bool UpdatePassword(int adminId, string psw)
        {
            var UserPsw = _backaccountRepo.GetAll<BackAccount>().FirstOrDefault(x => x.AdminId == adminId);
            UserPsw.Password = MD5Hash(psw);
            _backaccountRepo.Update<BackAccount>(UserPsw);

            return true;
        }


        /// <summary>
        /// 自動更新帳號的數字
        /// </summary>
        /// <param name="msg"></param>
        /// <returns></returns>
        public static string getStrInt(string msg)
        {
            return Regex.Replace(msg, "[^0-9]", "");
        }

        /// <summary>
        /// 權限資料從數字轉為字串
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public static string AuthorityToString(int number)
        {
            switch (number)
            {
                case 0:
                    return "全功能";
                case 1:
                    return "會員管理&訂單管理";
                case 2:
                    return "首頁管理&總覽";
                case 3:
                    return "管理員帳號管理";
                default:
                    return "未設定";
            }
        }

        /// <summary>
        /// Created HashCode
        /// </summary>
        /// <param name="password"></param>
        /// <returns></returns>
        public static string MD5Hash(string password)
        {
            StringBuilder sb;
            using (MD5 md5 = MD5.Create())
            {
                //將字串轉為Byte[]
                byte[] byteAttay = Encoding.UTF8.GetBytes(password);

                //進行MD5雜湊加密
                byte[] encryption = md5.ComputeHash(byteAttay);

                sb = new StringBuilder();

                for(int i = 0;i < encryption.Length; i++)
                {
                    sb.Append(encryption[i].ToString("x2"));
                }
            }

            return sb.ToString();

        }

        /// <summary>
        /// 加入新管理者資料
        /// </summary>
        /// <param name="UserData"></param>
        /// <returns></returns>
        public bool AddUser(LoginViewModel UserData)
        {
           
            //1.View Model--> Data Model
            string name = HttpUtility.HtmlEncode(UserData.AccountName);
            string password = HttpUtility.HtmlEncode(UserData.Password);
            string email = HttpUtility.HtmlEncode(UserData.Email);
            string account = HttpUtility.HtmlEncode(UserData.Account);
            int authority = UserData.Authority;
            int deactivated = UserData.Deactivated;

        BackAccount userAccountData = new BackAccount
            {
                Account = account,
                Name = name,
                Email = email,
                Password = MD5Hash(password),
                Authority = authority,
                Deactivated = deactivated
        };

            using (var tran = _ctx.Database.BeginTransaction())
            {
                try
                {
                    _ctx.BackAccounts.Add(userAccountData);
                    _ctx.SaveChanges();

                    tran.Commit();

                    return true;
                }
                catch(Exception)
                {
                    tran.Rollback();
                    return false;
                }
            }

            
        }
    }
}

