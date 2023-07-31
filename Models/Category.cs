using System;
using System.Collections.Generic;

namespace ProjectPrn211.Models
{
    public partial class Category
    {
        public Category()
        {
            Cards = new HashSet<Card>();
        }

        public int CatId { get; set; }
        public string CatName { get; set; } = null!;

        public virtual ICollection<Card> Cards { get; set; }
    }
}
