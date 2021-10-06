using Mat3am.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Mat3am.VModels
{
    public class VmSelesBill
    {
        public VmSelesBill()
        {
            details = new List<SelesBillDetaliVm> ();
        }
        public int Id { get; set; }
        public decimal? Totale { get; set; }
        public decimal? Cash { get; set; }
        public decimal? Discount { get; set; }
        [Required(ErrorMessage ="entar your dleavaryId")]
        public int DlaveryId { get; set; }

        public List<SelesBillDetaliVm> details { get; set; }
    }
    public class SelesBillDetaliVm
    {
        public ProductNew product { get; set; }
        public int Quantity { get; set; }
        public int Totale { get; set; }
    }
}
