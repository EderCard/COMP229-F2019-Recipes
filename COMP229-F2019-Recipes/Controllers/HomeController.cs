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
        private IRecipeRepository repository;

        public HomeController(IRecipeRepository repo)
        {
            repository = repo;
        }
        // default action method
        public ViewResult Index()
        {
            return View();
        }
        /// <summary>
        /// This method return ViewRecipe view (GET)
        /// </summary>
        /// <returns></returns>
        public ViewResult ViewRecipe(int RecipeId)
        {
            return View(repository.Recipes
                .Where(r => r.RecipeId == RecipeId)
                .FirstOrDefault());
        }
        /// <summary>
        /// This method returns RecipeList view
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public ViewResult RecipeList()
        {
            return View(repository.Recipes);
        }

    }
}
