using System;
using System.Collections.Generic;

#nullable disable

namespace Mat3am.Models
{
    public partial class ProductNew
    {
        public ProductNew()
        {
            ProductImgNews = new HashSet<ProductImgNew>();
            SelesBillDetalis = new HashSet<SelesBillDetali>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int? CatogryId { get; set; }
        public string Descraption { get; set; }
        public decimal? Price { get; set; }
        public string Img { get; set; }

        public virtual Catogrey Catogry { get; set; }
        public virtual ICollection<ProductImgNew> ProductImgNews { get; set; }
        public virtual ICollection<SelesBillDetali> SelesBillDetalis { get; set; }
    }
}
