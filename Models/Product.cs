using System;
using System.Collections.Generic;

#nullable disable

namespace Mat3am.Models
{
    public partial class Product
    {
        public Product()
        {
            ProductImgs = new HashSet<ProductImg>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Descraption { get; set; }
        public decimal? Price { get; set; }
        public int? CatogryId { get; set; }
        public string Img { get; set; }

        public virtual Catogryy Catogry { get; set; }
        public virtual ICollection<ProductImg> ProductImgs { get; set; }
    }
}
