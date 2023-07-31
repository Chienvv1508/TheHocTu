using System;
using System.Collections.Generic;

namespace ProjectPrn211.Models
{
    public partial class Card
    {
        public Card()
        {
            Examples = new HashSet<Example>();
            Images = new HashSet<Image>();
            InverseOrg = new HashSet<Card>();
            Logs = new HashSet<Log>();
            Sounds = new HashSet<Sound>();
            Videos = new HashSet<Video>();
        }

        public int CardId { get; set; }
        public string CardText { get; set; } = null!;
        public string? CardMeaning { get; set; }
        public int Cat { get; set; }
        public int Topic { get; set; }
        public int? Image { get; set; }
        public int? Example { get; set; }
        public int? I { get; set; }
        public double? Ef { get; set; }
        public double? Q { get; set; }
        public int? N { get; set; }
        public int? Status { get; set; }
        public DateTime? DateLearn { get; set; }
        public int? OrgId { get; set; }

        public virtual Category CatNavigation { get; set; } = null!;
        public virtual Example? ExampleNavigation { get; set; }
        public virtual Image? ImageNavigation { get; set; }
        public virtual Card? Org { get; set; }
        public virtual Topic TopicNavigation { get; set; } = null!;
        public virtual ICollection<Example> Examples { get; set; }
        public virtual ICollection<Image> Images { get; set; }
        public virtual ICollection<Card> InverseOrg { get; set; }
        public virtual ICollection<Log> Logs { get; set; }
        public virtual ICollection<Sound> Sounds { get; set; }
        public virtual ICollection<Video> Videos { get; set; }
    }
}
