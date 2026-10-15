using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using sports_events.Data;

namespace sports_events.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ApplicationDBContext _context;
        public CategoryController(ApplicationDBContext context)
        {
            _context = context;
        }
        [HttpGet]
        public IActionResult GetUsers(int CategoryId, string CategoryName, string CategoryDescription)
        {

            var categories = _context.Categories.ToList();

            return Ok(categories);

        }
    }
}
