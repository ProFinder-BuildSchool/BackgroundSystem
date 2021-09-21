using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Background_ProFinder.Models.DBModel;
using Background_ProFinder.Models.ViewModel;
using System.Text;
using System.Security.Cryptography;
using System.Web;


namespace Background_ProFinder.Service
{
    public class LoginService
    {
        private readonly ThirdGroupContext _ctx;
        public LoginService(ThirdGroupContext context)
        {
            _ctx = context;
        }

        /// <summary>
        /// 比對帳號密碼
        /// </summary>
        /// <param name="LoginData"></param>
        /// <returns></returns>
        public BackAccount CompareUserData(LoginViewModel LoginData)
        {
            var dataList = (from b in _ctx.BackAccounts
                            where b.Account.ToUpper() == LoginData.AccountName.ToUpper() && b.Password == LoginData.Password
                            select b).FirstOrDefault();

            return dataList;
        }

        /// <summary>
        /// 獲得帳戶資料
        /// </summary>
        /// <returns></returns>
        public List<BackAccount> GetUserAccountData()
        {
            var dataList = (from b in _ctx.BackAccounts
                            select b).ToList();

            return dataList;
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

        public bool AddUser(LoginViewModel UserData)
        {
           
            //1.View Model--> Data Model
            string name = HttpUtility.HtmlEncode(UserData.AccountName);
            string password = HttpUtility.HtmlEncode(UserData.Password);
            string email = HttpUtility.HtmlEncode(UserData.Email);
            string account = HttpUtility.HtmlEncode(UserData.Account);
            int authority = UserData.Authority;

            BackAccount userAccountData = new BackAccount
            {
                Account = account,
                Name = name,
                Email = email,
                Password = MD5Hash(password),
                Authority = authority
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

