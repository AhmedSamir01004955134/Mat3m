using System;
using System.Collections.Generic;

#nullable disable

namespace Mat3am.Models
{
    public partial class SelesBillDetali
    {
        public int Id { get; set; }
        public int? ProductId { get; set; }
        public int? Quantity { get; set; }
        public decimal? Price { get; set; }
        public decimal? Totale { get; set; }
        public int? SelesBillId { get; set; }
        public int? ProductNewId { get; set; }

        public virtual ProductNew Product { get; set; }
        public virtual SelesBill SelesBill { get; set; }
    }
}
