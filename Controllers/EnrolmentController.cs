using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using sports_events.Data;
using sports_events.Models;

namespace sports_events.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EnrolmentController : ControllerBase
    {
        private readonly ApplicationDBContext _context;
        public EnrolmentController(ApplicationDBContext context)
        {
            _context = context;
        }

        // GET: api/Enrolments
        [HttpGet]
        public IActionResult GetEnrolments(int EnrolmentId, string EnrolmentName, string EnrolmentType)
        {
            var enrolments = _context.Enrolments.ToList();
            return Ok(enrolments);
        }

        // POST: api/Enrolments
        [HttpPost]
        public IActionResult CreateCategory([FromBody] Enrolment enrolments)
        {

            _context.Enrolments.Add(enrolments);
            _context.SaveChanges();

            return Ok(enrolments);
        }
    }
}
