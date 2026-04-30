using System.ComponentModel.DataAnnotations;
using RecipeNestAPI.Models;


namespace RecipeNestAPI.Models
{
    public class Chef
    {
        public int ChefID { get; set; }

        [Required]
        public string FullName { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        public string PasswordHash { get; set; }

        public string? Biography { get; set; }

        public string? ProfileImage { get; set; }
    }
}