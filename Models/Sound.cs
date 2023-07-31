using System;
using System.Collections.Generic;

namespace ProjectPrn211.Models
{
    public partial class Sound
    {
        public int SoundId { get; set; }
        public string Sound1 { get; set; } = null!;
        public int Card { get; set; }

        public virtual Card CardNavigation { get; set; } = null!;
    }
}
