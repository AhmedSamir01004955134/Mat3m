using System;
using System.Collections.Generic;

#nullable disable

namespace Mat3am.Models
{
    public partial class SelesBill
    {
        public SelesBill()
        {
            SelesBillDetalis = new HashSet<SelesBillDetali>();
        }

        public int Id { get; set; }
        public DateTime? Date { get; set; }
        public decimal? Totale { get; set; }
        public decimal? Cash { get; set; }
        public decimal? Discount { get; set; }
        public int? DelvaryId { get; set; }
        public int? OrderNumper { get; set; }

        public virtual Dlevary Delvarys { get; set; }
        public virtual ICollection<SelesBillDetali> SelesBillDetalis { get; set; }
    }
}
