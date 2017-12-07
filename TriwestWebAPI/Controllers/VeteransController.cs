using System.Linq;
using Microsoft.AspNetCore.Mvc;
using TriwestWebAPI.Demo;

namespace TriwestWebAPI.Controllers
{
    [Produces("application/json")]
    [Route("api/Veterans")]
    public class VeteransController : Controller
    {
        private readonly CcnContext _context;

        public VeteransController(CcnContext context)
        {
            _context = context;
            _context.Database.EnsureDeleted();
            _context.SeedData();
        }

        //GET: api/Veterans/5
        [HttpGet("{id:int}", Order=1)]
        public IActionResult Get(int id)
        {
            var veteran = _context.Veterans.Where(v => v.Id == id).SingleOrDefault();

            if (veteran == null)
                return NotFound(id);

            return Ok(veteran);
        }
    }
}