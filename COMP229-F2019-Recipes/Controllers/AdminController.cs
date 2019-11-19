using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using COMP229_F2019_Recipes.Models;

namespace COMP229_F2019_Recipes.Controllers
{
    public class AdminController : Controller
    {
        private IRecipeRepository repository;

        public AdminController(IRecipeRepository repo)
        {
            repository = repo;
        }
        // default action method
        public ViewResult Index() => View(repository.Recipes);

        /// <summary>
        /// This method returns the AddRecipe view (GET)
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public ViewResult AddRecipe()
        {
            return View();
        }

        /// <summary>
        /// This method is used to save the new recipe into the RecipeList (POST)
        /// </summary>
        /// <param name="recipe"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult AddRecipe(Recipe recipe)
        {
            if (ModelState.IsValid)
            {
                repository.SaveRecipe(recipe);
                return RedirectToAction("RecipeList", controllerName: "Home");
            }
            else
            {
                return View();
            }
        }

        /// <summary>
        /// This method returns the EditRecipe view
        /// </summary>
        /// <param name="recipeId"></param>
        /// <returns></returns>
        public ViewResult EditRecipe(int recipeId) => View(repository.Recipes
            .FirstOrDefault(r => r.RecipeId == recipeId));

        /// <summary>
        /// This method is used to save changes on Recipe
        /// </summary>
        /// <param name="recipe"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult EditRecipe(Recipe recipe)
        {
            if (ModelState.IsValid)
            {
                repository.SaveRecipe(recipe);
                TempData["message"] = $"{recipe.Name} has been saved!";
                return RedirectToAction("RecipeList", controllerName: "Home");
            }
            else
            {
                return View(recipe);
            }
        }

        /// <summary>
        /// This method returns the ReviewRecipe view
        /// </summary>
        /// <param name="recipeId"></param>
        /// <returns></returns>
        public ViewResult ReviewRecipe(int recipeId) => View(repository.Recipes
            .FirstOrDefault(r => r.RecipeId == recipeId));

                /// <summary>
        /// This method is used to save the Review (POST)
        /// </summary>
        /// <param name="recipe"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult ReviewRecipe(Recipe recipe)
        {
            repository.SaveReview(recipe);
            TempData["message"] = $"{recipe.Name} has been saved!";
            return RedirectToAction("RecipeList", controllerName: "Home");
        }

        /// <summary>
        /// This method is used to delete a recipe
        /// </summary>
        /// <param name="recipeId"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult Delete(int recipeId)
        {
            Recipe deletedRecipe = repository.DeleteRecipe(recipeId);

            if (deletedRecipe != null)
            {
                TempData["message"] = $"{deletedRecipe.Name} was deleted!";
            }

            return RedirectToAction("RecipeList", controllerName: "Home");
        }
    }
}