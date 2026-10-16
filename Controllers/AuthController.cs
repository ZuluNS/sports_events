using Azure.Core;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD

using Microsoft.IdentityModel.Tokens; 
using sports_events.Data;
using sports_events.Models;
using sports_events.Services;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

using sports_events.Models;
using sports_events.Data;

=======
using sports_events.Models;
using sports_events.Data;
>>>>>>> 527bd026c0b979f446c5757d3227486c75c5bb69
=======
using sports_events.Models;
using sports_events.Data;
>>>>>>> 527bd026c0b979f446c5757d3227486c75c5bb69
=======
using sports_events.Models;
using sports_events.Data;
>>>>>>> 527bd026c0b979f446c5757d3227486c75c5bb69

namespace sports_events.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController(IAuthService authService) : ControllerBase
    {
<<<<<<< HEAD
=======
        public static User user = new User();
        [HttpPost("register")]
        public ActionResult<User> Register(UserDto request)
        {
            var hashedPassword = new PasswordHasher<User>().
                HashPassword(user, request.Password);
            user.UserName = request.UserName;
            user.PasswordHash = hashedPassword;
            return Ok(user);
        }
        [HttpPost("login")]
        public ActionResult<string> Login(UserDto request)
        {// Check if the username exists
            if (user.UserName != request.UserName)
            {
                return BadRequest("User not found.");
            }
            if (new PasswordHasher<User>().VerifyHashedPassword(user, user.PasswordHash, request.Password)
                == PasswordVerificationResult.Failed)
            {
                return BadRequest("Wrong password.");
            }
            string token = "success";
            return Ok(token);
        }
    }
>>>>>>> 527bd026c0b979f446c5757d3227486c75c5bb69

        public static User user = new User();




        // POST: api/Auth/register
        [HttpPost("register")]
        public async Task<ActionResult<string>> Register(UserDto request)
        {
            var user = await authService.RegisterAsync(request);


            if (user == null)
            {
                return BadRequest("User already exists.");
            }
            return Ok(user);
        }






        // POST: api/Auth/login
        [HttpPost("login")]
        public async Task<ActionResult<string>> Login(UserDto request)
        {// Check if the username exists

            var token = authService.LoginAsync(request);
            if (token == null)
            {
                return BadRequest("Invalid username or password.");
            }
            return Ok(token);
        }


    }
}


