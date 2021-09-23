using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static Background_ProFinder.Enum.Enum;

namespace Background_ProFinder.Models.ViewModel
{
    public class MemViewModel
    {
        public int MemberId { get; set; }
        public string NickName { get; set; }
        public string Cellphone { get; set; }
        public string Email { get; set; }
        public byte[] RegistedTime { get; set; }
        
        public Identity Identity { get; set; }
        public string IdentityString { get; set; }

        public int? LocationId { get; set; }
        public string UserId { get; set; }

    }
}
