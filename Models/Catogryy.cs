using System;
using System.Collections.Generic;

#nullable disable

namespace Mat3am.Models
{
    public partial class Catogryy
    {
        public Catogryy()
        {
            Products = new HashSet<Product>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Icon { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}
