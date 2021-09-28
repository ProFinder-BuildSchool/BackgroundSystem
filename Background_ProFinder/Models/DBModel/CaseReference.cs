using System;
using System.Collections.Generic;

#nullable disable

namespace Background_ProFinder.Models.DBModel
{
    public partial class CaseReference
    {
        public int CaseRefId { get; set; }
        public string CaseRef { get; set; }
        public int? CaseId { get; set; }
    }
}
