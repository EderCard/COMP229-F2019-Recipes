using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace COMP229_F2019_Recipes.Models
{
    public class Recipe
    {
        public int RecipeId { get; set; }
        
        [Required(ErrorMessage = "Please enter a recipe category")]
        public int Category{ get; set; }
        
        [Required(ErrorMessage = "Please enter a recipe name")]
        public String Name { get; set; }

        [Required(ErrorMessage = "Please enter the ingredients list")]
        public String Ingredients { get; set; }

        [Required(ErrorMessage = "Please enter the directions for cooking")]
        public String Directions { get; set; }
        
        [Required(ErrorMessage = "Please enter the number of serves")]
        public int Serves { get; set; }

        public string Comment { get; set; }
    }

}
