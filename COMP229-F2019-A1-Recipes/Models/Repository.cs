using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace COMP229_F2019_A1_Recipes.Models
{
    public static class Repository
    {

        private static List<Recipe> recipes = new List<Recipe>();

        public static IEnumerable<Recipe> Recipe
        {
            get
            {
                return recipes;
            }
        }
        public static void AddRecipe(Recipe recipe)
        {
            recipes.Add(recipe);
        }
    }
}
