using Microsoft.AspNetCore.Mvc;
using TriwestWebAPI.Demo;

namespace TriwestWebAPI.Controllers
{
    [Produces("application/json")]
    [Route("api/TrainingMessage")]
    public class TrainingMessageController : Controller
    {
        private readonly CcnContext _context;

        public TrainingMessageController(CcnContext context)
        {
            _context = context;
        }

        // GET: api/TrainingMessage
        [HttpGet]
        public IActionResult Get()
        {
            var trainingMessage = _context.TrainingMessages;
            //return Ok(new { id = "1", title = "training title", message = "Although the examples in this article primarily feature parent-child " +
             //   "interactions, the issues and alternatives apply to any relationship, including teacher-student ...", CreatedOn = "08/02/2017" });
            return Ok(trainingMessage);
        }

        // GET: api/TrainingMessage/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

    }
}
