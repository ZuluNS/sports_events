using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using sports_events.Data;
using sports_events.Models;

namespace sports_events.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ResultController : ControllerBase
    {
        private readonly ApplicationDBContext _context;
        public ResultController(ApplicationDBContext context)
        {
            _context = context;
        }
        [HttpGet]
        public IActionResult GetResults(int ResultId, string ResultName, string UserEmail, string ResultDate)
        {

            var results = _context.Results.ToList();
            return Ok(results);

        }
        [HttpPost]
        public IActionResult CreateResult([FromBody] Result result)
        {

            _context.Results.Add(result);
            _context.SaveChanges();

            return Ok(result);
        }



    }
}
