using System;
using System.Collections.Generic;

#nullable disable

namespace Mat3am.Models
{
    public partial class ProductImgNew
    {
        public int Id { get; set; }
        public string Img { get; set; }
        public int? ProductNewId { get; set; }

        public virtual ProductNew ProductNew { get; set; }
    }
}
