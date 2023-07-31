using System;
using System.Collections.Generic;

namespace ProjectPrn211.Models
{
    public partial class Video
    {
        public int VideoId { get; set; }
        public string Video1 { get; set; } = null!;
        public int Card { get; set; }

        public virtual Card CardNavigation { get; set; } = null!;
    }
}
