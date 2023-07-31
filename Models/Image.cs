using System;
using System.Collections.Generic;

namespace ProjectPrn211.Models
{
    public partial class Image
    {
        public Image()
        {
            Cards = new HashSet<Card>();
        }

        public int ImageId { get; set; }
        public string Image1 { get; set; } = null!;
        public int Card { get; set; }

        public virtual Card CardNavigation { get; set; } = null!;
        public virtual ICollection<Card> Cards { get; set; }
    }
}
