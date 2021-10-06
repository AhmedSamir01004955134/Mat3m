using System;
using System.Collections.Generic;

#nullable disable

namespace Mat3am.Models
{
    public partial class ProductImg
    {
        public int Id { get; set; }
        public string Img { get; set; }
        public int? ProductId { get; set; }

        public virtual Product Product { get; set; }
    }
}
