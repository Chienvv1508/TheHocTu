using System;
using System.Collections.Generic;

namespace ProjectPrn211.Models
{
    public partial class Topic
    {
        public Topic()
        {
            Cards = new HashSet<Card>();
        }

        public int TopicId { get; set; }
        public string TopicName { get; set; } = null!;
        public int? Student { get; set; }

        public virtual Student? StudentNavigation { get; set; }
        public virtual ICollection<Card> Cards { get; set; }
    }
}
