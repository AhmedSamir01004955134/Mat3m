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
    public class DelavryController : ControllerBase
    {
        MatamNewContext db = new MatamNewContext();
        [HttpGet("GetDlevaries")]
        public List<Dlevary> GetDlevaries()
        {
            return db.Dlevaries.ToList();
        }

    }
}
