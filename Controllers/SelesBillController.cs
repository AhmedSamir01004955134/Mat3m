using Mat3am.Models;
using Mat3am.VModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mat3am.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SelesBillController : ControllerBase
    {
        MatamNewContext db = new MatamNewContext();

        [HttpPost("SaveSeals")]
        public int SaveSeals( VmSelesBill model)
        {
            SelesBill selesBill = new SelesBill();
            selesBill.Cash = model.Cash;
            selesBill.Discount = model.Discount;
            selesBill.Totale = model.Totale;
            selesBill.DelvaryId = model.DlaveryId;
            selesBill.Date = DateTime.Now;
            selesBill.OrderNumper = db.SelesBills.Count() == 0 ? 1 : db.SelesBills.Count()+1;

            
            foreach (var item in model.details)
            {
                selesBill.SelesBillDetalis.Add(new SelesBillDetali
                {
                  Quantity=item.Quantity,
                   Price=item.product.Price,
                   //ProductId=item.product.Id,
                    Totale=item.Totale,
                    ProductNewId=item.product.Id

                    
                });
               

                db.SelesBills.Add(selesBill);

                
            }
            return db.SaveChanges();
        }

        [HttpGet("GetSeals")]
        public List<SelesBill> GetSeals()
        {

            return db.SelesBills.Include(x=>x.Delvarys).ToList();
            
        }
    }
}
