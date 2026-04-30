using Microsoft.AspNetCore.Mvc;
using RecipeNestAPI.Data;
using RecipeNestAPI.Models;
using System.Linq;

namespace RecipeNestAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class RecipeController : ControllerBase
    {
        private readonly AppDbContext _context;

        public RecipeController(AppDbContext context)
        {
            _context = context;
        }

        // GET ALL RECIPES
        [HttpGet]
        public IActionResult GetAllRecipes()
        {
            var recipes = _context.Recipes.ToList();
            return Ok(recipes);
        }

        // GET RECIPE BY ID
        [HttpGet("{id}")]
        public IActionResult GetRecipe(int id)
        {
            var recipe = _context.Recipes.FirstOrDefault(r => r.RecipeID == id);

            if (recipe == null)
                return NotFound("Recipe not found");

            return Ok(recipe);
        }

        // ADD RECIPE
        [HttpPost]
        public IActionResult AddRecipe(Recipe recipe)
        {
            _context.Recipes.Add(recipe);
            _context.SaveChanges();

            return Ok("Recipe added successfully");
        }

        // UPDATE RECIPE
        [HttpPut("{id}")]
        public IActionResult UpdateRecipe(int id, Recipe updatedRecipe)
        {
            var recipe = _context.Recipes.FirstOrDefault(r => r.RecipeID == id);

            if (recipe == null)
                return NotFound("Recipe not found");

            recipe.Title = updatedRecipe.Title;
            recipe.Ingredients = updatedRecipe.Ingredients;
            recipe.Instructions = updatedRecipe.Instructions;
            recipe.ImagePath = updatedRecipe.ImagePath;

            _context.SaveChanges();

            return Ok("Recipe updated successfully");
        }

        // DELETE RECIPE
        [HttpDelete("{id}")]
        public IActionResult DeleteRecipe(int id)
        {
            var recipe = _context.Recipes.FirstOrDefault(r => r.RecipeID == id);

            if (recipe == null)
                return NotFound("Recipe not found");

            _context.Recipes.Remove(recipe);
            _context.SaveChanges();

            return Ok("Recipe deleted successfully");
        }
    }
}