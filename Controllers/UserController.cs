using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using sports_events.Data;
using sports_events.Models;

namespace sports_events.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly ApplicationDBContext _context;

        public UserController(ApplicationDBContext context)
        {
            _context = context;
        }
        [HttpGet]
        public IActionResult GetUsers(int UserId, string UserName, string UserEmail, int UserPhone, string PasswordHash)
        {

            var users = _context.Users.ToList();
            return Ok(users);

        }
        [HttpPost]
        public IActionResult CreateUser([FromBody] User user)
        {

            _context.Users.Add(user);
            _context.SaveChanges();

            return Ok(user);
        }
    }
        
}
