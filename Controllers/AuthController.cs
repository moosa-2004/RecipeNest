using Microsoft.AspNetCore.Mvc;
using RecipeNestAPI.Data;
using RecipeNestAPI.Models;
using System.Linq;

namespace RecipeNestAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthController : ControllerBase
    {
        private readonly AppDbContext _context;

        public AuthController(AppDbContext context)
        {
            _context = context;
        }

        // REGISTER
        [HttpPost("register")]
        public IActionResult Register(Chef chef)
        {
            // Check if email already exists
            var existingUser = _context.Chefs.FirstOrDefault(c => c.Email == chef.Email);
            if (existingUser != null)
            {
                return BadRequest("Email already exists");
            }

            // Save user
            _context.Chefs.Add(chef);
            _context.SaveChanges();

            return Ok("User registered successfully");
        }

        // LOGIN
        [HttpPost("login")]
        public IActionResult Login(string email, string password)
        {
            var user = _context.Chefs.FirstOrDefault(c => c.Email == email && c.PasswordHash == password);

            if (user == null)
            {
                return Unauthorized("Invalid credentials");
            }

            return Ok(user);
        }
    }
}