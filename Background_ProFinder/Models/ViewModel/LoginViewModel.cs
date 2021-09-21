using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Background_ProFinder.Models.ViewModel
{
    public class LoginViewModel
    {
        public string AccountName { get; set; }
        public string Password { get; set; }
    }
}
