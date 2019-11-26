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
        private IRecipeRepository recipeRepository;

        public AdminController(IRecipeRepository recipeRepo)
        {
            recipeRepository = recipeRepo;
        }
        // default action method
        public ViewResult Index() => View(recipeRepository.Recipes);

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
                recipeRepository.SaveRecipe(recipe);
                TempData["message"] = $"{recipe.Name} has been saved!";
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
        [HttpGet]
        public ViewResult EditRecipe(int recipeId)
        {
            return View(recipeRepository.Recipes
                .FirstOrDefault(r => r.RecipeId == recipeId));
        }

        /// <summary>
        /// This method is used to save changes on Recipe (POST)
        /// </summary>
        /// <param name="recipe"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult EditRecipe(Recipe recipe)
        {
            if (ModelState.IsValid)
            {
                recipeRepository.SaveRecipe(recipe);
                TempData["message"] = $"{recipe.Name} has been saved!";
                return RedirectToAction("RecipeList", controllerName: "Home");
            }
            else
            {
                return View(recipe);
            }
        }

        /// <summary>
        /// This method is used to delete a recipe (POST)
        /// </summary>
        /// <param name="recipeId"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult Delete(int recipeId)
        {
            Recipe deletedRecipe = recipeRepository.DeleteRecipe(recipeId);
            if (deletedRecipe != null)
            {
                TempData["message"] = $"{deletedRecipe.Name} was deleted!";
            }
            return RedirectToAction("RecipeList", controllerName: "Home");
        }
       
    }
}