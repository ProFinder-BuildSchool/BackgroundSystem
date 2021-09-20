using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Background_ProFinder.Models.ViewModel
{
    public class WorkViewModel
    {
        public int WorkID { get; set; }
        public List<string> WorkPicture { get; set; }
        public string SubCategoryName { get; set; }
        public string Memo { get; set; }
        public string studio { get; set; }
        public int MemberID { get; set; }


    }
}
