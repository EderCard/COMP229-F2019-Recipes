using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace COMP229_F2019_Recipes.Models
{
    public interface IRecipeRepository
    {
        IQueryable<Recipe> Recipes { get; }
        void SaveRecipe(Recipe recipe);
        void SaveReview(Recipe recipe);
        Recipe DeleteRecipe(int recipeId);
    }
}
