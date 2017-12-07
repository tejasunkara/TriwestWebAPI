using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TriwestWebAPI.Demo;

namespace TriwestWebAPI.Controllers
{
    [Produces("application/json")]
    [Route("api/Providers")]
    public class ProvidersController : Controller
    {
        private readonly CcnContext _context;

        public ProvidersController(CcnContext context)
        {
            _context = context;
        }

        // GET: api/Provider
        [HttpGet]
        public IActionResult Get()
        {
            var providers = _context.Providers;

            return Ok(providers);
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public IActionResult Get([FromQuery]string taxId="", [FromQuery]string providerName = "", [FromQuery]string groupName = "", [FromQuery]string npi = "")
        {
            var providers = _context.Providers.Where(t => t.taxId == taxId || t.npi==npi);            

            return Ok(providers);
        }
    }
}
