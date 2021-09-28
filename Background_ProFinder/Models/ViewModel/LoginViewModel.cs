using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Background_ProFinder.Models.ViewModel
{
    public class LoginViewModel
    {
        public int AdminId { get; set; }
        public string AccountName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string Account { get; set; }
        public int Authority { get; set; }
        public string AuthorityName { get; set; }
        public int Deactivated { get; set; }

        public string newAccountNumber { get; set; }
    }

    public class UpdateUserInfo
    {
        public string Email { get; set; }
        public int Authority { get; set; }
        public string AccountName { get; set; }
        public string Password { get; set; }
    }
}
