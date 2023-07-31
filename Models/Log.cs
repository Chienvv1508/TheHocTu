using System;
using System.Collections.Generic;

namespace ProjectPrn211.Models
{
    public partial class Log
    {
        public int LogId { get; set; }
        public int Card { get; set; }
        public int UserId { get; set; }
        public int Action { get; set; }
        public DateTime? DateCreated { get; set; }
        public DateTime? DateLearn { get; set; }
        public int I { get; set; }
        public double Ef { get; set; }
        public int N { get; set; }
        public double? Q { get; set; }
        public int? Status { get; set; }

        public virtual Card CardNavigation { get; set; } = null!;
        public virtual Student User { get; set; } = null!;
    }
}
