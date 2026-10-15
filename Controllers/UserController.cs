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

        UserController(ApplicationDBContext context)
        {
            _context = context;
        }
        [HttpGet]
        public IActionResult GetUsers(string userId,string userName,string userEmail,int UserPhone,string userPassword)
        {
            
            var users = _context.Users.ToList();
            return Ok(users);
           
        }
        


    }
}
