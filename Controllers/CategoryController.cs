using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using sports_events.Data;
using sports_events.Models;

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
        public IActionResult GetCategory(int CategoryId, string CategoryName, string CateDescription)
        {
            var categories = _context.Categories.ToList();
            return Ok(categories);
        }

        [HttpPost]
        public IActionResult CreateCategory([FromBody] Category categories)
        {
            _context.Categories.Add(categories);
            _context.SaveChanges();
            return Ok(categories);
        }
    }
}
