using System;
using System.Collections.Generic;

#nullable disable

namespace Mat3am.Models
{
    public partial class Catogrey
    {
        public Catogrey()
        {
            ProductNews = new HashSet<ProductNew>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Img { get; set; }

        public virtual ICollection<ProductNew> ProductNews { get; set; }
    }
}
