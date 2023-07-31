using System;
using System.Collections.Generic;

namespace ProjectPrn211.Models
{
    public partial class Example
    {
        public Example()
        {
            Cards = new HashSet<Card>();
        }

        public int ExId { get; set; }
        public string Ex { get; set; } = null!;
        public int Card { get; set; }

        public virtual Card CardNavigation { get; set; } = null!;
        public virtual ICollection<Card> Cards { get; set; }
    }
}
