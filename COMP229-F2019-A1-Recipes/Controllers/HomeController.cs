using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

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
            return View();
        }
        public ViewResult AddRecipe()
        {
            return View();
        }
        public ViewResult ViewRecipe()
        {
            return View();
        }
        public ViewResult ReviewRecipe()
        {
            return View();
        }
    }
}
