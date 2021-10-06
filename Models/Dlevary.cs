using System;
using System.Collections.Generic;

#nullable disable

namespace Mat3am.Models
{
    public partial class Dlevary
    {
        public Dlevary()
        {
            SelesBills = new HashSet<SelesBill>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int? Age { get; set; }
        public string Phone { get; set; }

        public virtual ICollection<SelesBill> SelesBills { get; set; }
    }
}
