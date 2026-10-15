using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using sports_events.Data;
using sports_events.Models;

namespace sports_events.Controllers
{//start of namespace
    [Route("api/[controller]")]
    [ApiController]
    public class EventsController : ControllerBase
    {//start of namespace
        private readonly ApplicationDBContext _context;
        public EventsController(ApplicationDBContext context)
        {
            _context = context;
        }

  


        // GET: api/Events
        [HttpGet]
        public IActionResult GetEvents(string EventId,string EventName,string EventDescription)
        {
            var events = _context.Events.ToList();
            return Ok(events);
        }

        // POST: api/Events

        [HttpPost]
        public IActionResult CreateEvent([FromBody] Event events)
        {
          
            _context.Events.Add(events);
            _context.SaveChanges();

            return Ok(events);
        }
        

    }
}//end of namespace
