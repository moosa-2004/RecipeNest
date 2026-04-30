using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using RecipeNestAPI.Models;

namespace RecipeNestAPI.Models
{
    public class Recipe
    {
        public int RecipeID { get; set; }

        [ForeignKey("Chef")]
        public int ChefID { get; set; }

        public Chef? Chef { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public string Ingredients { get; set; }

        [Required]
        public string Instructions { get; set; }

        public string? ImagePath { get; set; }

        public DateTime DateCreated { get; set; } = DateTime.Now;
    }
}