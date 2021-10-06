using Mat3am.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mat3am.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        MatamNewContext db = new MatamNewContext();
        [HttpGet("ProductNews")]
        public List<ProductNew> ProductNews()
        {
            return db.ProductNews.ToList();
        }
        [HttpGet("GetCatogreys")]
        public List<Catogrey> GetCatogreys()
        {
            return db.Catogreys.ToList();
        }
    }
}
