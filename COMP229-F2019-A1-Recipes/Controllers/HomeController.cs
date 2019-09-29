using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using COMP229_F2019_A1_Recipes.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace COMP229_F2019_A1_Recipes.Controllers
{
    public class HomeController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            int hour = DateTime.Now.Hour;
            ViewBag.Greeting = hour < 12 ? "Good Morning" : "Good Afternoon";

            return View();
        }

        public ViewResult RecipeList()
        {
            List<Recipe> recipeList = new List<Recipe>
            {
                new Recipe
                {
                    Id = 1,
                    Name = "Um",
                    Description = "descricao1",
                    Ingredients = "ingredientes1",
                    HowToCook = "como preparar1"
                },
                new Recipe
                {
                    Id = 2,
                    Name = "dois",
                    Description = "descricao2",
                    Ingredients = "ingredientes2",
                    HowToCook = "como preparar2"
                },
                new Recipe
                {
                    Id = 3,
                    Name = "tres",
                    Description = "descricao3",
                    Ingredients = "ingredientes3",
                    HowToCook = "como preparar3"
                },
                new Recipe
                {
                    Id = 4,
                    Name = "quatro",
                    Description = "descricao4",
                    Ingredients = "ingredientes4",
                    HowToCook = "como preparar4"
                }
            };
            return View(recipeList);
        }
        [HttpGet]
        public ViewResult AddRecipe()
        {
            return View();
        }
        [HttpPost]
        public ViewResult AddRecipe(Recipe recipe)
        {
            if (ModelState.IsValid)
            {
                Repository.AddRecipe(recipe);
                return View("RecipeList", recipe);
            }
            else
            {
                return View();
            }
        }
        [HttpGet]
        public ViewResult ViewRecipe()
        {
            return View();
        }
        [HttpGet]
        public ViewResult ReviewRecipe()
        {
            return View();
        }
    }
}
