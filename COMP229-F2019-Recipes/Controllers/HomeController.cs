using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using COMP229_F2019_Recipes.Models;

namespace COMP229_F2019_Recipes.Controllers
{
    public class HomeController : Controller
    {
        private IRecipeRepository recipeRepository;

        public HomeController(IRecipeRepository recipeRepo)
        {
            recipeRepository = recipeRepo;
        }
        // default action method
        public ViewResult Index()
        {
            return View();
        }

        /// <summary>
        /// This method returns RecipeList view (GET)
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public ViewResult RecipeList()
        {
            return View(recipeRepository.Recipes);
        }

        /// <summary>
        /// This method returns ViewRecipe view (GET)
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public ViewResult ViewRecipe(int RecipeId)
        {
            return View(recipeRepository.Recipes
                .Where(r => r.RecipeId == RecipeId)
                .FirstOrDefault());
        }

    }
}
