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
        [HttpGet]
        public IActionResult GetEnrolment(int EnrolmentId, string EnrolmentName, string EnrolmentEmail)
        {

            var enrolments = _context.Enrolments.ToList();
            return Ok(enrolments);

        }
        [HttpPost]
        public IActionResult CreateEnrolment([FromBody] Enrolment enrolment)
        {

            _context.Enrolments.Add(enrolment);
            _context.SaveChanges();

            return Ok(enrolment);
        }
    }
}
