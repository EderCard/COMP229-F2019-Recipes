using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace COMP229_F2019_Recipes.Models
{
    public static class Repository
    {
        // Initial list of recipes
        private static List<Recipe> recipeList = new List<Recipe> 
            {
                new Recipe
                {
                    RecipeId = 1,
                    Category = "Main Dishes",
                    Name = "Ricotta Meatballs",
                    Ingredients = "1/2 onion, minced\n" +
                    "2 tablespoons olive oil\n" +
                    "3 cloves garlic, minced\n" +
                    "1 pound ground beef\n" +
                    "1 cup whole milk ricotta cheese\n" +
                    "1/4 cup packed chopped Italian parsley\n" +
                    "1 egg, beaten\n" +
                    "1 1/2 teaspoons kosher salt\n" +
                    "1/2 teaspoon freshly ground black pepper\n" +
                    "1 pinch cayenne pepper, or to taste\n" +
                    "1/3 cup dry bread crumbs\n" +
                    "2 tablespoons olive oil\n" +
                    "1 (28 ounce) jar marinara sauce\n" +
                    "1 cup water",
                    HowToCook = "Saute onion in 2 tablespoons olive oil in a skillet over medium heat until onion is translucent, about 5 minutes. Stir garlic into onion and turn off heat. Transfer onion mixture to a large mixing bowl.\n" +
                    "Stir ground beef, ricotta cheese, parsley, egg, kosher salt, black pepper, and cayenne pepper with onion mixture until almost combined; stir in bread crumbs and continue to mix until thoroughly blended.\n" +
                    "Roll about 2 tablespoons of mixture into a 1-inch ball for each meatball. Pour 2 tablespoons olive oil in same skillet used to cook onions. Place skillet over medium heat and brown meatballs on all sides in hot oil, about 5 minutes. Hold a crumpled paper towel in a tongs and use it to remove excess grease from skillet.\n" +
                    "Pour marinara sauce and water over meatballs in skillet. Stir to combine and bring to a simmer. Reduce heat to medium-low and simmer, stirring occasionally, until meatballs are cooked through and no longer pink in the center, about 30 minutes.",
                    Rate = 4.5
                },
                new Recipe
                {
                    RecipeId = 2,
                    Category = "Main Dishes",
                    Name = "Mediterranean Fish",
                    Ingredients = "4 (6 ounce) fillets halibut\n" +
                    "1 tablespoon Greek seasoning (such as Cavender's®)\n" +
                    "1 large tomato, chopped\n" +
                    "1 onion, chopped\n" +
                    "1 (5 ounce) jar pitted kalamata olives\n" +
                    "1/4 cup capers\n" +
                    "1/4 cup olive oil\n" +
                    "1 tablespoon lemon juice\n" +
                    "salt and pepper to taste\n" +
                    "",
                    HowToCook = "Preheat an oven to 350 degrees F (175 degrees C).\n" +
                    "Place halibut fillets on a large sheet of aluminum foil and season with Greek seasoning. Combine tomato, onion, olives, capers, olive oil, lemon juice, salt, and pepper in a bowl. Spoon tomato mixture over the halibut. Carefully seal all the edges of the foil to create a large packet. Place the packet on a baking sheet.\n" +
                    "Bake in the preheated oven until the fish flakes easily with a fork, 30 to 40 minutes.",
                    Rate = 4.8
                },
                new Recipe
                {
                    RecipeId = 3,
                    Category = "Main Dishes",
                    Name = "Butter Chicken",
                    Ingredients = "2 eggs, beaten\n" +
                    "1 cup crushed buttery round cracker crumbs\n" +
                    "½ teaspoon garlic salt\n" +
                    "ground black pepper to taste\n" +
                    "4 skinless, boneless chicken breast halves\n" +
                    "½ cup butter, cut into pieces",
                    HowToCook = "Preheat oven to 375 degrees F (190 degrees C).\n" +
                    "Place eggs and cracker crumbs in two separate shallow bowls. Mix cracker crumbs with garlic salt and pepper. Dip chicken in the eggs, then dredge in the crumb mixture to coat.\n" +
                    "Arrange coated chicken in a 9x13 inch baking dish. Place pieces of butter around the chicken.\n" +
                    "Bake in the preheated oven for 40 minutes, or until chicken is no longer pink and juices run clear.",
                    Rate = 4.2
                },
                new Recipe
                {
                    RecipeId = 4,
                    Category = "Dessert",
                    Name = "Strawberry Angel Food",
                    Ingredients = "1 (10 inch) angel food cake\n" +
                    "2 (8 ounce) packages cream cheese, softened\n" +
                    "1 cup white sugar\n" +
                    "1 (8 ounce) container frozen whipped topping, thawed\n" +
                    "1 quart fresh strawberries, sliced\n" +
                    "1 (18 ounce) jar strawberry glaze",
                    HowToCook = "Crumble the cake into a 9x13 inch dish.\n" +
                    "Beat the cream cheese and sugar in a medium bowl until light and fluffy. Fold in whipped topping. Mash the cake down with your hands and spread the cream cheese mixture over the cake.\n" +
                    "In a bowl, combine strawberries and glaze until strawberries are evenly coated. Spread over cream cheese layer. Chill until serving.",
                    Rate = 4.9
                }
        };
        /// <summary>
        /// This method return a list of recipes
        /// </summary>
        public static IEnumerable<Recipe> RecipeList
        {
            get
            {
                return recipeList;
            }
        }
        /// <summary>
        /// This method add items into the recipeList
        /// </summary>
        /// <param name="recipe"></param>
        public static void AddRecipe(Recipe recipe)
        {
            recipeList.Add(recipe);
        }
        public static void AddRate(Recipe recipe)
        {
            
        }
    }
}
